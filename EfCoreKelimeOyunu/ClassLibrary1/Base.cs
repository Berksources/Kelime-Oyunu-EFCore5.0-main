using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.KelimeOyunu
{
    public abstract class Base
    {
        protected Base()
        {
            DataGuidID = Guid.NewGuid();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DataGuidID { get; set; }
        public DateTime CreatedDate { get; set; } //Oluşturulma Tarihi
        public DateTime? ModifiedDate { get; set; } //Güncellenme Tarihi
    }
}
