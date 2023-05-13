namespace GunsOfTheOldWest.Models
{
    public class Gun
    {
        public int Kogels { get; set; }

        public void Geschoten()
        {
            Kogels--;
        }

        public void Seed()
        {
            Kogels = 12;
        }
    }
}
