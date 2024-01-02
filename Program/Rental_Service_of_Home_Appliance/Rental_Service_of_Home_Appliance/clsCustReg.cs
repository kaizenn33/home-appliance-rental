using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Service_of_Home_Appliance
{
    class clsCustReg:clsCustMethod
    {
        string cid, cname, cun, cpw, cph, ceml, caddr; // declaring var for data receiving and returning
        public string CustID
        {
            get
            {
                return cid; // data returning
            }
            set
            {
                cid = value; // data receiving
            }
        }
        public string CustName
        {
            get
            {
                return cname;
            }
            set
            {
                cname = value;
            }
        }
        public string CustUsername
        {
            get
            {
                return cun;
            }
            set
            {
                cun = value;
            }
        }
        public string CustPsw
        {
            get
            {
                return cpw;
            }
            set
            {
                cpw = value;
            }
        }
        public string Custph
        {
            get
            {
                return cph;
            }
            set
            {
                cph = value;
            }
        }
        public string CustEmail
        {
            get
            {
                return ceml;
            }
            set
            {
                ceml = value;
            }
        }
        public string CustAddress
        {
            get
            {
                return caddr;
            }
            set
            {
                caddr = value;
            }
        }
    }
}
