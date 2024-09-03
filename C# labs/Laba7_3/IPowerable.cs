namespace Laba7_3
{
    internal interface IPowerable
    {

        public void tern_on();

        public void tern_off();

        public int charge(int procent);

        public int lvl_charge { get; set; }
        public bool max_charge { get; set; }

    }
}
