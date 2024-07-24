using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSolidPrinciples.LSP.Solution;
public class Program
{
    static void Main(string[] args)
    {
        IFruit apple = new Apple();
        Console.WriteLine(apple.GetColor());

        IFruit orange = new Orange();
        Console.WriteLine(orange.GetColor());
    }

    public interface IFruit
    {
        string GetColor();
    }

    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
