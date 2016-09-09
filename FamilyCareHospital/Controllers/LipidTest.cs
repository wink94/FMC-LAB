using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCareHospital.Controllers
{
    class LipidTest
    {
        private int CTNo;
        private double HDL;
        private double LDL;
        private double serum_cholesterol;
        private string units;

        public void Cholesterol(double HDL,double LDL,double serum_cholesterol,string units)
        {
            this.serum_cholesterol = serum_cholesterol;
            this.HDL = HDL;
            this.LDL = LDL;
            this.units = units;
        } 
    }
}
