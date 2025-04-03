"use strict";

const p1 = document.getElementById("p1");
const p2 = document.getElementById("p2");
const btnCalcular = document.getElementById("btnCalcular");
const saida = document.getElementById("saida");

const obterp1 = () => +p1.value;
const obterp2 = () => +p2.value;
const mostraNota = (media) => saida.textContent = media;
const validarNotas = (nota) => (nota > 10 || nota < 0)? false : true;
const calculamedia = (num1, num2) => (num1 + 2*num2)/3;

const onClick = () => {

    let notap1 = obterp1();
    let notap2 = obterp2();
    let notap1validada = validarNotas(notap1);
    let notap2validada = validarNotas(notap2);
    let mediacalculada

    mediacalculada = (notap1validada == true && notap2validada == true)? calculamedia(notap1, notap2) : "as duas notas precisam ser válidas";
    
    mostraNota(mediacalculada);
}

btnCalcular.addEventListener("click", onClick);