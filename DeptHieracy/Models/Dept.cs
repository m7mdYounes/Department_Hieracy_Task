using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeptHieracy.Models
{
    public class Dept
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public string DeptNameName { get; set; }

        //[Display(Name = "Department Logo File")]
        //public byte[] Dept_Logo { get; set; }


        [Display(Name ="Parent Department")]
        [ForeignKey("Parent_dept")]
        public int? Parent_Dept_id { get; set; }
        public virtual Dept Parent_dept { get; set; }
    }
}
