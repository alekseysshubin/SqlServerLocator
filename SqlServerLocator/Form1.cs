using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServerLocator
{
    public partial class Form1 : Form
    {
        private readonly Locator _locator = new Locator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestButton.Visible = false;
        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            var instances = await Task.Run(() => _locator.GetLocal());
            foreach (var instance in instances)
            {
                ServersListBox.Items.Add(instance);
            }
        }

        private void ServersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestButton.Visible = ServersListBox.SelectedItem != null;
        }

        private async void TestButton_Click(object sender, EventArgs e)
        {
            var server = (string)ServersListBox.SelectedItem;
            var result = await Task.Run(() => _locator.TestConnection(server));
            MessageBox.Show(result ? "Connected!" : "Cannot connect");
        }
    }
}
