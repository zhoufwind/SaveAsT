using System;

namespace WindowsFormsSaveObjectsAsXMLAndJSON
{
    public class BilingualBook
    {
        public string Author { get; set; }
        public string SourceLang { get; set; }
        public string TargetLang { get; set; }
        public string EnglishTitle { get; set; }
        public string PaperbackURI { get; set; }
        public string KindleURI { get; set; }
        public string ImageURI { get; set; }
    }
}
