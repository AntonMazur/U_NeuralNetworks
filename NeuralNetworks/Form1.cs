using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworks.src;

namespace NeuralNetworks
{
    public partial class Form1 : Form
    {
        Point lastPoint = Point.Empty;
        bool isMousePressed = false;

        public Form1()
        {
            InitializeComponent();
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
                g.FillRectangle(new SolidBrush(Color.Black), drownPoint);
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
            int[] widthAndHeight = compImageResolution.Text.Split(';').Select(str => int.Parse(str)).ToArray();
            var workingImage = new MonoImage(getInitImage(), widthAndHeight[0], widthAndHeight[1]);
            MessageBox.Show("Image is computed!!!");
        }
    }
}
