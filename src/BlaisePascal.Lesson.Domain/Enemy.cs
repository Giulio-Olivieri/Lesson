using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Lesson.Domain
{
    public class Enemy
    {
        //attributo
        private int _health;

        //proprietà
        public int Health { get; private set; }
        //{ get { return _health; }

        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _health = 0;
        //        } else if(value > 100)
        //        {
        //            _health = 100;
        //        } else
        //        {
        //            _health = value;
        //        }
        //    }
        //}

        //costruttore
        public Enemy() { }

        public void setHealth(int newHealth)
        {
            if (newHealth < 0)
            {
                Health = 0;
            }
            else if (newHealth > 100)
            {
                Health = 100;
            }
            else
            {
                Health = newHealth;
            }
        }

        public bool isAlive()
        {
            return Health > 0;
        }
        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                damage = 0;
            }
            setHealth(Health - damage);


        }
    }
}
