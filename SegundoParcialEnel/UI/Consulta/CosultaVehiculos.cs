using SegundoParcialEnel.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcialEnel.UI.Consulta
{
    public partial class CosultaVehiculos : Form
    {
        public CosultaVehiculos()
        {
            InitializeComponent();
        }

        private void Buscar1button_Click(object sender, EventArgs e)
        {
            Expression<Func<Vehiculos, bool>> filtro = x => true;
            int id;
            if (CriteriotextBox.Text == string.Empty && FiltrocomboBox.SelectedIndex != 2)
            {
                MessageBox.Show("Digite el criterio", "Debe introducir el criterio",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: //id
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.VehiculoID == id;
                    break;

                case 1: //Descripcion
                    string d = CriteriotextBox.Text;
                    filtro = x => x.Descripcion == d;

                    break;

                case 2://todo
                    ConsulVehiculosdataGridView.DataSource = BLL.VehiculosBLL.GetList(filtro);
                    break;
            }
            ConsulVehiculosdataGridView.DataSource = BLL.VehiculosBLL.GetList(filtro);
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 2)
            {
                CriteriotextBox.Enabled = false;
            }
            else
                CriteriotextBox.Enabled = true;
        }
    }
    }

