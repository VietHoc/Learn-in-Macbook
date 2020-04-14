import math

n = int(input())
luy_thua_cap_1 = (2**n)%1000
luy_thua_cap_2 = ((luy_thua_cap_1**n) - 1)%1000
print(luy_thua_cap_2)