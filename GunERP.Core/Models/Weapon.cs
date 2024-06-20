using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunERP.Core.Models
{
    public class Weapon
    {
        public int BulletCapacity { get; set; }
        public int BulletCountOnWeaponComb { get; set; }
        public string ShootMode { get; set; }

        public Weapon(int bulletCapacity, int BulletCountComb , string shootMode)
        {
            BulletCapacity = bulletCapacity;
            ShootMode = shootMode;
             BulletCountOnWeaponComb = BulletCountComb;
        }
    }
}
