namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> techCompanies = new List<string>();
            techCompanies.Add("Microsoft");
            techCompanies.Add("Google");
            techCompanies.Add("Cognosos");
            techCompanies.Add("Rocket");

            techCompanies.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
