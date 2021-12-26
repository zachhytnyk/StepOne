using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepOne
{
    public partial class GenPassword : Form
    {
        public GenPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenSetting genSetting = new GenSetting()
            {
                lengthPasword = int.Parse(numericUpDown1.Value.ToString()),
                CapEngLettersCheck = CapEngLettersCheck.Checked,
                engLetterCheck=engLetterCheck.Checked,
                CapRuLattersCheck=CapRuLattersCheck.Checked,
                SpecialSymbolsCheck=SpecialSymbolsCheck.Checked,
                RuLattersCheck=RuLattersCheck.Checked,
                NumbersCheck=NumbersCheck.Checked,
                AllCheck=AllCheck.Checked
            };
            richTextBox1.Text= genSetting.Run();
        }
    }
}
