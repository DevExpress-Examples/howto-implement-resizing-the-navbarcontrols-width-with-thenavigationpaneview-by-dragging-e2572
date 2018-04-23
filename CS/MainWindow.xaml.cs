using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.NavBar;

namespace DXWpfApplication
{
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            double minWidth = 100;

            double newWidth = navBar.ActualWidth + e.HorizontalChange;

            if (newWidth >= minWidth)
            {
                if (!view.IsExpanded)
                    view.IsExpanded = true;
                navBar.MaxWidth = newWidth;
            }

            else if (newWidth < minWidth && e.HorizontalChange < 0)
            {
                view.IsExpanded = false;
                thumb.CancelDrag();
            }
            
        }
    }

}
