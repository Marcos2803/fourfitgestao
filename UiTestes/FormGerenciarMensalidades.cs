﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiTestes
{
    public partial class FormGerenciarMensalidades : Form
    {
        public FormGerenciarMensalidades()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMensalidades formMensalidades = new FormMensalidades();
            formMensalidades.ShowDialog();
        }
    }
}
