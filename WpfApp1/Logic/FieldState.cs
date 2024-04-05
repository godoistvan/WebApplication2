using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApp1.Interfaces;

namespace WpfApp1.Logic
{
    public class FieldState : IFieldState
    {
        string[] field = new string[9];
        public void Draw(Player player)
        {
            field[fieldnumber] = player;
        }
        public void ShowField()
        {

        }
        public void PlayerWin()
        {
            string winner = " ";
            if (field[1] == "x" && field[2] == "x" && field[3] == "x" || field[4] == "x" && field[5] == "x" && field[6] == "x" || field[7] == "x" && field[8] == "x" && field[9] == "x" || field[1] == "x" && field[4] == "x" && field[7] == "x" || field[2] == "x" && field[5] == "x" && field[8] == "x" || field[3] == "x" && field[6] == "x" && field[9] == "x" || field[1] == "x" && field[5] == "x" && field[9] == "x" || field[3] == "x" && field[5] == "x" && field[7] == "x")
            {
                winner = "x";
            }
            if (field[1] == "o" && field[2] == "o" && field[3] == "o" || field[4] == "o" && field[5] == "o" && field[6] == "o" || field[7] == "o" && field[8] == "o" && field[9] == "o" || field[1] == "o" && field[4] == "o" && field[7] == "o" || field[2] == "o" && field[5] == "o" && field[8] == "o" || field[3] == "o" && field[6] == "o" && field[9] == "o" || field[1] == "o" && field[5] == "o" && field[9] == "o" || field[3] == "o" && field[5] == "o" && field[7] == "o")
            {
                winner = "o";
            }
        }
    }
}
