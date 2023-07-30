using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Decorator.Decorator;

namespace DecoratorDemo;
class Program
{
    static void Main(string[] args)
    {
        ICar car = new Suzuki();
        CarDecorator decorator = new OfferPrice(car);
        Console.WriteLine(
            string.Format(
                "Make :{0}  Price:{1} " + "DiscountPrice : {2}"
                , decorator.Make, decorator.GetPrice().ToString()
                , decorator.GetDiscountedPrice().ToString()
            )
        );
        Console.ReadLine();
    }
}
