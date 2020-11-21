using System;

namespace MustCanDo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextVerwaltung tv = new TextVerwaltung();
            tv.AddTexte("Hallo");
            tv.AddTexte("tolle");
            tv.AddTexte("3CHIT");
            tv.PrintText();
            Console.WriteLine(tv.ReplaceText("Hallo", "Hi"));
            tv.PrintText();
            Console.WriteLine(tv.ReplaceText("Hi", "liebe"));
            tv.PrintText();
            Console.ReadKey();
        }
    }
}
