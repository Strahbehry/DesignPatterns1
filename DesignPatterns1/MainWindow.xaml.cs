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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Reflection;

namespace DesignPatterns1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] _files;
        public MainWindow()
        {
            InitializeComponent();
            fillCircuitList();

        }

        private void fillCircuitList()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            _files = Directory.GetFiles(projectDirectory + @"\Circuits");
            foreach (string file in _files)
            {
                CircuitList.Items.Add(System.IO.Path.GetFileName(file));
            }
        }

        private void CircuitList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filereader filereader = new Filereader();
            filereader.setFilePath(_files[CircuitList.SelectedIndex]);
        }
    }
}
