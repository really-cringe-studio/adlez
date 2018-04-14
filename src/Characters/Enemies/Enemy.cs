using src.Interfaces;

namespace src.Characters.Enemies
{
	abstract class Enemy : Character, IDamageable
	{
		protected Enemy(int health, int speed) : base(health, speed) // TODO: add damage class, calculates 
		{
			//extra tings incoming
		}

        protected int Attack()
        {
            // TODO: do a swing or whatever

            return 1;
        }

		public void Damage(int damage)
		{
			
		}
	}
}
