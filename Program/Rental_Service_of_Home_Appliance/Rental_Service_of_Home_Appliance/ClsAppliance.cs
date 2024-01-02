using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Service_of_Home_Appliance
{
    class ClsAppliance:clsMethod
    {
        private string appid, appname, apptype, brand, spec, consumption, cost, maintain;//declaring variables for receiving data from appliance form
        
        public string AppID
        {
            get
            {
                return appid; //returning value
            }
            set
            {
                appid = value; //receving value
            }
        }
        public string AppNm
        {
            get
            {
                return appname;
            }
            set
            {
                appname = value;
            }
        }
        public string AppType
        {
            get
            {
                return apptype;
            }
            set
            {
                apptype = value;
            }
        }
        public string AppBrand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string AppSpec
        {
            get
            {
                return spec;
            }
            set
            {
                spec = value;
            }
        }
        public string AppConsump
        {
            get
            {
                return consumption;
            }
            set
            {
                consumption = value;
            }
        }
        public string AppCost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public string AppMntn
        {
            get
            {
                return maintain;
            }
            set
            {
                maintain = value;
            }
        }
    }
}
