﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personage
{
    static class StaticMetodsForPersonage_
    { 
        public static Weapon weapons { get; set; }
        public static int strenght { get; set; }
        public static int dexterity { get; set; }
        public static int intellegence { get; set; }
        public static int lvl { get; set; }
       /* public static int pers_1 { get; set; }
        public static int pers_2 { get; set; }*/

        static public string Power(Personage pers)
        {
            int i = (((pers.strenght + pers.dexterity + pers.intellegence) * pers.lvl) + (pers.weapons.lvl * pers.weapons.damage));
            if (i < 0)
            {
               i = 2147483647;
            }
            switch (weapons.Type_weapon)
            {
                case "Меч":
                    {
                        if (i <= 50)
                        {
                            return ("Просто мечник");
                        }
                        if (i >= 51 && i <= 100)
                        {
                            return ("Хороший мечник");
                        }
                        if (i >= 101 && i <= 200)
                        {
                            return ("Отличный мечник");
                        }
                        if (i >= 201 && i <= 400)
                        {
                            return ("Великолепный мечник");
                        }
                        if (i >= 401)
                        {
                            return ("А точно мечник? Может это Гатс?");
                        }
                    }
                    break;
                case "Клинки":
                    {
                        if (i <= 50)
                        {
                            return ("Кадет");
                        }
                        if (i >= 51 && i <= 100)
                        {
                            return ("Рядовой");
                        }
                        if (i >= 101 && i <= 200)
                        {
                            return ("Ефрейтор");
                        }
                        if (i >= 201 && i <= 400)
                        {
                            return ("Младший капрал");
                        }
                        if (i >= 401)
                        {
                            return ("Капрал");
                        }
                        break;
                    }
                case "Щит":
                    {

                        if (i <= 50)
                        {
                            return ("Просто щитоносец");
                        }
                        if (i >= 51 && i <= 100)
                        {
                            return ("Хороший щитоносец");
                        }
                        if (i >= 101 && i <= 200)
                        {
                            return ("Отличный щитоносец");
                        }
                        if (i >= 201 && i <= 400)
                        {
                            return ("Великолепный щитоносец");
                        }
                        if (i >= 401)
                        {
                            return ("А точно щитоносец? Может это Львинный Глаз?");
                        }
                        break;
                    }
                case "Лук":
                    {
                        if (i <= 50)
                        {
                            return ("Просто лучник");
                        }
                        if (i >= 51 && i <= 100)
                        {
                            return ("Хороший лучник");
                        }
                        if (i >= 101 && i <= 200)
                        {
                            return ("Отличный лучник");
                        }
                        if (i >= 201 && i <= 400)
                        {
                            return ("Великолепный лучник");
                        }
                        if (i >= 401)
                        {
                            return ("«А точно лучник? Может это Лиралей?");
                        }
                        break;
                    }

            }
            return "";
        }

        static public string Strong_pers(List<Personage> pers) 
        {
            int max_power = 0;
            int index = 0;
            for (int i = 0; i <pers.Count(); i++)
            {
                int power = (((pers[i].strenght + pers[i].dexterity + pers[i].intellegence) * pers[i].lvl) + (pers[i].weapons.lvl * pers[i].weapons.damage));
                if (power < 0)
                {
                    power = 2147483647;
                }
                if (power > max_power)
                {
                    max_power = power;
                    index = i;
                }
            }
            return $"Самый сильный персонаж: {pers[index].GetInfo()}";
          
        }
    }
}
