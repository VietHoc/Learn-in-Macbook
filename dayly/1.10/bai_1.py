n, m = map(int, input().split())
l = []
sum = 0
min = 100000000000
max = 0
for i in range(m):
    so_long = int(input())
    l.append(so_long)
    sum += so_long
    if max < so_long:
        max = so_long
    if min > so_long:
        min = so_long

max_l = sum//n

for i in range(max_l, i, -1):
    total = 0
    # print(i, max//i, (min//i), max//i + (min//i)*(len(l)-1))
    if (n <= (max//i + (min//i)*(len(l)-1))):
        for j in range(0, len(l)):
            total += l[j] // i
        if total >= n:
            print(i)
            break