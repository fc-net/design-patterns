using PatternAdapter.Adapter;
using System;

namespace DesignPatterns
{
    public class MainAdapter
    {
        public static void RuntimeArgumentHandle()
        {
            IAdapter adapter = null;

            //Let emulate the decision where the choice of using the underlying system is made
            Console.WriteLine("Enter which library you wanna use to do operation {1,2}");
            int x = Console.Read();

            if (x == '1')
            {
                //Let us choose to use Library one to do something
                adapter = new AdapterOne();
            }
            else if (x == '2')
            {
                //Let us choose to use Library two to do something
                adapter = new AdapterTwo();
            }
            
            //Just do the operation now
            adapter.Do();
        }
    }
}
