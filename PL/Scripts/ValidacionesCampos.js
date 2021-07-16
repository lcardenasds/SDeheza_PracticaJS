
$(document).ready(function() 
{
    SoloNumeros(e);
    SoloLetras(e);
})

function SoloNumeros(e) {
    var key = error.keyCode || error.which;
    var caracter = error.key;
    if (!/^[0-9]+$/.test(caracter)) {
        alert("Solo se aceptan numeros");
        return false;

    }
    else {
        return true;
    }
}

function SoloLetras(e) {
    var key = error.keyCode || error.which;
    var caracter = error.key;
    if (!/^[a-zA-Z]*$/g.test(caracter)) {
        alert("Solo se aceptan letras");
        return false;

    }
    else {
        return true;
    }
}