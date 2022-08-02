using Employee.API.Model;

namespace Employee.API
{
    public class EmployeeData
    {
        public List<EmployeeViewModel> employeesList { get; set; }
        public EmployeeData()
        {
            employeesList = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel()
                {
                    Id = 1,
                    FirstName="Lokesh",
                    LastName="kunduru",
                    Email="lokesh@gmail.com",
                    MobileNumber="253132165",
                    AddressLine1="abc",
                    AddressLine2="abc",
                    city="vijayawada",
                    Country="India",
                    PostalCode="123",
                },
                new EmployeeViewModel()
                {
                    Id = 2,
                    FirstName="Ravi",
                    LastName="kumar",
                    Email="kumar@gmail.com",
                    MobileNumber="7895201463",
                    AddressLine1="mumbai",
                    AddressLine2="delhi",
                    city="Eluru",
                    Country="India",
                    PostalCode="521230",
                },
                new EmployeeViewModel()
                {
                    Id = 3,
                    FirstName="Venu",
                    LastName="Gopal",
                    Email="venu@gmail.com",
                    MobileNumber="63043665",
                    AddressLine1="abcsdvdcv",
                    AddressLine2="abcbfghjiklmo",
                    city="vizag",
                    Country="Usa",
                    PostalCode="799788",
                },

            };
        }
    }
}
