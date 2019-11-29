li=[{"Product_id":"101",
"Name":"Laptop",
"Category":"ELectronics",
"Brand":"HP",
"Cost":500000,
"Rating":8.9,
"Discount":30
},
{"Product_id":"102",
"Name":"Mobile",
"Category":"Electronics",
"Brand":"Oneplus",
"Cost":30000,
"Rating":9.1,
"Discount":20},
{"Product_id":"103",
"Name":"Dress",
"Category":"Clothing",
"Brand":"Zara",
"Cost":3000,
"Rating":9.1,
"Discount":40},
{"Product_id":"104",
"Name":"Shoes",
"Category":"Clothing",
"Brand":"Nike",
"Cost":5000,
"Rating":8.5,
"Discount":20},
{"Product_id":"105",
"Name":"Shirt",
"Category":"Clothing",
"Brand":"LV",
"Cost":4000,
"Rating":7.3,
"Discount":40}
]


x=int(input(print('''Enter: 1 to sort by Rating 
2 to sort by Discount High to Low
3 to sort by Discount Low to High
4 to sort by Cost High to Low
5 to sort by Cost Low to High''')))
                             
format='''
Name={Name}
Category={Category}
Brand={Brand}
Cost={Cost}
Rating={Rating}
Discount={Discount}
''' 
list=[["Rating",False],["Discount",True],["Discount",False],["Cost",True],["Cost",False]]

li.sort(reverse=list[x-1][1],key=(lambda el:el[list[x-1][0]]))
for i in li: 
    print(format.format(**i))
    

    


       
                
                
                
                