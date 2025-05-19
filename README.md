# Stack implementation using C#

This project is a basic implementation of a Stack data structure in C#. It provides fundamental stack operations such as push, pop, checking if the stack is empty, and displaying the elements of the stack.

## Overview

A stack is a linear data structure that follows the Last-In, First-Out (LIFO) principle. This implementation uses a linked list internally to store the stack elements.

## Features

* **Push:** Adds a new element to the top of the stack.
* **Pop:** Removes and returns the element at the top of the stack.
* **isEmpty:** Checks if the stack is currently empty.
* **Display:** Prints all the elements currently in the stack.

## Code Structure

The project consists of two main classes:

* **`Node`:** Represents a single node in the linked list that forms the stack. Each node contains:
    * `data`: An integer value stored in the node.
    * `next`: A reference to the next node in the stack (null if it's the top node).
* **`Stack`:** Implements the stack data structure. It contains:
    * `top`: A private `Node` variable that points to the top of the stack (null if the stack is empty).
    * `Stack()`: Constructor to initialize an empty stack (sets `top` to null).
    * `isEmpty()`: A method to check if the stack is empty.
    * `Push(int data)`: A method to add a new element to the stack.
    * `Pop()`: A method to remove and return the top element from the stack.
    * `Display()`: A method to print the elements of the stack from top to bottom.
    * `Main()`: The entry point of the program, providing a menu-driven interface for interacting with the stack.

## How to Use

When you run the program, you will be presented with the following options:

1.  **Push:** Enter `1` and then the integer value you want to add to the stack.
2.  **Pop:** Enter `2` to remove and see the value popped from the stack.
3.  **Check if Empty:** Enter `3` to check the current status of the stack.
4.  **Display Stack:** Enter `4` to view the elements currently in the stack.
5.  **Exit:** Enter `5` to terminate the program.


