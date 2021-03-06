﻿using System;
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
using System.Diagnostics;
using TaskManager.ProcessData;

namespace TaskManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int count = 0;

            foreach (Process process in Process.GetProcesses())
            {
                listOfProcesses.Items.Add(new ProcessModel(process));
                count++;
            }
            AllProcess.Text = count.ToString();
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Controls.ListViewItem item = sender as System.Windows.Controls.ListViewItem;
            if (item != null && item.IsSelected)
            {
                ProcessModel selectedProc = listOfProcesses.SelectedItem as ProcessModel;
                ProcessThreads processThreadWindow = new ProcessThreads(selectedProc.name);
                processThreadWindow.Show();
            }
        }
    }
}
