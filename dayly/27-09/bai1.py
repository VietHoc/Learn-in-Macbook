n = int(input())
arr = list(map(int, input().split()))

max = 1
total = sum(arr)
if (total < n):
    firstOne = arr.index(1)
    firstZero = n-1
    sumOfSubarr = sum(arr[firstOne:firstZero])
    while(firstOne != firstZero):
        
        if (sumOfSubarr == 1):
            max = firstZero - firstOne
            break
        firstZero -= 1
        sumOfSubarr -= arr[firstOne]
    

print(max)