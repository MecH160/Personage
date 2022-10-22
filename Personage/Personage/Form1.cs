using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        List<Weapon> weapons = new List<Weapon> { };
        List<Personage> pers = new List<Personage>{};
        string path_weapon;
        string path_char;
        int count_weapon=0;
        int count_char = 0;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*. BMP, *.JPG," + "*.GIF, *.PNG) |*.bmp; *.jpg; *.gif; *.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(dialog.FileName);
                    Bitmap bmp = new Bitmap(image);
                    pictureBox1.Image = bmp;
                    path_char = Path.GetFileName(dialog.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string CharName = textBox2.Text;
                int CharLvl = Convert.ToInt32(textBox3.Text);
                int CharStr = Convert.ToInt32(textBox4.Text);
                int CharDex = Convert.ToInt32(textBox5.Text);
                int CharInt = Convert.ToInt32(textBox6.Text);
                int index = comboBox1.SelectedIndex;
                string pathCH = path_char;
                Weapon weapon = weapons[index];
                Personage per = new Personage(CharName, CharLvl, CharStr, CharDex, CharInt, weapon,pathCH, weapon.lvl, weapon.damage);
                pers.Add(per);
                int last_count = pers.Count() - 1;
                comboBox6.Items.Add(pers[last_count].GetInfo());
                button2.Enabled = true;
                StaticMetodsForPersonage_.dexterity = CharDex;
                StaticMetodsForPersonage_.intellegence = CharInt;
                StaticMetodsForPersonage_.lvl = CharLvl;
                StaticMetodsForPersonage_.strenght = CharStr;
                StaticMetodsForPersonage_.weapons = weapon;
                button8.Enabled = true;
                count_char++;
                if(count_char>=1)
                {
                    button7.Enabled = true;
                }

            }
            catch(Exception ex)
            {
                int last_count_w = weapons.Count() - 1;
                int last_count_p = pers.Count();
                Weapon weapon = weapons[last_count_w];
                Personage per = new Personage(weapon);
                pers.Add(per);
                comboBox6.Items.Add(pers[last_count_p].GetInfo());
                button8.Enabled = true;
                count_char++;
                if (count_char >= 1)
                {
                    button7.Enabled = true;
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
            {
            try
            {
                string name = textBox7.Text;
                int lvl = Convert.ToInt32(textBox8.Text);
                int damage = Convert.ToInt32(textBox9.Text);
                string Type_of_weapon = comboBox4.Text;
                string path = path_weapon;
                Weapon weapon = new Weapon(name, lvl, damage, Type_of_weapon, path);
                weapons.Add(weapon);
                int last_count = weapons.Count() - 1;
                listBox1.Items.Add(weapon.GerInfo());
                comboBox1.Items.Add(weapons[last_count].GerInfo());
                comboBox2.Items.Add(weapons[last_count].GerInfo());
                comboBox3.Items.Add(weapons[last_count].GerInfo());
                comboBox5.Items.Add(weapons[last_count].GerInfo());
                button2.Enabled = true;
                count_weapon++;
                if (count_weapon >= 2)
                {
                    button6.Enabled = true;
                    button4.Enabled = true;
                }
            }
            catch(Exception ex)
            {             
                Weapon weapon = new Weapon();
                weapons.Add(weapon);
                int last_count = weapons.Count() - 1;
                listBox1.Items.Add(weapons[last_count].GerInfo());
                comboBox1.Items.Add(weapons[last_count].GerInfo());
                comboBox2.Items.Add(weapons[last_count].GerInfo());
                comboBox3.Items.Add(weapons[last_count].GerInfo());
                comboBox5.Items.Add(weapons[last_count].GerInfo());
                button2.Enabled = true;
                count_weapon++;
                if (count_weapon >= 2)
                {
                    button6.Enabled = true;
                    button4.Enabled = true;
                }
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox2.SelectedIndex;
                int index2 = comboBox3.SelectedIndex;
                if (weapons[index].Type_weapon == weapons[index2].Type_weapon)
                {
                    weapons.Add(weapons[index] += weapons[index2]);
                    int last_count = weapons.Count() - 1;
                    listBox1.Items.Add(weapons[last_count].GerInfo());
                    comboBox1.Items.Add(weapons[last_count].GerInfo());
                    comboBox2.Items.Add(weapons[last_count].GerInfo());
                    comboBox3.Items.Add(weapons[last_count].GerInfo());
                    comboBox5.Items.Add(weapons[last_count].GerInfo());
                }
                else
                {
                    MessageBox.Show("Типы оружия не совпадают");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*. BMP, *.JPG," + "*.GIF, *.PNG) |*.bmp; *.jpg; *.gif; *.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(dialog.FileName);
                    Bitmap bmp = new Bitmap(image);
                    pictureBox2.Image = bmp;                    
                    path_weapon = Path.GetFileName(dialog.FileName);
                    button3.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = comboBox5.SelectedIndex;
            Image image = Image.FromFile(weapons[index].path_weapon);
            Bitmap bmp = new Bitmap(image);
            pictureBox2.Image = bmp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = comboBox6.SelectedIndex;
            Image image = Image.FromFile(pers[index].path_char);
            Bitmap bmp = new Bitmap(image);
            pictureBox1.Image = bmp;
            int power_pers = (((pers[index].strenght + pers[index].dexterity + pers[index].intellegence) * pers[index].lvl) + (pers[index].weapons.lvl * pers[index].weapons.damage));
            
            MessageBox.Show($"Звание персонажа:  {StaticMetodsForPersonage_.Power(pers[index])} Мощность равна:{power_pers}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string result = StaticMetodsForPersonage_.Strong_pers(pers);
           
                MessageBox.Show(result);
            
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
