values = list()
str_input = input()
while str_input != "stop":
    num = float(str_input)
    if values.__contains__(num):
        print("Number already has been appended")
    else:
        values.append(num)
    str_input = input()

values.sort()
min_num = values[0]
max_num = values[-1]
if len(values) > 3:
    values.pop(0)
    values.pop(-1)
    sum = 0.0
    for digit in values:
        sum += digit
    print(min_num)
    print(max_num)
    print(sum/2)
else:
    print("numbers is less then 4")
