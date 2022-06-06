using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using equipment;

namespace sh1Forms
{
    class Equipment
    {
        internal HouseholdEquipment[] AllEquipment { get; }

        public Equipment()
        {
            AllEquipment = new HouseholdEquipment[6];
            AllEquipment[0] = new Kettle("РКК32", 900, "аллюминий", "Вода");
            AllEquipment[1] = new Oven("АПН12", 1900, 350, false, "аллюминий", "вся");
            AllEquipment[2] = new Hover("СУС5", 500, 2000, 1200, 100);
            AllEquipment[3] = new AirCleaner("САС11", 200, 3, 30, 10);
            AllEquipment[4] = new SolderingIron("ХОТ3", 700, 2200, 30, 0);
            AllEquipment[5] = new Drill("КРУТ43", 2200, 2000, "Перьевое", 90);
        }
        public int CountPower()
        {
            int allPower = 0;
            foreach (HouseholdEquipment equipment in AllEquipment)
            {
                allPower += equipment.Power;
            }
            return allPower;
        }
        public void Sort()
        {
            for (int k = 0; k < 6; k++)
            {
                for (int l = k + 1; l < 6; l++)
                {
                    if (AllEquipment[k].RatedPower < AllEquipment[l].RatedPower)
                    {
                        (AllEquipment[l], AllEquipment[k]) = (AllEquipment[k], AllEquipment[l]);
                    }
                }
            }
        }
        public HouseholdEquipment Find(string type, string name, int power)
        {
            foreach (HouseholdEquipment equipment in AllEquipment)
            {
                if (equipment.RatedPower == power && equipment.Name == name && equipment.Type == type)
                    return equipment;
            }
            MessageBox.Show("Не найдено!");
            return null;
        }
        public override string ToString()
        {
            string result = "";
            foreach (HouseholdEquipment equipment in AllEquipment)
            {
                result += equipment.ToString() + "\n\r";
            }
            return result;
        }
        public void Outlet(int number)
        {
            AllEquipment[number].Outlet();
        }
        public void PrintEquipment(DataGridView dg)
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
                dg.Rows[i].Cells[0].Value = AllEquipment[i].Type;
                dg.Rows[i].Cells[1].Value = AllEquipment[i].Name;
                dg.Rows[i].Cells[2].Value = AllEquipment[i].RatedPower;
                if (AllEquipment[i].PowerOn)
                    dg.Rows[i].Cells[3].Value = "вкл";
                else
                    dg.Rows[i].Cells[3].Value = "выкл";
            }
        }
    }
}
