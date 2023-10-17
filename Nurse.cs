using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjukhuset
{
    internal class Nurse:Person
    {
        private bool _dayShift;


        public Nurse(string name, bool dayshift ) {
            _name = name;
            _dayShift = dayshift;
        
        
        }
        

        void SetDiagnosis(string diagnosis, Pasient myPatient)
        {
            myPatient._diagnosis = diagnosis;



        }



    }
}
