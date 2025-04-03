"use strict";
console.log("olá, mundo!");

let nome = "rafael", idade = 18, eAluno = true, altura;
var a, b, c;
let x=5, y=8;
const resp="s"

console.log("----------------------------------------------------------------------------------------------------------")

a = 2;
b = 8;
c = a + b;

if (y == 8){
    let x=0;
    console.log("o valor de x dentro do if é ", x);
}
console.log("o valor de x fora do if é ", x);

console.log("----------------------------------------------------------------------------------------------------------")

console.log("nome: ", nome, "-", typeof nome);
console.log("idade: ", idade, "-", typeof idade);
console.log("foi aluno?", eAluno, "-", typeof eAluno);
console.log("altura: ", altura, "-", typeof altura);

console.log("----------------------------------------------------------------------------------------------------------")

let p1 = 9.5, p2 = 8.25, med;
med = (p1+2*p2)/3;

console.log(`média: ${med.toFixed(1)}`);

console.log("----------------------------------------------------------------------------------------------------------")

let ab = 'peixe' + 'peixe', ac = "3" * "2", bb = 'peixe' + 3, cb = true + true, db, eb = 3 + db;

console.log(ab, typeof ab);
console.log(ac, typeof ac);
console.log(bb, typeof bb);
console.log(cb, typeof cb);
console.log(eb, typeof eb);

console.log("----------------------------------------------------------------------------------------------------------")

console.log (3 >= 3);
console.log (3 == 7);
console.log(3 > 1 && 3 > 10);
console.log(3 > 1 || 3 > 10);
console.log(!true);
console.log("1" == 1);
console.log("1" === 3);

console.log("----------------------------------------------------------------------------------------------------------")

let pr1 = 1, pr2 = 1, media;
media = (pr1 + 2*pr2)/3;

if (media >= 5) {
    console.log("aprovado");
    if (media >= 9){
        console.log("Conceito A");
    }
    else {
        if (media >= 7){
            console.log("Conceito B");
        }
        else{
            console.log("Conceito C");
        }
    }
}
else{
    console.log("em exame");
    if (media < 2){
        console.log("Conceito E");
    }
    else{
        console.log("conceito D");
    }
}

/* 
ANOTAÇÕES JAVASCRIPT

• (não usar) declaração ímplicita de variável: ao usar uma variável mesmo que ela não exista ela é implicitamente declarada se tornando uma variável global.
• caso seja usado no começo do código {"use strict";} o código entra em modo estrito, onde não se pode mais usar uma programação "desrespeitável", como por exemplo a declaração implícita de variável.
• para declarar uma variável não se define o tipo da variável. o tipo dela é o mesmo do valor atribuido.
• hoisting é quando a declaração das variáveis vem depois do uso delas mas ao rodar o programa ela é levada pra cima.
• entre `` é possível usar ${} para servir de placeholder.
• {===} é um operador lógico para estritamente igual (ou seja, tanto o valor quanto o tipo devem ser iguais)
• operador condicional ternário {x = (condição)? {caminho do verdadeiro} : {caminho dos falsos};}
• criar objeto - const [nome do objeto] = {}
• JSON é uma string que pode trocar objetos entre linguagens. objeto na memória stringfica-se [stringfy] para JSON  e a string pode se objetificar {parse} 

METODOS:

• [console.log] - mostrar na tela.
• [var] - (não usar) declarar variável global.
• [let] - criar variáveis locais.
• [const] - criar variáveis locais de valor constante (não muda o valor).
• [.toFixed] - serve para limitar o número de casas depois da vírgula.
• [for], [while] e [do-while] - funcionam da mesma for que no c#.
• [console.table] - mostra os elementos de um array.
• [.indexof] - encontra o index do elemento no array.
• [.length] - funciona da mesma forma que o c#.
• [.push] - adiciona um item ao final do array.
• [.pop] - remove um item ao final do array.
• [.unshift] - adiciona um item ao início do array.
• [.shift] - remove um item ao inicio do array.
• [splice(a partir de qual), (número de itens a serem apagados), (itens a serem adicionados)] - pode adicionar ou remover itens de qualquer lugar de um array. Ele também retorna o que foi removido. 
• [delete] - apaga algo da estrutura de um objeto

OPERADORES:

• [typeof] - verifica o tipo do valor que está sendo armazenado na variável.

ATALHOS:  

• [ctrl + alt + N] - testar o código.
• [ctrl + ,] - abre as configurações do visual studio code (clear previos output limpa automaticamente o painel de saída).
• [ctrl + J] - abre e fecha a janela de saída.
• [alt + ↓/↑] - levar a parte selecionada para cima ou para baixo. 
*/ 