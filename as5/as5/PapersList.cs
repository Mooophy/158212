using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as5
{
    internal class PapersList : Form
    {
        internal ListBox list;
        public PapersList()
        {
            this.InitializeComponent();
            this.list.MouseDoubleClick += delegate { this.Hide(); };
        }

        internal int? GetSelectedPaperCode()
        {
            if (this.list.SelectedItem != null)
                return Convert.ToInt32(list.GetItemText(list.SelectedItem));
            else
                return null;
        }

        internal void Populate(string[] papers)
        {
            this.list.Items.Clear();
            this.list.Items.AddRange(papers);
            this.list.ClearSelected();
        }

        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 12;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(229, 72);
            this.list.TabIndex = 0;
            // 
            // PapersList
            // 
            this.ClientSize = new System.Drawing.Size(229, 72);
            this.Controls.Add(this.list);
            this.Name = "PapersList";
            this.Text = "Paper List";
            this.ResumeLayout(false);
        }
    }
}
