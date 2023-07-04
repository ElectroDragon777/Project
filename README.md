# Project
_This project's purpose is to show how Stack and recursion work._
**Exercise 1:**
We are using Stack (System.Collections.Generic to call it) to mirror a string. We split the string by SPACE character and add it to a string array, for which we use "foreach" to get every single word in it.
The Stack is LIFO (Last in, first out) which means the last thing that gets pushed to the Stack (Stack.Push() is to add the elements) comes first.
**Exercise 2:**
Writing a method has its tricks some people aren't aware of. One of those tricks in an easy one - _recursion_. It calls the method itself again and everything in it goes again. But how do we stop it? If the methods variables reach a value that doesn't work for us, we check with _if_ construction. If it does meet the termination criteria, use return. It will break the method.
