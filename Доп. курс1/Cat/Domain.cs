using System;

namespace Domain
{
    public class CatColor
    {
        public string HeathyColor { get; set; }
        public string SickColor { get; set; }
        public CatColor()
        {
            HeathyColor = "white";
            SickColor = "green";
        }
        
    }
    public class Cat
    {
        private int _heath;
        private string _name;
        public int Age { get; private set; }
        public string Name
        {
            get { return _name; }
            set { if (_name == "Безымянный(ая)") _name = value; }
        }
        public string CurrentColor()
        {
            return (_heath < 5) ? Color.SickColor : Color.HeathyColor;
        }
        public CatColor Color { get; set; }
        public Cat()
        {
            Console.Write("Животное какого возраста вы бы хотели приобрести?\n");
            Age = Convert.ToInt32(Console.ReadLine());
            _name = "Безымянный(ая)";
            Color = new CatColor();
            _heath = 5;
        }
        public void Feed()
        {
            _heath++;
        }

        public void Punish()
        {
            _heath--;
        }
    }
}
