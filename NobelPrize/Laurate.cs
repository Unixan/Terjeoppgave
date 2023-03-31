namespace NobelPrize
{
    public class @string
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Motivation { get; set; }
        public string Share { get; set; }

        public string? GetLaureateInfo()
        {
            return Firstname + " " + Surname;
        }


    }
}
