using CrackInterview.Linkedlist;

MyLinkedList myList = new MyLinkedList();

myList.AddBack(3);
myList.AddBack(5);
myList.AddBack(8);
myList.AddBack(5);
myList.AddBack(10);
myList.AddBack(5);
myList.AddBack(1);

Solutions s = new Solutions();
s.KthToLast(myList, 3);
// myList.Print(myList);