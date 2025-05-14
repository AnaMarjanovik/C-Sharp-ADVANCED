using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entity
{
    public class WebPage : ISearchable
    {
        public string htmlContent;

        public WebPage()
        {
        }

        public WebPage(string htmlContent)
        {
            this.htmlContent = htmlContent;
        }

        public bool Search(string word)
        {
            return htmlContent.Contains(word);
        }
    }
}
