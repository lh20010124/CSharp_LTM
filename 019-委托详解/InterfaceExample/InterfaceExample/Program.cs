namespace InterfaceExample
{
    /// <summary>
    /// 模板方法
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toycarFactory = new ToyCarFactory();
            WrapFactory wrapFactory = new WrapFactory();


            Box box1 = wrapFactory.WrapProduct(pizzaFactory);
            Box box2 = wrapFactory.WrapProduct(toycarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

    public interface IProductFactory
    {
        Product Make();
    }

    public class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }

    public class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            return product;
        }
    }


    public class Product
    {
        public string Name { get; set; }
    }

    public class Box
    {
        public Product Product { get; set; }
    }

    public class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }

}