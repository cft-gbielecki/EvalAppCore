using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalAppCore.CFT_specific
{
    public class ServiceClass
    {
        public Services ServiceType { get; set; }
        public bool IsBillable{ get; set; }
        public bool IsCountsForRequired{ get; set; }
        public bool IsCountForOT{ get; set; }
        public string ServiceSuffix { get; private set; }

        public ServiceClass(Services serviceType)
        {
            ServiceType = serviceType;
            SetSuffix();
        }
        protected void SetSuffix()
        {
            StringBuilder suffixString = new StringBuilder("(___)");
            //ServiceSuffix = "(___)";
            if (ServiceType == Services.Consult)
                suffixString[1] = 'b';
            if (ServiceType == Services.Consult || ServiceType == Services.EvalSupp || ServiceType == Services.LeaveOth || ServiceType == Services.MakeUp || ServiceType == Services.Mathernity
                || ServiceType == Services.Operate || ServiceType == Services.Sell || ServiceType == Services.Sick_Leave || ServiceType == Services.SickChild || ServiceType == Services.Unpaid
                || ServiceType == Services.Vacation)
                suffixString[2] = 'r';
            if (ServiceType == Services.Consult || ServiceType == Services.Operate || ServiceType == Services.Vacation)
                suffixString[3] = 'o';
            ServiceSuffix = suffixString.ToString();
        }
    }
}
