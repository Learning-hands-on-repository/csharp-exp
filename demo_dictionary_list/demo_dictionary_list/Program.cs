internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> testDict = new Dictionary<string, string>();

        testDict.Add("abc", "123");
        testDict.Add("bcd", "321");
        testDict.Add("dbc", "456");

        foreach (KeyValuePair<string,string> kvp in testDict.ToList())
        {
            // Console.WriteLine(kvp);
        }
        foreach (string str in testDict.Values)
        {
            // Console.WriteLine(str);
        }

        // with more complex example
        Dictionary<string, List<string>> test2DmDict = new Dictionary<string, List<string>>();
        test2DmDict.Add("abc", new List<string>()
        {
            "123", "456", "978"
        });
        test2DmDict.Add("bcd", new List<string>()
        {
            "123"
        });
        foreach (KeyValuePair<string, List<string>> kvp in test2DmDict.ToList())
        {
            Console.WriteLine(kvp);
        }
        foreach (List<string> str in test2DmDict.Values)
        {
            Console.WriteLine(str);
        }
    }
}