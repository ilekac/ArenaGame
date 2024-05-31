namespace DAbstractMethods
{
    class Square : OneSizedShape
    {
        public double Size
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
            return Size * Size;
        }
    }
}
