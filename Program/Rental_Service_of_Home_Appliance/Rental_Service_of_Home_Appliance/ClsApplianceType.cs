using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Service_of_Home_Appliance
{
    class ClsApplianceType:clsMethod
    {
        public string AppTypeID, AppTypeName;

        public int  AppAQ, AppTQ, AppIQ;//declaring var for data receiving and returning of appliance type form

        public string ATypeName
        {
            get
            {
                return AppTypeName; //returning data
            }
            set
            {
                AppTypeName = value;//receiving data
            }
        }

        public string ATypeID
        {
            get
            {
                return AppTypeID;
            }
            set
            {
                AppTypeID = value;
            }
        }

        public int AAQ
        {
            get
            {
                return AppAQ;
            }
            set
            {
                AppAQ = value;
            }
        }

        public int  ATQ
        {
            get
            {
                return AppTQ;
            }
            set
            {
                AppTQ = value;
            }
        }

        public int  AIQ
        {
            get
            {
                return AppIQ;
            }
            set
            {
                AppIQ = value;
            }
        }

    }
}
