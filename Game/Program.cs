using Game;

var stack = new Game.Stack<string>();
Console.WriteLine(stack.Pop());
stack.Push("lol");
stack.Push("kek");
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());