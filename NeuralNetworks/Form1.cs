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
        FormState state = new FormState();
        

        public Form1()
        {
            InitializeComponent();
            rbthHamming.Checked = true;
            compImageResolution.SelectedItem = compImageResolution.Items[0];
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

        private void btnClearInitPB_Click(object sender, EventArgs e)
        {
            picBoxInit.Image = null;
            Invalidate();
        }

        private Image getInitImage()
        {
            if (picBoxInit.Image == null)
            {
                picBoxInit.Image = new Bitmap(picBoxInit.Width, picBoxInit.Height);
            }

            return picBoxInit.Image;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            showInputImage_Click(sender, e);

            Sample targetSample = null;

            switch (state.chosenNetwork)
            {
                case 1:
                    targetSample = hamming.Network.run(state.samples.ToArray(), new Sample("Test sample", state.pbState.imgArr));
                    break;
                case 0:
                    break;
                default:
                    throw new NotImplementedException();
            }

            pbResult.Image = MonoImage.getCompressedImage(targetSample.imgArr);
            labelResDesc.Text = targetSample.description;
        }

        private MonoImage getWorkingImage()
        {
            int[] widthAndHeight = compImageResolution.Text.Split(';').Select(str => int.Parse(str)).ToArray();
            return new MonoImage(getInitImage(), widthAndHeight[0], widthAndHeight[1]);
        }

        private void btnSaveSampleToFile_Click(object sender, EventArgs e)
        {
            if (this.state.pbState != null)
            {
                var descriptionForm = new SampleDescriptionForm();
                descriptionForm.ShowDialog();
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
                MessageBox.Show(descriptionForm.getInput());
            }
        }

        private void btnLoadSamplesFromFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog(); 
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofd.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    foreach (var line in text.Split('\n'))
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

        private void btnAddToSamples_Click(object sender, EventArgs e)
        {
            showInputImage_Click(sender, e);

            var descriptionForm = new SampleDescriptionForm();
            descriptionForm.ShowDialog();

            state.addSample(new Sample(descriptionForm.getInput(), state.pbState.imgArr));
        }

        private void showInputImage_Click(object sender, EventArgs e)
        {
            var workingImage = getWorkingImage();
            picBoxCropped.Image = workingImage.getCompressedImage();
            this.state.pbState = new WorkingPicBoxState(workingImage.getCompressedImageArr());
        }

        private void btnResetSamples_Click(object sender, EventArgs e)
        {
            state.samples.Clear();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (!rb.Checked) return;
            state.chosenNetwork = rb.Parent.Controls.IndexOf(rb);
            MessageBox.Show("Chosen network: " + state.chosenNetwork);
        }

        private void btnLearnNetwork_Click(object sender, EventArgs e)
        {
            switch (state.chosenNetwork)
            {
                case 1:
                    return;
                    break;
                case 0:
                    hebb.Network.
                    break;
                default:
                    throw new NotImplementedException();
            }
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
}
