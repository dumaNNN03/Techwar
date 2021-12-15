using BitirmeProjesi.Weapon.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Weapon.Concrete
{
    public class AssaultRifle : IRangedWeapon<CoreAmmo>
    {
        public AssaultRifle( string model, int damage, string brand, int magazine, CoreAmmo ammoType, bool scope, int shoottingAmmo)
        {
            Model = model;
            Damage = damage;
            Brand = brand;
            Magazine = magazine;
            AmmoType = ammoType;
            Scope = scope;
            ShoottingAmmo = shoottingAmmo;
            Type = "Taramalı Tüfek";
        }

        public string Model { get; private set; }

        public int Damage { get; private set; }

        public string Type { get; private set; }

        public int Magazine { get; private set; }

        public CoreAmmo AmmoType { get; private set; }

        public bool Scope { get; private set; }

        public string Brand { get; private set; }
        public int ShoottingAmmo { get; private set; }

        public void Hit(ICharacter character)
        {
            ToggleScope();
            character.Health -= Damage;
            Magazine -= ShoottingAmmo;
            Console.WriteLine($"{character.Name} {Damage} Hasar Aldı.");
            ToggleScope();

        }

        public bool CanHit()
        {
            if (Magazine < ShoottingAmmo)
            {
                return false;
            }
            return true;
        }

        public void ToggleScope()
        {
            if (Scope)
            {
                Console.WriteLine("Dürbün Kapandı");
            }
            else
            {
                Console.WriteLine("Dürbün Açıldı");
            }
            Scope = !Scope;
        }

        public int NumberofHit()
        {
            return Magazine / ShoottingAmmo;
        }
    }
}
