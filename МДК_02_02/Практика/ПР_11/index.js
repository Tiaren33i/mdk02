  let arr={	
"D":[["O1",8],["O2",6],["M",5]],
"O1":[["D",8],["O2",66],["R",2]],
"O2":[["D",6],["O1",66],["M",44],["E",55]],
"M":[["D",5],["O2",44],["E",55]],
 "E":[["O2",55],["M",1],["R",22]]
};
let start="D";
let end='R';

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

