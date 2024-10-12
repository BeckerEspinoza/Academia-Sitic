let colores: string[] = ["Rojo", "Verde", "Azul"];

// const refaccion = {
//     nombre: "Filtro",
//     existencia: 50,
//     colores: ["Rojo, Negro"]
// }

interface Articulo {
    nombre: string,
    existencia: number,
    colores: string[],
    marca?: string
}

const refaccion: Articulo = {
    nombre: "Filtro",
    existencia: 50,
    colores: ["Rojo", "Negro"],
    //marca: "LTH"
}
refaccion.marca = "LTH";

 console.log(refaccion);
 console.table(refaccion);

export{};