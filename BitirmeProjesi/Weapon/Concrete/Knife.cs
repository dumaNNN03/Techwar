using BitirmeProjesi.Weapon.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    public class Knife : ICloseRangeWeapon
    {
        public Knife( string model, int damage, string brand)
        {
       
            Model = model;
            Damage = damage;

            Brand = brand;
            Type = "Bıçak";
            Sharpness = true;
        }

        

        public string Model { get; private set; }


        public bool Sharpness { get; private set; }

        public string Type { get; private set; }
        public int Damage { get; private set; }

        public string Brand { get; private set; }    

        public void Hit(ICharacter character)
        {
            if (Sharpness == false)
            {
                Sharpen();
            }
            character.Health -= Damage;
            Console.WriteLine($"{character.Name} {Damage} Hasar Aldı.");
            Sharpness = false;
            Console.WriteLine("Bıçak Köreldi");

        }
        
        public bool CanHit()
        {
            return true;
        }

        public void Sharpen()
        {
            if (Sharpness)
            {
                Console.WriteLine("Bıçak Zaten Keskin");
            }
            else
            {
                Sharpness = true;
                Console.WriteLine("Bıçak Keskinleştirildi.");

            }

        }
        public int NumberofHit()
        {
            return 999;
        }
    }
}
