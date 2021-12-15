using BitirmeProjesi.Weapon.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    public class Enemy : ICharacter
    {
        public Enemy(string name,int health, IWeapon weapon)
        {
            try
            {
                if (health < 30 || health > 70)
                {
                    throw new Exception("Düşmanın Canın 30 dan az 70 den fazla olamaz");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Name = name;
            Health = health;
            Weapon = weapon;
            
        }
        public string Name { get;  set; }

        public int Health { get;  set; }


        private IWeapon Weapon { get; set; }

        public IWeapon  ShowWeapon()
        {
            return Weapon;
        }

        public IWeapon SelectWeapon()
        {
            return Weapon;
        }


        public void Attack(ICharacter character,IWeapon weapon)
        { 
            weapon.Hit(character);
        }
    }
}
