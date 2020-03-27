using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private int x;
        private int y;
        private int z;
        public Vector() {}
        public Vector(int x)
        {
            this.x = x;
        }
        public Vector(int x, int y, int z):this(x)
        {
            this.y = y;
            this.z = z;
        }
        public void Create()
        {
            Console.Write("Input x -> ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Input y -> ");
            y = Int32.Parse(Console.ReadLine());
            Console.Write("Input z -> ");
            z = Int32.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("X: {0}\tY: {1}\tZ: {2}", x, y, z);
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public int Z
        {
            get { return z; }
        }
        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            return length;
        }
        public double GetAngle()
        {
            double angle = Math.Asin(y / (Math.Sqrt(x * x + y * y)));
            return angle;
        }
        public double IncreaseByScalar(double scalar)
        {
            double result;
            if (scalar > 0){ 
                result = GetLength() * scalar;
                return result;
            } 
            else if (scalar < 0) {
                x = -x;
                y = -y;
                z = -z;
                result = GetLength() * -scalar;
                Show();
                return result;
            }
            return 0;
        }
        public double DecreaseByScalar(double scalar)
        {
            double result;
            if(scalar > 1)
            {
                x = x / 2;
                y = y / 2;
                z = z / 2;
                result = GetLength() * scalar;
                Show();
                return result;
            }
            return 0;
        }
        public static Vector operator + (Vector v1, Vector v2)
        {
            Vector v3 = new Vector();
            v3.x = v1.x + v2.x;
            v3.y = v1.y + v2.y;
            v3.z = v1.z + v2.z;
            return v3;
        }
        public static Vector operator - (Vector v1, Vector v2)
        {
            Vector v3 = new Vector();
            v3.x = v1.x - v2.x;
            v3.y = v1.y - v2.y;
            v3.z = v1.z - v2.z;
            return v3;
        }
        public static Vector operator *(Vector v1, Vector v2)
        {
            Vector v3 = new Vector();
            v3.x = v1.x * v2.x;
            v3.y = v1.y * v2.y;
            v3.z = v1.z * v2.z;
            return v3;
        }
        public static double ScalarMult(Vector v1, Vector v2)
        {
            double result = (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
            return result;
        }
        public static double AngleBetweenVectors(Vector v1, Vector v2)
        {
            double scalarMult = ScalarMult(v1, v2);
            double lengthV1 = v1.GetLength();
            double lengthV2 = v2.GetLength();
            double COSangle = scalarMult / lengthV1 * lengthV2;
            Console.WriteLine("Cos of angle = " + COSangle);
            return COSangle;
        }
        public static bool operator == (Vector v1, Vector v2)
        {
            if (ReferenceEquals(v1, v2))
                return true;
            return false;
        }
        public static bool operator != (Vector v1, Vector v2)
        {
            if (ReferenceEquals(v1, v2))
                return false;
            return true;
        }
        
    }
}
