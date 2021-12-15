using BitirmeProjesi.Weapon.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Weapon.Concrete
{
    public class Cannon : IRangedWeapon<CannonBall>
    {
        public Cannon( string model, int damage, string brand, int magazine, CannonBall ammoType, int shoottingAmmo)
        {

            Model = model;
            Damage = damage;
            Brand = brand;
            Magazine = magazine;
            AmmoType = ammoType;
            ShoottingAmmo = shoottingAmmo;
            Type = "Top";
        }

        public string Model { get; private set; }

        public int Damage { get; private set; }

        public string Type { get; private set; }

        public int Magazine { get; private set; }

        public CannonBall AmmoType { get; private set; }



        public string Brand { get; private set; }
        public int ShoottingAmmo { get; private set; }

        public void Hit(ICharacter character)
        {
            character.Health -= Damage;
            Magazine -= ShoottingAmmo;
            Console.WriteLine($"{character.Name} {Damage} Hasar Aldı.");

        }

        public bool CanHit()
        {
            if (Magazine < ShoottingAmmo)
            {
                return false;
            }
            return true;
        }


        public int NumberofHit()
        {
            return Magazine / ShoottingAmmo;
        }
    }
}
