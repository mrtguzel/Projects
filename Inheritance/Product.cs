using System;

namespace Inheritance
{
    public abstract class Product : IPublisher
    {
        public int ProductId { get; set; }

        public int ProductType { get; set; }

        public abstract void WriteSample();

        public void Publish()
        {
            Console.WriteLine("Product Publisher Running");
        }
    }
}
