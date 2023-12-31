﻿using System;
using System.Windows.Forms;
using Sistema_De_Costos.Negocio;

namespace Sistema_De_Costos
{
    public partial class Form_Categorias : Form
    {
        public Form_Categorias()
        {
            InitializeComponent();
        }

        #region "Mis Métodos"
        private void Formato_ca()
        {
            //Se le da un formato para poder enlistar la información
            dataGridView_Principal.Columns[0].Width = 100;
            dataGridView_Principal.Columns[0].HeaderText = "CODIGO_CA";
            dataGridView_Principal.Columns[1].Width = 300;
            dataGridView_Principal.Columns[1].HeaderText = "CATEGORIA";
        }

        private void Listado_ca(string cTexto)
        {
            try
            {
                dataGridView_Principal.DataSource = N_Categorias.Listado_ca(cTexto);
                this.Formato_ca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void dataGridView_Principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
