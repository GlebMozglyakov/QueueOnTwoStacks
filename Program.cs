// See https://aka.ms/new-console-template for more information
using QueueOnTwoStacks;

Console.WriteLine("Hello, World!");

var queue = new QueueTwoStacks<int>();
queue.Push(1);
queue.Push(2);
queue.Push(3);
queue.Push(44);
Console.WriteLine(queue.Pop());
Console.WriteLine(queue.Pop());
Console.WriteLine(queue.Pop());
Console.WriteLine(queue.Pop());