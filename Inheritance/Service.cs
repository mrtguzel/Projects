using System;

namespace Inheritance
{
    public abstract class Service : IPublisher
    {
        public void Publish()
        {
            Console.WriteLine("Service Publish Running");
        }
         
    }
}
