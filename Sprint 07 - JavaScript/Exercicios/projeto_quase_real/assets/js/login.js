let body = document.getElementsByTagName("body");
let elementoLogin = document.getElementById('login')
let elementoSenha = document.getElementById('senha')
let elementoButtonEntrar = document.getElementById("button-entrar");
let elementoAlerta = document.getElementById('div-alert');

const verificarLogin = (login, senha) => {
    if (login.toLowerCase() == 'maria'.toLowerCase() 
        && senha == '123'){
            localStorage.setItem("usuarioLogado", login.toUpperCase());
            localStorage.setItem("sobrenomeUsuarioLogado", 'Silva'.toUpperCase());
        return true;
    }
    return false
};

const apresentaMsgErro = () => {
    elementoAlerta.style.display = '';
};

const limparErros = () => {
    elementoAlerta.style.display = 'none';
};

const realizarLogin = () =>{
    const login = elementoLogin.value;
    const senha = elementoSenha.value;

    limparErros();

    if(verificarLogin(login, senha)){
        window.location.assign("./views/home.html");
        return true;
    }

    apresentaMsgErro();
};