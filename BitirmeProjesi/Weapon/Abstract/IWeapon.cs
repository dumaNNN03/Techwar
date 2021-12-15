using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    public interface IWeapon
    {

        public string Model { get;}

        public string Brand { get;}

        public int Damage { get;}

        void Hit(ICharacter character);

        public string Type { get;}

        bool CanHit();

        int NumberofHit();
    }
}
