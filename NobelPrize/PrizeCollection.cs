namespace NobelPrize
{
    internal class PrizeCollection
    {
        public Prize[] Prizes { get; set; }

        public PrizeCollection(Prize[] prizes)
        {
            Prizes = prizes;
        }

        public void FilterByYear()
        {
            Console.WriteLine("Skriv åsrtall du vil filtrere: ");
            var choice = Console.ReadLine();
            var listOfYears = Prizes.Where(y => y.Year == choice);
            foreach (var year in listOfYears)
            {
                Console.WriteLine($"{year.GetPrizeInfo()}");
            }
        }

        public void WonMoreThanOnce()
        {
            var multipleWins = MultipleWins();

            for (var i = 0; i < multipleWins.Length; i++)
            {
                var number = (i + 1).ToString().PadLeft(2,'0');
                var winner = multipleWins[i];
                Console.WriteLine($"{number} {winner}");
            }
        }

        private string[] MultipleWins()
        {
            var listOfAllWinners = new List<string>();
            var multipleWins = new List<string>();
            foreach (var winners in Prizes)
            {
                var prizeWinnersArray = winners.GetAllLaureatesOfPrize();
                foreach (var winner in prizeWinnersArray)
                {
                    if (!listOfAllWinners.Contains(winner) && winner != null)
                    {
                        listOfAllWinners.Add(winner);
                    }
                    else if (listOfAllWinners.Contains(winner) && !multipleWins.Contains(winner))
                    {
                        multipleWins.Add(winner);
                    }
                }
            }

            return multipleWins.ToArray();
        }
    }
}
