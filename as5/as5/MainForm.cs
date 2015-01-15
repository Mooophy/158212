using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace as5
{
    public partial class MainForm : Form
    {
        Dictionary<int, string> _dic;
        public MainForm()
        {
            InitializeComponent();

            _dic = new Dictionary<int, string>();
            _dic[1] = "test";
            _dic[2] = "test2";

            var arr = from row in _dic select new { Item = row.Key, Price = row.Value, Remark = 0 };
            grid.DataSource = arr.ToArray();
            grid.ForeColor = Color.Aqua;
            grid.AutoSize = true;
            grid.AllowUserToAddRows = true;
            

            grid.BackgroundColor = Color.Azure;
            grid.RowHeaderMouseClick += delegate{ MessageBox.Show("test"); };
            grid.ColumnHeaderMouseClick += delegate { MessageBox.Show("test2"); };
        }
    }
}
