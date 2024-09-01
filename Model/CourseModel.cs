using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Model
{
    [Table("CourseTBL")]
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }

        [Column("Course_Name")]
        public string CourseName { get; set; }

        [Column("Course_Description")]
        public string CourseDescription { get; set; }
    }
}
