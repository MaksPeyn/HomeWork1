using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Kisa
    {
        string _klichka;
        public string Cvet { get; set; }
        public int Health { get; private set; }
        public Kisa (int health)
        {
            Health = health;
        }
        public void Korm (int k) { Health += k; }
        public string Klichka
        {
            get { return _klichka; }
            set { if (_klichka[0] == '\0') _klichka = value; }
        }

    }
}
