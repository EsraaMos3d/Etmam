using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Core.Models
{
    public class College
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int College_Id { get; set; }
        public string CollegeName_Ar { get; set; }
        public string CollegeName_En { get; set; }
        [ForeignKey("University")]
        public int FK_University_Id { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public virtual University University { get; set; }
    }
}
