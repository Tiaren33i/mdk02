let dec = "";
let result = 0;
function calc() {
  let num1 = Number(document.querySelector(".num1").value);
  let num2 = Number(document.querySelector(".num2").value);
  console.log(typeof num1);
  switch (dec) {
    case "+":
      result = num1 + num2;
      break;
    case "-":
      result = num1 - num2;
      break;
    case "*":
      result = num1 * num2;
      break;
    case "/":
      result = num1 / num2;
      break;
    case "%":
      result = num1 % num2;
      break;
    case "Pow":
      result = Math.pow(num1, num2);
      break;
  }
  document.querySelector(".result").innerHTML = result;
}
function sqrt(x) {
  let num = Number(document.querySelector(x).value);
  result = Math.sqrt(num);
  document.querySelector(".result").innerHTML = result;
}
