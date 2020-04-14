def maxSubArraySum(a,size,toi_da): 
    max_so_far = -100000000000 - 1
    max_ending_here = 0
       
    for i in range(0, size): 
        max_ending_here = max_ending_here + a[i] 
        if (max_so_far < max_ending_here) and (max_ending_here <= toi_da): 
            max_so_far = max_ending_here 
  
        if max_ending_here < 0: 
            max_ending_here = 0   
    return max_so_far 
   
# Driver function to check the above function  
toi_da, n= map(int, input().split())
hanh_tinh = []
for i in range(n):
    so_nguoi = int(input())
    hanh_tinh.append(so_nguoi)

print(maxSubArraySum(hanh_tinh,len(hanh_tinh), toi_da))