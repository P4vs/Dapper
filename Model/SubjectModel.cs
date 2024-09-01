using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Model
{
    [Table("SubjectTBL")]
    public class SubjectModel
    {
        [Key]
        public int Id { get; set; }

        [Column("Subject_Name")]
        public string SubjectName { get; set; }

        [Column("Subject_Description")]
        public string SubjectDescription { get; set; }
    }
}
