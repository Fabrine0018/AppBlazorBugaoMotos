const menuItems = document.querySelectorAll('.menu-item');

menuItems.forEach(item => {
    item.addEventListener('click', () => {
        // Remove a classe "active" de todos
        menuItems.forEach(el => el.classList.remove('active'));
        // Adiciona ao item clicado
        item.classList.add('active');
    });
});

/* cadastro cliente */
document.getElementById("loginForm").addEventListener("submit", function (e) {
    e.preventDefault();

    const usuario = document.getElementById("usuario").value;
    const senha = document.getElementById("senha").value;

    // Simula��o de login
    if (usuario === "admin" && senha === "1234") {
        alert("Login bem-sucedido!");
    } else {
        alert("Usu�rio ou senha inv�lidos.");
    }
});

/* cadastro fornecedor */
document.getElementById("loginForm").addEventListener("submit", function (e) {
    e.preventDefault();

    const usuario = document.getElementById("usuario").value;
    const senha = document.getElementById("senha").value;

    // Simula��o de login
    if (usuario === "admin" && senha === "1234") {
        alert("Login bem-sucedido!");
    } else {
        alert("Usu�rio ou senha inv�lidos.");
    }
});

/* Cadastro Produto */
document.getElementById("loginForm").addEventListener("submit", function (e) {
    e.preventDefault();

    const usuario = document.getElementById("usuario").value;
    const senha = document.getElementById("senha").value;

    // Simula��o de login
    if (usuario === "admin" && senha === "1234") {
        alert("Login bem-sucedido!");
    } else {
        alert("Usu�rio ou senha inv�lidos.");
    }
});

/* Cadastro Servi�o */
document.getElementById("loginForm").addEventListener("submit", function (e) {
    e.preventDefault();

    const usuario = document.getElementById("usuario").value;
    const senha = document.getElementById("senha").value;

    // Simula��o de login
    if (usuario === "admin" && senha === "1234") {
        alert("Login bem-sucedido!");
    } else {
        alert("Usu�rio ou senha inv�lidos.");
    }
});
