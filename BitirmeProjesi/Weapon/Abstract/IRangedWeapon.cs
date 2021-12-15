using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Weapon.Abstract
{
    public interface IRangedWeapon<T> : IWeapon where T : class,IAmmo,new() 
    {


        public int Magazine { get;}

        public  T AmmoType { get; }

        public int ShoottingAmmo { get; }



    }
}
