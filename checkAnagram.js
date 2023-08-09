function checkAnagram(s1,s2){
    if(s1.length != s2.length)
        return false;

     //sort both string
     s1 = Array.from(s1).sort().join('');  // ['a','n','g','e','l'].join('');--> aegln
     s2 = Array.from(s2).sort().join('');
     for(let i=0; i < s1.length; i++){
        if(s1[i]!= s2[i]){
          return false;
        }
    }

    return true;
}

let str1 = "angel";
let str2 = "glean";

console.log(checkAnagram(str1, str2));
