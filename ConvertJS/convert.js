let a = 6;
let b = 'Hello';
let coordinate;

//console.log(a);
let inputString1 = document.querySelector('.stringForConvert1');
let inputString2 = document.querySelector('.stringForConvert2');
let inputString3 = document.querySelector('.stringForConvert3');
let buttonGo = document.querySelector('.buttonOkConvert');
let buttonGo2 = document.querySelector('.buttonOkConvert2');
let resultConverting = document.querySelector('.stringAnsver');
buttonGo.onclick = function (){
    console.log("111");
    coordinate = convertCoordinate(inputString1.value) + ", " + convertCoordinate(inputString2.value);
    console.log(coordinate);
    resultConverting.value = coordinate;
   // inputString1.value = 44;
   // console.log(4455);
};

buttonGo2.onclick = function (){
    console.log("222");
    coordinate = convertCoordinateToDualWord(inputString3.value);
    console.log(coordinate);
    resultConverting.value = coordinate;
   // inputString1.value = 44;
   // console.log(4455);
};


function convertCoordinate (stringForConvert){
    let convertingString="";
    convertingString=stringForConvert.replace(/[^0-9,.]/g,"");
    console.log(convertingString[2]);
    if(convertingString[2] == ',')
    {
        console.log('crrrr'); 
        convertingString = convertingString.replace(',', '.');
    }
   
   // for (let i=0; i<stringForConvert.length; i++){
   //     console.log(stringForConvert[i]);

     //   if('0' <= stringForConvert[i] <= '9'){
     //       convertingString += String(stringForConvert[i]);
    //    }
      //  if(stringForConvert[i] == ',' || stringForConvert[i] == '.' && convertingString.length == 2)
     //   {
     //       convertingString += String(stringForConvert[i]);
     //   }
    //}
    console.log(convertingString);
    return convertingString;
}

function convertCoordinateToDualWord (stringForConvert){
    let convertingString1="";
    let convertingString2="";
    let convertingString="";
    let firstCor="";
    let secondCor="";
    let defisInString;
    defisInString = stringForConvert.search('/');
    firstCor=stringForConvert.substring(0,defisInString);
    secondCor=stringForConvert.substring(defisInString);
    convertingString1=firstCor.replace(/[^0-9,.]/g,"");
    console.log(convertingString[2]);
    if(convertingString1[2] == ',')
    {
        console.log('crrrr'); 
        convertingString1 = convertingString1.replace(',', '.');
    }
    convertingString2=secondCor.replace(/[^0-9,.]/g,"");
    console.log(convertingString2[2]);
    if(convertingString2[2] == ',')
    {
        console.log('crrrr'); 
        convertingString2 = convertingString2.replace(',', '.');
    }
    console.log(convertingString2);
    convertingString = convertingString1  + ", " + convertingString2;
    return convertingString;
}


//convertCoordinate (inputString1.value)+convertCoordinate (inputString2.value)