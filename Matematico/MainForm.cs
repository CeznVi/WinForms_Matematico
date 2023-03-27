using Matematico.GameFieldControl;
using System.Numerics;
using System;

namespace Matematico
{
    public partial class Form_Main : Form
    {
        private Game _game;


        public Form_Main()
        {
            InitializeComponent();
            _game = new Game(new CardDeck(gameFieldControl_Player.Buttons), new CardDeck(gameFieldControl_Computer.Buttons));
            _game.OnNextNumberChanged += _game_OnNextNumberChanged;
            _game.OnGameFinished += _game_OnGameFinished;

        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            _game.NewGame();
            button_nextNumber.Text = _game.GetNextNumber().ToString();
        }

        private void _game_OnGameFinished(object sender, Player e)
        {
            MessageBox.Show(e.Login, "Победитель!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void _game_OnNextNumberChanged(object sender, int e)
        {
            button_nextNumber.Text = e.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //int[] tmp = new int[5] { 11, 10, 13, 1, 12 };

            //int points = Scoring.CheckTwoIdentialNumbers(tmp);
            //int pointsTwo = Scoring.CheckTwoPairIdentialNumbers(tmp);
            //int pointsTwoThree = Scoring.CheckThreeAndTwoIdentialNumbers(tmp);
            //int pointsTwovals = Scoring.CheckThreeUnitAndTwoThirteenNumbers(tmp);
            //int pointsCombin = Scoring.CheckCombinationNumbers(tmp);
        }


    }
}