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

namespace FlowDocs
{
    public partial class EditFlowDocument : Window
    {
        public EditFlowDocument()
        {
            InitializeComponent();
        }

        public FlowDocument DocumentResult { get; set; } = null;

        public static EditFlowDocument ShowDialog(Window owner)
        {
            var dlg = new EditFlowDocument();
            
            dlg.Owner = owner;
            dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dlg.ShowDialog();

            return dlg;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DocumentResult = richTextBox.Document;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DocumentResult = null;
            this.Close();
        }
    }
}
