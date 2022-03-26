using System.Numerics;

namespace RaytracerChallenge
{
    public class Vectors : Tuples
    {
        public Vectors() : base(0.00f, 0.00f, 0.00f, 0.00f)
        {
            
        }

        public Vectors(float x = 0.00f, float y = 0.00f, float z = 0.00f, float w = 0.00f) : base(x, y, z, 0.00f)
        {
            
        }

    }
}