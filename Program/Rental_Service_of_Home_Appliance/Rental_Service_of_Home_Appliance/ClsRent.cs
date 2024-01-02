using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Service_of_Home_Appliance
{
    class ClsRent:clsMethod
    {
        string RentID, CustID, RentDate, RentStatus;
        int RendPrd, TtQty, TtPrc, Promo, NetPrc;

        public string rntid
        {
            get
            {
                return RentID;
            }
            set
            {
                RentID = value;
            }
        }
        public string custid
        {
            get
            {
                return CustID;
            }
            set
            {
                CustID = value;
            }
        }
        public string rntdt
        {
            get
            {
                return RentDate;
            }
            set
            {
                RentDate = value;
            }
        }
        public string rntstt
        {
            get
            {
                return RentStatus;
            }
            set
            {
                RentStatus = value;
            }
        }
        
        public int rntprd
        {
            get
            {
                return RendPrd;
            }
            set
            {
                RendPrd = value;
            }
        }
        public int tqt
        {
            get
            {
                return TtQty;
            }
            set
            {
                TtQty = value;
            }
        }
        public int tprc
        {
            get
            {
                return TtPrc;
            }
            set
            {
                TtPrc = value;
            }
        }
        public int prm
        {
            get
            {
                return Promo;
            }
            set
            {
                Promo = value;
            }
        }
        public int netpr
        {
            get
            {
                return NetPrc;
            }
            set
            {
                NetPrc = value;
            }
        }


    }
}
