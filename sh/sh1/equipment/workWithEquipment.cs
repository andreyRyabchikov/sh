using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class equipment
    {
        private householdEquipment[] all_equipment;
        public equipment()
        {
            all_equipment = new householdEquipment[6];
            all_equipment[0] = new kettle("РКК32", 900, "аллюминий", "Вода");
            all_equipment[1] = new oven("АПН12", 1900, 350, false, "аллюминий", "вся");
            all_equipment[2] = new hover("СУС5", 500, 2000, 1200, 100);
            all_equipment[3] = new airCleaner("САС11", 200, 3, 30, 10);
            all_equipment[4] = new solderingIron("ХОТ3", 700, 2200, 30, 0);
            all_equipment[5] = new drill("КРУТ43", 2200, 2000, "Перьевое", 90);
        }
        public int count_power()
        {
            int all_power = 0;
            foreach (householdEquipment equipment in all_equipment)
            {
                all_power += equipment.power;
            }
            return all_power;
        }
        public void sort()
        {
            for (int k = 0; k < 6; k++)
            {
                for (int l = k + 1; l < 6; l++)
                {
                    if (all_equipment[k].rated_power < all_equipment[l].rated_power)
                    {
                        householdEquipment tmp = all_equipment[k];
                        all_equipment[k] = all_equipment[l];
                        all_equipment[l] = tmp;
                    }
                }
            }
        }
        public householdEquipment find(string type, string name, int power)
        {
            foreach (householdEquipment equipment in all_equipment)
            {
                if (equipment.rated_power == power && equipment.name == name && equipment.type == type)
                    return equipment;
            }
            MessageBox.Show("Не найдено!");
            return null;
        }
        public override string ToString()
        {
            string result = "";
            foreach (householdEquipment equipment in all_equipment)
            {
                result += equipment.ToString() + "\n\r";
            }
            return result;
        }
        public void outlet(int number)
        {
            all_equipment[number].outlet();
        }
        public void print_equipment(DataGridView dg)
        {
            dg.RowCount = 6;
            dg.ColumnCount = 4;
            dg.Columns[0].HeaderCell.Value = "Тип";
            dg.Columns[0].Width = 200;
            dg.Columns[1].HeaderCell.Value = "Имя";
            dg.Columns[1].Width = 200;
            dg.Columns[2].HeaderCell.Value = "Мощность";
            dg.Columns[2].Width = 200;
            dg.Columns[3].HeaderCell.Value = "Розетка";
            dg.Columns[3].Width = 200;
            for (int i = 0; i < 6; i++)
            {
                dg.Rows[i].HeaderCell.Value = i;
                dg.Rows[i].Cells[0].Value = all_equipment[i].type;
                dg.Rows[i].Cells[1].Value = all_equipment[i].name;
                dg.Rows[i].Cells[2].Value = all_equipment[i].rated_power;
                if (all_equipment[i].power_on)
                    dg.Rows[i].Cells[3].Value = "вкл";
                else
                    dg.Rows[i].Cells[3].Value = "выкл";
            }
        }
    }
}
