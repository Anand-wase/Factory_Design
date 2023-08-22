using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Factory_Design.Models
{
    public class EmployeeType
    {

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [MaxLength(50)]

        public string Employee_Type { get; set; }


    }
}
