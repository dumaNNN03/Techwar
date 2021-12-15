using BitirmeProjesi.Weapon.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Models
{
    public class CreatedModels
    {
        
        public List<Map> maps = new List<Map>() { new Map("Vahiş Batı", 8), new Map("Hayalet Şehir", 5), new Map("Lou's Cafe", 3) };
        static CannonBall cannonBall = new CannonBall();
        static CoreAmmo coreAmmo = new CoreAmmo();
        static Rocket rocket = new Rocket();
        static ShotgunAmmo shotgunAmmo = new ShotgunAmmo();
        public List<IWeapon> gamerWeapons = new List<IWeapon>() {
            new Knife("K500",5,"Rambo"),
            new Knife("K700",8,"Rambo"),
            new Bayonet("K100",8,"Rambo"),
            new Gun("A300",8,"Altıpatlar",6,coreAmmo,1),
            new Gun("S1000",8,"Su",15,coreAmmo,1),
            new ShotGun("P400",15,"Poz",5,shotgunAmmo,false,1),
            new AssaultRifle("T600",10,"Tara",50,coreAmmo,false,5),
            new Bazooka("R100",40,"Rot",1,rocket,false,1),
            new Cannon("G200",30,"Guny",1,cannonBall,1)
        };



      
        public static List<IWeapon> enemyWeapons = new List<IWeapon>() {
            new Knife("K500",5,"Rambo"),
            new Knife("K700",8,"Rambo"),
            new Bayonet("K100",8,"Rambo"),
            new Gun("A300",8,"Altıpatlar",6,coreAmmo,1),
            new Gun("S1000",8,"Su",15,coreAmmo,1),
            new ShotGun("P400",15,"Poz",5,shotgunAmmo,false,1),
            new AssaultRifle("T600",10,"Tara",50,coreAmmo,false,5),
            new Bazooka("R100",40,"Rot",1,rocket,false,1),
            new Cannon("G200",30,"Guny",1,cannonBall,1)
        };
        public List<IWeapon> ChoosenWeapons = new List<IWeapon>();

        public List<Enemy> enemies = new List<Enemy>() { 
         new Enemy("Yalnız Kurt",40, enemyWeapons[3]),
         new Enemy("Yaralı Kurt",30, enemyWeapons[1]),
         new Enemy("Zeki Kurt",50, enemyWeapons[6]),
         new Enemy("Paralı Asker",60, enemyWeapons[5]),
         new Enemy("Rambo",70, enemyWeapons[7]),
         new Enemy("John Wick",70, enemyWeapons[4]),
         new Enemy("Marty McFly",30, enemyWeapons[0]),
         new Enemy("Akın Karakurt",70, enemyWeapons[8]),
        };
    }
}
