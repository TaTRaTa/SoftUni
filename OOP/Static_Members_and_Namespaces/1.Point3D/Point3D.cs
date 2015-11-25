
namespace _1.Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPointCoordinates;

        static Point3D()
        {
            StartingPointCoordinates = new Point3D(0,0,0);
        }

        public Point3D(double x, double y, double z)
        {
            this.CoordX = x;
            this.CoordY = y;
            this.CoordZ = z;
        }

        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double CoordZ { get; set; }


        public static Point3D StartPoint
        {
            get { return Point3D.StartingPointCoordinates; }
        }

        public override string ToString()
        {
            return $"Point: {{x= {this.CoordX}, y= {this.CoordY}, z= {this.CoordZ}}}";
        }
    }
}
