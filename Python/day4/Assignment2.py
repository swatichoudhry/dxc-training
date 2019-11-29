def demo(a):
    def inner(*args,**kwargs):
        for i in (args):
            if type(i).__name__!="str":
                print("invalid arguments")
                break 
        else:
            for i in (kwargs.values()):
            if type(i).__name__!="str":
                print("invalid arguments")
                break
            else:
                a(*args,**kwargs)
    return inner
@demo               #decorator function    
def sayhi(name):        #decorated function 
        print("hi "+name)
@demo               #decorator function   
def sayhello(name1,name2):     #decorated function 
        print("hello "+name1+" and "+name2)
        
# sayhi=demo(sayhi)#test1 is wrapper of sayhi      
# sayhello=demo(sayhello)#test2 is wrapper of sayhello      
sayhi("Sachin")
sayhello(name1="Sachin",name2="Tendulkar")
