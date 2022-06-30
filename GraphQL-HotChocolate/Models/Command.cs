namespace GraphQL_HotChocolate.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLine { get; set; }

        public Platform Platform { get; set; }
    }
}
