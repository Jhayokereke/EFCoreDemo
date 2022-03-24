using EFCoreDemo.UI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreDemo.UI
{
    public partial class BaseForm : Form
    {
        private readonly IFellowService fellowService;

        public BaseForm(IFellowService fellowService)
        {
            InitializeComponent();
            this.fellowService = fellowService;
        }

        private void AF_btn_Click(object sender, EventArgs e)
        {
            new RegistrationForm(fellowService).Show();
        }

        private void VF_btn_Click(object sender, EventArgs e)
        {
            new ViewForm(fellowService).Show();
        }
    }
}
