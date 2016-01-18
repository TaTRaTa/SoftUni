import logging

CATALOG_SAMPLE = "C:/Users/lenovo/PycharmProjects/Python/ExceptionsDebuggingTextFilesAndPip/catalog_sample.csv"
CATALOG_FULL = 'C:/Users/lenovo/PycharmProjects/Python/ExceptionsDebuggingTextFilesAndPip/catalog_full.csv'
total = 0
count = 0
with open(CATALOG_FULL) as f:
    for line_num, line in enumerate(f):
        values = line.split(',')
        if len(values) == 7 or len(values) == 8 and values[0]:
            total += float(values[-1])
            count += 1
        else:
            logging.warning('Invalid line detected on line: {}\n\t{}'.format(line_num + 1, line))

    if count > 0:
        print('Average price is {:.2f}'.format(total/count))