namespace CoinFlip.Models
{
    class Coin
    {
        public int Lados { get; set; } = 2;
         
        public int Girar()
        {
            return Random.Shared.Next(0, Lados);
        }
    }
}
