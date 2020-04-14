def binary_search(list, item):
    n = len(list)
    first, last = 0, n-1
    while (first < last):
        mid = (first + last)//2
        if list[mid] == item:
            return mid
        else: 
            if item < list[mid]:
                right = mid -1
            else:
                left = mid +1
    return -1

print(binary_search([1, 2, 3, 4, 5], 3))