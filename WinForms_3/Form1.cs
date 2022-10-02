namespace WinForms_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>()
            {
                "Premium",
                "A-95",
                "A-92",
                "Diesel",
                "Metan Gas",
                "Propan Gas"
            };
            cBox_benzin.DataSource = list;
        }


        private void calculateBenzin()
        {
            float mebleg = Convert.ToSingle(txt_benzin.Text);
            if (rBtn_litr.Checked)
                mebleg *= Convert.ToSingle(txt_litr.Text);
            else
                mebleg = Convert.ToSingle(txt_mebleg.Text) / mebleg;

            lbl_benzinSonMebleg.Text = mebleg.ToString();
            calculateAll();
        }

        private void calculateKafe()
        {
            float mebleg = 0;
            foreach (CheckBox item in gBox_kafe.Controls.OfType<CheckBox>())
            {
                if (item.Checked)
                    switch (item.Text)
                    {
                        case "Hot-Doq":
                            if (!string.IsNullOrEmpty(txt_hotdoqSay.Text))
                                mebleg += (float)4 * Convert.ToInt32(txt_hotdoqSay.Text);
                            break;
                        case "Hamburger":
                            if (!string.IsNullOrEmpty(txt_hamburgerSay.Text))
                                mebleg += (float)5.4 * Convert.ToInt32(txt_hamburgerSay.Text);
                            break;
                        case "Kartof-Fri":
                            if (!string.IsNullOrEmpty(txt_kartofSay.Text))
                                mebleg += (float)7.2 * Convert.ToInt32(txt_kartofSay.Text);
                            break;
                        case "Koka-Kola":
                            if (!string.IsNullOrEmpty(txt_kolaSay.Text))
                                mebleg += (float)4.4 * Convert.ToInt32(txt_kolaSay.Text);
                            break;
                    }
            }
            lbl_kafeSonMebleg.Text = mebleg.ToString();
            calculateAll();
        }

        private void calculateAll()
        {
            lbl_yekunMebleg.Text = (Convert.ToSingle(lbl_benzinSonMebleg.Text) + Convert.ToSingle(lbl_kafeSonMebleg.Text)).ToString();
        }



        private void cBox_benzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBox_benzin.SelectedItem)
            {
                case "Premium":
                    txt_benzin.Text = "2.00";
                    break;
                case "A-95":
                    txt_benzin.Text = "1.70";
                    break;
                case "A-92":
                    txt_benzin.Text = "1.00";
                    break;
                case "Diesel":
                    txt_benzin.Text = "0.80";
                    break;
                case "Metan Gas":
                    txt_benzin.Text = "0.65";
                    break;
                case "Propan Gas":
                    txt_benzin.Text = "0.65";
                    break;
            }
            calculateBenzin();
        }

        private void txt_litr_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_litr.Text) || string.IsNullOrEmpty(txt_litr.Text))
                txt_litr.Text = "0";
            else if (txt_litr.Text[0] == '0' && txt_litr.Text.Length > 1)
                txt_litr.Text = txt_litr.Text.Remove(0, 1);
            else if (!txt_litr.Text.All(c => (c >= '0' && c <= '9') || c == '.'))
                txt_litr.Text = txt_litr.Text.Remove(txt_litr.Text.Length - 1, 1);
            txt_litr.SelectionStart = txt_litr.Text.Length;
            calculateBenzin();
        }

        private void txt_mebleg_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mebleg.Text) || string.IsNullOrEmpty(txt_mebleg.Text))
                txt_mebleg.Text = "0";
            else if (txt_mebleg.Text[0] == '0' && txt_mebleg.Text.Length > 1)
                txt_mebleg.Text = txt_mebleg.Text.Remove(0, 1);
            if (!txt_mebleg.Text.All(c => (c >= '0' && c <= '9') || c == '.'))
                txt_mebleg.Text = txt_mebleg.Text.Remove(txt_mebleg.Text.Length - 1, 1);
            txt_mebleg.SelectionStart = txt_mebleg.Text.Length;
            calculateBenzin();
        }

        private void rBtn_litr_CheckedChanged(object sender, EventArgs e)
        {
            txt_litr.ReadOnly = !rBtn_litr.Checked;
            txt_mebleg.ReadOnly = rBtn_litr.Checked;
            calculateBenzin();
        }



        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            bool trueFalse = !cb.Checked;
            switch (cb.Text)
            {
                case "Hot-Doq":
                    txt_hotdoqSay.ReadOnly = trueFalse;
                    break;
                case "Hamburger":
                    txt_hamburgerSay.ReadOnly = trueFalse;
                    break;
                case "Kartof-Fri":
                    txt_kartofSay.ReadOnly = trueFalse;
                    break;
                case "Koka-Kola":
                    txt_kolaSay.ReadOnly = trueFalse;
                    break;
            }
            calculateKafe();
        }

        private void sayTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as MaskedTextBox).Text))
                calculateKafe();
        }



        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(lbl_yekunMebleg.Text) > 0)
                MessageBox.Show($"Siz BestOil-den {lbl_yekunMebleg.Text} AZN deyerinde alis-veris etdiniz.", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xahis olunur BestOil-i kecis olaraq istifade etmeyin...", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Environment.Exit(0);

        }
    }
}