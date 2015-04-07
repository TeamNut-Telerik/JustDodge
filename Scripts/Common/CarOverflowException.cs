
namespace Assets.Scripts.Common
{
    using System;
    class CarOverflowException:ApplicationException
    {
        private readonly int maxCarOnRoad = 25;

        public CarOverflowException(string message)
        : base(message)
        {
        }

        public int MaxCarOnRoad
        {
            get { return this.maxCarOnRoad; }
        }
    }
}
