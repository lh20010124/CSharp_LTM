using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EventExample8
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    // 自定义的委托类型 用于声明事件的委托类型
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Customer
    {
        //// 委托类型的字段
        //private OrderEventHandler orderEventHandler;
        //// 事件的声明
        //public event OrderEventHandler Order
        //{
        //    add
        //    {
        //        this.orderEventHandler += value;
        //    }
        //    remove
        //    {
        //        this.orderEventHandler -= value;
        //    }
        //}

        //// 事件的简略声明
        //public event OrderEventHandler Order;

        // .net平台准备好的EventHandler委托 用于声明事件的委托类型
        public event EventHandler Order;

        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine($"I will pay {this.Bill}");
        }

        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant");
        }
        public void SitDown()
        {
            Console.WriteLine("Sit down;");
        }
        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think ... ");
                Thread.Sleep(1000);
            }

            this.OnOrder("Kongpao Chicken", "large");
        }

        protected void OnOrder(string dishName, string size)
        {
            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao ChicKen";
                e.Size = "large";
                this.Order.Invoke(this, e);
            }
        }

        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }

    public class Waiter
    {
        public void Action(Object sender, EventArgs eventArgs)
        {
            Customer customer = sender as Customer;
            OrderEventArgs e = eventArgs as OrderEventArgs;
            Console.WriteLine($"I will serve you the dish - {e.DishName}");
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}
