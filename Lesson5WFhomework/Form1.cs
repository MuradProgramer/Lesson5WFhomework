using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5WFhomework
{
    public partial class Form1 : MaterialForm
    {
        public int MaxMoney { get; set; }

        public double CurrentMoney { get; set; } = 0;

        public Dictionary<string, int> stock { get; set; }

        public User user { get; set; }

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, 
                Primary.BlueGrey900, Primary.BlueGrey200, 
                Accent.LightBlue200, TextShade.WHITE);
            MaxMoney = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialProgressBar1.Value = 0;
            m_lbl_mebleg.Text = "0,0";
            m_lbl_qaliq.Text = "0,0";
            CurrentMoney = 0;
            var jsonStr = File.ReadAllText("stock.json");
            stock = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonStr);

            var jsonStr2 = File.ReadAllText("user.json");
            user = JsonConvert.DeserializeObject<User>(jsonStr2);

            m_ckb_albeni.Text = stock["Albeni"].ToString();
            m_ckb_bizon.Text = stock["Bizon"].ToString();
            m_ckb_bounty.Text = stock["Bounty"].ToString();
            m_ckb_chips.Text = stock["Chips"].ToString();
            m_ckb_cola.Text = stock["Cola"].ToString();
            m_ckb_fanta.Text = stock["Fanta"].ToString();
            m_ckb_icetea.Text = stock["Ice Tea"].ToString();
            m_ckb_mars.Text = stock["Mars"].ToString();
            m_ckb_nzs.Text = stock["NZS"].ToString();
            m_ckb_pepsi.Text = stock["Pepsi"].ToString();
            m_ckb_snickers.Text = stock["Snickers"].ToString(); 
            m_ckb_tutku.Text = stock["Tutqu"].ToString();

            m_ckb_albeni.Enabled = false;
            m_ckb_bizon.Enabled = false;
            m_ckb_bounty.Enabled = false;
            m_ckb_chips.Enabled = false;
            m_ckb_cola.Enabled = false;
            m_ckb_fanta.Enabled = false;
            m_ckb_icetea.Enabled = false;
            m_ckb_mars.Enabled = false;
            m_ckb_nzs.Enabled = false;
            m_ckb_pepsi.Enabled = false;
            m_ckb_snickers.Enabled = false;
            m_ckb_tutku.Enabled = false;

            m_ckb_albeni.Checked = false;
            m_ckb_bizon.Checked = false;
            m_ckb_bounty.Checked = false;
            m_ckb_chips.Checked = false;
            m_ckb_cola.Checked = false;
            m_ckb_fanta.Checked = false;
            m_ckb_icetea.Checked = false;
            m_ckb_mars.Checked = false;
            m_ckb_nzs.Checked = false;
            m_ckb_pepsi.Checked = false;
            m_ckb_snickers.Checked = false;
            m_ckb_tutku.Checked = false;            
        }

        public void CheckTrueMoney(bool statement)
        {
            m_ckb_albeni.Enabled = statement && (int.Parse(m_ckb_albeni.Text) > 0);
            m_ckb_bizon.Enabled = statement && (int.Parse(m_ckb_bizon.Text) > 0);
            m_ckb_bounty.Enabled = statement && (int.Parse(m_ckb_bounty.Text) > 0);
            m_ckb_chips.Enabled = statement && (int.Parse(m_ckb_chips.Text) > 0);
            m_ckb_cola.Enabled = statement && (int.Parse(m_ckb_cola.Text) > 0);
            m_ckb_fanta.Enabled = statement && (int.Parse(m_ckb_fanta.Text) > 0);
            m_ckb_icetea.Enabled = statement && (int.Parse(m_ckb_icetea.Text) > 0);
            m_ckb_mars.Enabled = statement && (int.Parse(m_ckb_mars.Text) > 0);
            m_ckb_nzs.Enabled = statement && (int.Parse(m_ckb_nzs.Text) > 0);
            m_ckb_pepsi.Enabled = statement && (int.Parse(m_ckb_pepsi.Text) > 0);
            m_ckb_snickers.Enabled = statement && (int.Parse(m_ckb_snickers.Text) > 0);
            m_ckb_tutku.Enabled = statement && (int.Parse(m_ckb_tutku.Text) > 0);
        }

        private void m_btn_10qepik_Click(object sender, EventArgs e)
        {
            if (sender is MaterialButton mb)
            {
                if (materialProgressBar1.Value == 100)
                    return;

                if (mb.Text == "10 q")
                    if (double.Parse(m_lbl_mebleg.Text) + 0.1 <= MaxMoney)
                        m_lbl_mebleg.Text = (double.Parse(m_lbl_mebleg.Text) + 0.1).ToString();

                if (mb.Text == "20 q")
                    if (double.Parse(m_lbl_mebleg.Text) + 0.2 <= MaxMoney)
                        m_lbl_mebleg.Text = (double.Parse(m_lbl_mebleg.Text) + 0.2).ToString();

                if (mb.Text == "50 q")
                    if (double.Parse(m_lbl_mebleg.Text) + 0.5 <= MaxMoney)
                        m_lbl_mebleg.Text = (double.Parse(m_lbl_mebleg.Text) + 0.5).ToString();

                if (mb.Text == "1 azn")
                    if (double.Parse(m_lbl_mebleg.Text) + 1 <= MaxMoney)
                        m_lbl_mebleg.Text = (double.Parse(m_lbl_mebleg.Text) + 1).ToString();

                if (mb.Text == "5 azn")
                    if (double.Parse(m_lbl_mebleg.Text) + 5 <= MaxMoney)
                        m_lbl_mebleg.Text = (double.Parse(m_lbl_mebleg.Text) + 5).ToString();

                if (mb.Text == "10 azn")
                    if (double.Parse(m_lbl_mebleg.Text) + 10 <= MaxMoney)
                        m_lbl_mebleg.Text = (double.Parse(m_lbl_mebleg.Text) + 10).ToString();

                materialProgressBar1.Value = (int)double.Parse(m_lbl_mebleg.Text);
                CurrentMoney = double.Parse(m_lbl_mebleg.Text);
                CheckTrueMoney(double.Parse(m_lbl_mebleg.Text) >= 1);
            }
        }

        private void m_ckb_cola_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_cola.Checked)
                CurrentMoney--;
            else if (m_ckb_cola.Checked == false && m_ckb_cola.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_chips_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_chips.Checked)
                CurrentMoney--;
            else
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_fanta.Checked)
                CurrentMoney--;
            else if (m_ckb_fanta.Checked == false && m_ckb_fanta.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_icetea_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_icetea.Checked)
                CurrentMoney--;
            else if (m_ckb_icetea.Checked == false && m_ckb_icetea.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_mars_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_mars.Checked)
                CurrentMoney--;
            else if (m_ckb_mars.Checked == false && m_ckb_mars.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_tutku_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_tutku.Checked)
                CurrentMoney--;
            else if (m_ckb_tutku.Checked == false && m_ckb_tutku.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_albeni_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_albeni.Checked)
                CurrentMoney--;
            else if (m_ckb_albeni.Checked == false && m_ckb_albeni.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_snickers_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_snickers.Checked)
                CurrentMoney--;
            else if (m_ckb_snickers.Checked == false && m_ckb_snickers.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_bounty_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_bounty.Checked)
                CurrentMoney--;
            else if (m_ckb_bounty.Checked == false && m_ckb_bounty.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_bizon_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_bizon.Checked)
                CurrentMoney--;
            else if (m_ckb_bizon.Checked == false && m_ckb_bizon.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_nzs_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_nzs.Checked)
                CurrentMoney--;
            else if (m_ckb_nzs.Checked == false && m_ckb_nzs.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void m_ckb_pepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ckb_pepsi.Checked)
                CurrentMoney--;
            else if (m_ckb_pepsi.Checked == false && m_ckb_pepsi.Enabled == true)
                CurrentMoney++;
            m_lbl_qaliq.Text = CurrentMoney.ToString();
            CheckTrueMoney(CurrentMoney >= 1);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            List<string> foods = new List<string>();
            if (m_ckb_cola.Checked)
            {
                stock["Cola"]--;
                foods.Add("Cola");
            }
            if (m_ckb_pepsi.Checked)
            {
                stock["Pepsi"]--;
                foods.Add("Pepsi");
            }
            if (m_ckb_fanta.Checked)
            {
                stock["Fanta"]--;
                foods.Add("Fanta");
            }
            if (m_ckb_icetea.Checked)
            {
                stock["Ice Tea"]--;
                foods.Add("Ice Tea");
            }
            if (m_ckb_snickers.Checked)
            {
                stock["Snickers"]--;
                foods.Add("Snickers");
            }
            if (m_ckb_albeni.Checked)
            {
                stock["Albeni"]--;
                foods.Add("Albeni");
            }
            if (m_ckb_tutku.Checked)
            {
                stock["Tutqu"]--;
                foods.Add("Tutqu");
            }
            if (m_ckb_mars.Checked)
            {
                stock["Mars"]--;
                foods.Add("Mars");
            }
            if (m_ckb_bounty.Checked)
            {
                stock["Bounty"]--;
                foods.Add("Bounty");
            }
            if (m_ckb_bizon.Checked)
            {
                stock["Bizon"]--;
                foods.Add("Bizon");
            }
            if (m_ckb_nzs.Checked)
            {
                stock["NZS"]--;
                foods.Add("NZS");
            }
            if (m_ckb_chips.Checked)
            {
                stock["Chips"]--;
                foods.Add("Chips");
            }

            var str = JsonConvert.SerializeObject(stock, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("stock.json", str);

            user = new User("Murad", foods, double.Parse(m_lbl_mebleg.Text), CurrentMoney, DateTime.Now);

            var str1 = JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("user.json", str1);

            MessageBox.Show($"Size {CurrentMoney} AZN pul qaytarildi.");
            Form1_Load(sender, e);
        }
    }
}
