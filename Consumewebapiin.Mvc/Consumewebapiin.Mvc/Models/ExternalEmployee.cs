namespace Consumewebapiin.Mvc.Models
{
    public class ExternalEmployee
    {
        public string status { get; set; }
        public List<Datum> data { get; set; }
        public string message { get; set; }
    }
    public class Datum
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }
}
