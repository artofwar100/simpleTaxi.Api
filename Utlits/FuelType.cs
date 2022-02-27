using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Utlits
{
    public enum FuelType
    {
        [EnumMember(Value = "Gasoline")]
        Gasoline,

        [EnumMember(Value = "Diesel")]
        Diesel,

        [EnumMember(Value = "Hybrid")]
        Hybrid,

        [EnumMember(Value = "Electric")]
        Electric
    }
}
