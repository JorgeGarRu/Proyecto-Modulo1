using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_modulo_1
{
    public class Ranking
    {
        //Propiedades
        #region Propiedades

        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        private List<Score> scores;

        public List<Score> Scores
        {
            get { return scores; }
            
        }



        #endregion

        //Constructores
        #region Constructores

            public Ranking(string name,List<Score> scores)
        {
            this.name = name;
            this.scores = scores;
        }
#endregion

        //To String
        public override string ToString()
        {
            string s = "Ranking: " + Name + "\n";
            foreach(Score sc in Scores)
            {
                s = s + "   " + sc + "\n";
            }

            return s;
        }
    }
}
