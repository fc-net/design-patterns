using PatternAdapter.Library;

namespace PatternAdapter.Adapter
{
    public class AdapterOne : IAdapter
    {
        private LibraryOne one = null;

        public AdapterOne()
        {
            one = new LibraryOne();
        }

        public void Do()
        {
            one.ThisIsHowOneDoesIt();
        }
    }
}
