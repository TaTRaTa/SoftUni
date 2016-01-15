firstText = input()
secondText = input()

len = len(secondText)
index = firstText.find(secondText)
print(firstText[index + len:])
