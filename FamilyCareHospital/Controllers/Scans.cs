using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCareHospital.Controllers
{
    class Scans
    {
        private int SNo;
        private bool CT;
        private bool MRI;
        private bool X_RAY;

        public bool CT_Scan { set { CT = value; } get { return CT; } }
        public bool MRI_Scan { set { MRI = value; } get { return MRI; } }
        public bool X_RAY_Scan { set { X_RAY = value; } get { return X_RAY; } }

    }
}
