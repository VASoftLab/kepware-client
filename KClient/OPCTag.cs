using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KClient
{
    public class OPCTag
    {
        public String Name { get; set; }
        public OPCTagType Type {get; set; }
        public OPCTag()
        {
            Name = String.Empty;
            Type = OPCTagType.Double;
        }
    }
}
