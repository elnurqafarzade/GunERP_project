using GunERP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunERP.Business.Services.Interfaces
{
    public interface IWeaponService
    {
        public void EditBulletCapacity(int newMaxBulletCapacity);
        void EditBulletComb(int NewBulletComb);
        public void Info();
        public void Shoot();
        public void Fire();
        public int GetRemainBulletCount();
        public void Reload();
        public void ChangeFireMode(string newFireMode);



    }
}
