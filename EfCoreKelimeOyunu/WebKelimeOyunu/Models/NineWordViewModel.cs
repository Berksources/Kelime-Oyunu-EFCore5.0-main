using Entity.KelimeOyunu;

namespace WebKelimeOyunu.Models
{
    public class NineWordViewModel
    {
        public NineWord NineWord { get; set; }
        public IEnumerable<NineWord> NineWords{get;set;}
    }
}
