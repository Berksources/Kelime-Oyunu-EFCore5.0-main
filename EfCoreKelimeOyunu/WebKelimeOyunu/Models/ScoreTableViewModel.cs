using Entity.KelimeOyunu;

namespace WebKelimeOyunu.Models
{
    public class ScoreTableViewModel
    {
        public ScoreTable ScoreTable { get; set; }
        public IEnumerable<ScoreTable> ScoreTables{get;set;}
    }
}
