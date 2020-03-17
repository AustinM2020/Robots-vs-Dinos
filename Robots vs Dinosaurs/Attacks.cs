using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    class Attacks
    {
        public int attackPower;
        public string attackType;
        public int energyUsage;

        public Attacks(int attackPower, string attackType, int energyUsage)
        {
            this.attackPower = attackPower;
            this.attackType = attackType;
            this.energyUsage = energyUsage;
        }
    }
}
