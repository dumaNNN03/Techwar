using BitirmeProjesi.Weapon.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    class Game
    {
      public bool Duel(Gamer gamer,Enemy enemy)
        {

            while (gamer.Health > 0 && enemy.Health > 0 )
            {
                if (!CheckEnemyWeapon(enemy)) return true;
                if (!CheckGamerWeapons(gamer)) return false;
                SelectWeapon(gamer).Hit(enemy);
                if (enemy.Health <= 0) return true;
                enemy.SelectWeapon().Hit(gamer);
                Console.WriteLine($"{enemy.Name} {enemy.Health} Canı Kaldı");
                Console.WriteLine($"{gamer.Health} Canınız Kaldı");
            }
            if (gamer.Health > 0) 
            { 
                return true; 
            }
            else
            {
                return false;
            }         
        }

        bool CheckEnemyWeapon(Enemy enemy)
        {
            if (enemy.SelectWeapon().CanHit()) return true;
            Console.WriteLine("Düşmanın Silahı Kalmadığından Düşmanı Yendiniz");
            return false;
        }
        bool CheckGamerWeapons(Gamer gamer)
        {
            int disUsedWeapon = 0;
            foreach (IWeapon weapon in gamer.ShowWeapons())
            {
                if (!weapon.CanHit())
                {
                    disUsedWeapon += 1;
                }
            }
            if (disUsedWeapon != 3) return true;
            Console.WriteLine("Kullanılabilir Bir Silahınız Olmadığından");
            return false;
            
        }

        void ShowGamerWeapons(Gamer gamer)
        {
            int selectWeapon = 1;
            foreach (IWeapon weapon in gamer.ShowWeapons())
            {
                if (weapon.CanHit())
                {
                    Console.WriteLine($"{selectWeapon} - {weapon.Model} {weapon.Type} Vurduğu Hasar {weapon.Damage} ve {weapon.NumberofHit()} kere Kullanılabilir ");
                    
                }
                selectWeapon += 1;

            }
        }

        IWeapon SelectWeapon(Gamer gamer)
        {
            ShowGamerWeapons(gamer);
            Console.WriteLine("Kullanmak İstediğiniz Silahı Seçiniz");
            return gamer.SelectWeapon(int.Parse(Console.ReadLine())-1);
        }
    }
}
