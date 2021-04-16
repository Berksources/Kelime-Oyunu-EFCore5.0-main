using Entity.KelimeOyunu;
using System.Collections.Generic;

namespace WebKelimeOyunu.Models
{
    public class TenWordViewModel
    {
        public TenWord TenWord { get; set; }
        public IEnumerable<TenWord> TenWords {get;set;}
        public IEnumerable<TenWord> TenWordOnly {get;set;}
    }
}
