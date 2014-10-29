using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace METR4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //
        // При загрузке формы
        private void Form3_Load(object sender, EventArgs e)
        {            
            pGraph.Paint += new PaintEventHandler(pGraph_Paint);
        }
        //
        // При нажатии на кнопку "Результаты"
        private void btnRes_Click(object sender, EventArgs e)
        {
            
        }

        private void pGraph_Paint(object sender, PaintEventArgs e)
        {
            string s = "";
            Graphics g1 = pGraph.CreateGraphics();
            Pen myPen = new Pen(Color.Gray);
            myPen.Width = 1;
            Pen Pen2 = new Pen(Color.Black);
            Pen2.Width = 2;
            SolidBrush myBrush1 = new SolidBrush(Color.Blue);
            float midx = pGraph.Width / 2;
            float midy = pGraph.Height / 2;
            float sh = midx / 26;
            for (int i = 0; i < 26; i += 2)
            {
                g1.DrawLine(myPen, 0, midy - i * sh, midx * 2, midy - i * sh);
                g1.DrawLine(myPen, 0, midy + i * sh, midx * 2, midy + i * sh);
                g1.DrawLine(myPen, midx - i * sh, 0, midx - i * sh, midy * 2);
                g1.DrawLine(myPen, midx + i * sh, 0, midx + i * sh, midy * 2);
            }
            g1.DrawLine(Pen2, midx, 0, midx, midy * 2);
            g1.DrawLine(Pen2, 0, midy, midx * 2, midy);
            Font myFont = new Font("Arial", 10.0F);
            g1.DrawString("Меланхолик", myFont, myBrush1, 20, midy / 2 - 12);
            g1.DrawString("Холерик", myFont, myBrush1, midx + 100, midy / 2 - 12);
            g1.DrawString("Флегматик", myFont, myBrush1, 20, 1.5F * midy - 2);
            g1.DrawString("Сангвиник", myFont, myBrush1, midx + 100, 1.5F * midy - 2);
            g1.DrawString("Невротизм", myFont, myBrush1, midx - 32, 5);
            g1.DrawString("Эмоциональная устойчивость", myFont, myBrush1, midx - 81, midy * 2 - 20);
            g1.DrawString("Интроверт", myFont, myBrush1, 5, midy - 20);
            g1.DrawString("Экстраверт", myFont, myBrush1, midx + 120, midy - 20);
            //
            SolidBrush myBrush2 = new SolidBrush(Color.Red);
            g1.FillEllipse(myBrush2, midx - 10 * sh + Form2.Eks * sh - 2.5F, midy + 10 * sh - Form2.Nevr * sh - 2.5F, 5, 5);
            if (Form2.Eks > 10 && Form2.Nevr < 10) s = "Сангвиник-экстраверт: стабильная личность, социален, направлен к внешнему миру, общителен, порой болтлив, беззаботный, веселый, любит лидерство, много друзей, жизнерадостен.";
            if (Form2.Eks > 10 && Form2.Nevr >= 10) s = "Холерик-экстраверт: нестабильная личность, обидчив, возбужден, несдержан, агрессивен, импульсивен, оптимистичен, активен, но работоспособность и настроение нестабильны, цикличны. В ситуации стресса — склонность к истерико-психопатическим реакциям.";
            if (Form2.Eks <= 10 && Form2.Nevr <= 10) s = "Флегматик-интраверт: стабильная личность, медлителен, спокоен, пассивен, невозмутим, осторожен, задумчив, мирный, сдержанный, надежный, спокойный в отношениях, способен выдержать длительные невзгоды без срывов здоровья и настроения.";
            if (Form2.Eks < 10 && Form2.Nevr > 10) s = "Меланхолик-интраверт: нестабильная личность, тревожен, пессимистичен, очень сдержан внешне, но чувствителен и эмоционален внутри, интеллектуальный, склонен к размышлениям. В ситуации стресса — склонность к внутренней тревоге, депрессии, срыву или ухудшению результатов деятельности (стресс кролика).";
            rtbDesc.Text = s;
        }
    }
}
