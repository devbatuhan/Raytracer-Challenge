namespace RaytracerChallenge
{
    public class Point : Tuples
    {
        public Point() : base(0.00f, 0.00f, 0.00f, 1.00f)
        {
            
        }
        
        public Point(float x = 0.00f, float y = 0.00f, float z = 0.00f, float w = 1.00f) : base(x, y, z, w)
        {
            
        }
    }
}