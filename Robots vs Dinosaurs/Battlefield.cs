using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_vs_Dinosaurs
{
    public class Battlefield
    {
        Herd herd = new Herd();
        Fleet fleet = new Fleet();
        int robotsAttack = 5;
        public Random random;
        

        public Battlefield()
        {
        }
        public void GameStart()
        {
            random = new Random();

            int num = random.Next(0, 11);
            {
                Console.WriteLine("ROBOTS VS DINOSAURS\nPRESS ENTER TO BEGIN");
                Console.ReadLine();
                if(num >= robotsAttack)
                {
                    Console.WriteLine("ROBOTS ATTACK FIRST");
                    MenuRobot();
                    GameContinuedDinos();
                }
                else
                {
                    Console.WriteLine("DINOSAURS ATTACK FIRST");
                    MenuDino();
                    GameContinuedRobots();
                }            
            }
        }
        public void GameContinuedDinos()
        {
            while ((fleet.alpha.health + fleet.gipsy.health + fleet.typhoon.health) > 0  && (herd.spino.health + herd.ankyl.health + herd.quetzal.health) > 0)
            {
                MenuDino();
                MenuRobot();
            }
            if ((fleet.alpha.health > 0) && (fleet.gipsy.health > 0) && (fleet.typhoon.health > 0))
            {
                Console.WriteLine("ROBOTS WIN");
            }
            else if ((herd.spino.health > 0) && (herd.ankyl.health > 0) && (herd.quetzal.health > 0))
            {
                Console.WriteLine("DINOSAURS WIN");
            }
        }
        public void GameContinuedRobots()
        {
            while (((fleet.alpha.health > 0) || (fleet.gipsy.health > 0) || (fleet.typhoon.health > 0)) && ((herd.spino.health > 0) || (herd.ankyl.health > 0) || (herd.quetzal.health > 0)))
            {
                MenuRobot();
                MenuDino();
            }
            if ((fleet.alpha.health > 0) && (fleet.gipsy.health > 0) && (fleet.typhoon.health > 0))
            {
                Console.WriteLine("ROBOTS WIN");
            }
            else if ((herd.spino.health > 0) && (herd.ankyl.health > 0) && (herd.quetzal.health > 0))
            {
                Console.WriteLine("Dinosaurs Win");
            }
        }
        public int MenuRobot()
        {
            Console.WriteLine("SELECT A ROBOT TO USE!");
            Console.WriteLine("1)" + fleet.alpha.name + " Health:" + fleet.alpha.health + " Energy Level:" + fleet.alpha.energy);
            Console.WriteLine("2)" + fleet.gipsy.name + " Health:" + fleet.gipsy.health + " Energy Level:" + fleet.gipsy.energy);
            Console.WriteLine("3)" + fleet.typhoon.name + " Health:" + fleet.typhoon.health + " Energy Level:" + fleet.typhoon.energy);
            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (fleet.alpha.health > 0)
                        {
                            return AlphaWeaponChoice();
                        }
                        Console.WriteLine("THAT ROBOT IS DEAD MAKE ANOTHER SELECTION");
                        break;
                    case 2:
                        if (fleet.gipsy.health > 0)
                        {
                            return GipsyWeaponChoice();
                        }
                        Console.WriteLine("THAT ROBOT IS DEAD MAKE ANOTHER SELECTION");
                        break;
                    case 3:
                        if (fleet.typhoon.health > 0)
                        {
                            return TyphoonWeaponChoice();
                        }
                        Console.WriteLine("THAT ROBOT IS DEAD MAKE ANOTHER SELECTION");
                        break;
                }
            }
            while (fleet.alpha.health > 0 || fleet.gipsy.health > 0 || fleet.typhoon.health > 0);
            return 0;
        }
        public int MenuDino()
        {
            Console.WriteLine("SELECT A DINOSAUR TO USE!");
            Console.WriteLine("1)" + herd.spino.type + " Health:" + herd.spino.health + " Attack Power:" + herd.spino.attackPower);
            Console.WriteLine("2)" + herd.ankyl.type + " Health:" + herd.ankyl.health + " Attack Power:" + herd.ankyl.attackPower);
            Console.WriteLine("3)" + herd.quetzal.type + " Health:" + herd.quetzal.health + " Attack Power:" + herd.quetzal.attackPower);
            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (herd.spino.health > 0)
                        {
                            return SpinoAttack();
                        }
                        Console.WriteLine("THAT DINO IS DEAD MAKE ANOTHER SELECTION");
                        break;
                    case 2:
                        if (herd.ankyl.health > 0)
                        {
                            return AnkylAttack();
                        }
                        Console.WriteLine("THAT DINO IS DEAD MAKE ANOTHER SELECTION");
                        break;
                    case 3:
                        if (herd.quetzal.health > 0)
                        {
                            return QuetzalAttack();
                        }
                        Console.WriteLine("THAT DINO IS DEAD MAKE ANOTHER SELECTION");
                        break;
                }
            }
            while (herd.spino.health > 0 || herd.ankyl.health > 0 || herd.quetzal.health > 0);
            return 0;
        }
       
        public int SpinoAttack()
        {
            Console.WriteLine("SELECT  ROBOT TO ATTACK!");
            Console.WriteLine("1)" + fleet.alpha.name + " Health:" + fleet.alpha.health);
            Console.WriteLine("2)" + fleet.gipsy.name + " Health:" + fleet.gipsy.health);
            Console.WriteLine("3)" + fleet.typhoon.name + " Health:" + fleet.typhoon.health);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    fleet.alpha.health = fleet.alpha.health - herd.spino.attackPower;
                    Console.WriteLine("CHERNO ALPHAS HEALTH IS NOW:" + fleet.alpha.health);
                    if (fleet.alpha.health <= 0)
                    {
                        Console.WriteLine("CHERNO ALPHA HAS DIED!");
                    }
                    return fleet.alpha.health;
                    break;
                case 2:
                    fleet.gipsy.health = fleet.gipsy.health - herd.spino.attackPower;
                    Console.WriteLine("GIPSY DANGERS HEALTH IS NOW:" + fleet.gipsy.health);
                    if (fleet.gipsy.health <= 0)
                    {
                        Console.WriteLine("GIPSY DANGER HAS DIED!");
                    }
                    return fleet.gipsy.health;
                    break;
                case 3:
                    fleet.typhoon.health = fleet.typhoon.health - herd.spino.attackPower;
                    Console.WriteLine("CRIMSON TYPHOONS HEALTH IS NOW:" + fleet.typhoon.health);
                    if (fleet.typhoon.health <= 0)
                    {
                        Console.WriteLine("CRIMSON TYPHOON HAS DIED!");
                    }
                    return fleet.typhoon.health;
                    break;
            }
            return 0;
        }
        public int AnkylAttack()
        {
            Console.WriteLine("SELECT  ROBOT TO ATTACK!");
            Console.WriteLine("1)" + fleet.alpha.name + " Health:" + fleet.alpha.health);
            Console.WriteLine("2)" + fleet.gipsy.name + " Health:" + fleet.gipsy.health);
            Console.WriteLine("3)" + fleet.typhoon.name + " Health:" + fleet.typhoon.health);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    fleet.alpha.health = fleet.alpha.health - herd.ankyl.attackPower;
                    Console.WriteLine("CHERNO ALPHAS HEALTH IS NOW:" + fleet.alpha.health);
                    if (fleet.alpha.health <= 0)
                    {
                        Console.WriteLine("CHERNO ALPHA HAS DIED!");
                    }
                    return fleet.alpha.health;
                    break;
                case 2:
                    fleet.gipsy.health = fleet.gipsy.health - herd.ankyl.attackPower;
                    Console.WriteLine("GIPSY DANGERS HEALTH IS NOW:" + fleet.gipsy.health);
                    if (fleet.gipsy.health <= 0)
                    {
                        Console.WriteLine("GIPSY DANGER HAS DIED!");
                    }
                    return fleet.gipsy.health;
                    break;
                case 3:
                    fleet.typhoon.health = fleet.typhoon.health - herd.ankyl.attackPower;
                    Console.WriteLine("CRIMSON TYPHOONS HEALTH IS NOW:" + fleet.typhoon.health);
                    if (fleet.typhoon.health <= 0)
                    {
                        Console.WriteLine("CRIMSON TYPHOON HAS DIED!");
                    }
                    return fleet.typhoon.health;
                    break;
            }

            return 0;
        }
        public int QuetzalAttack()
        {
            Console.WriteLine("SELECT  ROBOT TO ATTACK!");
            Console.WriteLine("1)" + fleet.alpha.name + " Health:" + fleet.alpha.health);
            Console.WriteLine("2)" + fleet.gipsy.name + " Health:" + fleet.gipsy.health);
            Console.WriteLine("3)" + fleet.typhoon.name + " Health:" + fleet.typhoon.health);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    fleet.alpha.health = fleet.alpha.health - herd.quetzal.attackPower;
                    Console.WriteLine("CHERNO ALPHAS HEALTH IS NOW:" + fleet.alpha.health);
                    if (fleet.alpha.health <= 0)
                    {
                        Console.WriteLine("CHERNO ALPHA HAS DIED!");
                    }
                    return fleet.alpha.health;
                    break;
                case 2:
                    fleet.gipsy.health = fleet.gipsy.health - herd.quetzal.attackPower;
                    Console.WriteLine("GIPSY DANGERS HEALTH IS NOW:" + fleet.gipsy.health);
                    if (fleet.gipsy.health <= 0)
                    {
                        Console.WriteLine("GIPSY DANGER HAS DIED!");
                    }
                    return fleet.gipsy.health;
                    break;
                case 3:
                    fleet.typhoon.health = fleet.typhoon.health - herd.quetzal.attackPower;
                    Console.WriteLine("CRIMSON TYPHOONS HEALTH IS NOW:" + fleet.typhoon.health);
                    if (fleet.typhoon.health <= 0)
                    {
                        Console.WriteLine("CRIMSON TYPHOON HAS DIED!");
                    }
                    return fleet.typhoon.health;
                    break;
            }

            return 0;
        }

        public int AlphaWeaponChoice()
        {
            Console.WriteLine("SELECT A WEAPON");
            Console.WriteLine("1)Weapon 1:" + fleet.missiles.weaponType + " | Attack Power:" + fleet.missiles.attackPower + " | Energy usage:" + fleet.missiles.energyUsage + "\n2)Weapon 2:" + fleet.punch.weaponType + " | Attack Power:" + fleet.punch.attackPower + " | Energy usage:" + fleet.punch.energyUsage);

            int choice; 
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        fleet.alpha.energy = fleet.alpha.energy - fleet.missiles.energyUsage;
                        if (fleet.alpha.energy >= fleet.missiles.energyUsage)
                        {
                            return MissleAttack();
                        }
                        Console.WriteLine("YOU DONT HAVE ENOUGH ENERGY TO USE THIS WEAPON! CHOOSE ANOTHER!");
                        break;
                    case 2:
                        fleet.alpha.energy = fleet.alpha.energy - fleet.punch.energyUsage;
                        if (fleet.alpha.energy >= fleet.punch.energyUsage)
                        {
                            return PunchAttack();
                        }
                        Console.WriteLine("YOU DONT HAVE ENOUGH ENERGY TO USE THIS WEAPON! CHOOSE ANOTHER!");
                        break;
                }
            }
            while (fleet.alpha.energy >= 50);
            return 0;
        }
       
        public int MissleAttack()
        {
            Console.WriteLine("SELECT A DINOSAUR TO ATTACK");
            Console.WriteLine("1)" + herd.spino.type + " | Health:" + herd.spino.health + "\n2)" + herd.ankyl.type + " | Health:" + herd.ankyl.health + "\n3)" + herd.quetzal.type + " | Health:" + herd.quetzal.health);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    herd.spino.health = herd.spino.health - fleet.missiles.attackPower;
                    Console.WriteLine("SPINOSAURUS HEALTH IS NOW:" + herd.spino.health);
                    if (herd.spino.health <= 0)
                    {
                        Console.WriteLine("SPINOSAURUS HAS DIED!");
                    }
                    return herd.spino.health;
                    break;
                case 2:
                    herd.ankyl.health = herd.ankyl.health - fleet.missiles.attackPower;
                    Console.WriteLine("ANKYLOSAURUS HEALTH IS NOW:" + herd.ankyl.health);
                    if (herd.ankyl.health <= 0)
                    {
                        Console.WriteLine("ANKYLOSAURUS HAS DIED!");
                    }
                    return herd.ankyl.health;
                    break;
                case 3:
                    herd.quetzal.health = herd.quetzal.health - fleet.missiles.attackPower;
                    Console.WriteLine("QUETZALCOATLUS HEALTH IS NOW:" + herd.quetzal.health);
                    if (herd.quetzal.health <= 0)
                    {
                        Console.WriteLine("QUETZALCOATLUS HAS DIED!");
                    }
                    return herd.quetzal.health;
                    break;
            }
            return 0;
        }
        public int PunchAttack()
        {
            Console.WriteLine("SELECT A DINOSAUR TO ATTACK");
            Console.WriteLine("1)" + herd.spino.type + " | Health:" + herd.spino.health + "\n2)" + herd.ankyl.type + " | Health:" + herd.ankyl.health + "\n3)" + herd.quetzal.type + " | Health:" + herd.quetzal.health);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    herd.spino.health = herd.spino.health - fleet.punch.attackPower;
                    Console.WriteLine("SPINOSAURUS HEALTH IS NOW:" + herd.spino.health);
                    if (herd.spino.health <= 0)
                    {
                        Console.WriteLine("SPINOSAURUS HAS DIED!");
                    }
                    return herd.spino.health;
                    break;
                case 2:
                    herd.ankyl.health = herd.ankyl.health - fleet.punch.attackPower;
                    Console.WriteLine("ANKYLOSAURUS HEALTH IS NOW:" + herd.ankyl.health);
                    if (herd.ankyl.health <= 0)
                    {
                        Console.WriteLine("ANKYLOSAURUS HAS DIED!");
                    }
                    return herd.ankyl.health;
                case 3:
                    herd.quetzal.health = herd.quetzal.health - fleet.missiles.attackPower;
                    Console.WriteLine("QUETZALCOATLUS HEALTH IS NOW:" + herd.quetzal.health);
                    if (herd.quetzal.health <= 0)
                    {
                        Console.WriteLine("QUETZALCOATLUS HAS DIED!");
                    }
                    return herd.quetzal.health;
            }
            return 0;
        }
        public int GipsyWeaponChoice()
        {
            Console.WriteLine("SELECT A WEAPON");
            Console.WriteLine("1)Weapon 1:" + fleet.plasma.weaponType + " | Attack Power:" + fleet.plasma.attackPower + " | Energy usage:" + fleet.plasma.energyUsage + "\n2)Weapon 2:" + fleet.sword.weaponType + " | Attack Power:" + fleet.sword.attackPower + " | Energy usage:" + fleet.sword.energyUsage);

            int choice; 
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        fleet.gipsy.energy = fleet.gipsy.energy - fleet.plasma.energyUsage;
                        if (fleet.gipsy.energy >= fleet.plasma.energyUsage)
                        {
                            return PlasmaAttack();
                        }
                        Console.WriteLine("YOU DONT HAVE ENOUGH ENERGY TO USE THIS WEAPON! CHOOSE ANOTHER!");
                        break;
                    case 2:
                        fleet.gipsy.energy = fleet.gipsy.energy - fleet.sword.energyUsage;
                        if (fleet.gipsy.energy >= fleet.sword.energyUsage)
                        {
                            return SwordAttack();
                        }
                        Console.WriteLine("YOU DONT HAVE ENOUGH ENERGY TO USE THIS WEAPON! CHOOSE ANOTHER!");
                        break;
                }
            }
            while (fleet.gipsy.energy >= 50);
            return 0;
        }
        public int PlasmaAttack()
        {
            Console.WriteLine("SELECT A DINOSAUR TO ATTACK");
            Console.WriteLine("1)" + herd.spino.type + " | Health:" + herd.spino.health + "\n2)" + herd.ankyl.type + " | Health:" + herd.ankyl.health + "\n3)" + herd.quetzal.type + " | Health:" + herd.quetzal.health);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    herd.spino.health = herd.spino.health - fleet.plasma.attackPower;
                    Console.WriteLine("SPINOSAURUS HEALTH IS NOW:" + herd.spino.health);
                    if (herd.spino.health <= 0)
                    {
                        Console.WriteLine("SPINOSAURUS HAS DIED!");
                    }
                    return herd.spino.health;
                    break;
                case 2:
                    herd.ankyl.health = herd.ankyl.health - fleet.plasma.attackPower;
                    Console.WriteLine("ANKYLOSAURUS HEALTH IS NOW:" + herd.ankyl.health);
                    if (herd.ankyl.health <= 0)
                    {
                        Console.WriteLine("ANKYLOSAURUS HAS DIED!");
                    }
                    return herd.ankyl.health;
                case 3:
                    herd.quetzal.health = herd.quetzal.health - fleet.plasma.attackPower;
                    Console.WriteLine("QUETZALCOATLUS HEALTH IS NOW:" + herd.quetzal.health);
                    if (herd.quetzal.health <= 0)
                    {
                        Console.WriteLine("QUETZALCOATLUS HAS DIED!");
                    }
                    return herd.quetzal.health;
            }
            return 0;
        }
        public int SwordAttack()
        {
            Console.WriteLine("SELECT A DINOSAUR TO ATTACK");
            Console.WriteLine("1)" + herd.spino.type + " | Health:" + herd.spino.health + "\n2)" + herd.ankyl.type + " | Health:" + herd.ankyl.health + "\n3)" + herd.quetzal.type + " | Health:" + herd.quetzal.health);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    herd.spino.health = herd.spino.health - fleet.sword.attackPower;
                    Console.WriteLine("SPINOSAURUS HEALTH IS NOW:" + herd.spino.health);
                    if (herd.spino.health <= 0)
                    {
                        Console.WriteLine("SPINOSAURUS HAS DIED!");
                    }
                    return herd.spino.health;
                    break;
                case 2:
                    herd.ankyl.health = herd.ankyl.health - fleet.sword.attackPower;
                    Console.WriteLine("ANKYLOSAURUS HEALTH IS NOW:" + herd.ankyl.health);
                    if (herd.ankyl.health <= 0)
                    {
                        Console.WriteLine("ANKYLOSAURUS HAS DIED!");
                    }
                    return herd.ankyl.health;
                case 3:
                    herd.quetzal.health = herd.quetzal.health - fleet.sword.attackPower;
                    Console.WriteLine("QUETZALCOATLUS HEALTH IS NOW:" + herd.quetzal.health);
                    if (herd.quetzal.health <= 0)
                    {
                        Console.WriteLine("QUETZALCOATLUS HAS DIED!");
                    }
                    return herd.quetzal.health;
            }
            return 0;
        }
        public int TyphoonWeaponChoice()
        {
            Console.WriteLine("SELECT A WEAPON");
            Console.WriteLine("1)Weapon 1:" + fleet.saw.weaponType + " | Attack Power:" + fleet.saw.attackPower + " | Energy usage:" + fleet.saw.energyUsage + "\n2)Weapon 2:" + fleet.kick.weaponType + " | Attack Power:" + fleet.kick.attackPower + " | Energy usage:" + fleet.kick.energyUsage);

            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        fleet.typhoon.energy = fleet.typhoon.energy - fleet.saw.energyUsage;
                        if (fleet.typhoon.energy >= fleet.saw.energyUsage)
                        {
                            return SawAttack();
                        }
                        Console.WriteLine("YOU DONT HAVE ENOUGH ENERGY TO USE THIS WEAPON! CHOOSE ANOTHER!");
                        break;
                    case 2:
                        fleet.typhoon.energy = fleet.typhoon.energy - fleet.kick.energyUsage;
                        if (fleet.typhoon.energy >= fleet.kick.energyUsage)
                        {
                            return KickAttack();
                        }
                        Console.WriteLine("YOU DONT HAVE ENOUGH ENERGY TO USE THIS WEAPON! CHOOSE ANOTHER!");
                        break;
                }
            }
            while (fleet.typhoon.energy >= 50);
            return 0;
        }
        public int SawAttack()
        {
            Console.WriteLine("SELECT A DINOSAUR TO ATTACK");
            Console.WriteLine("1)" + herd.spino.type + " | Health:" + herd.spino.health + "\n2)" + herd.ankyl.type + " | Health:" + herd.ankyl.health + "\n3)" + herd.quetzal.type + " | Health:" + herd.quetzal.health);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    herd.spino.health = herd.spino.health - fleet.saw.attackPower;
                    Console.WriteLine("SPINOSAURUS HEALTH IS NOW:" + herd.spino.health);
                    if (herd.spino.health <= 0)
                    {
                        Console.WriteLine("SPINOSAURUS HAS DIED!");
                    }
                    return herd.spino.health;
                    break;
                case 2:
                    herd.ankyl.health = herd.ankyl.health - fleet.saw.attackPower;
                    Console.WriteLine("ANKYLOSAURUS HEALTH IS NOW:" + herd.ankyl.health);
                    if (herd.ankyl.health <= 0)
                    {
                        Console.WriteLine("ANKYLOSAURUS HAS DIED!");
                    }
                    return herd.ankyl.health;
                case 3:
                    herd.quetzal.health = herd.quetzal.health - fleet.saw.attackPower;
                    Console.WriteLine("QUETZALCOATLUS HEALTH IS NOW:" + herd.quetzal.health);
                    if (herd.quetzal.health <= 0)
                    {
                        Console.WriteLine("QUETZALCOATLUS HAS DIED!");
                    }
                    return herd.quetzal.health;
            }
            return 0;
        }
        public int KickAttack()
        {
            Console.WriteLine("SELECT A DINOSAUR TO ATTACK");
            Console.WriteLine("1)" + herd.spino.type + " | Health:" + herd.spino.health + "\n2)" + herd.ankyl.type + " | Health:" + herd.ankyl.health + "\n3)" + herd.quetzal.type + " | Health:" + herd.quetzal.health);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    herd.spino.health = herd.spino.health - fleet.kick.attackPower;
                    Console.WriteLine("SPINOSAURUS HEALTH IS NOW:" + herd.spino.health);
                    if (herd.spino.health <= 0)
                    {
                        Console.WriteLine("SPINOSAURUS HAS DIED!");
                    }
                    return herd.spino.health;
                    break;
                case 2:
                    herd.ankyl.health = herd.ankyl.health - fleet.kick.attackPower;
                    Console.WriteLine("ANKYLOSAURUS HEALTH IS NOW:" + herd.ankyl.health);
                    if (herd.ankyl.health <= 0)
                    {
                        Console.WriteLine("ANKYLOSAURUS HAS DIED!");
                    }
                    return herd.ankyl.health;
                case 3:
                    herd.quetzal.health = herd.quetzal.health - fleet.kick.attackPower;
                    Console.WriteLine("QUETZALCOATLUS HEALTH IS NOW:" + herd.quetzal.health);
                    if (herd.quetzal.health <= 0)
                    {
                        Console.WriteLine("QUETZALCOATLUS HAS DIED!");
                    }
                    return herd.quetzal.health;
            }
            return 0;
        }
    }
}
