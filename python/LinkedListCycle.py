class ListNode(object):
     def __init__(self, x):
         self.val = x
         self.next = None

""" 
Given head, the head of a linked list, determine if the linked list has a cycle in it.
There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.

Answer:  Floyd's Tortoise and Hare Algorithm
# referenced article: https://www.linkedin.com/pulse/navigating-racetrack-understanding-floyds-slow-fast-pointers-penrose-mo8ic/
"""
def hasCycle(head):
    tortoise = head
    hare = head 
    while hare and hare.next:
        
        # Advance the tortoise and hare's accordingly
        tortoise = tortoise.next
        hare = hare.next.next

        if hare is tortoise:
            return True

    return False

# Tests ----------------

# Standard cycle 
n1  = ListNode(1)
n2  = ListNode(2)
n3  = ListNode(3)
n4  = ListNode(4)

n1.next = n2
n2.next = n3
n3.next = n4
n4.next = n1

result = hasCycle(n1)
expected = True 
passed = expected == result
print("Expected: " + str(expected) +" | Actual: " + str(result) + " | Passed: " + str(passed))

# Single Node Test 
a0 = ListNode(0)
result0 = hasCycle(a0)
expected0 = False
passed0 = expected0 == result0
print("Expected: " + str(expected0) +" | Actual: " + str(result0) + " | Passed: " + str(passed0))

# Simple Linked List 
a0.next = ListNode(1)
resultLen2 = hasCycle(a0)
expectedLen2 = False
passedLen2 = expectedLen2 == resultLen2
print("Expected: " + str(expectedLen2) +" | Actual: " + str(resultLen2) + " | Passed: " + str(passedLen2))

# Single Cycle test (cycle on self)
sc = ListNode(0)
sc.next = sc
scres = hasCycle(sc)
expectedsc = True
passedsc = expectedsc == scres
print("Expected: " + str(expectedsc) +" | Actual: " + str(scres) + " | Passed: " + str(passedsc))
