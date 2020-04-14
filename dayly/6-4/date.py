import datetime
from datetime import date
dateStr = '06/04/2020 15:06'
date_time_obj = datetime.datetime.strptime(dateStr, '%d/%m/%Y %H:%M')
print(date_time_obj.date())
print(date.today())
print(date_time_obj == date.today())

l1 = ["eat","sleep","repeat"]
for index, temp  in enumerate(l1):
    print(index, temp)