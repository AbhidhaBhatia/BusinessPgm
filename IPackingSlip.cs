using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineAB
{
    public interface IPackingSlip
    {
        void GeneratePackingSlip(string Department, string Addon);
    }
}
