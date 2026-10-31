using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Student : Human
    {
        [Key]
        public int stud_id {get; set;}

        [ForeignKey(nameof(Group))]
        public int group { get; set; }
        //Navigation
        public Group Group { get; set; }
    }
}
