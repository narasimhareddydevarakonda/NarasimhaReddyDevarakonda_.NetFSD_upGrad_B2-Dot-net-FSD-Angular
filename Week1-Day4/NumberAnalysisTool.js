let num=5;
let sign=(num>0) ? "Positive" :"Negative";
console.log("The number is", sign);

if (num % 2 === 0) {
    console.log("The number is Even");
} else {
    console.log("The number is Odd");
}
console.log(`Counting from 1 to ${num}:`);
for (let i = 1; i <= num; i++) {
    console.log(i);
}