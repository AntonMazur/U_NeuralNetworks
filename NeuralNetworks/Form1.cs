using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworks.src;
using hamming = NeuralNetworks.src.networks.hamming;
using hebb = NeuralNetworks.src.networks.hebb;
using NeuralNetworks.src.networks;

namespace NeuralNetworks
{
    public partial class Form1 : Form
    {
        Point lastPoint = Point.Empty;
        bool isMousePressed = false;
        ToolStripMenuItem lastChecked;
        ToolStripMenuItem choosenNetwork;
        FormState state = new FormState();
        

        public Form1()
        {
            InitializeComponent();
            lastChecked = toolStripMenuItem4;
            toolStripMenuItem4.Checked = true;
            state.segCount = 4;
            choosenNetwork = сетьХеммингаToolStripMenuItem;
            сетьХеммингаToolStripMenuItem.Checked = true;
            //rbthHamming.Checked = true;
        }

        private void picBoxInit_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMousePressed = true;
        }

        private void picBoxInit_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMousePressed || lastPoint.IsEmpty)
            {
                return;
            }

            using (Graphics g = Graphics.FromImage(getInitImage()))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var location = e.Location;
                var drownPoint = rectangleAroundPoint(location, 50);
                g.FillRectangle(new SolidBrush(Color.DarkBlue), drownPoint);
                lastPoint = location;
            }

            picBoxInit.Invalidate();

        }

        private RectangleF rectangleAroundPoint(Point p, int sideLength)
        {
            return new RectangleF(new Point(p.X - sideLength / 2, p.Y - sideLength / 2), new Size(sideLength, sideLength));
        }

        private void picBoxInit_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            lastPoint = Point.Empty;
            picBoxInit.Invalidate();
        }

        private Image getInitImage()
        {
            if (picBoxInit.Image == null)
            {
                picBoxInit.Image = new Bitmap(picBoxInit.Width, picBoxInit.Height);
            }

            return picBoxInit.Image;
        }

        private MonoImage getWorkingImage()
        {
            return new MonoImage(getInitImage(), state.segCount, state.segCount);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.state.samples.Count() != 0)
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        var bytesToWrite = Encoding.UTF8.GetBytes(state.ToString());
                        myStream.Write(bytesToWrite, 0, bytesToWrite.Length);
                        myStream.Close();
                    }
                }
            }
        }

        private void загрузитьОбразцыИзФайлаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofd.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    foreach (var line in text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.None))
                    {
                        state.addSample(line == "" ? null : Sample.FromString(line));
                    }
                    MessageBox.Show("sample are loaded !!!");
                }
                catch (IOException)
                {
                }
            }
        }

        private void очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state.samples.Clear();
        }

        private void показатьОбрабатываемоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var workingImage = getWorkingImage();
            picBoxCropped.Image = workingImage.getCompressedImage();
            this.state.pbState = new WorkingPicBoxState(workingImage.getCompressedImageArr());
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBoxInit.Image = null;
            Invalidate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            changedSegmentCount(sender);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            changedSegmentCount(sender);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            changedSegmentCount(sender);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            changedSegmentCount(sender);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            changedSegmentCount(sender);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            changedSegmentCount(sender);
        }

        private void changedSegmentCount(object sender)
        {
            var menuItem = (ToolStripMenuItem)sender;
            state.segCount = int.Parse(menuItem.Text);
            menuItem.Checked = true;
            lastChecked.Checked = false;
            lastChecked = menuItem;
        }

        private void сетьХеббаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changedNetwork(sender);
        }

        private void сетьХеммингаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changedNetwork(sender);
        }

        private void changedNetwork(object sender)
        {
            var menuItem = (ToolStripMenuItem)sender;
            choosenNetwork.Checked = false;
            choosenNetwork = menuItem;
            menuItem.Checked = true;
        }

        private void сохранитьКакОбразецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            показатьОбрабатываемоеToolStripMenuItem_Click(sender, e);

            var descriptionForm = new SampleDescriptionForm();
            descriptionForm.ShowDialog();

            state.addSample(new Sample(descriptionForm.getInput(), state.pbState.imgArr));
        }

        private void обучитьСетьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (choosenNetwork.Text)
            {
                case "Сеть Хэбба":
                    hebb.Network.learn(state.samples.ToArray());
                    break;
                default:
                    return;
            }
        }

        private void запускСетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            показатьОбрабатываемоеToolStripMenuItem_Click(sender, e);
            var testSample = new Sample("Test sample", state.pbState.imgArr);
            Sample targetSample = null;

            switch (choosenNetwork.Text)
            {
                case "Сеть Хэмминга":
                    targetSample = hamming.Network.run(state.samples.ToArray(), new Sample("Test sample", state.pbState.imgArr));
                    break;
                case "Сеть Хэбба":
                    targetSample = hebb.Network.run(state.samples.ToArray(), testSample);
                    break;
                default:
                    throw new NotImplementedException();
            }

            pbResult.Image = MonoImage.getCompressedImage(targetSample.imgArr);
            labelResDesc.Text = targetSample.description;
        }
    }

    class WorkingPicBoxState
    {
        public bool[,] imgArr;

        public WorkingPicBoxState(bool[,] imgArr)
        {
            this.imgArr = imgArr;
        }
    }

    class FormState
    {
        public WorkingPicBoxState pbState { get; set; }
        public List<Sample> samples = new List<Sample>();
        public int chosenNetwork = 1;
        public int segCount;

        public bool addSample(Sample sample)
        {
            if (sample == null) return false;
            samples.Add(sample);
            return true;
        }

        public override string ToString()
        {
            return String.Join("", samples.Select(s => s.ToString()));
        }

    }

    enum UsingNetwork
    {
        HAMMING,
        HEBB
    }
}
