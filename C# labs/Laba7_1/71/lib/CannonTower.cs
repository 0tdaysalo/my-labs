using System.Windows.Forms;
using System;

namespace _71.lib
{
    public class CannonTower : GuardTower
    {
        public override int HP => hepe;
        public RRRANGE attack => new RRRANGE(10, 50);
        public int range => 7;
        public override uint cost => 1000;

        public void FinishHimEnemy()
        {
            MessageBox.Show("враг добит");
        }

        public CannonTower()
        {
            hepe = 160;
            max_hepe = 160;
        }
        public CannonTower(WatchTower gh)
        {
            hepe = gh.HP;
            max_hepe = 160;
        }
    }
}
