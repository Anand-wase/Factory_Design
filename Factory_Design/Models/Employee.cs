using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Factory_Design.Models
{
    public class Employee
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        // [MaxLength(50)]

        public string Name { get; set; }

        //  [MaxLength(50)]

        public string JobDescription { get; set; }

        //  [MaxLength(50)]  

        public string Number { get; set; }

        //  [MaxLength(50)]
        public string Department { get; set; }

        //  [Column(TypeName = "decimal(18,4)")]

        public int HourlyPay { get; set; }

        //  [Column(TypeName = "decimal(18,4)")]

        public int Bonus { get; set; }
        public int HouseAllowance {get; set;}
        public int MedicalAllowance {get; set;}
        public string? ComputerDetails { get; set;}

        [ForeignKey("EmployeeType")]

        public int EmployeeTypeId { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }

    }
}
   

