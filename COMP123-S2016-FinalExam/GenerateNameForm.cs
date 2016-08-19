using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {

        }
        public static void GenerateNames()
        {
            show.FirstNameListBox 
                show.LastNameListBox
        }

        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     /*
     * @method NextButton_Click
     * @param {object
    }
    sender
    * @param
    { EventArgs }
    e
    */
        private void NextButton_Click(object sender, EventArgs e)
    {
        AbilityGeneratorForm abilityform = (abilityform)FirstNameLabel.SelectedItem;
        AbilityGeneratorForm abilityform = new AbilityGeneratorForm(abilityform);
        abilityform.Show();

        this.Close();
    }
}
    }
}
