using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace $safeprojectname$
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            b.Click += Test2;
        }

        private void Test2(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public List<string> Test(string sdsf)
        {
            List<string> d = new List<string>();
            var liness = Regex.Matches(sdsf, "\\^FD(.+)(\\^FS)");
            foreach (Match l in liness)
                d.Add(l.Value.Replace("^FS", "").Replace("^FD",""));
            return d;
        }
    }
}
//