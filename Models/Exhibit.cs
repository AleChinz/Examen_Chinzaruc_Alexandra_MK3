using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen_Chinzaruc_Alexandra_MK3.Models
{
    public class Exhibit
    {
        public int ID { get; set; }

        [Display(Name = "Exhibit Name")]
        public string Exhibit_Name { get; set; }
        [Display(Name = "Comic Universe")]
        public string Comic_Universe { get; set; }
        [Display(Name = "Hero Power")]
        public string Hero_Power { get; set; }

        [Display(Name = "First Appearance Issue Number")]
        [Column(TypeName = "decimal(6, 0)")]
        public decimal Issue_of_Apparition { get; set; }

        [Display(Name = "First Appearance Issue")]
        public string Issue_Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "First Appearance Date")]
        public DateTime FirstAppearanceDate { get; set; }
    }
}
