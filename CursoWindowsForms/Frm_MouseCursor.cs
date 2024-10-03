﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_MouseCursor : Form
    {
        public Frm_MouseCursor()
        {
            InitializeComponent();
        }

        private void Btn_Cursor_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            for (int i = 0; i <= 10; i++)
            {
                Btn_Cursor.Text = i.ToString();
                System.Threading.Thread.Sleep(1000);
            }

            this.Cursor = Cursors.Default;
        }
    }
}
