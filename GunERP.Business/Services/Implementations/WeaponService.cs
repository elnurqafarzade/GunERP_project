
using GunERP.Business.Services.Interfaces;
using GunERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GunERP.Business.Services.Implementations
{
    public class WeaponService : IWeaponService
    {
        private Weapon weapon = new Weapon(30, 30, "Auto");

        public void ChangeFireMode(string newFireMode)
        {
            weapon.ShootMode = newFireMode;
            Console.WriteLine("Atış modu dəyişdirildi: " + newFireMode);
        }

        public void Fire()
        {
            if (weapon.ShootMode != "Single")
                if (weapon.BulletCountOnWeaponComb > 0)
                {
                    Console.WriteLine("Bütün güllələr atəşləndi.");
                    weapon.BulletCountOnWeaponComb = 0;
                }
                else
                    Console.WriteLine("Daraqda güllə yoxdur.");
            else
                Console.WriteLine("Mode yalnisdir");
        }

        public int GetRemainBulletCount()
        {
            return weapon.BulletCountOnWeaponComb;
        }

        public void Info()
        {
            Console.WriteLine("Daraqın güllə tutumu: " + weapon.BulletCapacity);
            Console.WriteLine("Daraqdakı güllə sayı: " + weapon.BulletCountOnWeaponComb);
            Console.WriteLine("Silah modu " + weapon.ShootMode);
        }

        public void Reload()
        {
            weapon.BulletCountOnWeaponComb = weapon.BulletCapacity;
            Console.WriteLine("Daraq yenidən dolduruldu.");
        }

        public void Shoot()
        {
            if (weapon.ShootMode == "Single")
                if (weapon.BulletCountOnWeaponComb > 0)
                    weapon.BulletCountOnWeaponComb--;
                else
                    Console.WriteLine("Daraqda güllə yoxdur.");
            else
                Console.WriteLine("Mode yalnisdir");
        }
        public void EditBulletCapacity(int newMaxBulletCapacity)
        {
            weapon.BulletCapacity = newMaxBulletCapacity;
        }
        public void EditBulletComb( int NewBulletComb)
        {
            weapon.BulletCountOnWeaponComb = NewBulletComb;
        }
    }
}

