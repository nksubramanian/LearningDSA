namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.PrintAllNodes();
            bool isPresent = linkedList.Search(2);
            Console.WriteLine(isPresent);

        }



    }
}