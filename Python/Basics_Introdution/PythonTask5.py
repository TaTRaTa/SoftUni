import turtle

turtle.speed("fastest")
side = 40

for a in range(8):
    for i in range(8):
        if i % 2 == 0:
            turtle.begin_fill()
        for temp in range(4):
            turtle.forward(side)
            turtle.left(90)
        turtle.end_fill()
        turtle.forward(side)
    if a % 2 == 0:
        turtle.left(90)
        turtle.forward(side * 2)
        turtle.left(90)
    else:
        turtle.right(180)
print("Fin")
turtle.exitonclick()