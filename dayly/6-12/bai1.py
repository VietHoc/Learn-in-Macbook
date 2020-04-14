from functools import cmp_to_key

n = int(input())
arr = list()
for i in range(0, n):
    arr.append(str(input()))
   
res = sorted(arr, key = cmp_to_key(lambda i, j: -1 
                if str(j) + str(i) < str(i) + str(j) else 1)) 

result = ''.join(map(str,res))
while (len(result) > 1 and result[0]=='0'):
    result = result[1:]

print (result)