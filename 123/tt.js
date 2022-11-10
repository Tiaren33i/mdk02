 let arr = [
     ["r1v1", "r1v2", "r1v3"],
     ["r2v1", "r2v2", "r2v3"],
     ["r3v1", "r3v2", "r3v3"]
 ];
 let newArr = arr.map((el, i) => el.map((el2, j) => arr[j][i]));
 console.log(newArr);


//10.	Дана вещественная матрица размерности n * m. Вывести номера строк, содержащих больше положительных элементов, чем отрицательных.
let arr1 = [
    [-1,-4,6,2,6,7],
    [7,-3,8,2,9,1],
    [-1,-4,-6,-33,-777,1]
];

arr1.forEach((str,i)=>{
    let pol=0;
    let otr=0;
    str.forEach(((col)=>{
        if(col>0){
            pol++;
        }
        if(col<0){
            otr++;
        }

    }));
    if(pol>otr){
        console.log(i)
    }

});