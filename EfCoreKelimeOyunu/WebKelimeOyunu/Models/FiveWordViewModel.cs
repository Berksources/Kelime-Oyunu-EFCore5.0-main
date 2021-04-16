using Entity.KelimeOyunu;
using System.Collections.Generic;

namespace WebKelimeOyunu.Models
{
    public class FiveWordViewModel
    {
        public FifthWord FifthWord { get; set; }
        public IEnumerable<FifthWord> FifthWords{get;set;}
        public IEnumerable<FifthWord> FifthWordOnly{get;set;}
    }
}
