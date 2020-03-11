using System;

namespace Random_Weapon_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0; //Do you want to protect yourself, or do some damage?
            var hiddenD20 = new Random(); //For bonuses and amount of bonuses
            int D20 = 0;//Amount generated per 20
            string[] bonusPoints = {"-5","-4","-3","-2","-1","+0","+1","+2","+3","+4","+5" };//Points
            var bonus = new Random(); //Universal
            /*
             
                WEAPONS 

             */
            var RANDweapon = new Random();
            Weapons weapon = new Weapons();
            var RANDdamageType = new Random();
            DamageType damageType = new DamageType();
            var RANDweaponUnique = new Random();
            UniqueWeapon uniqueWeapon = new UniqueWeapon();


            /*
             
                ARMOR 

             */
            var RANDarmor = new Random();
            Armor armor = new Armor();
            var RANDarmorType = new Random();
            ArmorType armorType = new ArmorType();
            var RANDarmorUnique = new Random();
            ArmorUnique armorUnique = new ArmorUnique();

            do
            {

                do
                {
                    /* //THIS IS FOR TESTING
                    for (int i = 0; i < weapon.weapon.Length; i++)
                    {
                        Console.WriteLine(i);

                    }
                    Console.Write("weapons");
                    for (int i = 0; i < damageType.damageType.Length; i++)
                    {
                        Console.WriteLine(i);

                    }
                    Console.WriteLine("Damage");
                    for (int i = 0; i < uniqueWeapon.uniqueWeapon.Length; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("unique");
                    */
                    Console.WriteLine("1.Weapon\n2.Armor");

                    choice = int.Parse(Console.ReadLine());

                } while (choice != 1 && choice != 2);

                    Console.Clear();

                D20 = hiddenD20.Next(0, 20);
                if (D20 == 20)
                {
                    //Has 3 passive effects
                    Console.WriteLine($"    {bonusPoints[bonus.Next(0, 10)]} {weapon.weapon[RANDweapon.Next(0, 34)]} of {damageType.damageType[RANDarmorType.Next(0, 12)]} effect: {uniqueWeapon.uniqueWeapon[RANDweaponUnique.Next(0, 136)]}, {uniqueWeapon.uniqueWeapon[RANDweaponUnique.Next(0,136)]} and {uniqueWeapon.uniqueWeapon[RANDweaponUnique.Next(0,136)]}\n\n ");
                    
                }
                else if (D20 == 18 || D20 == 19)
                {
                    //Has 2 passive effects
                    Console.WriteLine($"    {bonusPoints[bonus.Next(0, 10)]} {weapon.weapon[RANDweapon.Next(0, 34)]} of {damageType.damageType[RANDarmorType.Next(0, 12)]} effect: {uniqueWeapon.uniqueWeapon[RANDweaponUnique.Next(0, 136)]} and {uniqueWeapon.uniqueWeapon[RANDweaponUnique.Next(0,136)]}\n\n ");
                }
                else
                {
                    //Has 1 effect
                    Console.WriteLine($"    {bonusPoints[bonus.Next(0,10)]} {weapon.weapon[RANDweapon.Next(0,34)]} of {damageType.damageType[RANDarmorType.Next(0,12)]} effect: {uniqueWeapon.uniqueWeapon[RANDweaponUnique.Next(0,136)]}\n\n ");
                }

                Console.WriteLine("Quit? (-1 = Yes)(Anything else = No)");
                choice = int.Parse(Console.ReadLine());
            } while (choice != -1);
        }
    }
}
