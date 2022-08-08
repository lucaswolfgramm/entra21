//exibir_load(true);
let produtos = []
fetch('../json/produtos.json')
    .then(response => response.json())
    .then(data => {
        produtos = data;
        console.log(data);
    })    
    .catch( error => { //para status de erro
        console.error('Algo deu errado na requisição', error);
    }) .finally((finalizar) => {
        //exibir_load(false);
        console.log('Sempre cai aqui');
    });