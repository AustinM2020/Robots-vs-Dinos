using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Fleet
    {
        public Weapons weapon;
        
        Robots alpha = new Robots("Cherno Alpha", 500, 500);
        Robots gipsy = new Robots("Gipsy Danger", 300, 500);
        Robots typhoon = new Robots("Crimson Typhoon", 200, 500);
    }
}
