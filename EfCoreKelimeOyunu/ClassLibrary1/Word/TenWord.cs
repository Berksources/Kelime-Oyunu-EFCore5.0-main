using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class TenWord:Base
    {
        [Key]
        public int TenWordID { get; set; }
        [Required]
        public string TenWordQuestion { get; set; }//Soru
        [Required]
        public string TenWordAnswer { get; set; }//Cevap
        [Required]
        public string TenWordData { get; set; }//Veri
        [Required]
        public int TenWordScore { get; set; }
    }
}
