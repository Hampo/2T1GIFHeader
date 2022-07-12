using System.Drawing.Imaging;

namespace _2T1GIFHeader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtInputGIF_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                FileName = TxtInputGIF.Text,
                Filter = "GIF Images|*.gif",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                Title = "Choose input GIF"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
                TxtInputGIF.Text = ofd.FileName;
        }

        private void TxtOutputFolder_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new()
            {
                SelectedPath = TxtOutputFolder.Text,
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PopstarDevs", "2Take1Menu", "scripts", "GIFHeader"),
                ShowNewFolderButton = true,
            };
            if (fbd.ShowDialog() == DialogResult.OK)
                TxtOutputFolder.Text = fbd.SelectedPath;
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtInputGIF.Text))
            {
                MessageBox.Show("You must choose an input GIF.", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtOutputFolder.Text))
            {
                MessageBox.Show("You must choose an output folder.", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(TxtInputGIF.Text))
            {
                MessageBox.Show("Could not find input GIF at the selected path.", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DirectoryInfo dir;
            try
            {
                dir = Directory.CreateDirectory(TxtOutputFolder.Text);
                if (dir == null)
                {
                    MessageBox.Show($"Could not create the output folder.", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error creating the output folder: {ex}", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                using Image gif = Image.FromFile(TxtInputGIF.Text);

                FrameDimension fd = new(gif.FrameDimensionsList.First());
                int frameCount = gif.GetFrameCount(fd);

                if (frameCount == 0)
                {
                    MessageBox.Show("No frames found in input GIF.", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int padding = frameCount.ToString().Length;

                byte[]? lengths = gif.GetPropertyItem(0x5100)?.Value;
                if (lengths == null)
                {
                    MessageBox.Show("Could not find frame lengths.", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string rootDir = dir.FullName;
                for (int i = 0; i < frameCount; i++)
                {
                    gif.SelectActiveFrame(fd, i);
                    int length = BitConverter.ToInt32(lengths, 4 * i) * 10;
                    using Bitmap bmp = (Bitmap)gif.Clone();
                    bmp.Save(Path.Combine(rootDir, $"{(i + 1).ToString().PadLeft(padding, '0')}_{length}.gif"), ImageFormat.Gif);
                }

                MessageBox.Show($"Successfully exported {frameCount} frames.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error processing the GIF: {ex}", "Error processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}