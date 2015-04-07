using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Common
{
    class CarOverflowException:Exception
    {
        public CarOverflowException(string message)
        : base(message)
        {
        }
    }
}
