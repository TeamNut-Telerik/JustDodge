namespace Assets.Scripts.Common
{
    using System;
    class OutOfRoadException:ApplicationException
    {
        private readonly int minCarPosition = 0;
        public readonly int maxCarPosition = 2;
        
        public OutOfRoadException(string message)
        : base(message)
        {
        }

        public int MinCarPosition
        {
            get { return this.minCarPosition; }
        }

        public int MaxCarPosition
        {
            get { return this.maxCarPosition; }
        }
    }
}
