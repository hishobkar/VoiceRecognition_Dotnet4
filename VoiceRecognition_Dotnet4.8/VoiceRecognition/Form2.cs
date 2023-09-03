using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoiceRecognition
{
    public partial class Form2 : Form
    {
        public void addData(string _data)
        {
            this.lb_process.Items.Add(_data);
        }
        public void clearCommand()
        {
            this.lb_process.Items.Clear();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
