namespace WebApplication2.Controllers
{
    public class Player
    {
        public Player(string symbol, int number)
        {
            this.symbol = symbol;
            this.number = number;
        }

        public string symbol { get; set; }
        public int number { get; set; }

    }
}