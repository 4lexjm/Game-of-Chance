using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chance
{
    public abstract class User
    {
        enum Gender
        {
            Man,
            Woman
        }

        public string Name { get; set; }

    }
}
