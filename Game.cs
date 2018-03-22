using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//added in Step 7

namespace Lab2
{
    public class Game
    {
        public string Team1;
        public string Team2;
        public int Score1;
        public int Score2;

        public Game()
        {

        }

         public Game(string t1, string t2, int scr1, int scr2)
        {
            Team1 = t1;
            Team2 = t2;
            Score1 = scr1;
            Score2 = scr2;
        }

        public override string ToString()
        {
            return Team1 + " ("+ Score1 + ") - " + Team2 + " (" + Score2 + ")";
        }

// A Change in the branch_1




    }
}

//A Change in the Master Branch
