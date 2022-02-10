using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace hellowin;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        button1.Click += button1_Click;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        button1.Text = "Hello World!";
    }
}
