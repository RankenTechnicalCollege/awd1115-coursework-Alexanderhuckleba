using System.Data;
using Project_9;

Leaf leaf = new ();
Pancake pancake = new();
Corner corner = new  ();
Page page = new ();

List<ITurnable>turntables= new List<ITurnable> { pancake, leaf, corner, page };

static void Turning(List<ITurnable> t)
{
    foreach (ITurnable turn in t)
    {
        Console.WriteLine(turn.Turn());
    }
}

