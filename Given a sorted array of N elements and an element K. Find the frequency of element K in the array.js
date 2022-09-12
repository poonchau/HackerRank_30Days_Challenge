/*Given a sorted array of N elements and an element K. Find the frequency of element K in the array. 
Discussed on edge cases like 
If the element K is not present in the array
If the array is null or empty*/

-------------------------------------MY SOLUTION----------------------------------------------------------------------------------------------------------------------------

function findFrequency(arr, size, k){
  if(size == 0){
  console.log("array is empty");
}
else{
  arr.forEach((ele,index) => {
    if(arr.indexOf(ele) == arr.indexOf(k)){
      eleFound = true;
      frequency=frequency+1;
    }
  });
}
return eleFound ? frequency : "element K not found";
}
let arr = [1,1,2,3,4,5,6];
let k = 6;
let frequency = 0;
let eleFound = false;
let output = findFrequency(arr, arr.length,k);
console.log(output); // 1
