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
using DesignPatterns1.Models;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using DesignPatterns1.Validators;

namespace DesignPatterns1
{

    public partial class MainWindow : Window
    {
        Help helpWindow;
        string[] _files;
        CircuitBoard circuitBoard;

        public GViewer Viewer { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            fillCircuitList();

            Viewer = new GViewer();

            graphForm.Child = Viewer;
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
            Filereader.Instance.setFilePath(_files[CircuitList.SelectedIndex]);
        }

        private void ShowCircuitBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = Filereader.Instance.readFile();
            circuitBoard = Fileparser.Instance.ParseCircuit(lines);

            if(circuitBoard != null)
                drawCircuit();
        }

        private void drawCircuit()
        {
            Graph graph = new Graph("circuit");

            circuitBoard.Accept(new DrawGraph(graph));
            graph.Attr.LayerDirection = LayerDirection.LR;
            Viewer.Graph = graph;

            try
            {
                circuitBoard.Accept(new InfiniteLoopValidator(circuitBoard));
                circuitBoard.Accept(new NoDeadEndValidator(circuitBoard));
            }
            catch
            {
                // Errors are handled in Exceptions
            }
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            helpWindow = new Help(this);
            helpWindow.Show();
        }
    }
}
