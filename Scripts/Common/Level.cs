using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Common
{
    public struct Level
    {
        public int Experience { get; set; }

        public int PlayerLevel
        {
            get
            {
                if (this.Experience < 500)
                {
                    return 1;
                }
                else if (this.Experience < 1000)
                {
                    return 2;
                }
                else if (this.Experience < 2000)
                {
                    return 3;
                }
                else if (this.Experience < 5000)
                {
                    return 4;
                }
                else if (this.Experience < 8500)
                {
                    return 5;
                }
                else if (this.Experience < 15000)
                {
                    return 6;
                }
                else if (this.Experience < 25000)
                {
                    return 7;
                }
                else if (this.Experience < 40000)
                {
                    return 7;
                }
                else if (this.Experience < 55000)
                {
                    return 8;
                }
                else if (this.Experience < 75000)
                {
                    return 9;
                }
                else if (this.Experience < 100000)
                {
                    return 10;
                }
                else if (this.Experience < 1000000)
                {
                    return 11;
                }
                else
                {
                    return 12;
                }
            }
        }
    }
}
