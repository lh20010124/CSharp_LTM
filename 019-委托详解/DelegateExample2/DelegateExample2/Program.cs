namespace DelegateExample2
{
    /// <summary>
    /// 模板方法
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.log);

            Box box1 = wrapFactory.WrapProduct(func1, log);
            Box box2 = wrapFactory.WrapProduct(func2, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Logger
    {
        public void log(Product product)
        {
            Console.WriteLine($"Product {product.Name} created at {DateTime.Now}.Price is {product.Price}");
        }
    }

    public class Box
    {
        public Product Product { get; set; }
    }

    public class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct, Action<Product> logCallback)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price >= 50)
            {
                logCallback(product);
            }
            box.Product = product;
            return box;
        }
    }

    public class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }
        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            product.Price = 100;
            return product;
        }
    }
}
