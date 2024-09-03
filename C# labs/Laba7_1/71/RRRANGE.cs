namespace _71
{
    public class RRRANGE
    {
        public int start;
        public int stop;
        public RRRANGE(int a, int b)
        {
            start = a;
            stop = b;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", start, stop);
        }
    }
}