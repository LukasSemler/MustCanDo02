using System;
using System.Collections.Generic;
using System.Text;

namespace MustCanDo_2
{
    internal class TextVerwaltung
    {
        protected List<string> texte = new List<string> { };


        public void AddTexte(string neu)
        {
            texte.Add(neu);
        }

        public void PrintText()
        {
            foreach (var item in texte)
            {
                Console.WriteLine(item);
            }
        }

        public bool ReplaceText(string alt, string neu)
        {
            int index = texte.IndexOf(alt);
            if (index >= 0)
            {
                texte[index] = neu;
                return true;
            }
            else
                return false;
        }
    }
}
