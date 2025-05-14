using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entity
{
    public class Document : ISearchable
    {
        public string text;

        public Document()
        {
            
        }
        public Document(string text)
        {
            this.text = text;
        }

        public bool Search(string word)
        {
            return text.Contains(word);
        }

    }
}
