const arrayprofessores = ["sobrino", "avelino", "luis antônio", "sobrino"];

let localizarindice = (array, elemento) => array.indexOf(elemento);

let excluirelemento = (array, elemento) => {let pos = array.indexOf(elemento); return (pos != -1)? array.splice(pos, 1) : false;} 

let excluirVariosElementos = (array, elemento) => {
    let newarray = array.slice();
    let pos = newarray.indexOf(elemento);

    if (pos == -1)
    {
        return false;

    } else{

        while (pos != -1 ){
            (newarray.splice(pos, 1));
            pos = newarray.indexOf(elemento);
        }

        return newarray;
    }
}

function existearray(array, elemento)
{
    return (array.includes(elemento))? true : false
}
let indiceElemento = localizarindice(arrayprofessores, "sobrino");

console.log("index do sobrino: ", indiceElemento);

const arrayresultante = excluirVariosElementos(arrayprofessores, "sobrino");

console.log("sem o sobrino: ", arrayresultante);
console.log("array original: ", arrayprofessores);
console.log("sobrino existe no array?", existearray(arrayprofessores, "sobrino"))
console.log("avelino existe? ", existearray(arrayprofessores, "avelino"))
console.log("guerra existe? ", existearray(arrayprofessores, "guerra"))
