/* What is an Event?
An event is simply a delegate wrapper.
It is recommented to use the built-in delegate EventHandler for common events.
Events are created using Publisher classes and Subscriber classes. Publisher raises event, whereas Subscribers registers for events and implement the event handler methods.
  
Event Steps
Define delegate
Define event based on delegate
Publisher raises the event
*/
using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            var product = new Product() { Title = "Nutella Breakfast Bar" };
            var mailSender = new MailSender();
            var faxSender = new FaxSender();

            var orderManager = new OrderManager();
            orderManager.ProductOrderedEventHandler += mailSender.OnProductOrdered;
            orderManager.ProductOrderedEventHandler += faxSender.OnVideoEncoded;
            orderManager.OrderProduct(product);
        }
    }
    class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
    class MailSender
    {
        public void OnProductOrdered(object source, ProductEventArgs e)
        {
            Console.WriteLine("Mail order sent for => " + e.Product.Title);
        }
    }
    class FaxSender
    {
        public void OnVideoEncoded(object source, ProductEventArgs e)
        {
            Console.WriteLine("Fax order sent for => " + e.Product.Title);
        }
    }
    class Product
    {
        public string Title { get; set; }

    }

    class OrderManager
    {
        //step 1: define delegate
        //step 2: define event based on delegate
        //step 3: Make publisher raise the event

        public event EventHandler<ProductEventArgs> ProductOrderedEventHandler;

        public void OrderProduct(Product product)
        {
            Console.WriteLine("ordering product ...");

            var data = new ProductEventArgs() { Product = product };

            OnProductOrdered(data);
        }

        protected virtual void OnProductOrdered(ProductEventArgs e)
        {
            /*if (ProductOrdered != null)
            {
                ProductOrdered(this, new ProductEventArgs() { Product = product });
            }*/ //second version
            //del.Invoke("Hello -!");
// or 
            //del("Hello!");
            ProductOrderedEventHandler?.Invoke(this, e);
        }
    }
}
/*
ordering product …
Mail order sent for => Nutella Breakfast Bar
Fax order sent for => Nutella Breakfast Bar
*/