const objRafael = {
    nome: "rafael", 
    idade: 18, 
    éAluno: true
};

objRafael.nome = "Rafael Rodrigues";
objRafael.altura = 1.75;

console.log("objeto: ", objRafael,"\ntipo do objeto: ", typeof objRafael, "\ntipo da propriedade do objeto: ", objRafael.idade, "comprimento propriedade do objeto: ", objRafael.nome.length);

const arraynotas = [
    {aluno: "joão Eli", p1: 7.5, p2: 5},
    {aluno: "maria claudia", p1: 9.5, p2: 7}, 
    {aluno: "caio maia", p1: 3, p2: 6.5}
];

console.table(arraynotas);

console.log("objetos do javascript vão virar JSON:");
const strJSON = JSON.stringify(arraynotas);

console.log(strJSON);

console.log("JSON para objetos JS:");
const arrayObj = JSON.parse(strJSON);

console.log(arrayObj);