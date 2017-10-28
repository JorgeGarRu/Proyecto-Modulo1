using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_modulo_1
{
    public class Game
    {
        //Propiedades
        #region Propiedades

        private string name;

        public string Name
        {
            get { return name; }
           
        }

        private Genres genre;

        public Genres Genre
        {
            get { return genre; }

        }

        private List<Platforms> platforms;

        public List<Platforms> Platforms
        {
            get { return platforms; }
            
        }

        private int releaseDate;

        public int ReleaseDate
        {
            get { return releaseDate; }
            
        }

        private Dictionary<Platforms, Ranking> rankings;

        public Dictionary<Platforms,Ranking> Rankings
        {
            get { return  rankings; }
            
        }



        #endregion

        //Constructores
        #region Constructores

            public Game(string name, Genres genre, List<Platforms> platforms,int releaseDate, Dictionary<Platforms,Ranking> rankings)
        {
            this.name = name;
            this.genre = genre;
            this.platforms = platforms;
            if(releaseDate>=1980&& releaseDate<= 2018)
            {
                this.releaseDate = releaseDate;
            }
            this.rankings = rankings;
        }

        public Game(string datas)
        {
            string[] gamesplit = datas.Split('-');
            this.name = gamesplit[0];
            this.genre = (Genres)int.Parse(gamesplit[1]);
            this.releaseDate = int.Parse(gamesplit[2]);
            //platforms = Platforms.ToString(gamesplit[3]);
            string[] platformsSplit = gamesplit[3].Split(',');

          
        }

#endregion

        //To Equals
        public override bool Equals(object obj)
        {
            if(obj is Game)
            {
                Game aux = (Game)obj;
                return this.Name == aux.Name;
            }
            return false;
        }

        //To String
        public override string ToString()
        {
            string s = string.Format("--- {0} ({1}) - ", Name, ReleaseDate);

            foreach(Platforms plat in platforms)
            {
                s = s + plat + ", ";
            }

            s = s + "- " + Genre + "\n";

            s = s + "    Rankings:\n";

            foreach(Ranking r in Rankings.Values)
            {
                s = s + "     - " + r.Name + " (" + r.Scores.Count + ")\n";
            }


           

            return s;
        }
    }
}
