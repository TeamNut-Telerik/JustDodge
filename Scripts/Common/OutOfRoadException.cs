using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Common
{
    class OutOfRoadException:Exception
    {
        public OutOfRoadException(string message)
        : base(message)
        {
        }
    }
}
