using System;
using Inheritance;

namespace PublishProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Marker _marker = new Marker();
            Email _email = new Email();
            _marker.ProductId = 1;
            _marker.WriteSample();
            _marker.Publish();
            _email.Publish();
            Console.ReadKey();
        }
    }
}
