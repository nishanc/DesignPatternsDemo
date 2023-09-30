public class President
{
    private static President? instance;
    private President() { }

    public static President Instance
    {
        get
        {
            if (instance == null)
                instance = new President();
            return instance;
        }
    }
}