//Общие переменные
let i=-100;
let y=0;
let h=0.1;

let max =0;
for (let x=i;x<100;x=x+h){
    y=Math.sqrt(2*x*x+1)/3+x*x
    
if (max<y){
    max=y;
}}
console.log(max);