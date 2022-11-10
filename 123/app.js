let i=-100;
let y=0;
let h=0.1;
let arr=[];
for (let x=i;x<100;x=x+h){
 y=Math.floor(x*x-Math.sin(3*x * Math.PI/180));

 if (y==0){ 
  arr.push([x,y]);
 }

}
console.log(arr);
