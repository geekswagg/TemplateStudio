﻿using MahApps.Metro.Controls;
using Prism.Regions;
using Param_RootNamespace.Models;

namespace Param_RootNamespace.Views
{
    public partial class ShellPage : MetroWindow
    {
        public ShellPage(IRegionManager regionManager, AppConfig config)
        {
            InitializeComponent();
            RegionManager.SetRegionName(hamburgerMenuContentControl, config.MainRegion);
            RegionManager.SetRegionManager(hamburgerMenuContentControl, regionManager);
        }
    }
}
