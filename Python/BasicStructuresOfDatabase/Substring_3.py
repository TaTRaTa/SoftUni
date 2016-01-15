print("Enter full name: ", end='')
str_name = input()
names = str_name.split()
for name in names:
    for char in name:
        if char.isupper():
            print(char + ".", end='')



