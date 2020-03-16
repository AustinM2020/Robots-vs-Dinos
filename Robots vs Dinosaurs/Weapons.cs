using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Weapons
    {
        public int attackPower;
        public string weaponType;
        public int energyUsage;

        public Weapons(int attackPower, string weaponType, int energyUsage)
        {
            this.attackPower = attackPower;
            this.weaponType = weaponType;
            this.energyUsage = energyUsage;
        }
    }
}
