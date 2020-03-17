namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public int energyUsage;

        public Dinosaur(string type, int health, int energy, int attackPower, int energyUsage)
        {
            this.type = type;
            this.health = health;            
            this.energy = energy;
            this.attackPower = attackPower;
            this.energyUsage = energyUsage;
        }
    }
}
