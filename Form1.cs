using System.Windows.Forms;
using System;
using IronOcr;

namespace ReadImageText
{
    public partial class ReadImageText : Form
    {
        public ReadImageText()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var Ocr = new AutoOcr();
            var Result = Ocr.Read(imagePath.Text);
            var saveFile = imagePath.Text + ".txt";
            outputTextBox.Text = Result.Text;
            Result.SaveAsTextFile(saveFile);
        }
    }
}
