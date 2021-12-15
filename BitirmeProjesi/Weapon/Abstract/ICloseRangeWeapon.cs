using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Weapon.Abstract
{
    public interface ICloseRangeWeapon : IWeapon
    {

        public bool Sharpness { get;}

        void Sharpen();

    }
}
