using System.ComponentModel.DataAnnotations;

namespace employeenote.Models
{
    public enum DEPARTMENT
    {
        HR,SALES,FININACE
    }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Field is Empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field is Empty")]
        [EmailAddress]
        public string email    { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        [EnumDataType(typeof(DEPARTMENT))]
        public DEPARTMENT dept { get; set; }
        public Employee() {
            Console.WriteLine("Emp");
        }
     }
}
