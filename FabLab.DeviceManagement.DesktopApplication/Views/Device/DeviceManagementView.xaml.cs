﻿using FabLab.DeviceManagement.DesktopApplication.Core.Application.ViewModels.Device;
using NPOI.Util;
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

namespace FabLab.DeviceManagement.DesktopApplication.Views.Device
{
    /// <summary>
    /// Interaction logic for DeviceManagementView.xaml
    /// </summary>
    public partial class DeviceManagementView : UserControl
    {
        public DeviceManagementView()
        {
            InitializeComponent();       
        }

        private void DataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (sender is DataGrid dataGrid && e.OriginalSource is FrameworkElement frameworkElement && frameworkElement.DataContext == dataGrid.SelectedItem)
            //{
            //    if (dataGrid.RowDetailsVisibilityMode == DataGridRowDetailsVisibilityMode.VisibleWhenSelected)
            //        dataGrid.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Collapsed;
            //    else
            //        dataGrid.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.VisibleWhenSelected;
            //}
        }



    }
}
