using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Core.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Department_ID { get; set; }
        public string Name_Ar { get; set; }
        public string Name_En { get; set; }
        public Nullable<bool> IsActive { get; set; }
        [ForeignKey("College")]
        public int FK_College_Id { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public virtual College College { get; set; }
    }
}
