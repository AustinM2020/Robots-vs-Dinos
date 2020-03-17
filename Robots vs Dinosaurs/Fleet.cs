using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Fleet
    {
        public Robots alpha;
        public Robots gipsy;
        public Robots typhoon;

        public Weapons plasma;
        public Weapons sword;
        public Weapons punch;
        public Weapons missiles;
        public Weapons kick;
        public Weapons saw;
        
        public Fleet()
        {
            alpha = new Robots("Cherno Alpha", 500, 100);            
            gipsy = new Robots("Gipsy Danger", 300, 150);
            typhoon = new Robots("Crimson Typhoon", 200, 200);

            plasma = new Weapons(125, "Plasma Cannon", 125);
            sword = new Weapons(150, "Sword", 150);
            punch = new Weapons(200, "Rocket Punch", 250);
            missiles = new Weapons(300, "Missile Barrage", 350);
            kick = new Weapons(75, "Flying Fick", 50);
            saw = new Weapons(100, "Buzzsaw", 75);
        }
      
       
    }
}
