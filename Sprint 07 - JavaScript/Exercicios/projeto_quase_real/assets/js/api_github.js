function renderiza_foto(foto) {
    const img_foto = document.getElementById('foto');
    img_foto.src = `${foto}`
}

fetch('https://api.github.com/users/lucaswolfgramm')
    .then(response => response.json())
    .then(data => {
        console.log(data);
        renderiza_foto(data.avatar_url);
        document.getElementById('nome').innerText = data.name;
    })
    .catch(error => {
        console.error('Algo deu errado na requisição', error);
    }).finally((finalizar) => {
        console.log('Sempre cai aqui');
    });