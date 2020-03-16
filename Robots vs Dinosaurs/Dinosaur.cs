using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int health;
        public int attackPower;
        public int energy;

        public Dinosaur(string type, int health, int attackPower, int energy)
        {
            this.type = type;
            this.health = health;
            this.attackPower = attackPower;
            this.energy = energy;
        }
    }
}
