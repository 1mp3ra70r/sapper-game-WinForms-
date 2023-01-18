using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size;
        char[,] mapChar;
        Button[,] mapButtons;
        bool[,] flags;
        int bombCount = 0;
        int unitCount = 0;
        DialogResult result;

        /// <summary>
        /// Метод который проверяет количество бомб вокруг данной клетки
        /// </summary>
        /// <param name="a"> строка клетки </param>
        /// <param name="b"> столбец клетки </param>
        /// <returns></returns>
        public string GetBombAroundCount(int a, int b)
        {
            int BombCount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    try
                    {
                        if (mapChar[i + a, j + b] == '#') BombCount++;
                    }
                    catch
                    {

                    }
                }
            }
            string total = BombCount > 0 ? BombCount.ToString() : " ";
            return total;
        }

        public bool[,] FlagFalse(bool[,] flags, int size)
        {

            for (int i = 0; i < flags.GetLength(0); i++)
            {
                for (int j = 0; j < flags.GetLength(1); j++)
                {
                    flags[i, j] = false;
                }
            }
            return flags;
        }

        /// <summary>
        /// Создаем массив чаров одинаковый по размерам с  
        /// массивом кнопок чтобы кнопки изначально  
        /// были пустые но по индексам  
        /// бы значение соответствовало тексту на кнопке при нажатии
        /// </summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public char[,] charMapLoad(char[,] map, int size)
        {
            char[,] mapChar = new char[size, size];
            Random rnd = new Random();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    int unit = rnd.Next(0, 5);
                    unitCount++;
                    switch (unit)
                    {
                        case 0:
                            map[i, j] = '#';
                            bombCount++;
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            map[i, j] = ' ';
                            break;
                    }
                }
            }
            mapChar = map;
            return mapChar;
        }

        /// <summary>
        /// Создание массива кнопок изначально пустых
        /// Подписка их на ивент клика
        /// </summary>
        /// <param name="mapBtn"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public Button[,] MapLoad(Button[,] mapBtn, int size)
        {
            int height = (100 / size) * 3;
            int width = (100 / size) * 3;

            int x = 10;
            int y = 10;
            Button[,] mapButtons = new Button[size, size];
            for (int i = 0; i < mapBtn.GetLength(0); i++)
            {
                for (int j = 0; j < mapBtn.GetLength(1); j++)
                {
                    mapBtn[i, j] = new Button();
                    mapBtn[i, j].Font = new Font("ArialBlack", height / 2, FontStyle.Bold, GraphicsUnit.Point);
                    mapBtn[i, j].Size = new Size(height, width);
                    mapBtn[i, j].BackColor = Color.White;
                    mapBtn[i, j].Text = "";
                    mapBtn[i, j].Location = new Point(x, y);
                    this.Controls.Add(mapBtn[i, j]);
                    x += width + 1;
                    mapBtn[i, j].MouseDown += button_MouseDown;
                }
                x = 10;
                y += height + 1;
            }
            mapButtons = mapBtn;
            return mapButtons;
        }

        /// <summary>
        /// Ивент который происходит при нажатии кнопки старт
        /// Включаем таймер
        /// Выключаем надпись и текстбоксы
        /// Создаем массив кнопок и массив значений пробела или мины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            try
            {
                size = int.Parse(textBoxSize.Text);
            }
            catch
            {
                size = 10;
            }


            labelSize.Visible = false;
            textBoxSize.Visible = false;
            buttonStart.Visible = false;

            mapButtons = new Button[size, size];

            mapChar = new char[size, size];

            flags = new bool[size, size];



            mapChar = charMapLoad(mapChar, size);
            mapButtons = MapLoad(mapButtons, size);
            FlagFalse(flags, size);

            labelBombCount.Visible = true;
            labelTotalCount.Visible = true;

            textBoxBomb.Visible = true;
            textBoxTotal.Visible = true;
        }


        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                Button btn = new Button();
                if (sender is Button)
                {
                    btn = sender as Button;
                }
                for (int i = 0; i < mapButtons.GetLength(0); i++)
                {
                    for (int j = 0; j < mapButtons.GetLength(1); j++)
                    {
                        if (btn == mapButtons[i, j])
                        {
                            if (!flags[i, j])
                            {
                                unitCount--;
                                btn.Text = mapChar[i, j].ToString();
                                if (btn.Text == " ")
                                {
                                    btn.BackColor = Color.Gray;
                                    btn.ForeColor = Color.Snow;
                                    btn.Text = GetBombAroundCount(i, j);

                                }
                                else
                                {
                                    bombCount--;

                                    btn.BackColor = Color.DarkRed;
                                    result = MessageBox.Show("Вы проиграли!!!",
                                        "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (result == DialogResult.OK)
                                    {
                                        Application.Restart();
                                    }
                                }
                                break;
                            }
                        }
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                Button btn = new Button();
                if (sender is Button)
                {
                    btn = sender as Button;
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if(btn == mapButtons[i, j])
                        {
                            if (flags[i, j] && btn.BackColor != Color.Gray)
                            {
                                btn.BackColor = Color.White;
                                flags[i, j] = false;
                            }
                            else if(!flags[i, j] && btn.BackColor != Color.Gray)
                            {
                                btn.BackColor = Color.Lime;
                                flags[i, j] = true;
                            }
                            break;
                        }
                    }
                }

            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            textBoxBomb.Text = bombCount.ToString();
            textBoxTotal.Text = unitCount.ToString();

            if (textBoxTotal.Text == textBoxBomb.Text)
            {
                timer.Enabled = false;
                result = MessageBox.Show("Вы победили", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }
    }
}
