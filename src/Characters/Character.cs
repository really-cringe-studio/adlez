using UnityEngine;

namespace src.Characters
{
	public abstract class Character : MonoBehaviour
	{	
		private Health _health;

		private int _speed; // Movement class with factory method. pass class that is moving, get animation for that class

		protected Character(int health, int speed)
		{
			_health = new Health (health);
			_speed  = speed;
		}

		public int Health
		{
			get { return _health.Percentage; }
		}
	}
}
