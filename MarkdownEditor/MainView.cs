using System;
using System.IO;
using System.Windows.Forms;

namespace MarkdownEditor
{
    public partial class MainView : Form
    {
        const string AppName = "Markdown editor";
        string fileName;

        public MainView()
        {
            InitializeComponent();
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            renderer.DocumentText = MarkdownParser.Parse(editor.Text);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                editor.Text = sr.ReadToEnd();
                sr.Close();
            }
            fileName = openFileDialog.FileName;
            ActiveForm.Text = AppName + " - " + openFileDialog.FileName;
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Markdown (*.md)|*.md";
                saveFileDialog.DefaultExt = "md";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    ActiveForm.Text = AppName + " - " + saveFileDialog.FileName;
                }
                else return;
            }

            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(editor.Text);
            sw.Close();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            string insertText = "**";
            int selectionStart = editor.SelectionStart;
            int selectionStop = editor.SelectionStart + editor.SelectionLength + insertText.Length;

            editor.Text = editor.Text.Insert(selectionStart, insertText);
            editor.Text = editor.Text.Insert(selectionStop, insertText);
            editor.SelectionStart = selectionStop + insertText.Length;
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            string insertText = "*";
            int selectionStart = editor.SelectionStart;
            int selectionStop = editor.SelectionStart + editor.SelectionLength + insertText.Length;

            editor.Text = editor.Text.Insert(selectionStart, insertText);
            editor.Text = editor.Text.Insert(selectionStop, insertText);
            editor.SelectionStart = selectionStop + insertText.Length;
        }

        private void unorderedListButton_Click(object sender, EventArgs e)
        {
            string insertText = "- ";
            int selectionStart = editor.GetFirstCharIndexOfCurrentLine();

            editor.Text = editor.Text.Insert(selectionStart, insertText);
            editor.SelectionStart = selectionStart + insertText.Length;
        }

        private void orderedListButton_Click(object sender, EventArgs e)
        {
            string insertText = "1. ";
            int selectionStart = editor.GetFirstCharIndexOfCurrentLine();

            editor.Text = editor.Text.Insert(selectionStart, insertText);
            editor.SelectionStart = selectionStart + insertText.Length;
        }

        private void insertHeading(int level)
        {
            string insertText = "";
            for (int i = 0; i < level; i++)
            {
                insertText += '#';
            }
            insertText += " ";
            int selectionStart = editor.GetFirstCharIndexOfCurrentLine();

            editor.Text = editor.Text.Insert(selectionStart, insertText);
            editor.SelectionStart = selectionStart + level + 1;

        }

        private void heading1Button_Click(object sender, EventArgs e) { insertHeading(1); }
        private void heading2Button_Click(object sender, EventArgs e) { insertHeading(2); }
        private void heading3Button_Click(object sender, EventArgs e) { insertHeading(3); }
        private void heading4Button_Click(object sender, EventArgs e) { insertHeading(4); }
        private void heading5Button_Click(object sender, EventArgs e) { insertHeading(5); }
        private void heading6Button_Click(object sender, EventArgs e) { insertHeading(6); }
    }
}
