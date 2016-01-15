ivan = ['пушене', 'пиене', 'тия три неща', 'коли', 'facebook', 'игри', 'разходки по плажа', 'скандинавска поезия']
maria = ['пиене', 'мода', 'facebook', 'игри', 'лов със соколи', 'шопинг', 'кино']
print(set(ivan).intersection(maria))
print(set(ivan) & set(maria))
print()
print(set(ivan).symmetric_difference(maria))
print(set(ivan) ^ set(maria))
print()
print(set(ivan).union(maria))
print(set(ivan) | set(maria))
print()
print(set(ivan).difference(maria))
print(set(ivan) - set(maria))