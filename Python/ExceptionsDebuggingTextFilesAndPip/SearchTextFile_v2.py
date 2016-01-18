import logging

CATALOG_SAMPLE = "C:/Users/lenovo/PycharmProjects/Python/ExceptionsDebuggingTextFilesAndPip/catalog_sample.csv"
CATALOG_FULL = 'C:/Users/lenovo/PycharmProjects/Python/ExceptionsDebuggingTextFilesAndPip/catalog_full.csv'
total = {}
count = {}
gender = {'infant', 'kid', 'men', 'unisex', 'woman'}

for gen in gender:
    total[gen] = 0
    count[gen] = 0

with open(CATALOG_FULL) as f:
    for line_num, line in enumerate(f):
        values = line.split(',')
        if len(values) == 7 or len(values) == 8 and values[0]:
            for gen in gender:
                if str(values[-2]).upper() == gen.upper():
                    total[gen] += float(values[-1])
                    count[gen] += 1

        else:
            logging.warning('Invalid line detected on line: {}\n\t{}'.format(line_num + 1, line))

    for gen in gender:
        if count[gen] > 0:
            print('{} average price is {:.2f}'.format(gen, total[gen] / count[gen]))
        else:
            logging.warning('counter cannot be 0')