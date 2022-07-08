const vetorProduto =
    [
        {
            "produto": "Produto 01",
            "preco": 3.65,
            "descricao": "Lorem ipsum!",
            "em_estoque": true,
            "img": "assets/img/img0001.jpg"
        },
        {
            "produto": "Produto 02",
            "preco": 100.00,
            "descricao": "Lorem ipsum! Not ipsum!",
            "em_estoque": false,
            "img": "assets/img/img0002.jpg"
        },
        {
            "produto": "Produto 03",
            "preco": 0.90,
            "descricao": "Prod 03 Lorem ipsum! Not ipsum!",
            "em_estoque": false,
            "img": "assets/img/img0003.jpg"
        },
        {
            "produto": "Produto 04",
            "preco": 3.70,
            "descricao": "Lorem ipsum!",
            "em_estoque": true,
            "img": "assets/img/semImagem.jpg"
        },
        {
            "produto": "Produto 05",
            "preco": 100.05,
            "descricao": "Lorem ipsum! Not ipsum!",
            "em_estoque": false,
            "img": "assets/img/semImagem.jpg"
        },
        {
            "produto": "Produto 06",
            "preco": 0.95,
            "descricao": "Prod 03 Lorem ipsum! Not ipsum!",
            "em_estoque": true,
            "img": "assets/img/semImagem.jpg"
        }
    ];

const exibirProdutos = (vetor) => {
    divListaProdutos.innerText = "";
    for (let elemento of vetor) {
        const divProduto = `
            <div class="produto">
                <h1>${elemento.produto}</h1>
                <p>${elemento.descricao}</p>
                <h5>R$ ${elemento.preco.toFixed(2)}</h5>
            </div>
        `;

        divListaProdutos.innerHTML += divProduto;
    };
};

const filtroMaiorQue10 = ((elemento) => {
    return elemento.preco >= 1.00;
});

const emEstoque = ((elemento) => {
    return elemento.em_estoque === true;
});

const converterDolar = (elemento) => {
    const newElemento = elemento;
    newElemento.preco = newElemento.preco / 5.43;
    return newElemento;
}

const retornaNomeProdutos = (elemento) => {
    return elemento.produto + " --- " + elemento.preco;
};

/**
 * Reduce - fazer um calculo com todos os elementos retornando um unico valor
 */

const somaPreco = (totalizador, elemento) => {
    return totalizador + elemento.preco;
}

const divListaProdutos = document.getElementById('lista-produtos');

const resetarFiltro = (elemento, elementText) => {
    exibirProdutos(vetorProduto);
    elemento.className = elemento.className.replace('-selected', '');
    elemento.innerText = elementText;
};

const aplicarFiltro = (vetor, elemento, elementText) => {
    exibirProdutos(vetor);
    elemento.className = elemento.className + "-selected";
    elemento.innerText = elementText;
};

const btnFiltraApenasEstoque = document.getElementById('filtroApenasEstoque');

btnFiltraApenasEstoque.onclick = () => {
    let buttonSelected = document.getElementById('filtroApenasEstoque').classList.contains('filtro-selected');
    if (buttonSelected == false) {
        const vetorFiltrado = vetorProduto.filter(emEstoque);
        aplicarFiltro(vetorFiltrado, btnFiltraApenasEstoque, "Filtrar apenas em Estoque");
        carregarMediaPrecos(vetorFiltrado);
    } else {
        resetarFiltro(btnFiltraApenasEstoque, "Remover Apenas em Estoque");
    }
};

const carregarMediaPrecos = (vetor) => {
    const elementoMediaPrecos = document.getElementById('mediaPrecos');
    const soma_preco = vetor.reduce(somaPreco, 0);

    elementoMediaPrecos.innerText = 'Média dos preços: ' + (soma_preco / vetor.length).toFixed(2);
};

const filtroExibirPrecosEmDolar = document.getElementById('exibirPrecosEmDolar');

filtroExibirPrecosEmDolar.onclick = () => {
    let buttonSelected = document.getElementById('exibirPrecosEmDolar').classList.contains('filtro-selected');
    if (buttonSelected == false) {
        aplicarFiltro(vetorProduto.map(converterDolar), filtroExibirPrecosEmDolar, "Aplicar preço em Real");
    } else {
        resetarFiltro(filtroExibirPrecosEmDolar, "Aplicar preço em dolar");
    }
};


/** TO-DO
 * Mostrar média
 * Botão exibir preco em dolar
 */

exibirProdutos(vetorProduto);
carregarMediaPrecos(vetorProduto);

//const produtos_em_estoque = vetorProduto.filter(emEstoque).filter(filtroMaiorQue10);
//const produtos_em_dolar = [vetorProduto].map(converterDolar);
//const nomesProdutos = vetorProduto.map(retornaNomeProdutos);
//const soma_preco = vetorProduto.reduce(somaPreco, 0);