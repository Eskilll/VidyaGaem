using System;

namespace Vidya
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Player thePlayer = new Player();

            thePlayer.name = "Whatever";
            thePlayer.x = 1;
            thePlayer.y = 1;
            thePlayer.z = 1;
            thePlayer.lookingY = 1;
            thePlayer.lookingX = 1;
            thePlayer.speed = 1;

            Weapon theWeapon = new Weapon();
            theWeapon.fireRate = 600; // rounds/min
            theWeapon.recoil = 1;
            theWeapon.damage = 15;
            theWeapon.bulletPerShot = 1;
            theWeapon.name = "gun";

            Grenade theGrenade = new Grenade();
            theGrenade.name = "FragGrenade";
            theGrenade.fire = false;
            theGrenade.damage = 120;
            theGrenade.fallOff = 100;
            theGrenade.aoe = 200;

        }
    }
}
