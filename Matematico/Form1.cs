using Matematico.GameFieldControl;

namespace Matematico
{
    public partial class Form1 : Form
    {
        private Game _game;


        public Form1()
        {
            InitializeComponent();
            _game = new Game();
            _game.CardDeskPlayer = new CardDesk(gameFieldControl_Player.Buttons);
            _game.CardDeskComputer = new CardDesk(gameFieldControl_Computer.Buttons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}