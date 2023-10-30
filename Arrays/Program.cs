using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine("------");
            Console.WriteLine();

            // single weapon
            // weapon ammo amount

            //int ammo;
            //ammo = 0;
            // Fire()
            // Reload()
            // Range Check (0.50)


            //int pistolAmmo;
            //int shotGun;
            //int sprederAmmo;
            //int rocketLauncherAmmo;
            //string currentWeapon;
            // Current Weapon; 0 = pistol, 1 = shotgun, ect
            // Fire()

            // if (currentWeapon == "pistol") ....
            // {
            //      // range check
            //pistolAmmo = pistolAmmo - 1;
            // }
            // else if (currentWeapon == "shotGun") ....



            // multiple weapons w/arrays
            // 0 - pistol
            // 1 - shotgun
            // 2 - spreader
            // 3 - rocket launcher


            int[] ammo; // declaration
                        // "int[]" = type = "array of ints'
            ammo = new int[4]; // instatiation (New!) -- make sure there is memory!
            // max ammo cheat

            ammo[0] = 50;// pistol
            ammo[1] = 20;// shotgun
            ammo[2] = 100;// spreader
            ammo[3] = 6;// rocket launcher
            //ammo[4] = 0;// initialization - does not work! since it's out of range of the array

            int currentWeapon;
            currentWeapon = 0; // pistol
            //Fire()
            // PickUp(int weaponType)


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }

        static void Fire()
        {
            if (currentWeapon == 0)
            {
                ammo[1] = ammo[1] - 1;
            }
        }
    }
}
