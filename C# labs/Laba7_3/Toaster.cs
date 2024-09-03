namespace Laba7_3
{
    internal class Toaster : IPowerable
    {
        private int _lvl_charge;

        private bool _max_charge;

        public int lvl_charge { get => _lvl_charge; set => _lvl_charge = value; }
        public bool max_charge { get => _max_charge; set => _max_charge = value; }

        public int charge(int procent)
        {
            _lvl_charge += procent;

            if (_lvl_charge >= 100)
            {
                _max_charge = true;
            }
            return _lvl_charge;
        }

        public void tern_off()
        {
            Console.WriteLine("ваш тостер выключен");
        }

        public void tern_on()
        {
            Console.WriteLine("ваш тостер включен");
            _lvl_charge -= 1;
            _max_charge = false;
        }
    }
}
