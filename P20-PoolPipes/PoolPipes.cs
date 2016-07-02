using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class PoolPipes
    {
        static void Main(string[] args)
        {
        int poolCapacity = int.Parse(Console.ReadLine());
        int firstPipeFlow = int.Parse(Console.ReadLine());
        int secondPipeFlow = int.Parse(Console.ReadLine());
        double fillHours = double.Parse(Console.ReadLine());
        double firstPipeContribution = (firstPipeFlow * fillHours);
        double secondPipeContribution = (secondPipeFlow * fillHours);
        double poolCurrentState = firstPipeContribution + secondPipeContribution;

        if (poolCurrentState<=poolCapacity)
        {
            Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.",
                        (int)(100 * poolCurrentState /poolCapacity),
                        (int)(100 * firstPipeContribution /poolCurrentState),
                        (int)(100 * secondPipeContribution /poolCurrentState));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1:##.##} liters.",
                            fillHours, poolCurrentState-poolCapacity);
        }
    }
}

