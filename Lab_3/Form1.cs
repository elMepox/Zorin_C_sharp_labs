using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }
        //Событие вызываемое при тике таймера
        private void timer_Tick(object sender, EventArgs e)
        {
            //Смещение по x и y
            int dx = 1;
            int dy = 1;
            //Получаем координаты курсора 
            Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
            //Проверяем не выходит ли за границы экраны при смещении курсора по оси x
            if(point.X - dx > 0)
            {
                //Смещаем курсор по оси x
                point.X -= dx;
            }
            //Проверяем не выходит ли за границы экраны при смещении курсора по оси y

            if (point.Y + dy < Screen.PrimaryScreen.Bounds.Height)
            {
                //Смещаем курсор по оси y
                point.Y += dy;
            }
            //Принменяем изменение координат курсора
            Cursor.Position = point;
        }
    }
}
