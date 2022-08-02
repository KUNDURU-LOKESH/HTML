using System.ComponentModel.DataAnnotations;

namespace Employee_crud_mvc.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(15)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        [MaxLength(10)]
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string PostalCode { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string city { get; set; }
    }
}
