using System;

using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1.Ulti {
    class Tool {

        public static DialogResult Show(string title, string promptText, ref string value) {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static void confirmExit(Form form) {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Techcombank", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes) {
                form.Close();
            } else {
                return;
            }
        }
        public static DialogResult dialogConfirm(String msg) {
            DialogResult dr = MessageBox.Show(msg, "Techcombank", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return dr;    
        }

        public static int DropDownWidth(ComboBox myCombo) {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items) {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth) {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }
        public static String getCurrentTime() {
            return DateTime.Now.ToString("HH:mm:ss tt, dd/MM/yyyy");
        }
       public static String formatTien(decimal tien) {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,0.## VNĐ}", tien);
        }

        public static void numberOnlyWarnming(TextBox textBox1) {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        public static void numberOnly(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }

        }









    }

}
