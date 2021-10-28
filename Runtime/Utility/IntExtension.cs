namespace Utility
{
    public static class IntExtension
    {
        public static int Module(this int x, int m)
        {
            var r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}
