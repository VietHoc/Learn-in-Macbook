x, y, z = map(int, input().split())

a = gcd(x,y)
if ((z % a) ==0):
    print('true')
else:
    print('false')