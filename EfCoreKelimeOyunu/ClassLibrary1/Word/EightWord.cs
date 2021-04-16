using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class EightWord:Base
    {
        [Key]
        public int EightWordID { get; set; }
        [Required]
        public string EightWordQuestion { get; set; }//Soru
        [Required]
        public string EightWordAnswer { get; set; }//Cevap
        [Required]
        public string EightWordData { get; set; }//Veri
        [Required]
        public int EightWordScore { get; set; }
    }
}
