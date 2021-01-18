


let myButton = document.getElementById('button');
myButton.addEventListener('click', function(event){
    let firstValue = document.getElementById('firstValue').value;
    let secondValue = document.getElementById('secondValue').value;
    firstValue = parseInt(firstValue);
    secondValue = parseInt(secondValue);
    let operand = document.getElementById('operand').value;
    let result = document.getElementById('result');
    if ((operand==="/") && (secondValue===0)){
        result.innerHTML="Divide by zero ERROR: infinity. "
        
    }
    else{
        switch(operand){
            case "+":
                result.innerHTML=`Result: ${firstValue+secondValue} `;
                break;
            case "-":
                result.innerHTML=`Result: ${firstValue-secondValue} `;
                break;
            case "*":
                result.innerHTML=`Result: ${firstValue*secondValue} `;
                break;
            case "/":
                result.innerHTML=`Result: ${firstValue/secondValue} `;
                break
            default:
                console.log("invalid operand");
        }
    }
    
    

});


