using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class Worker : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
