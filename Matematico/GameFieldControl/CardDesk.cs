using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematico.GameFieldControl
{

    class CardDesk
    {
        private Card[][] _cards = new Card[5][];

        public CardDesk(TableLayoutControlCollection buttons)
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                _cards[i] = new Card[5];
            }

            int counter = 0;
            int ind = 0;
            foreach (Button oneBut in buttons)
            {
                oneBut.Font = new Font(FontFamily.GenericSansSerif, 25);
                _cards[counter / 5][ind] = new Card();
                _cards[counter / 5][ind].Button = oneBut;
                _cards[counter / 5][ind].Points = 0;
                counter++;
                ind++;
                if (ind == 5) ind = 0;
            }
        }

        public Card[][] Cards
        {
            get { return _cards; }
        }


        
            
    }
}
