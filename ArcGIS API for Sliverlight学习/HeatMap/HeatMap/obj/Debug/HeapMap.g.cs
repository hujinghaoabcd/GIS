﻿#pragma checksum "E:\学习\src\GIS学习\HeatMap\HeatMap\HeapMap.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "58CFBEDB9E547A7FE8130A4992C54129"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace HeatMap {
    
    
    public partial class HeapMap : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal ESRI.ArcGIS.Client.Map MyMap;
        
        internal System.Windows.Controls.TextBlock ResponseTextBlock;
        
        internal System.Windows.Controls.Slider MyIntensitySlider;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/HeatMap;component/HeapMap.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.MyMap = ((ESRI.ArcGIS.Client.Map)(this.FindName("MyMap")));
            this.ResponseTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("ResponseTextBlock")));
            this.MyIntensitySlider = ((System.Windows.Controls.Slider)(this.FindName("MyIntensitySlider")));
        }
    }
}

