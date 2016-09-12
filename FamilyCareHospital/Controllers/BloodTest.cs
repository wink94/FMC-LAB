using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public Dictionary<string,string> identifyTests(string testID)
        {
            var dic = new Dictionary<string, string> ();

            string patternSugar=@"BS";
            string patternCellCount = @"BCC";
            string patternPlatelets= @"PC"; 
            Match sugar = Regex.Match(testID, patternSugar);
            Match cellCount = Regex.Match(testID, patternCellCount);
            Match platelet = Regex.Match(testID, patternPlatelets);

            if (sugar.Success)
            {
                dic.Add("field1_units", "mg/dm\u00b3");
                dic.Add("field1_name", "Sugar");
                dic.Add("field1_dataType", "int");
                dic.Add("field_num", "1");
                return dic;
            }
            else if (cellCount.Success)
            {
                dic.Add("field1_units", "mg/dm\u00b3");
                dic.Add("field1_name", "WBC");
                dic.Add("field1_dataType", "int");
                dic.Add("field2_units", "mg/dm\u00b3");
                dic.Add("field2_name", "RBC");
                dic.Add("field2_dataType", "int");
                dic.Add("field_num", "2");
                return dic;
            }
            else if (platelet.Success)
            {
                dic.Add("field1_units", "mg/dm\u00b3");
                dic.Add("field1_name", "Platelet Count");
                dic.Add("field1_dataType", "int");
                dic.Add("field_num", "1");
                return dic;
            }
            else
                return dic;

        }

    }
}
