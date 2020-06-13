using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns1
{
    public sealed class Filereader
    {
        private static Filereader instance = null;
        // Thread-safe implementation using a lock on a shared object
        private static readonly object padlock = new object();
        string _path { get; set;}


        Filereader()
        {
        }

        public static Filereader Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Filereader();
                    }
                }
                return instance;
            }
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
                return null;
            }

            return _lines;
        }
    }
}
