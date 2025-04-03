"use strict";

const saida = document.getElementById("saida");
const cep = document.getElementById("cep");
const btnPesquisar = document.getElementById("btnPesquisar");
let rua;

const buscarDadosCEP = async () => {
    let urlCEP = `https://viacep.com.br/ws/${getCEP()}/json/`;

    try {
        const resposta = await fetch(urlCEP);
        const dadosJSON = await resposta.json();
        (!dadosJSON.erro)? saida.innerText = `logradouro: ${dadosJSON.logradouro}` : saida.innerText = `CEP inexistente`   
    } catch (e) {
        saida.innerText =  `erro: ${e}`
    }
}

const getCEP = () => cep.value;

btnPesquisar.addEventListener("click", buscarDadosCEP);