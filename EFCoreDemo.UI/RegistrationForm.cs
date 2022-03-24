using EFCoreDemo.UI.Core;
using EFCoreDemo.UI.Entities;
using EFCoreDemo.UI.Models;
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
    public partial class RegistrationForm : Form
    {
        private readonly IFellowService _service;

        public RegistrationForm(IFellowService fellowService)
        {
            InitializeComponent();
            _service = fellowService;
        }

        private void Fname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var fellow = new RegisterFellowRequest
                {
                    Firstname = Fname_txt.Text,
                    Middlename = MName_txt.Text,
                    Lastname = LName_txt.Text,
                    StateId = int.Parse(State_txt.Text),
                    GenderId = int.Parse(Gender_txt.Text)
                };

                var resp = await _service.Register(fellow);

                if (resp) MessageBox.Show("Successful");
                else MessageBox.Show("Failed"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
            
        }
    }
}
