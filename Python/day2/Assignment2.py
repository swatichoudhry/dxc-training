
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

format='''
Name={Name}
Category={Category}
Brand={Brand}
Cost={Cost}
Rating={Rating}
Discount={Discount}
'''
y=int(input(print('''Enter 1 to Categorize by Brand
2 to Categorize by Name,
3 to Categorize by Category''')))

list=["Brand","Name","Category"]
print("My order called for "+el[list[y-1]])

print(list[y-1])
newobj=filter((lambda el:el[list[y-1]]=="Clothing"),li)
for i in newobj:
    print(format.format(**i))



