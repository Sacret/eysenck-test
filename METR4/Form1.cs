using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace METR4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Переменные
        public Point mouse_offset;  
        //
        // Событие - опускание "мыши" вниз
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        //
        // Событие - перемещение "мыши"
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y); // определяем текущие координаты курсора...
                Location = mousePos; // ... и перемещаем форму
            }
        }
        //
        // При загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            Rectangle SmallRect = btnEnter.ClientRectangle;
            SmallRect.Inflate(-3, -3);
            gp.AddEllipse(SmallRect);
            btnEnter.Region = new Region(gp);
            g.Dispose();
            //
            GraphicsPath gp2 = new GraphicsPath();
            Graphics g2 = CreateGraphics();
            Rectangle SmallRect2 = btnClose.ClientRectangle;
            SmallRect2.Inflate(-3, -3);
            gp2.AddEllipse(SmallRect2);
            btnClose.Region = new Region(gp2);
            g2.Dispose();
            //
            GraphicsPath gp3 = new GraphicsPath();
            Graphics g3 = CreateGraphics();
            Rectangle SmallRect3 = btnMin.ClientRectangle;
            SmallRect3.Inflate(-3, -3);
            gp3.AddEllipse(SmallRect3);
            btnMin.Region = new Region(gp3);
            g3.Dispose();
            //
            this.ttHelp.SetToolTip(btnEnter, "Нажмите, чтобы перейти к тестированию");
            this.ttHelp.SetToolTip(btnClose, "Нажмите, чтобы закрыть приложение");
            this.ttHelp.SetToolTip(btnMin, "Нажмите, чтобы свернуть приложение");
        }
        //
        // Закрытие окна
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Свернуть окно
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        // При нажатии на кнопку - пройти тест
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = false;
            Form2 frm = new Form2();
            frm.Show();
        }        
    }
}
