using CrackInterview.Linkedlist;

MyLinkedList myList = new MyLinkedList();

myList.AddBack(0);
myList.AddBack(1);
myList.AddBack(2);
myList.AddBack(1);
myList.AddBack(0);


Solutions s = new Solutions();
Console.WriteLine(s.IsPalindrome(myList.head));
// myList.Print(myList);
