using src.Interfaces;


namespace src.Characters
{
    public class Player : Character, IDamageable
    {
        protected Player(int health, int speed) : base(health, speed)
        {
            
        }

        public void Damage(int damage)
        {
            
        }
    }
}