using System;

namespace Inheritance
{
    public class Marker : Product 
    {

        public int MarkerId { get; set; }
        public override void WriteSample()
        {
             Console.WriteLine("Implements Class");
        }
    }
}
