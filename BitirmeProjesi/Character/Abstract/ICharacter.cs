using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    public interface ICharacter
    {
        public string Name { get; set; }

        public int Health { get; set; }


        void Attack(ICharacter character,IWeapon weapon);

    }
}
