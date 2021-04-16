using Entity.KelimeOyunu;

namespace WebKelimeOyunu.Models
{
    public class TenWordViewModel
    {
        public TenWord TenWord { get; set; }
        public IEnumerable<TenWord> TenWords{get;set;}
    }
}
