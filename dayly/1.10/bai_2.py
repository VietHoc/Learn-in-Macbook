def luan_hoi(n):
    new_num = (n % 10) * (10**(len(str(n))-1)) + (n//10)
    if (new_num > n) and (new_num % n == 0):
        return True
    else:
        return False

n, m = map(int, input().split())
total = 0
for i in range(10**n, 10**m):
    if luan_hoi(i):
        print(i)
        total += i
print(total)