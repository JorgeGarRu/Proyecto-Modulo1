using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_modulo_1
{
    public class Score
    {
        //Propiedades
        #region Propiedades

        private string nickName;

        public string NickName
        {
            get { return nickName; }
           
        }

        private int points;

        public int Points
        {
            get { return points; }
            set {
                if (value >= 0)
                {
                    this.points = value;
                }
            }
        }



        #endregion

        //Constructores
        #region Constructores

            public Score(string nickName, int points)
        {
            this.nickName = nickName;
            if(points >= 0)
            {
                this.points = points;
            }
            else
            {
                Console.WriteLine("La puntuacion debe ser mayor que 0");
            }
        }

#endregion

        //To String
        public override string ToString()
        {
            string s = string.Format("{0} - {1}", NickName, Points);
            return s;
        }
    }
}
