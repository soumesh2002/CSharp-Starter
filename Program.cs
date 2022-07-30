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


        /*Console.WriteLine("Personal Name: ");*/

        /*foreach (string str in collection)
        {
            Console.WriteLine(str);
        }*/

        /* remove a item from the linked list */
        /*collection.Remove(collection.First());
        foreach (string str in collection)
        {
            Console.WriteLine(str);
        }*/

        //counting the number of students left after removing in the collection
        Console.WriteLine($"number of students: {collection.Count}"); // 4

        //after removing
        collection.Remove(collection.First());
        Console.WriteLine("after removing");
        Console.WriteLine($"number of students now: {collection.Count}");
    }
}