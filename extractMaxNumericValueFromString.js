function extractMaxNumericValueFromString(str){
    let result = 0, num =0;
    for (let i=0; i < str.length; i++){
        let currentChar = str.charAt(i);
        //console.log(typeof currentChar);
        if(!isNaN(currentChar)){
            console.log(currentChar);
           num = num * 10 + parseInt(currentChar);
        }
        else {
            result = Math.max(num, result);
            num = 0;
        }
    }
    return result;
}
console.log(extractMaxNumericValueFromString("po544n12neelu"));