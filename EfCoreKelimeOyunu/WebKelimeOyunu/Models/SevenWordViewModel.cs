using Entity.KelimeOyunu;

namespace WebKelimeOyunu.Models
{
    public class SevenWordViewModel
    {
        public SevenWord SevenWord { get; set; }
        public IEnumerable<SevenWord> SevenWords {get;set;}
        public IEnumerable<SevenWord> SevenWordsOnly {get;set;}

    }
}
