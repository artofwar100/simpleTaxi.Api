using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Utlits
{
     public enum CarType
    {
        [EnumMember(Value = "Sedan")]
        Sedan,

        [EnumMember(Value = "Station")]
        Station,

        [EnumMember(Value = "Van")]
        Van,
    }
}
