using _71.lib;
using System.ComponentModel;

namespace _71
{
    public class Game
    {
        public int Money;
        public BindingList<Building> objects = [];

        public Game()
        {
            Money = 1600;
        }

        public void buy_WatchTower()
        {
            if (Money - 550 <= 0) return;
            Money -= 550;
            objects.Add(new WatchTower());

        }

        public void add_hp(int id)
        {
            objects[id].change_hepe(10);
        }

        public void reduce_hp(int id)
        {
            objects[id].change_hepe(-10);
        }

        public void upgrate(int id)
        {
            Building b = objects[id];
            if (b.cost == 550)
            {
                if (Money - 550 <= 0) return;
                Money -= 550;
                var h = new GuardTower(b as WatchTower);
                objects.RemoveAt(id);
                objects.Insert(id, h);
            }
            else if (b.cost == 500)
            {
                if (Money - 1000 <= 0) return;
                Money -= 1000;
                var h = new CannonTower(b as GuardTower);
                objects.RemoveAt(id);
                objects.Insert(id, h);
            }
        }
    }
}
