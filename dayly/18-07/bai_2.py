n, m = map(int, input().split())
so_la = []
thoi_gian = []
for i in range(n):
    la = int(input())
    so_la.append(la)
for i in range(m):
    time = int(input())
    thoi_gian.append(time)

def index_max(array):
    return array.index(max(array))

def max_so_la(array, time):
    for i in range(time):
        array[index_max(array)] -= 1
    return max(array)

for i in range(m):
    so_la_copy = so_la.copy()
    print(max_so_la(so_la_copy, thoi_gian[i]))