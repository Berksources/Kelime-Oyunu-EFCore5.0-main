using Entity.KelimeOyunu;
using System.Collections.Generic;

namespace WebKelimeOyunu.Models
{
    public class NineWordViewModel
    {
        public NineWord NineWord { get; set; }
        public IEnumerable<NineWord> NineWords {get;set;}
        public IEnumerable<NineWord> NineWordOnly {get;set;}
    }
}
