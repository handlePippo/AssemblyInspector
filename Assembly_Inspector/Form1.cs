using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace AssemblyInspector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "File Name|*.dll;*.exe";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            string pathName = openFileDialog1.FileName;
            if (pathName != string.Empty && (sender as Button).Tag is "Methods")
            {
                textBox1.Text = string.Empty;
                IInspector<MethodInfo> inspector = new Inspector<MethodInfo>();
                List<MethodInfo> methods = inspector.InspectAssemblyMethods(pathName);
                foreach (MethodInfo method in methods)
                {
                    textBox1.Text += method.Name + "\r\n";
                }
                return;
            }
            else if (pathName != string.Empty && (sender as Button).Tag is "Attributes")
            {
                textBox1.Text = string.Empty;
                IInspector<Attribute> inspector = new Inspector<Attribute>();
                List<Attribute> attributes = inspector.InspectAssemblyAttributes(pathName);
                foreach (Attribute attribute in attributes)
                {
                    textBox1.Text += attribute.ToString() + "\r\n";
                }
                return;
            }
            return;
        }
        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
