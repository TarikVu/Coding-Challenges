
""" 
Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.
You must write an algorithm with O(log n) runtime complexity. 

Answer:  Binary Search.  For this problem, instead of returning a -1 if the 
target is not found, return the midpoint instead.  This is where the item would have been "inserted".
"""

def searchInsert(nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        # Indexes of l, m, h


        return binarySearch(nums, 0, len(nums)-1, target)

# A basic Binary Search Algorthim you can find anywhere. 
# This one is based off of GeeksforGeeks implementation.
# ref https://www.geeksforgeeks.org/binary-search/

def binarySearch(nums, l, h, target):
        if h >= l:
            m = (h+l) // 2

            if nums[m] == target:
                return m
            
            elif nums[m] > target:
                return binarySearch(nums,l,m-1,target)

            else:
                return binarySearch(nums,m+1,h,target)
            
        else:
            return ((h+l) // 2) + 1
        
        
        
# Case 1        
result = searchInsert([1,3,5,6],5)
expected = 2 
passed = expected == result
print("Expected: " + str(expected) +" | Actual: " + str(result) + " | Passed: " + str(passed))

# Case 2        
result = searchInsert([1,3,5,6],2)
expected = 1 
passed = expected == result
print("Expected: " + str(expected) +" | Actual: " + str(result) + " | Passed: " + str(passed))

# Case 3       
result = searchInsert([1,3,5,6],7)
expected = 4 
passed = expected == result
print("Expected: " + str(expected) +" | Actual: " + str(result) + " | Passed: " + str(passed))