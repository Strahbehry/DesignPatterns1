using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns1
{
    public class Filereader
    {
        string _path;
        
        public Filereader()
        {
        }

        public void setFilePath(string path)
        {
            _path = path;
        }

        public string[] readFile()
        {
            string[] _lines = null;
            if (_path == null)
            {
                MessageBox.Show("Please select the Circuit");
            }

            try
            {
                _lines = File.ReadAllLines(_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with reading the file: " + ex.Message);
            }

            return _lines;
        }
    }
}
