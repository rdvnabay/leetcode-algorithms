namespace Algorithms.Solutions.Easy;

public class ValidParentheses
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"> "(){}}{" </param>
    /// <returns></returns>
    public static bool Run(string s)
    {
        bool output = false;

        var items = new List<Item>()
        {
            new(1,'{',-1),
            new(2,'}',1),
            new(3,'(',-2),
            new(4,')',2),
            new(5,'[',-3),
            new(6,']',3),
        };

        var checkList = new List<Item>();

        for (int i = 0; i < s.Length; i++)
        {
            var currentItem = items.Find(x => x.Key == s[i]);

            if (currentItem is not null)
            {
                if (i == 0)
                    if (currentItem.Value > 0) return false;

                if (currentItem.Value < 0)
                    checkList.Add(new Item(checkList.Count + 1, s[i], currentItem.Value));

                else if (currentItem.Value > 0)
                {
                    var previousItem = checkList.LastOrDefault();

                    if (checkList.Count == 0) return false;
                    if (currentItem.Value + previousItem.Value != 0) return false;

                    else
                    {
                        checkList.RemoveAt(checkList.FindIndex(x => x.Id == previousItem.Id));
                        output = true;
                    }
                }
            }
        }
        return checkList.Count > 0 ? false : true;
    }
}

public class Item
{
    public Item(int id, char key, int value)
    {
        Id = id;
        Key = key;
        Value = value;
    }

    public int Id { get; set; }
    public char Key { get; set; }
    public int Value { get; set; }
}
