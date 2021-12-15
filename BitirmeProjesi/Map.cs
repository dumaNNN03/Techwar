using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    public class Map
    {
        public Map(string name, int enemynumber)
        {
            try
            {
                if ((enemynumber > 8 || enemynumber < 3) || name.Length > 15)
                {
                    throw new Exception("Haritalar için gerekli kurallara uyulmadı.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Name = name;
            EnemyNumber = enemynumber;
        }
        public string Name { get; private set; }

        public int EnemyNumber { get; private set; }


    }
}
