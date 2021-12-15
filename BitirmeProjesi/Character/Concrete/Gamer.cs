using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    public class Gamer : ICharacter
    {
        public Gamer(string name, List<IWeapon> weapons)
        {
            Name = name;
            Health = 100;
            foreach (IWeapon weapon in weapons)
            {
                Weapons.Add(weapon);
            }
        }
        public string Name { get;  set; }

        public int Health { get;  set; }


        private List<IWeapon> Weapons = new List<IWeapon>();

        public List<IWeapon> ShowWeapons()
        {
            return Weapons;
        }

        public IWeapon SelectWeapon(int index)
        {
            return Weapons[index];
        }

        public void Attack(ICharacter character, IWeapon weapon)
        {
            weapon.Hit(character);
        }

    }
}
