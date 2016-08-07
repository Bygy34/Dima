namespace WebApplication3
{
    public abstract class Temperature : Technics, ITemprich
    {
        private int temperature;
        public Temperature(string name, int temperature, bool status) : base(name, status)
        {
            this.temperature = temperature;
        }

        public int TempricheUp
        {
            get
            {
                temperature++;
                return temperature;
            }
        }

        public int TempricheDown
        {
            get
            {
                temperature--;
                return temperature;
            }
        }

        public int GetTempriche
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value > 0 && value < 101)
                {
                    temperature = value;
                }
            }
        }
    }
}