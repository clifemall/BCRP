
//    function GetKeyCode(evt)
//    {
//        var keyCode;
//        if(evt.keyCode > 0)
//        {
//        keyCode = evt.keyCode;
//    }
//        else if(typeof(evt.charCode) != "undefined")
//        {
//        keyCode = evt.charCode;
//    }
//        alert("You pressed : " + keyCode);
//}


function OnlyNumber(evt) {
    evt = (evt) ? evt : event;
    var charCode = (evt.charCode) ? evt.charCode : ((evt.keyCode) ? evt.keyCode :
        ((evt.which) ? evt.which : 0));
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        //alert("Enter numbers only in this field.");
        return false;
    }
    return true;
}

function OnlyLetter(evt) {
    evt = (evt) ? evt : event;
    var charCode = (evt.charCode) ? evt.charCode : ((evt.keyCode) ? evt.keyCode :
        ((evt.which) ? evt.which : 0));
    if (charCode > 31 && (charCode < 65 || charCode > 90) &&
        (charCode < 97 || charCode > 122)) {
        //alert("Enter letters only.");
        
        return false;
    }
    return true;
}

