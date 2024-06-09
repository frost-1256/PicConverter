using System.Drawing.Imaging;

namespace PicConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rightPanel.AllowDrop = true;
            leftPanel.AllowDrop = true;
        }

        private void leftPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void leftPanel_DragDrop(object sender, DragEventArgs e)
        {
            ConvertDroppedFiles(e.Data.GetData(DataFormats.FileDrop), ImageFormat.Png, leftPanel);
        }

        private void rightPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void rightPanel_DragDrop(object sender, DragEventArgs e)
        {
            ConvertDroppedFiles(e.Data.GetData(DataFormats.FileDrop), ImageFormat.Icon, rightPanel);
        }

        private void ConvertDroppedFiles(object data, ImageFormat format, Panel panel)
        {
            string[] files = (string[])data;

            foreach (string file in files)
            {
                try
                {
                    // �摜�t�@�C���ȊO�̏ꍇ
                    if (!IsImageFile(file))
                    {
                        MessageBox.Show("�摜������₪��", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    using (Image image = Image.FromFile(file))
                    {
                        string outputDirectory = Path.GetDirectoryName(file);
                        string outputFileName = $"{Path.GetFileNameWithoutExtension(file)}.{(format == ImageFormat.Icon ? "ico" : format.ToString().ToLower())}";
                        string outputFilePath = Path.Combine(outputDirectory, outputFileName);

                        if (File.Exists(outputFilePath))
                        {
                            DialogResult result = MessageBox.Show($"�t�@�C�� '{outputFileName}' �͊��ɑ��݂��܂��B�㏑�����܂���?", "�m�F", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.Cancel)
                            {
                                continue; // ���̃t�@�C���ɐi��
                            }
                            else if (result == DialogResult.No)
                            {
                                // �ʖ��ŕۑ�����
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.FileName = outputFileName;
                                saveFileDialog.InitialDirectory = outputDirectory;
                                saveFileDialog.Filter = $"{format.ToString()} �t�@�C�� (*{format.ToString().ToLower()})|*{format.ToString().ToLower()}";

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    outputFilePath = saveFileDialog.FileName;
                                }
                                else
                                {
                                    continue; // �L�����Z�����ꂽ�ꍇ�͎��̃t�@�C���ɐi��
                                }
                            }
                        }

                        image.Save(outputFilePath, format);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif" || extension == ".tiff";
        }
    }
}
