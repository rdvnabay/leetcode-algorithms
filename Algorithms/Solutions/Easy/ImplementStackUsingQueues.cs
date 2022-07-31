namespace Algorithms.Solutions.Easy;

public class ImplementStackUsingQueues
{
    public static void Run()
    {
        var myStack = new MyStack();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Top();
        myStack.Pop();
        myStack.Empty();
    }
}

public class MyStack
{
    private readonly List<int> _list;
    public MyStack()
    {
        _list = new List<int>();
    }

    public void Push(int x) => _list.Add(x);

    public int Pop()
    {
        int removeItem = _list[_list.Count - 1];
        _list.RemoveAt(_list.Count - 1);
        return removeItem;
    }

    public int Top() => _list[_list.Count - 1];

    public bool Empty() => _list.Count == 0;
}
