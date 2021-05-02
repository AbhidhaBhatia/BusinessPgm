using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineAB
{
    interface ISendEmail
    {
        void SendEmailTo(string Receipient, string Content);
    }
}
