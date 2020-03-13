using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaurs
    {
        string type;
        int health;
        int attack;
        
        public Dinosaurs(string type, int health, int attack)
        {
            this.type = type;
            this.health = health;
            this.attack = attack;
        }
    }
}
