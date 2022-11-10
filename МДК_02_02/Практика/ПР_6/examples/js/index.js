//Общие переменные
let i=-100;
let y=0;
let h=0.1;

//Локальный минимум/максимум y=sin(x^2)
let max=0;
for (let x=i;x<100;x=x+h){
 y=Math.sin(x*x * Math.PI/180);

 if (max<y){
  max=y;
 }

}
console.log(max);
//Все нули функции y=sin(x^2)
let arr=[];
for (let x=i;x<100;x=x+h){
 y=Math.sin(x*x * Math.PI/180);

 if (y==0){ 
  arr.push(y);
 }

}
console.log(arr);

//Перечесечение графиков функций y=sin(x) и y=sin(x^2)
let union=[];
for (let x=i;x<100;x=x+h){
 let y1=Math.sin(x*x * Math.PI/180);
 let y2=Math.sin(x * Math.PI/180);
 
 if (y1==y2){ 
   union.push([x,y1]);
 } 
}
console.log(union);
//Точка в которых функция равна значению 10 для y=sin(x)

for (let x=i;x<100;x=x+h){ 
 y=Math.sin(x * Math.PI/180);
 
 if (y==10){ 
   console.log(`x=${x}`);
 } 
}
