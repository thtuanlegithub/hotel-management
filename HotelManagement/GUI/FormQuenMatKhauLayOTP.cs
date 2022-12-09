﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class FormQuenMatKhauLayOTP : Form
    {
        private FormLogin formLoginParent;
        public FormQuenMatKhauLayOTP(FormLogin formMain)
        {
            InitializeComponent();
            this.formLoginParent = formMain;
         }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormDangNhap(formLoginParent));
        }
        bool checkUsernameAndEmail()
        {
            return true;
        }
        private void ButtonLayOTP_Click(object sender, EventArgs e)
        {
            if (checkUsernameAndEmail())
            {
                formLoginParent.openChildForm(new FormQuenMatKhauNhapOTP(formLoginParent));
            }
        }
    }
}
