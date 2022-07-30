class Program
{
    static void Main()
    {
        LinkedList<string> collection = new LinkedList<string>();
        // to add a item in a linked list -> AddLast()
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