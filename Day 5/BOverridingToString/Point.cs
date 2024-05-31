namespace BOverridingToString
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"Point. X = {X}, Y = {Y}";
        }
    }
}
