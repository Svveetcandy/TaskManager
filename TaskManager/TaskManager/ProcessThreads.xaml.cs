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
using System.Diagnostics;
using TaskManager.ProcessData;

namespace TaskManager
{
    public partial class ProcessThreads : Window
    {
        public ProcessThreads(string procName)
        {
            InitializeComponent();
            Process proc = Process.GetProcessesByName(procName)[0];
            ProcessThreadCollection processThreads = proc.Threads;
            foreach (ProcessThread thread in processThreads)
            {
                listOfThreads.Items.Add(new ThreadModel(thread));
            }
        }
    }
}
