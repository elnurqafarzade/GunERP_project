
using GunERP.Business.Services.Implementations;
using GunERP.Business.Services.Interfaces;
using GunERP.Core;
using GunERP.Core.Models;

namespace GunERP.CA
{
    public class Program
    {
        public static IWeaponService weaponService = new WeaponService();
        static void Main(string[] args)
        {
            StartApp();
        }

        private static void StartApp()
        {
            Console.WriteLine("0.Info \n 1.Shoot \n 2.Fire \n 3.Get Remain Bullet Count \n 4.Reload \n 5.Change Fire Mode \n 6. Exit \n 7.Edit ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    weaponService.Info();
                    break;
                case "1":
                    weaponService.Shoot();
                    break;
                case "2":
                    weaponService.Fire();
                    break;
                case "3":
                    weaponService.GetRemainBulletCount();
                    break;
                case "4":
                    weaponService.Reload();
                    break;
                case "5":
                    Console.WriteLine("FireMode daxil edin.   Auto or Single");

                    weaponService.ChangeFireMode(Console.ReadLine());
                    break;
                case "6":
                    break;
                case "7":
                    Console.WriteLine("1 - Tutumu dəyişsin");
                    Console.WriteLine("2 - Güllə sayı deyissin");
                    string editOption = Console.ReadLine();
                    if (editOption == "1")
                    {
                        Console.WriteLine("Yeni güllə tutumunu daxil edin (maksimum güllə sayı):");
                        int newMaxBulletCapacity = Convert.ToInt32(Console.ReadLine());
                        weaponService.EditBulletCapacity(newMaxBulletCapacity);
                       
                    }
                    else if (editOption == "2")
                    {
                        Console.WriteLine("Yeni güllə sayını daxil edin:");
                        int NewBulletComb = Convert.ToInt32(Console.ReadLine());
                        weaponService.EditBulletComb(NewBulletComb);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış seçim. Zəhmət olmasa düzgün seçim edin.");
                    }
                    break;
            }
            StartApp();
        }
    }
}
