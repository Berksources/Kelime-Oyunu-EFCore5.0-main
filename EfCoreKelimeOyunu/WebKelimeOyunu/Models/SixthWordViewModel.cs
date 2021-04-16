using Entity.KelimeOyunu;
using System.Collections.Generic;

namespace WebKelimeOyunu.Models
{
    public class SixthWordViewModel
    {
        public SixthWord SixthWord { get; set; }
        public IEnumerable<SixthWord> SixthWords{get;set;}
        public IEnumerable<SixthWord> SixthWordsOnly{get;set;}
    }
}
