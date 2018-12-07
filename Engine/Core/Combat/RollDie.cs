using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This is a place holder for basic combat rolls
 * this section will have methods for normal hit then switch to see if it was a crit hit
 */

namespace Engine
{
    public class RollDie
    {
        #region Fields
        Random rand = new Random();
        #endregion

        // Create the Class Properties
        #region Properties
        public int NumDice { get; set; }
        public int DieSize { get; set; }
        public int DieResult { get; set; }
        #endregion

        #region Constructors
        public RollDie(string typeDice)
        {
            string[] dice = typeDice.Split('D');
            int num = Convert.ToInt32(dice[0]);
            int die = Convert.ToInt32(dice[1]);
            NumDice = num;
            DieSize = die;
        }

        public RollDie(int Num, int Size)
        {
            NumDice = Num;
            DieSize = Size;
        }
        #endregion

        public int Roll()
        {
            int sum = 0;

            for (int i = 0; i < NumDice; i++)
            {
                sum += rand.Next(DieSize + 1);
            }

            return sum;
        }
    }
}