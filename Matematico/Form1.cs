using Matematico.GameFieldControl;

namespace Matematico
{
    public partial class Form_Main : Form
    {
        private Game _game;


        public Form_Main()
        {
            InitializeComponent();
            _game = new Game(gameFieldControl_Player.Buttons, gameFieldControl_Computer.Buttons, button_nextNumber);

            //_game.CardDeskPlayer = new CardDesk(gameFieldControl_Player.Buttons);
            //_game.CardDeskComputer = new CardDesk(gameFieldControl_Computer.Buttons);
            //_game._btnNextNumber = button_nextNumber;


            _game.InitPlayerButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}