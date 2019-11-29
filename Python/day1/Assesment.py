a=int(input("Enter the number of rows"))

i=1
while i<=a:
    print("*"*i)
    i+=1
    


a=int(input("Enter the number of rows"))
i=a
while i>0:
    print("*"*i)
    i-=1
    

a=int(input("Enter the number of rows"))
i=a
x=0
while i>0 and x<a:   
    print(" "*x,end="*"*i)
    print("")
    i-=1
    x+=1
    
a=int(input("Enter the number of rows"))
i=0
x=a
while i<=a and x>0:   
    print(" "*x,end="*"*i)
    print("")
    i+=1
    x-=1
    
a=int(input("Enter the number of rows"))
i=0
x=a
while i<=a and x>0:
    print(" "*x,end="* "*i)
    print("")
    i+=1
    x-=1

data="Python" 
x=len(data)  
for i in range(1,len(data)+1):
    print(" "*x,data[:i])     
    x-=1

# Factorial

x=int(input("Enter a number"))

data=range(x,0,-1)
for i in data:
    print(i," x",end="")
    
# Fibonacci

def add(a,b):
    return a+b

data=add(1,4)
print("Sum: ",data)