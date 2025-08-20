using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create a label and set its properties
            var helloLabel = new Label
            {
                Text = "Hello World",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20) // Position on the form
            };

            // Add the label to the form's controls
            this.Controls.Add(helloLabel);
        }
    }
}
