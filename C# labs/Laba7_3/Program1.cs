namespace Laba7_3
{
    internal class Solution1s
    {
        public static void main()
        {
            iPhone telef = new iPhone();
            Toaster tost = new Toaster();

            telef.charge(88);
            telef.tern_on();
            Console.WriteLine(telef.lvl_charge);
            telef.tern_off();


            tost.charge(14);
            tost.tern_on();
            Console.WriteLine(tost.lvl_charge);
            tost.tern_off();



        }
    }
}
