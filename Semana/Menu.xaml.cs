using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Semana
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OperationsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem != null && selectedItem.Content.ToString() == "Salida")
            {
                Operaciones operaciones = new Operaciones();
                operaciones.ShowDialog();
                comboBox.SelectedIndex = -1; 
            }
        }

        private void MaintenanceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem != null)
            {
                if (selectedItem.Content.ToString() == "Camiones")
                {
                    Camiones camiones = new Camiones();
                    camiones.ShowDialog();
                    comboBox.SelectedIndex = -1;
                }
                else if (selectedItem.Content.ToString() == "Conductores")
                {
                    Conductores conductores = new Conductores();
                    conductores.ShowDialog();
                    comboBox.SelectedIndex = -1;
                }
            }
        }


        private void ReportsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem != null && selectedItem.Content.ToString() == "Salida")
            {
                MessageBox.Show("Acción para " + selectedItem.Content + "...");
                comboBox.SelectedIndex = -1; 
            }
        }
    }
}