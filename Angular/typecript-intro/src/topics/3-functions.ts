function addNumbers(a:number, b:number){
    return a +b;

}

const addNumbersArrow = (a: number, b:number): string => {
   // return (a + b).toString();
   return `${a + b}`;
}

function multiply(firstNumber: number, secondNumber?: number, base: number = 2): number{
    return firstNumber * base;
}

const result = addNumbers(1, 2);
const result2 = addNumbersArrow(1, 2);
const multiplyResult1 = multiply(5);
const multiplyResult2 = multiply(5, 3);
const multiplResult3 = multiply(5, null, 3);

console.log({multiplyResult1, multiplyResult2, multiplResult3});
console.log('result: ', result);
console.log('result2:', result2);






export{};