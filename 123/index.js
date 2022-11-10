  let arr={	
"C":[["F",9],["H",9],["B",2]],
"F":[["C",9],["H",69],["O",777]],
"H":[["C",7],["F",79],["B",2],["L",66]],
"B":[["C",6],["F",55],["L",66]],
 "L":[["H",66],["B",2],["O",33]]
};
let start="C";
let end='O';

let stack=[{
	location:start,
	km:0,
	history:[]
}];
let result=[];
while (stack.length!=0){
	let cursor=stack.pop();
	let {location,km,history}=cursor;
	

	if (location!=end){
			
		let points=arr[location];
		
		points.forEach((point)=>{
			 let kuda=point[0];
			 let km_dist=point[1];
			 if (!history.includes(kuda)){
        			stack.push({
        			location:kuda,
	        		km:km+km_dist,
        			history:history.concat(location)
				}); 
			}	
		});
	} else {
		result.push(cursor);
		// console.log(cursor);
	}
}
console.log(result);

