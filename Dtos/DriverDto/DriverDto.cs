using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utlits;

namespace Dtos.DriverDto
{
    public class DriverDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Rating { get; set; }
        public Gender Gender { get; set; }
    }
}
