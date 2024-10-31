using Newtonsoft.Json;

namespace Customer
{
    internal class Customer
    {
        public static string jsonAddress = @"C:\Users\II novbe\Desktop\Customer\Data\customers.json";
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public static void Add(Customer customer)
        {
            using (StreamReader sr = new StreamReader(Program.jsonAddress)) ;

            //string json = 
            List<Customer> list = JsonConvert.DeserializeObject<List<Customer>>(jsonAddress);
            list.Add(customer);
        }
    }
}
