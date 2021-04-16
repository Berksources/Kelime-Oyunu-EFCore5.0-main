using Entity.KelimeOyunu;
using System.Collections.Generic;

namespace WebKelimeOyunu.Models
{
    public class FourWordViewModel
    {
        public FourWord FourWord { get; set; }
        public IEnumerable<FourWord> FourWords{get;set;}
        public IEnumerable<FourWord> FourWordsOnly{get;set;}
    }
}
