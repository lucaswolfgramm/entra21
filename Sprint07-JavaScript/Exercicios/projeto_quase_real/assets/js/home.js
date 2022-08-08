let body = document.getElementsByTagName("body");
let elemento_usuario_logado = document.getElementById('usuario-logado');
const nome_usuario_logado = localStorage.getItem("usuarioLogado");
const sobrenome_usuario_logado = localStorage.getItem("sobrenomeUsuarioLogado");

elemento_usuario_logado.innerText = `Olá ${nome_usuario_logado} ${sobrenome_usuario_logado}`;

body[0].innerHTML +=

'<div id="toaster" class="toaster">' +
    '   <div class="toast align-items-center text-white bg-primary border-0 fade show" role="alert" aria-live="assertive" aria-atomic="true">' +
    '        <div class="d-flex">' +
    '            <div class="toast-body">' +
    '               Bem vindo ' +
    `${nome_usuario_logado}, você está logada.` +
    '            </div>' +
    '            <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>' +
    '        </div>' +
    '    </div>' +
    '</div>';

const logout = () => {
    window.location.assign("../index.html");
    localStorage.clear();
}

passou = false;

const hideToaster = () => {
    if(passou === false){
        document.getElementById("toaster").classList.remove('toaster show');
        document.getElementById("toaster").classList.add('toaster');
        passou = true;
    }
}