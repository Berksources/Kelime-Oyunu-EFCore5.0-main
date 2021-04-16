using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class SevenWord:Base
    {
        [Key]
        public int SevenWordID { get; set; }
        [Required]
        public string SevenWordQuestion { get; set; }//Soru
        [Required]
        public string SevenWordAnswer { get; set; }//Cevap
        [Required]
        public string SevenWordData { get; set; }//Veri
        [Required]
        public int SevenWordScore { get; set; }
    }
}
