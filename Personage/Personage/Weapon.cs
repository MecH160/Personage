using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personage
{
    class Weapon
    {
        public string name;
        public int lvl;
        public int damage;
        public string Type_weapon;
        public string path_weapon;

        public Weapon(string name, int lvl, int damage, string  Type_weapon, string path_weapon)
        {
            this.name = name;
            this.lvl = lvl;
            this.damage = damage;
            this.Type_weapon = Type_weapon;
            this.path_weapon = path_weapon;
        }
        
        public Weapon()
        {
            this.name = "Безымянный щит";
            this.lvl = 1;
            this.damage = 10;
            this.Type_weapon = "Щит";
            this.path_weapon = "shield.jpg";
        }
        public static Weapon operator +(Weapon i1, Weapon i2)
        {
            if (i1.lvl > i2.lvl)
            {
               string name_best = i1.name;
               int lvl_best = i1.lvl + 1;
               return new Weapon(name_best + "+", lvl_best++, i1.damage + i2.damage, i1.Type_weapon,i1.path_weapon);
            }
            else if(i1.lvl < i2.lvl)
            {
                string name_best = i2.name;
                int lvl_best = i2.lvl + 1;
                return new Weapon(name_best + "+", lvl_best++, i1.damage + i2.damage, i1.Type_weapon,i2.path_weapon);
            }
            else
            {
                string name_best = i1.name;
                int lvl_best = i1.lvl + 1;
                return new Weapon(name_best + "+", lvl_best++, i1.damage + i2.damage, i1.Type_weapon, i1.path_weapon);
            }
        }

        public virtual string GerInfo()
        {
            return $"Имя: {name}, Уровень оружия: {lvl}, \nУрон: {damage}, Тип оружия: {Type_weapon}";
        }
    }
}
