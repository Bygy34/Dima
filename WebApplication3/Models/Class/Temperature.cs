namespace WebApplication3
{
    public abstract class Temperature : Technics, ITemprich
    {
        private int temperature;
        public Temperature(string name, int temperature, bool status) : base(name, status)
        {
            this.temperature = temperature;
        }

        public int Temprich
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value <= 5 && value <= 27)
                {
                   temperature = value;
                }
            }
        }


        public void IncreaseTempriche()
        {
            Temprich++;
        }

        public void DecreasTempriche()
        {
            Temprich--;
        }
        
    }
}