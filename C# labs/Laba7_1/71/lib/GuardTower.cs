using System;
using System.Windows.Forms;

namespace _71.lib
{
    public class GuardTower : WatchTower
    {
        public override int HP => hepe;
        public override RRRANGE attack => new RRRANGE(6, 16);
        public override int? range => 6;
        public override uint? armor => 20;
        public override uint cost => 500;

        public void KillEnemy()
        {
            if (base.isEnemyFound())
            {
                if ((new Random().Next(0, 1) == 0))
                {
                    MessageBox.Show("враг убит");                  
                }
                else
                {
                    MessageBox.Show("враг остался жив");
                }
            }
        }

        public GuardTower()
        {
            hepe = 100;
            max_hepe = 100;
        }

        public GuardTower(WatchTower wt)
        {
            hepe = wt.HP;
            max_hepe = 130;
        }
    }
}
