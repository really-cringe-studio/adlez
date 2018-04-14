

namespace src.Characters
{
    public class Health
    {
        private readonly int _maximum;

        private int _current;

        public int Percentage
        {
            get 
            {
                return _current / _maximum;
            }
        }

        public Health(int max)
        {
            _maximum = max;
            _current = max;
        }

        public void TakeDamage(int damage)
        {
            _current -= damage;
        }
    }
}
