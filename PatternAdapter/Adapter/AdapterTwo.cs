using PatternAdapter.Library;
using System;

namespace PatternAdapter.Adapter
{
    public class AdapterTwo : IAdapter
    {
        private LibraryTwo two = null;

        public AdapterTwo()
        {
            two = new LibraryTwo();
        }

        public void Do()
        {
            Console.WriteLine(two.ThisIsHowTwoDoesIt() + "\n"); ;
        }
    }
}
