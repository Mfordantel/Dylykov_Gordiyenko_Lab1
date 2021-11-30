using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace WasherES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rule[] rules = new Rule[146];
        UserData ud = new UserData();

        private void bGetRes_Click(object sender, EventArgs e)
        {
            resultbox.Clear();
            //чтение введенных данных
            ud.LoadUserData((long)Pricebox.Value, (long)Heightbox.Value, (long)Widthbox.Value, Smallbox.Checked, Medbox.Checked, Largebox.Checked, ToFive.Checked, MoreFive.Checked, Yfrbox.Checked, Nfrbox.Checked);
            //проверка на корректность
            if (!CheckData())
            {
                //ошибка
                resultbox.Text = "В каждом блоке должен быть выбран лишь один вариант. Проверьте ваши данные и попробуйте снова";
            }
            else
            {
                resultbox.Text = "Ожидайте . . .";
               //загрузка базы данных
               LoadDB();
                // выбор подходящей стиральной машины
                resultbox.Clear();
                resultbox.Text = GetResult().Washer;
            }
        }

        public bool CheckData()//проверка на введенность данных
        {
            bool ob, cam, type;

            if ((Smallbox.Checked ^ Medbox.Checked ^ Largebox.Checked) | (Smallbox.Checked ^ Medbox.Checked) | (Smallbox.Checked ^ Largebox.Checked) | (Medbox.Checked ^ Largebox.Checked)) ob = true;
            else ob = false;

            if (ToFive.Checked ^ MoreFive.Checked) cam = true;
            else cam = false;

            if (Yfrbox.Checked ^ Nfrbox.Checked) type = true;
            else type = false;

            if (ob & cam & type) return true;
            else return false;
        }

        public void LoadDB()//чтение базы данных
        {
            Microsoft.Office.Interop.Excel.Application DB = new Microsoft.Office.Interop.Excel.Application();

            Workbook exel = DB.Workbooks.Open(@"C:\Users\mford\Desktop\ИС\Лаб1\Washer.xlsx");
            _Worksheet DBSheet = exel.Sheets[1];
            Range DBRange = DBSheet.UsedRange;
            long prH; long prL; long hH; long hL; long wH; long wL; string drum; string tp; string hol;

            // перенести информацию из базы знаний в объекты
            for ( int i=0; i< 144; i++)
            {
                rules[i] = new Rule();

                drum = DBRange.Cells[i + 2, 1].Value2.ToString();
                hL = Convert.ToInt64(DBRange.Cells[i + 2, 2].Value2.ToString());
                hH = Convert.ToInt64(DBRange.Cells[i + 2, 3].Value2.ToString());                   
                wL = Convert.ToInt64(DBRange.Cells[i + 2, 4].Value2.ToString());
                wH = Convert.ToInt64(DBRange.Cells[i + 2, 5].Value2.ToString());
                prL = Convert.ToInt64(DBRange.Cells[i + 2, 6].Value2.ToString());
                prH = Convert.ToInt64(DBRange.Cells[i + 2, 7].Value2.ToString());
                tp = DBRange.Cells[i + 2, 8].Value2.ToString();
                hol = DBRange.Cells[i + 2, 10].Value2.ToString();

                rules[i].GetRule(prH, prL, hH, hL, wH, wL, drum, tp, hol);
            }

            DB.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(DB);
        }

        //сохранение результата
        public Rule GetResult()
        {
            Rule result = new Rule();
            for (int i = 0; i < 144; i++)
            {
                if (!rules[i].isTrue(ud))
                {
                    continue;
                }
                result = rules[i];
                break;
            }

            return result;
        }

        public class UserData
        {
            public long usPrice;
            public long usHeight;
            public long usWidth;
            public long usVol;
            public bool usCountDrum;
            public bool usSmart;
            public bool ustype;

            public UserData()
            {
                usPrice = 0;
                usHeight = 0;
                usWidth = 0;
                usVol = 0;
                usCountDrum = false;
                usSmart = false;
                ustype = false;
            }

            public void LoadUserData(long p, long h, long w, bool chmal, bool chsr, bool chbol, bool ch1cam, bool ch2cam, bool frda, bool frnet)
            {
                usPrice = p;
                usHeight = h;
                usWidth = w;

                if (chmal) usVol = 1;
                if (chsr) usVol = 2;
                if (chbol) usVol = 3;

                if (ch1cam) usCountDrum = true;
                if (ch2cam) usCountDrum = false;

                if (frda) ustype = true;
                if (frnet) ustype = false;
            }
        }

        public class Rule
        {
            public long priceH;
            public long priceL;
            public long heightH;
            public long heightL;
            public long widthH;
            public long widthL;
            public bool countDrum;
            public bool type;
            public string Washer;

            public Rule()
            {
                priceH = 0;
                priceL = 0;
                heightH = 0;
                heightL = 0;
                widthH = 0;
                widthL = 0;
                countDrum = false;
                type = false;
                Washer = "";
            }

            public void GetRule(long prH, long prL, long hH, long hL, long wH, long wL, string drum, string tp, string hol)
            {
                priceH = prH;
                priceL = prL;
                heightH = hH;
                heightL = hL;
                widthH = wH;
                widthL = wL;
 
                if (drum == "<=5кг") countDrum = true;
                if (drum == ">5кг") countDrum = false;

                if (tp == "вертикальная") type = true;
                if (tp == "фронтальная") type = false;

                Washer = hol;
            }

            public bool isTrue(UserData d)//запись результата 
            {
                if (d.usPrice <= priceH & d.usPrice >= priceL & d.usHeight >= heightL & d.usHeight <= heightH & d.usWidth >= widthL & d.usWidth <= widthH & d.usCountDrum == countDrum & d.ustype == type) return true;
                else return false;
            }
        }
    }
}
