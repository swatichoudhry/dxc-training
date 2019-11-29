import os
import re
dir = "C:/Users/yrudra/Documents/TRAINING/python/day4/Demo"
for root, dirs, files in os.walk(dir):
    for file in files:
        if file.endswith('.log'):
            fo=open(file,"r")
            data=fo.read()
            pattern='[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+'
            matches=re.search(pattern,data)
            if matches:
                print(data[matches.start():matches.end()])
            else:
                print("None Found!")


# number=input("enter the phone number:\n")
# pattern='^[0-9]{10}$'
# matches=re.match(pattern,number)
# if matches:
    # print("valid number")
# else:
    # print("invalid number")