using BitirmeProjesi.Models;
using BitirmeProjesi.Weapon.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BitirmeProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int mapchoose = 1;
            int weaponchoose = 1;
            List<Enemy> enemies = new List<Enemy>();
            CreatedModels createdModels = new CreatedModels();
            Game game = new Game();
            Console.WriteLine("TechCareer War Game");
            Console.WriteLine("İsminizi Giriniz = ");
            string gamerName = Console.ReadLine();
            Console.WriteLine($"Hoş Geldin Asker {gamerName} Savaşmak İstediğin Bölgeyi Seç : ");
            foreach (Map map in createdModels.maps)
            {
                Console.WriteLine($"{mapchoose} - Bölge = {map.Name}  {map.EnemyNumber} düşman bulunur.");
                mapchoose += 1;

            }
            mapchoose = int.Parse(Console.ReadLine());
            Console.WriteLine($"{gamerName} Oynamak İstediğin 3 Silahı Seç");
            foreach (IWeapon weapon in createdModels.gamerWeapons)
            {
                Console.WriteLine($"{weaponchoose} - {weapon.Model} Model {weapon.Type} - Verdiği Hasar = {weapon.Damage} - {weapon.NumberofHit()} Kere Kullanılarbilir.");
                weaponchoose += 1;
            }
            Console.WriteLine("Birinci Silahı Seç = ");
            weaponchoose = int.Parse(Console.ReadLine());
            createdModels.ChoosenWeapons.Add(createdModels.gamerWeapons[weaponchoose - 1]);
            Console.WriteLine(createdModels.ChoosenWeapons[0].Model + " " + createdModels.ChoosenWeapons[0].Type + "  Silahı seçtin.");
            Console.WriteLine("İkinci Silah Seç = ");
            weaponchoose = int.Parse(Console.ReadLine());
            createdModels.ChoosenWeapons.Add(createdModels.gamerWeapons[weaponchoose - 1]);
            Console.WriteLine(createdModels.ChoosenWeapons[1].Model + " " + createdModels.ChoosenWeapons[1].Type + "  Silahı seçtin.");
            Console.WriteLine("Üçüncü Silah Seç = ");
            weaponchoose = int.Parse(Console.ReadLine());
            createdModels.ChoosenWeapons.Add(createdModels.gamerWeapons[weaponchoose - 1]);
            Console.WriteLine(createdModels.ChoosenWeapons[2].Model + " " + createdModels.ChoosenWeapons[2].Type + "  Silahı seçtin.");
            for (int i = 0; i < createdModels.maps[mapchoose - 1].EnemyNumber; i++)
            {
                enemies.Add(createdModels.enemies[i]);
            }
            Gamer gamer = new Gamer(gamerName, createdModels.ChoosenWeapons);
            bool continues = true;

            while (continues)
            {
                foreach (Enemy enemy in enemies)
                {
                    Console.WriteLine($"Düşmanınız {enemy.Name} Canı {enemy.Health} Kullandığı Silah {enemy.ShowWeapon().Model} {enemy.ShowWeapon().Type} ");
                    Console.WriteLine("Düelloya Başlamak İçin Bir Tuşa Basınız");
                    Console.ReadKey();
                    continues = game.Duel(gamer, enemy);
                    if (!continues)
                    {
                        Console.WriteLine("Oyunu Kaybettiniz");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{enemy.Name} İsimli Düşmanı Yendiniz");
                        Console.WriteLine("Sıradaki Düşmana Geçmek İçin Bir Tuşa Basınız");
                        Console.ReadKey();

                    }
                }
                if (continues)
                {
                    Console.WriteLine("Haritadaki Tüm Düşmanları Yendiniz.");
                    Console.WriteLine("Oyunu Kazandınız Tebrikler");
                    Console.WriteLine("Kapatmak İçin Bir Tuşa Basınız");
                    Console.ReadKey();
                    break;
                }

            }





        }
    }
}
