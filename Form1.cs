using System;
using System.Drawing;
using System.Windows.Forms;

namespace PraktikumGrafKom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // --- OBJEK KOMPLEKS BERMAKNA (Pemandangan Rumah) ---

            // 1. Langit (FillRectangle)
            g.FillRectangle(Brushes.SkyBlue, 0, 0, 400, 200);

            // 2. Rumput / Tanah (FillRectangle)
            g.FillRectangle(Brushes.ForestGreen, 0, 200, 400, 150);

            // 3. Matahari (FillEllipse)
            g.FillEllipse(Brushes.Gold, 300, 30, 60, 60);

            // 4. Sinar Matahari (DrawLine)
            g.DrawLine(new Pen(Color.Gold, 2), 290, 60, 270, 60);

            // 5. Dinding Rumah (FillRectangle)
            g.FillRectangle(Brushes.SaddleBrown, 80, 150, 140, 100);

            // 6. Tepi Dinding Rumah (DrawRectangle)
            g.DrawRectangle(Pens.Black, 80, 150, 140, 100);

            // 7. Atap Segitiga (FillPolygon)
            Point[] atap = { new Point(70, 150), new Point(150, 90), new Point(230, 150) };
            g.FillPolygon(Brushes.DarkRed, atap);

            // 8. Pintu Rumah (FillRectangle)
            g.FillRectangle(Brushes.DarkGoldenrod, 130, 190, 40, 60);

            // 9. Jendela Rumah (FillEllipse)
            g.FillEllipse(Brushes.LightCyan, 95, 170, 25, 25);

            // 10. Batang Pohon (FillRectangle)
            g.FillRectangle(Brushes.Sienna, 270, 170, 20, 60);

            // 11. Daun Pohon (FillEllipse)
            g.FillEllipse(Brushes.DarkGreen, 250, 120, 60, 60);

            // 12. Label Teks (DrawString)
            g.DrawString("Praktikum 1 - GDI+ Kompleks", new Font("Arial", 10, FontStyle.Bold), Brushes.White, 10, 10);
        }
    }
}