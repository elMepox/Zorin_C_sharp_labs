using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        //Событие, вызываемое при нажатии на pictureBox (на белую часть формы)
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Получаем координаты клика внути формы
            Point location = e.Location;
            //Рисуем триугольник с центром, где был произведен клик
            drawTriangle(location, 60);

        }
        /*private void drawTriangle(Point location, int R)
         *Описание:
         *Рисует по заданным параметрам треугольник
         *Аргументы:
         *Point location - координаты центра треугольника
         *int R - радиус описанной вокрур треугольника
         */
        private void drawTriangle(Point location, int R)
        {
            //Получаем графический контекст - "холст"
            Graphics canvas = pictureBox.CreateGraphics();
            //Закрашиваем "холст" белым
            canvas.Clear(Color.White);
            //В цикле рисуем линии -  стороны треугольника
            for(int i = 0, angl = 270; i<3; i++, angl = (angl + 120) % 360)
            {
                //Вычисляем координаты начала линии
                Point p1 = new Point();
                int dx1 = Convert.ToInt32(Math.Round(R * Math.Cos(dergToRads(angl))));
                p1.X = location.X + dx1;
                int dy1 = Convert.ToInt32(Math.Round(R * Math.Sin(dergToRads(angl))));
                p1.Y = location.Y + dy1;
                //Вычисляем координаты конца линии
                Point p2 = new Point();
                int dx2 = Convert.ToInt32(Math.Round(R * Math.Cos(dergToRads((angl+120)%360))));
                p2.X = location.X + dx2;
                int dy2 = Convert.ToInt32(Math.Round(R * Math.Sin(dergToRads((angl + 120) % 360))));
                p2.Y = location.Y + dy2;
                //Рисуем линию
                canvas.DrawLine(new Pen(Color.Red, 2), p1, p2);
            }

        }
        //Функция, переводящая градусы в радианы
        private double dergToRads(int angl)
        {
            return (angl/180.0)*Math.PI;
        }
    }
}
