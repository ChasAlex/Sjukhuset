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


        Nurse(string name ) {
        
        
        
        }
        

        void SetDiagnosis(string diagnosis, Pasient myPatient)
        {
            myPatient._diagnosis = diagnosis;



        }



    }
}
