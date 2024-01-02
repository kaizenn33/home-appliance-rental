using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Service_of_Home_Appliance
{
    class clsAdm:clsMethod
    {
        string aname, aid, ausn, apsw, aslry, aph, aeml, aadr; // declaring variables for data rreceiving and returning
       

        public string AdmAdd
        {
            get
            {
                return aadr;
            } // returning data
            set
            {
                aadr = value;
            } // receiving data
        }

        public string AdmEml
        {
            get
            {
                return aeml;
            }
            set
            {
                aeml = value;
            }
        }

        public string AdmPh
        {
            get
            {
                return aph;
            }
            set
            {
                aph = value;
            }
        }

        public string AdmSalary
        {
            get
            {
                return aslry;

            }
            set
            {
                aslry = value;
            }
        }

        public string AdmPsw
        {
            get
            {
                return apsw;
            }
            set
            {
                apsw = value;
            }
        }

        public string AdmUsn
        {
            get
            {
                return ausn;
            }
            set
            {
                ausn = value;
            }
        }

        public string AdmID
        {
            get
            {
                return aid;
            }
            set
            {
                aid = value;
            }
        }

       
        public string  AdmName
        {
            get
            {
                return aname;
            }
            set
            {
                aname = value;
            }
        }
    }
}
