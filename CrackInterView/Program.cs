﻿using CrackInterview.Linkedlist;

MyLinkedList myList = new MyLinkedList();

myList.AddBack(1);
myList.AddBack(2);
myList.AddBack(3);
myList.AddBack(4);
myList.AddBack(5);
myList.AddBack(3);
myList.AddBack(5);
myList.AddBack(1);
myList.Print();

Console.WriteLine("After delete middle operation");


myList.Print();