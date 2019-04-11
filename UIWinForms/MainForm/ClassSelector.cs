using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Views.Views.Interfaces;

namespace UIWinForms
{
    public partial class ClassSelector : MetroFramework.Controls.MetroUserControl, IClassSelectorView
    {
        
        public ClassSelector()
        {
            InitializeComponent();
        }
    }
}
