using System;
using System.Windows;
using System.Windows.Controls;
using QBits.Intuition.Text;
using System.Reflection;
using QBits.Intuition.Assemblies;

namespace QuotaConverterWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = string.Format("Quota converter v{0}", AssemblyHelper.AssemblyVersion(WhichAssembly.ThisAssembly));
        }

        private void NumQuotaString_TextChanged(object sender, TextChangedEventArgs e)
        {
            double inValue;
            if (double.TryParse(NumQuotaString.Text, out inValue))
            {
                string quotaString = FinancialHelper.ConvertQuotaToText(inValue);
                QuotaText.Text = quotaString;
            }
        }
    }
}
