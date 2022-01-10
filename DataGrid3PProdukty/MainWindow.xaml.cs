using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGrid3PProdukty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("Pan Tadeusz", true, 20, "klasyka"));
            ListaProduktow.Add(new Produkt("Lalka",true,25,"klasyka"));
            ListaProduktow.Add(new Produkt("Kamienie na szaniec",false,15,"sensacyjna"));
            ListaProduktow.Add(new Produkt("Diuna",true,24,"fantastyka"));
            ListaProduktow.Add(new Produkt("Hobbit",false,15,"fantastyka"));
            gridProdukty.ItemsSource = ListaProduktow;
            ObservableCollection<string> ListaKategorii = new ObservableCollection<string>()
            { "klasyka","sensacyjna","fantastyka","obyczajowe","dramaty"};
            KategorieComboBox.ItemsSource = ListaKategorii;
        }
    }
}
