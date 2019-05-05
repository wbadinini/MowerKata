namespace MowerKata.Entities
{
    public class Coords
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coords(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Coords(Coords coords)
        {
            this.X = coords.X;
            this.Y = coords.Y;
        }

        public override bool Equals(object obj)
        {
            var coords = (Coords)obj;
            return coords != null && (this.X.Equals(coords.X) && this.Y.Equals(coords.Y));
        }

        public override string ToString()
        {
            return $"{X} , {Y}";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}