function insert(num){
    //alert (num);
    document.getElementById('textview').value = document.getElementById('textview').value  + num;
    //alert (document.getElementById ('textview').value);
}

function test(){
    alert ("good");
}

function clean() {
   // alert("good");
    document.getElementById('textview').value = "";
}

function back1(){
    
    var line = document.getElementById('textview').value;
   // alert (line);
    document.getElementById('textview').value = line.substring(0,line.length-1);
}

function item1_equal(){
    var line = document.getElementById('textview').value;
    if(line){
        document.getElementById('textview').value = eval(line);
    }

}