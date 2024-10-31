namespace Customer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = @"C:\Users\II novbe\Desktop\Customer\Data";
            string fileName = "Data";
            Directory.CreateDirectory(address);
            string filePath = Path.Combine(address, "customers.json");
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath)) ;
            }
            Customer.Add(new Customer() { FirstName = "Azad", Id = 5, LastName = "Bulba", PhoneNumber = "+666 66 666" });
        }
        public static string jsonAddress = @"C:\Users\II novbe\Desktop\Customer\Data\customers.json";
        //File.WriteAllText(filePath, null);



    }
}