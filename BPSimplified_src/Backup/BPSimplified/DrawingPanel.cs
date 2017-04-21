#region Copyright (c), Some Rights Reserved
/*##########################################################################
 * 
 * DrawingPanel.cs
 * -------------------------------------------------------------------------
 * By
 * Murat FIRAT, September 2007
 * 
 * -------------------------------------------------------------------------
 * Description:
 * Inherited From Panel, The Control Provides Drawing Characters On It.. 
 * 
 * -------------------------------------------------------------------------
 ###########################################################################*/
#endregion

using System;
using System.Windows.Forms;
using System.Drawing;

namespace BPSimplified
{
    //A Custom Panel To Draw Characters
    class DrawingPanel : Panel
    {
        private Bitmap BufferImage = null;
        private bool MouseMoving = false;

        private Graphics g_Image = null;
        private Graphics g_Panel = null;

        private int p_Size = 10;//Default Point Size

        public DrawingPanel()
        {
            InitializeDrawingPanel();
        }

        private void InitializeDrawingPanel()
        {
            CreateNewImage();
            base.MouseDown += new MouseEventHandler(DrawingPanel_MouseDown);
            base.MouseUp += new MouseEventHandler(DrawingPanel_MouseUp);
            base.MouseMove += new MouseEventHandler(DrawingPanel_MouseMove);
            base.Paint += new PaintEventHandler(DrawingPanel_Paint);
            base.Resize += new EventHandler(DrawingPanel_Resize);
            base.BackColor = Color.White;
        }

        void DrawingPanel_Resize(object sender, EventArgs e)
        {
            CreateNewImage();
        }

        void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(BufferImage, 0, 0);
            g.Dispose();
        }

        void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseMoving &&
                (e.X < (base.Width - p_Size * .85)) && (e.Y < (base.Height - p_Size * .85)) &&
                (e.X > -p_Size * .15) && (e.Y > -p_Size * .15))//To Prevent Drawing Over The Panel 
            {
                //Draw The Point to The Image
                g_Image = Graphics.FromImage(BufferImage);
                g_Image.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, p_Size, p_Size);

                //Draw The Image to The Panel
                g_Panel = base.CreateGraphics();
                g_Panel.DrawImage(BufferImage, 0, 0);
            }
        }

        void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMoving = false;
        }

        void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseMoving = true;
        }

        public void Clear()
        {
            CreateNewImage();        
            base.Invalidate();
        }

        private void CreateNewImage()
        {
            BufferImage = new Bitmap(base.Width, base.Height);

            for (int i = 0; i < BufferImage.Height; i++)
                for (int j = 0; j < BufferImage.Width; j++)
                    BufferImage.SetPixel(j, i, Color.White);
        }

        protected override void Dispose(bool disposing)
        {
            //Release Resources
            if (g_Image != null) g_Image.Dispose();
            if (g_Panel != null) g_Panel.Dispose();
            if (BufferImage != null) BufferImage.Dispose();

            base.Dispose(disposing);
        }

        public Bitmap ImageOnPanel
        {
            get
            {                
                return BufferImage;
            }
            set
            {
                BufferImage = value;
                base.Invalidate();
            }
        }

        public int PointSize
        {
            get { return p_Size; }
            set { p_Size = value; }
        }
    }
}
