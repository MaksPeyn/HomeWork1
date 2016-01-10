namespace Domain
{
    public class CatColor
    {
        public string HealthyColor { get; set; }
        public string SickColor { get; set; }
        public CatColor()
        {
            HealthyColor = "white";
            SickColor = "green";
        }
        
    }
    public class Cat
    {
        private int _health;
        private string _name;
        public int Age { get; }
        public string Name
        {
            get { return _name; }
            set { if (_name == "Безымянный(ая)") _name = value; }
        }
        public string CurrentColor => (_health < 5) ? Color.SickColor : Color.HealthyColor;

        public CatColor Color { get; set; }
        public Cat (int age)
        {
            Age = age;
            _name = "Безымянный(ая)";
            Color = new CatColor();
            _health = 5;
        }
        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }
    }
}
