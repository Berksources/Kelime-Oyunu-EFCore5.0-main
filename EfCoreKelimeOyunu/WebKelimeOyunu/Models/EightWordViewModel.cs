using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebKelimeOyunu.Models
{
    public class EightWordViewModel
    {
        public EightWord EightWord { get; set; }
        public IEnumerable<EightWord> EightWords { get; set; }
        public IEnumerable<EightWord> EightWordOnly { get; set; }
    }
}
