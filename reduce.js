const data = [ 
    {name:"Poonam", age:25},
    {name:"Neelam", age:30},
    {name:"Sonu", age:32},
    {name:"Shani", age:24}
];

let output = data.reduce((acc, curr)=>{
if(curr.age > 30){

acc[curr.age] = curr.name;
}

return acc;



},{});


console.log(output); // {32:"sonu"}