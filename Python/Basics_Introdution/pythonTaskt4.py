import turtle
turtle.speed("fastest")
g = 134
l = 120
len = input()
x = int(len)
count = 0

while True:
    if x == count:
        break
    turtle.left(g)
    turtle.forward(l)
    count += 1
turtle.exitonclick()

