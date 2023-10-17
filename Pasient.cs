using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjukhuset
{
    internal class Pasient:Person
    {
        public string _recept;
        public string _diagnosis;

        public Pasient(string name)
        {
            _name = name;
            _recept = "Has no Prescription";
            _diagnosis = "Undiagnosed";
        }






    }
}

