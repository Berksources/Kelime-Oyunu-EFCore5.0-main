using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
   public class NineWord:Base
    {
        [Key]
        public int NineWordID { get; set; }
        [Required]
        public string NineWordQuestion { get; set; }//Soru
        [Required]
        public string NineWordAnswer { get; set; }//Cevap
        [Required]
        public string NineWordData { get; set; }//Veri
        [Required]
        public int NineWordScore { get; set; }
    }
}
