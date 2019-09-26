
    function passwordvalidate(){

        var x=document.getElementById("inputPW").value;
        var y=document.getElementById("Confirm-PW").value;
        var z=document.getElementById("inputPW").value;
        var a=z.length;

        if(a<7||a>12)
        {
            alert("Incorrect Password!")
        } 
            else if(x!=y)
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
                        
            }

         function unamevalidate(){
            
            var b= document.getElementById('uname').value
            var c=b.length;

            if(c<5||c>12)
            {
                alert("Invalid Username!")
            }
            
  }
  function name1(){
    var d= document.getElementById('name').value
    if(/[^a-zA-Z]/.test(d))
    {
        alert("Retype your name!");
  }
}
  

  function dobvalidate(){
    var e=document.getElementById('dob').value
    var f= new Date(e).getTime()
    var g= new Date().getTime()
    var h=(g-f)/(1000*60*60*24*365);
    // alert(h)
    if(h<18)
    {
        alert("Age must be above 18!")
    }
}

function valthisform(){
    var chkd = document.FC.c1.checked || document.FC.c2.checked||document.FC.c3.checked|| document.FC.c4.checked
   
    if (chkd == true){
   
    } else {
       alert ("please check a checkbox")
    }
   
   }






