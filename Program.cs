class Program
{
    static void Main()
    {
        LinkedList<string> collection = new LinkedList<string>();
        collection.AddLast("Soumesh");
        collection.AddLast("Aditya");
        collection.AddLast("Devashish");
        collection.AddLast("Amrit");


        Console.WriteLine("Personal Name: ");

        foreach (string str in collection)
        {
            Console.WriteLine(str);
        }
    }
}