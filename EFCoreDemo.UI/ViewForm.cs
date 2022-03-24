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
    public partial class ViewForm : Form
    {
        private readonly IFellowService _service;

        public ViewForm(IFellowService fellowService)
        {
            InitializeComponent();
            _service = fellowService;
        }

        private async void GetAll_btn_Click(object sender, EventArgs e)
        {
            dotnet_tbl.DataSource = await _service.GetAll();
        }
    }
}
