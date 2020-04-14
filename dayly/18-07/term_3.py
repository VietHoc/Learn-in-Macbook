toi_da, n= map(int, input().split())
hanh_tinh = []
for i in range(n):
    so_nguoi = int(input())
    hanh_tinh.append(so_nguoi)
max_array = []
for i in range(n-1):
    for j in range(i+1, n):
        tong = sum(hanh_tinh[i:j])
        if tong <= toi_da:
            max_array.append(tong)
        else:
            break
print(max(max_array))
    