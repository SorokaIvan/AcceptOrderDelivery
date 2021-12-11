namespace AcceptOrderDelivery
{
    public class OrderNumberGenerator
    {
        private Random _rnd = new Random();

        public string Generate()
        {
            var number = _rnd.Next(100000, 600000);

            
            return number.ToString();
        }
    }
}
