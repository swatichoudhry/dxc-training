var a=document.getElementById("email-id").value;
var b=document.getElementById("uname").value;

function val_mob() {
    var pat = /^([1-9]{1}[0-9]{9})$/;
    var mob = document.getElementById('phone-no').value
    if (pat.test(mob) == false) 
    {
        alert('Invalid Mobile No.');
         
    }else{
        alert('Mobile Number Accepted')
    }
}
    function unamevalidate(){

        if(!/[^a-zA-Z]/.test(b))
        {
          alert("Name accepted!")
      }
      else
      {
          alert("Retype your name!")
      }
  
  }


function passwordvalidate(){

var x=document.getElementById("pass").value;
var y=document.getElementById("cnf-pass").value;

    if(x==y)
    {
        alert("Password accepted!");
    }
    else 
    {
        alert("Retype your password!");
    }
}


function val_email() {
    var email = document.getElementById('email').value

    var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
           
            if (reg.test(email) == false) 
            {
                alert('Invalid Email Address');
                
            }
            else{
                alert("email accepted")
            }
}


 




