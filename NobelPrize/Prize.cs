namespace NobelPrize
{

    public class Prize
    {
        public string Year { get; set; }
        public string Category { get; set; }
        public @string[] Laureates { get; set; }
        public string OverallMotivation { get; set; }

        public string GetPrizeInfo()
        {
            var winners = Laureates.Aggregate(string.Empty,
                (current, winner) => current + (winner.GetLaureateInfo() + ", "));

            return $"Kategori: {Category}\nÅr: {Year}\nVinnere:\n  {winners}\n";
        }

        public string[] GetAllLaureatesOfPrize()
        {
            var prizeWinners = new List<string>();
            for (var i = 0; i < Laureates?.Length; i++)
            {
                var laureate = Laureates[i];
                prizeWinners.Add(laureate.GetLaureateInfo());
            }

            return prizeWinners.ToArray();
        }

    }
}


