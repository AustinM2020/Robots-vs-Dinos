using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Robots
    {
        string name;
        int health;
        int powerLevel;
        Weapons;

        public Robots(string name, int health, int powerLevel,)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;

        }
        Weapons plasma = new Weapons(125, "Plasma Canon", 125);
        Weapons sword = new Weapons(150, "Sword", 150);

        Weapons punch = new Weapons(200, "Rocket Punch", 250);
        Weapons missiles = new Weapons(300, "Missile Barrage", 350);

        Weapons kick = new Weapons(75, "Flying Fick", 50);
        Weapons saw = new Weapons(100, "Buzzsaw", 75);


    }
}