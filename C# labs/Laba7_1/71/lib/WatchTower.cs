using System;

namespace _71
{
    public class WatchTower : Building
    {
        public override int HP => hepe;
        public override uint cost => 550;
        public override uint? armor => null;
        public override RRRANGE? attack => null;
        public override int? range => null;

        public bool isEnemyFound()
        {
            return (new Random()).NextDouble() < 0.5;
        }

        public WatchTower()
        {
            hepe = 100;
            max_hepe = 100;
        }

    }
}
