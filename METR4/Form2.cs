﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //
        // Переменные
        public Point mouse_offset;
        static public int Eks = 0, Nevr = 0; 
        int K = 0;
        bool[] mas = new bool[57];
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
        private void Form2_Load(object sender, EventArgs e)
        {
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
            GraphicsPath gp4 = new GraphicsPath();
            Graphics g4 = CreateGraphics();
            Rectangle SmallRect4 = btnYes.ClientRectangle;
            SmallRect4.Inflate(-5, -5);
            gp4.AddRectangle(SmallRect4);
            btnYes.Region = new Region(gp4);
            g4.Dispose();
            //
            GraphicsPath gp5 = new GraphicsPath();
            Graphics g5 = CreateGraphics();
            Rectangle SmallRect5 = btnNo.ClientRectangle;
            SmallRect5.Inflate(-4, -4);
            gp5.AddRectangle(SmallRect5);
            btnNo.Region = new Region(gp5);
            g5.Dispose();
            //
            GraphicsPath gp6 = new GraphicsPath();
            Graphics g6 = CreateGraphics();
            Rectangle SmallRect6 = btnRes.ClientRectangle;
            SmallRect6.Inflate(-4, -4);
            gp6.AddRectangle(SmallRect6);
            btnRes.Region = new Region(gp6);
            g6.Dispose();
            //
            this.ttHelp.SetToolTip(btnClose, "Нажмите, чтобы закрыть приложение");
            this.ttHelp.SetToolTip(btnMin, "Нажмите, чтобы свернуть приложение");
            this.ttHelp.SetToolTip(btnYes, "Нажмите, если Ваш ответ Да");
            this.ttHelp.SetToolTip(btnNo, "Нажмите, если Ваш ответ Нет");
            this.ttHelp.SetToolTip(btnRes, "Нажмите, чтобы просмотреть результаты");
            //
            rtbQuestion.Text = "1. Часто ли Вы испытываете тягу к новым впечатлениям, к тому, чтобы отвлечься, испытать сильные ощущения?";
            K++;
        }
        //
        // Свернуть окно
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        // Закрыть приложение
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        // При нажатии на кнопку ответа Да
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (K == 57)
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
                btnRes.Visible = true;
                Result();
            }
            else
            {
                string s = "";
                if (K == 1) s = "2. Часто ли Вы чувствуете, что нуждаетесь в друзьях, которые могут вас понять, ободрить, посочувствовать?";
                if (K == 2) s = "3. Считаете ли Вы себя беззаботным человеком?";
                if (K == 3) s = "4. Очень ли трудно Вам отказаться от своих намерений?";
                if (K == 4) s = "5. Обдумываете ли Вы свои дела не спеша и предпочитаете ли подождать, прежде чем действовать";
                if (K == 5) s = "6. Всегда ли Вы сдерживаете свои обещания, даже если это Вам невыгодно?";
                if (K == 6) s = "7. Часто ли у Вас бывают спады и подъёмы настроения?";
                if (K == 7) s = "8. Быстро ли Вы обычно действуете и говорите?";
                if (K == 8) s = "9. Возникало ли у Вас когда-нибудь чувство, что Вы несчастны, хотя никакой серьёзной причины для этого не было?";
                if (K == 9) s = "10. Верно ли, что на «спор» Вы способны решиться на всё?";
                if (K == 10) s = "11. Смущаетесь ли Вы, когда хотите познакомиться с человеком противоположного пола, который Вам симпатичен?";
                if (K == 11) s = "12. Бывает ли когда-нибудь, что, разозлившись, Вы выходите из себя?";
                if (K == 12) s = "13. Часто ли бывает, что Вы действуете необдуманно, под влиянием момента?";
                if (K == 13) s = "14. Часто ли Вас беспокоит мысль о том, что Вам не следовало что-либо делать или говорить?";
                if (K == 14) s = "15. Предпочитаете ли Вы чтение книг встречам с людьми?";
                if (K == 15) s = "16. Верно ли, что Вас легко задеть?";
                if (K == 16) s = "17. Любите ли Вы часто бывать в компании?";
                if (K == 17) s = "18. Бывают ли у Вас такие мысли, которыми Вам бы не хотелось делиться с другими?";
                if (K == 18) s = "19. Верно ли, что иногда Вы настолько полны энергии, что всё горит в руках, а иногда чувствуете усталость?";
                if (K == 19) s = "20. Стараетесь ли Вы ограничить круг своих знакомств небольшим числом самых близких друзей?";
                if (K == 20) s = "21. Много ли Вы мечтаете?";
                if (K == 21) s = "22. Когда на Вас кричат, отвечаете ли Вы тем же?";
                if (K == 22) s = "23. Считаете ли Вы все свои привычки хорошими?";
                if (K == 23) s = "24. Часто ли у Вас появляется чувство, что Вы в чем-то виноваты?";
                if (K == 24) s = "25. Способны ли Вы иногда дать волю своим чувствам и беззаботно развлекаться в весёлой компании?";
                if (K == 25) s = "26. Можно ли сказать, что нервы у вас часто бывают натянуты до предела?";
                if (K == 26) s = "27. Слывете ли Вы человеком живым и весёлым?";
                if (K == 27) s = "28. После того как дело сделано, часто ли Вы мысленно возвращаетесь к нему и думаете, что смогли бы сделать лучше?";
                if (K == 28) s = "29. Чувствуете ли Вы себя неспокойно, находясь в большой компании?";
                if (K == 29) s = "30. Бывает ли, что Вы передаёте слухи?";
                if (K == 30) s = "31. Бывает ли, что Вам не спится из-за того, что в голову лезут разные мысли?";
                if (K == 31) s = "32. Если Вы хотите что-то узнать, Вы предпочитаете найти это в книге или спросить у людей?";
                if (K == 32) s = "33. Бывает ли у Вас сильное сердцебиение?";
                if (K == 33) s = "34. Нравится ли Вам работа, требующая сосредоточения?";
                if (K == 34) s = "35. Бывают ли у Вас приступы дрожи?";
                if (K == 35) s = "36. Всегда ли Вы говорите правду?";
                if (K == 36) s = "37. Бывает ли Вам неприятно находиться в компании, где подшучивают друг над другом?";
                if (K == 37) s = "38. Раздражительны ли Вы?";
                if (K == 38) s = "39. Нравится ли Вам работа, требующая быстродействия?";
                if (K == 39) s = "40. Верно ли, что Вам часто не дают покоя мысли о разных неприятностях и ужасах, которые могли бы произойти, хотя всё кончилось благополучно?";
                if (K == 40) s = "41. Верно ли, что Вы неторопливы в движениях и несколько медлительны?";
                if (K == 41) s = "42. Опаздываете ли Вы когда-нибудь на работу или на встречу с кем-либо?";
                if (K == 42) s = "43. Часто ли Вам снятся кошмары?";
                if (K == 43) s = "44. Верно ли, что Вы так любите поговорить, что не упускаете любого случая побеседовать с новым человеком?";
                if (K == 44) s = "45. Беспокоят ли Вас какие-нибудь боли?";
                if (K == 45) s = "46. Огорчились бы Вы, если бы долго не могли видеться с друзьями?";
                if (K == 46) s = "47. Вы нервный человек?";
                if (K == 47) s = "48. Есть ли среди ваших знакомых те, которые явно Вам не нравятся?";
                if (K == 48) s = "49. Вы уверенный в себе человек?";
                if (K == 49) s = "50. Легко ли Вас задевает критика Ваших недостатков или Вашей работы?";
                if (K == 50) s = "51. Трудно ли Вам получить настоящее удовольствие от мероприятий, в которых участвует много народу?";
                if (K == 51) s = "52. Беспокоит ли Вас чувство, что Вы чем-то хуже других?";
                if (K == 52) s = "53. Сумели бы Вы внести оживление в скучную компанию?";
                if (K == 53) s = "54. Бывает ли, что Вы говорите о вещах, в которых совсем не разбираетесь?";
                if (K == 54) s = "55. Беспокоитесь ли Вы о своем здоровье?";
                if (K == 55) s = "56. Любите ли Вы подшутить над другими?";
                if (K == 56) s = "57. Страдаете ли Вы бессонницей?";
                mas[K] = true;
                K++;
                rtbQuestion.Text = s;
            }
        }
        //
        // При нажатии на кнопку Нет
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (K == 57)
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
                btnRes.Visible = true;
                Result();
            }
            else
            {
                string s = "";
                if (K == 1) s = "2. Часто ли Вы чувствуете, что нуждаетесь в друзьях, которые могут вас понять, ободрить, посочувствовать?";
                if (K == 2) s = "3. Считаете ли Вы себя беззаботным человеком?";
                if (K == 3) s = "4. Очень ли трудно Вам отказаться от своих намерений?";
                if (K == 4) s = "5. Обдумываете ли Вы свои дела не спеша и предпочитаете ли подождать, прежде чем действовать";
                if (K == 5) s = "6. Всегда ли Вы сдерживаете свои обещания, даже если это Вам невыгодно?";
                if (K == 6) s = "7. Часто ли у Вас бывают спады и подъёмы настроения?";
                if (K == 7) s = "8. Быстро ли Вы обычно действуете и говорите?";
                if (K == 8) s = "9. Возникало ли у Вас когда-нибудь чувство, что Вы несчастны, хотя никакой серьёзной причины для этого не было?";
                if (K == 9) s = "10. Верно ли, что на «спор» Вы способны решиться на всё?";
                if (K == 10) s = "11. Смущаетесь ли Вы, когда хотите познакомиться с человеком противоположного пола, который Вам симпатичен?";
                if (K == 11) s = "12. Бывает ли когда-нибудь, что, разозлившись, Вы выходите из себя?";
                if (K == 12) s = "13. Часто ли бывает, что Вы действуете необдуманно, под влиянием момента?";
                if (K == 13) s = "14. Часто ли Вас беспокоит мысль о том, что Вам не следовало что-либо делать или говорить?";
                if (K == 14) s = "15. Предпочитаете ли Вы чтение книг встречам с людьми?";
                if (K == 15) s = "16. Верно ли, что Вас легко задеть?";
                if (K == 16) s = "17. Любите ли Вы часто бывать в компании?";
                if (K == 17) s = "18. Бывают ли у Вас такие мысли, которыми Вам бы не хотелось делиться с другими?";
                if (K == 18) s = "19. Верно ли, что иногда Вы настолько полны энергии, что всё горит в руках, а иногда чувствуете усталость?";
                if (K == 19) s = "20. Стараетесь ли Вы ограничить круг своих знакомств небольшим числом самых близких друзей?";
                if (K == 20) s = "21. Много ли Вы мечтаете?";
                if (K == 21) s = "22. Когда на Вас кричат, отвечаете ли Вы тем же?";
                if (K == 22) s = "23. Считаете ли Вы все свои привычки хорошими?";
                if (K == 23) s = "24. Часто ли у Вас появляется чувство, что Вы в чем-то виноваты?";
                if (K == 24) s = "25. Способны ли Вы иногда дать волю своим чувствам и беззаботно развлекаться в весёлой компании?";
                if (K == 25) s = "26. Можно ли сказать, что нервы у вас часто бывают натянуты до предела?";
                if (K == 26) s = "27. Слывете ли Вы человеком живым и весёлым?";
                if (K == 27) s = "28. После того как дело сделано, часто ли Вы мысленно возвращаетесь к нему и думаете, что смогли бы сделать лучше?";
                if (K == 28) s = "29. Чувствуете ли Вы себя неспокойно, находясь в большой компании?";
                if (K == 29) s = "30. Бывает ли, что Вы передаёте слухи?";
                if (K == 30) s = "31. Бывает ли, что Вам не спится из-за того, что в голову лезут разные мысли?";
                if (K == 31) s = "32. Если Вы хотите что-то узнать, Вы предпочитаете найти это в книге или спросить у людей?";
                if (K == 32) s = "33. Бывает ли у Вас сильное сердцебиение?";
                if (K == 33) s = "34. Нравится ли Вам работа, требующая сосредоточения?";
                if (K == 34) s = "35. Бывают ли у Вас приступы дрожи?";
                if (K == 35) s = "36. Всегда ли Вы говорите правду?";
                if (K == 36) s = "37. Бывает ли Вам неприятно находиться в компании, где подшучивают друг над другом?";
                if (K == 37) s = "38. Раздражительны ли Вы?";
                if (K == 38) s = "39. Нравится ли Вам работа, требующая быстродействия?";
                if (K == 39) s = "40. Верно ли, что Вам часто не дают покоя мысли о разных неприятностях и ужасах, которые могли бы произойти, хотя всё кончилось благополучно?";
                if (K == 40) s = "41. Верно ли, что Вы неторопливы в движениях и несколько медлительны?";
                if (K == 41) s = "42. Опаздываете ли Вы когда-нибудь на работу или на встречу с кем-либо?";
                if (K == 42) s = "43. Часто ли Вам снятся кошмары?";
                if (K == 43) s = "44. Верно ли, что Вы так любите поговорить, что не упускаете любого случая побеседовать с новым человеком?";
                if (K == 44) s = "45. Беспокоят ли Вас какие-нибудь боли?";
                if (K == 45) s = "46. Огорчились бы Вы, если бы долго не могли видеться с друзьями?";
                if (K == 46) s = "47. Вы нервный человек?";
                if (K == 47) s = "48. Есть ли среди ваших знакомых те, которые явно Вам не нравятся?";
                if (K == 48) s = "49. Вы уверенный в себе человек?";
                if (K == 49) s = "50. Легко ли Вас задевает критика Ваших недостатков или Вашей работы?";
                if (K == 50) s = "51. Трудно ли Вам получить настоящее удовольствие от мероприятий, в которых участвует много народу?";
                if (K == 51) s = "52. Беспокоит ли Вас чувство, что Вы чем-то хуже других?";
                if (K == 52) s = "53. Сумели бы Вы внести оживление в скучную компанию?";
                if (K == 53) s = "54. Бывает ли, что Вы говорите о вещах, в которых совсем не разбираетесь?";
                if (K == 54) s = "55. Беспокоитесь ли Вы о своем здоровье?";
                if (K == 55) s = "56. Любите ли Вы подшутить над другими?";
                if (K == 56) s = "57. Страдаете ли Вы бессонницей?";
                mas[K] = false;
                K++;
                rtbQuestion.Text = s;
            }            
        }
        //
        // Получение результата
        void Result()
        {
            int Lozh = 0;
            if (mas[0] == true) Eks++;
            if (mas[2] == true) Eks++;
            if (mas[7] == true) Eks++;
            if (mas[9] == true) Eks++;
            if (mas[12] == true) Eks++;
            if (mas[16] == true) Eks++;
            if (mas[21] == true) Eks++;
            if (mas[24] == true) Eks++;
            if (mas[26] == true) Eks++;
            if (mas[38] == true) Eks++;
            if (mas[43] == true) Eks++;
            if (mas[45] == true) Eks++;
            if (mas[48] == true) Eks++;
            if (mas[52] == true) Eks++;
            if (mas[55] == true) Eks++;
            if (mas[4] == false) Eks++;
            if (mas[14] == false) Eks++;
            if (mas[19] == false) Eks++;
            if (mas[28] == false) Eks++;
            if (mas[31] == false) Eks++;
            if (mas[36] == false) Eks++;
            if (mas[40] == false) Eks++;
            if (mas[50] == false) Eks++;
            //
            if (mas[1] == true) Nevr++;
            if (mas[3] == true) Nevr++;
            if (mas[6] == true) Nevr++;
            if (mas[8] == true) Nevr++;
            if (mas[10] == true) Nevr++;
            if (mas[13] == true) Nevr++;
            if (mas[15] == true) Nevr++;
            if (mas[18] == true) Nevr++;
            if (mas[20] == true) Nevr++;
            if (mas[22] == true) Nevr++;
            if (mas[25] == true) Nevr++;
            if (mas[27] == true) Nevr++;
            if (mas[30] == true) Nevr++;
            if (mas[32] == true) Nevr++;
            if (mas[34] == true) Nevr++;
            if (mas[37] == true) Nevr++;
            if (mas[39] == true) Nevr++;
            if (mas[42] == true) Nevr++;
            if (mas[44] == true) Nevr++;
            if (mas[46] == true) Nevr++;
            if (mas[49] == true) Nevr++;
            if (mas[51] == true) Nevr++;
            if (mas[54] == true) Nevr++;
            if (mas[56] == true) Nevr++;
            //
            if (mas[5] == true) Lozh++;
            if (mas[23] == true) Lozh++;
            if (mas[35] == true) Lozh++;
            if (mas[11] == false) Lozh++;
            if (mas[17] == false) Lozh++;
            if (mas[29] == false) Lozh++;
            if (mas[41] == false) Lozh++;
            if (mas[47] == false) Lozh++;
            if (mas[53] == false) Lozh++;
            //
            string s = "• экстраверсия: ";
            if (Eks < 11) s += "Вы - интроверт, замкнуты внутри себя";
            if (Eks > 10 && Eks < 15) s += "Вы - амбиверт, общаетесь, когда вам это нужно";
            if (Eks > 14 && Eks < 25) s += "Вы - экстраверт, общительны, обращены к внешнему миру";
            s += "\n• невротизм: ";
            if (Nevr < 11) s += "Вы эмоционально устойчивы";
            if (Nevr > 10 && Nevr < 17) s += "Вы эмоционально впечатлительны";
            if (Nevr > 16 && Nevr < 23) s += "Вы проявляете отдельные признаки расшатанности нервной системы";
            if (Nevr > 22 && Nevr < 25) s += "у Вас невротизм, граничащий с патологией, возможен срыв, невроз";
            s += "\n• ложь: ";
            if (Lozh < 4) s += "Ваши ответы соответствуют норме человеческой лжи, ответам можно доверять";
            if (Lozh > 3 && Lozh < 6) s += "Ваши ответы сомнительны";
            if (Lozh > 5 && Lozh < 10) s += "Ваши ответы недостоверны";
            //
            rtbQuestion.Text = s;
        }
        //
        // Просмотреть результаты на графике
        private void btnRes_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}