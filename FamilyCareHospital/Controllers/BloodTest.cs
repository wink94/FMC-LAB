using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCareHospital.Controllers
{
    class BloodTest
    {
        private int BTNo;
        private int sugar;
        private int WBC;
        private int RBC;
        private int Platelet_Count;
        private string units;
        


        public void BloodSugar(int sugar,string testUnits)
        {
            this.sugar = sugar;
            units = testUnits;
        }

        public void BloodCellCount(int wbcCount,int rbcCount)
        {
            WBC = wbcCount;
            RBC = rbcCount;
        }

        public void PlateletCount(int plateletCount)
        {
            Platelet_Count = plateletCount;
        }

    }
}
