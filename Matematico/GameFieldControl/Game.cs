using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematico.GameFieldControl
{
    class Game
    {
        ////-----------------------------------------------Свойства, переменные
        /// <summary>
        /// Ссылка на кнопку(колоду ведущего) для доступа к ней
        /// </summary>
        public Button _btnNextNumber;
        /// <summary>
        /// Свойство-ссылка на игральную доску игрока
        /// </summary>
        public CardDesk CardDeskPlayer { get; set; }
        /// <summary>
        /// Свойство-ссылка на игральную доску компьютера
        /// </summary>
        public CardDesk CardDeskComputer { get; set; }

        ////---------------------------------------------------------------------------/////



        ////-----------------------------------------------Приватные методы
        /// <summary>
        /// Медод подписки кнопок игрока на событие клик
        /// </summary>
        public void InitPlayerButton()
        {
            foreach (var item in CardDeskPlayer.Cards)
            {
                foreach (var card in item)
                {
                    card.Button.Click += button_Click;
                }
            }
        }

        ////---------------------------------------------------------------------------/////


        ////-----------------------------------------------События
        /// <summary>
        /// Событие клик которое присвает значение карты(общей) нажатой кнопке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == string.Empty) 
            {
                int num = int.Parse(_btnNextNumber.Text);
                string btn_name = ((Button)sender).Name;

                foreach (var item in CardDeskPlayer.Cards)
                {
                    foreach(var card in item)
                    {
                        if(card.Button.Name == btn_name)
                        {
                            card.Button.Text = num.ToString();
                            card.Points = num;
                        }
                    }
                }
                //int btn_num = int.Parse(((Button)sender).Name.Split("_")[1]);
                //((Button)sender).Text = num.ToString();
                //((Card)sender).Points = num;
            }
        }
        ////---------------------------------------------------------------------------/////
    }
}
