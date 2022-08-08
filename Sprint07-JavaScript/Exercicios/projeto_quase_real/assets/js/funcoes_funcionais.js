// const vetorProdutos =
//     [
//         {
//             "produto": "Produto 01",
//             "preco": 3.65,
//             "descricao": "Lorem ipsum!",
//             "em_estoque": true,
//             "img": "assets/img/img0001.jpg"
//         },
//         {
//             "produto": "Produto 02",
//             "preco": 100.00,
//             "descricao": "Lorem ipsum! Not ipsum!",
//             "em_estoque": false,
//             "img": "assets/img/img0002.jpg"
//         },
//         {
//             "produto": "Produto 03",
//             "preco": 0.90,
//             "descricao": "Prod 03 Lorem ipsum! Not ipsum!",
//             "em_estoque": false,
//             "img": "assets/img/img0003.jpg"
//         },
//         {
//             "produto": "Produto 04",
//             "preco": 3.70,
//             "descricao": "Lorem ipsum!",
//             "em_estoque": true,
//             "img": "assets/img/semImagem.jpg"
//         },
//         {
//             "produto": "Produto 05",
//             "preco": 100.05,
//             "descricao": "Lorem ipsum! Not ipsum!",
//             "em_estoque": false,
//             "img": "assets/img/semImagem.jpg"
//         },
//         {
//             "produto": "Produto 06",
//             "preco": 0.95,
//             "descricao": "Prod 03 Lorem ipsum! Not ipsum!",
//             "em_estoque": true,
//             "img": "assets/img/semImagem.jpg"
//         }
//     ];

let vetorProdutos = []
fetch('../json/produtos.json')
    .then(response => response.json())
    .then(data => {
        vetorProdutos = data;
        console.log(data);
    })    
    .catch( error => {
        console.error('Algo deu errado na requisição', error);
    }) .finally((finalizar) => {
        console.log('Sempre cai aqui');
    });

let vetorProdutoAlterado = vetorProdutos;    
let simboloMonetario = "R$ ";

const exibirProdutos = (vetor) => {
    divListaProdutos.innerText = "";
    for (let elemento of vetor) {
        const divProduto = `
            <div class="produto">
                <h1>${elemento.produto}</h1>
                <p>${elemento.descricao}</p>
                <h5 class="preco-produto">R$ ${elemento.preco.toFixed(2).replace(".", ",")}</h5>
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
    const newElemento = {...elemento};
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
    vetorProdutoAlterado = vetorProdutos;
    exibirProdutos(vetorProdutoAlterado);
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
        vetorProdutoAlterado = vetorProdutoAlterado.filter(emEstoque);
        aplicarFiltro(vetorProdutoAlterado, btnFiltraApenasEstoque, "Filtrar apenas em Estoque");
        carregarMediaPrecos(vetorProdutoAlterado);
    } else {
        vetorProdutoAlterado = vetorProdutos;
        resetarFiltro(btnFiltraApenasEstoque, "Remover Apenas em Estoque");
        carregarMediaPrecos(vetorProdutoAlterado);
    }
};

const carregarMediaPrecos = (vetor) => {
    const elementoMediaPrecos = document.getElementById('mediaPrecos');
    const soma_preco = vetorProdutoAlterado.reduce(somaPreco, 0);

    elementoMediaPrecos.innerText = 'Média dos preços: ' + simboloMonetario + (soma_preco / vetorProdutoAlterado.length).toFixed(2).replace(".", ",");
};

const filtroExibirPrecosEmDolar = document.getElementById('exibirPrecosEmDolar');

filtroExibirPrecosEmDolar.onclick = () => {
    let buttonSelected = document.getElementById('exibirPrecosEmDolar').classList.contains('filtro-selected');
    if (buttonSelected == false) {
        simboloMonetario = "$ ";
        vetorProdutoAlterado = vetorProdutoAlterado.map(converterDolar);

        aplicarFiltro(vetorProdutoAlterado, filtroExibirPrecosEmDolar, "Aplicar preço em Real");
        carregarMediaPrecos(vetorProdutoAlterado);
        
        
        const precos = document.getElementsByClassName("preco-produto");
        for (i=0; i < precos.length; i++) {
            const texto = precos[i].textContent;
            precos[i].innerText = texto.replace(",", ".").replace("R$", "$");
        }
    } else {
        simboloMonetario = "R$ ";
        //vetorProdutoAlterado = vetorProdutos;
        resetarFiltro(filtroExibirPrecosEmDolar, "Aplicar preço em dolar");
        carregarMediaPrecos(vetorProdutoAlterado);
    }
};


/** TO-DO
 * Mostrar média
 * Botão exibir preco em dolar
 */

exibirProdutos(vetorProdutos);
carregarMediaPrecos(vetorProdutos);

//const produtos_em_estoque = vetorProdutos.filter(emEstoque).filter(filtroMaiorQue10);
//const produtos_em_dolar = [vetorProdutos].map(converterDolar);
//const nomesProdutos = vetorProdutos.map(retornaNomeProdutos);
//const soma_preco = vetorProdutos.reduce(somaPreco, 0);