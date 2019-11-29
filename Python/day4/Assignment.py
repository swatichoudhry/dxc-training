
class InvalidCredentials(Exception):  
    
    def __init__(self,msg):
        Exception.__init__(self,msg)
dict={
    "user1":"pw1",
    "user2":"pw2",
    "user3":"pw3",
    "user4":"pw4",
    "user5":"pw5",
    "user6":"pw6",
    }        
try: 
      
    x=input("Enter your username: ")
    y=input("Enter your password: ")
    if x not in dict.keys():        
        raise InvalidCredentials("username not found")
    if dict[x]!=y:        
        raise InvalidCredentials("password did not match")
    print("Welcome "+x)
except InvalidCredentials as e:
    print(e)    
except Exception as e:
    print("Generic handler!" ,e)
print("Some other important task")

