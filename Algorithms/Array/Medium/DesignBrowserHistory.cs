/**
 * @id         1472
 * @title      Design Browser History
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/design-browser-history/
 */
using Algorithms.Common;

namespace Array.Medium;

public class DesignBrowserHistory
{
    private TestListNode _node;
    private int _index = 0;
    public DesignBrowserHistory(string homepage)
    {
        _node = new(_index, homepage);
    }

    public void Visit(string url)
    {
        _node.next = new TestListNode(_index++, url);

    }

    public string Back(int steps)
    {

        return "";
    }

    public string Forward(int steps)
    {
        return "";
    }
}


public class TestListNode
{
    public int val;
    public string site;
    public TestListNode next;
    public TestListNode(int val = 0, string site = "", TestListNode next = null)
    {
        this.val = val;
        this.next = next;
        this.site = site;
    }
}

