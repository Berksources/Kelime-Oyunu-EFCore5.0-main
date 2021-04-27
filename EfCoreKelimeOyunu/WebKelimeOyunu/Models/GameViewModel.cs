using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebKelimeOyunu.Models
{
    public class GameViewModel
    {
        public IEnumerable<FourWord> FourWords { get; set; }
        public IEnumerable<FifthWord> FifthWords { get; set; }
        public IEnumerable<SixthWord> SixthWords { get; set; }
        public IEnumerable<SevenWord> SevenWords { get; set; }
        public IEnumerable<EightWord> EightWords { get; set; }
        public IEnumerable<NineWord> NineWords { get; set; }
        public IEnumerable<TenWord> TenWords { get; set; }
        public IEnumerable<GameVariant> GameVariants { get; set; }
        public int WrongAnswerScore { get; set; }
    }
}
