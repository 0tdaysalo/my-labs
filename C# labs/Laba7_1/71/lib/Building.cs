using System;

namespace _71
{
    public abstract class Building : Object
    {
        protected int hepe;
        protected int max_hepe;
        public abstract RRRANGE attack { get; }
        public abstract uint? armor { get; }
        public abstract int? range { get; }

        public void change_hepe(int a)
        {
            if (hepe + a <= max_hepe)
            {
                hepe = Math.Max(0, Math.Min(max_hepe, hepe + a));

            }
        }
    }
}
