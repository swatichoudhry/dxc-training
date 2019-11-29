temp='''
Name={0}
Category={1}
Brand={2}
Cost={3}
Rating={4}
Discount={5}
'''
class product:
    def __init__(obj,pid,name,category,brand,cost,rating,discount):
        obj.Product_id=pid
        obj.Name=name
        obj.Category=category
        obj.Brand=brand
        obj.Cost=int(cost)
        obj.Rating=int(rating)
        obj.Discount=int(discount)
    def __str__(self):
        return  temp.format(self.Name,self.Category,self.Brand,self.Cost,self.Rating,self.Discount)
    

ProductList=[
product("101",
"Laptop",
"ELectronics",
"HP",
500000,
8.9,
30
),
product("102",
"Mobile",
"Electronics",
"Oneplus",
30000,
9.1,
20),
product("103",
"Dress",
"Clothing",
"Zara",
3000,
9.1,
40),
product("104",
"Shoes",
"Clothing",
"Nike",
5000,
8.5,
20),
product("105",
"Shirt",
"Clothing",
"LV",
4000,
7.3,
40)
]

x=int(input(print('''Enter: 1 to sort by Rating 
2 to sort by Discount High to Low
3 to sort by Discount Low to High
4 to sort by Cost High to Low
5 to sort by Cost Low to High''')))

list=[["Rating",False],["Discount",True],["Discount",False],["Cost",True],["Cost",False]]

ProductList.sort(reverse=list[x-1][1],key=(lambda el:el.__dict__[list[x-1][0]]))
print(*ProductList)

    


       
                
                
                
                