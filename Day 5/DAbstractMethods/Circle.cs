namespace DAbstractMethods
{
    class Circle : OneSizedShape
    {
        public double Radius
        {
            get
            {
                return SingleSize;
            }
            set
            {
                SingleSize = value;
            }
        }

        public override double CalcSurface()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
