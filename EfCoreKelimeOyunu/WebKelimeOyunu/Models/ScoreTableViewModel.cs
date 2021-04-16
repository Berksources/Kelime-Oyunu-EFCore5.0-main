using Entity.KelimeOyunu;
using System.Collections.Generic;

namespace WebKelimeOyunu.Models
{
    public class ScoreTableViewModel
    {
        public ScoreTable ScoreTable { get; set; }
        public IEnumerable<ScoreTable> ScoreTables {get;set;}
        public IEnumerable<ScoreTable> ScoreTableOnly {get;set;}
    }
}
