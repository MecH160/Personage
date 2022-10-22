using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personage
{

    class Personage
    {
        public string name;
        public int lvl;
        public int strenght;
        public int dexterity;
        public int intellegence;
        public Weapon weapons;
        public string path_char;
        public int lvl_w;
        public int damage;

        public Personage(string name, int lvl, int strenght, int dexterity, int intellegence, Weapon weapons, string path_char, int lvl_w, int damage)
        {
            this.name = name;
            this.lvl = lvl;
            this.strenght = strenght;
            this.dexterity = dexterity;
            this.intellegence = intellegence;
            this.weapons = weapons;
            this.path_char = path_char;
            this.lvl_w = lvl_w;
            this.damage = damage;
        }
        public Personage(Weapon weapons)
        {
            this.name = "Безымянный персонаж";
            this.lvl = 1;
            this.strenght = 1;
            this.dexterity = 1;
            this.intellegence = 10;
            this.weapons = weapons;
            this.path_char = "папич.jpg";                     
            this.lvl_w = weapons.lvl;
            this.damage = weapons.damage;

        }
        
        public virtual string GetInfo()
        {
            return $"Имя: {name}, Уровень: {lvl}, Сила: {strenght}, Ловкость: {dexterity}, Интеллект: {intellegence}";
        }
    }
}




