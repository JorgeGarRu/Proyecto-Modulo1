using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_modulo_1
{
    public static class GameServices
    {
        private const string PATH = "../../Resources/data.txt";
        //Propiedades
        #region propiedades

        private static List<Player> players = new List<Player>();

        public static List<Player> Players
        {
            get { return players; }
            //set { players = value; }
        }

        private static List<Game> games = new List<Game>();

        public static List<Game> Games
        {
            get { return games; }

        }



        #endregion

        //Funciones
        #region Funciones

        public static void Export(string path)
        {
            //Convertir los jugadores en string
            string playerData = ConvertPlayerToString();
            //Convertir los juegos en string
            string gameData = ConvertGamesToString();
            //Cnvertir las puntuaciones en string
            string scoreData = CovertScoresToString();
            //Separarlos mediante el simbolo *+*+*+*
            try
            {
                StreamWriter file = File.CreateText(path);
                string completeData = playerData + "\n*+*+*+*\n" + gameData + "\n*+*+*+*\n" + scoreData;
                file.Write(completeData);
                file.Close();
                Console.WriteLine("Exportado correctamente");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error al crear el archivo");
            }
        }

        public static void Import()
        {



        }
        #endregion

        //Funcionalidades
        #region Funcionalides

        public static Game OldestGame()//devuelve el juego mas antiguo
        {
            Game res = null;
            foreach (Game g in Games)
            {
                if (res == null || g.ReleaseDate < res.ReleaseDate)
                {
                    res = g;
                }

            }
            return res;
        }

        public static int NumScoresRankingGame(string nameGame, string nameRanking)//metodo que devuelve el numero de puntuaciones del ranking de un determinado juego

        {
            int numScores = 0;
            Game game = GetGameByName(nameGame);
            foreach(Game g in Games)
            {
               foreach(Ranking r in g.Rankings.Values)
                {
                    if(r.Name == nameRanking)
                    {
                        numScores++;
                    }
                    
                }

            }
            return numScores;
        }

            

        

        public static string NumGameGenre(Genres genre)
        {
            int numGames = 0;
            string s = "";
            foreach (Game g in Games)
            {
                if (g.Genre == genre)
                {
                    numGames++;
                }
            }
            s = string.Format("Hay {0} juegos de {1}", numGames, genre);
            return s;
        }//devuelve el numero de juegos de un determinado genero

        public static Game GameMoreNumScore()//devuelve el juego con mas puntuaciones
        {
            //TODO NOfunciona, arreglar
            Game game = null;
            foreach (Game g in Games)
            {

                if (NumScoreGame(g) > NumScoreGame(game))
                {
                    game = g;
                }
               


            }
            return game;
        }

        public static bool ExistGameWithNameCall()
        {
            bool res = false;
            foreach (Game g in Games)
            {
                if (g.Name.Contains("Call"))
                {
                    res = true;
                    break;
                }
            }
            return res;
        }//devuelve si existe un juego que contenga en su nombre la palara "Call"

        public static void GamesPlayer(string namePlayer)//devuelve los juegos que ha jugado el jugador introducido
        {
            //TODO no funciona,arreglar
            List<Game> listGame = new List<Game>();
            Player player = GetPlayerByName(namePlayer);
            foreach (Game g in Games)
            {
                foreach (Ranking r in g.Rankings.Values)
                {
                    foreach (Score sc in r.Scores)
                    {
                        if (sc.NickName == player.NickName)
                        {
                            listGame.Add(g);
                        }
                    }
                }
            }

            PrintListGame(listGame);
            
           
        }

        public static string GamesforPlayer()//devuelve los juegos que ha jugado cada jugador

        {
            string data = "";
            string playerData = "";
            string gameData = "";
            foreach(Player p in Players)
            {
                playerData += "-> " + p.NickName + ": \n=======>";
                foreach(Game g in Games)
                {
                    gameData+= g.Name+","; 
                }
                playerData += gameData+"\n";
            }
            data += playerData + "\n";
            return data;
        }



        #endregion

        //Funcionaes auxiliares
        #region Funciones auxiliares

            public static void PrintListGame(List<Game> games)//metodo que imprime por pantalla una lista de juegos
        {
            foreach(Game g in games)
            {
                Console.WriteLine(g);
            }
        }
            public static int NumScoreGame(Game game)//metodo que devuelve el numero de puntuaciones de un juego dado
        {
            int numScore = 0;
            foreach(Game g in Games)
            {
                if(g == game)
                {
                    foreach(Ranking r in g.Rankings.Values)
                    {
                        numScore += r.Scores.Count;
                    }
                }
            }
            return numScore;
        }

            public static List<Game> AddGame(Game game)//metodo para añadir juegos a la lista de juegos
        {
            //List<Game> Games = new List<Game>();
            Game ga = null;
           foreach(Game g in Games)
            {
                if(g == game)
                {
                    ga = g;
                    Games.Add(ga);
                }
                break;
            }
            return Games;
        }

        private static Game GetGameByName(string nameGame)
        {
            Game res = null;
            foreach (Game g in Games)
            {
                if (g.Name == nameGame)
                {
                    res = g;
                    break;
                }
            }
            return res;
        }//devuelve un juego dado su nombre

        private static Ranking GetRankingByName(string nameRanking)
        {
            Ranking res = null;
            foreach (Game g in Games)
            {
                foreach (Ranking r in g.Rankings.Values)
                {
                    if (g.Name == nameRanking)
                    {
                        res = r;
                        break;
                    }
                }
            }
            return res;
        }//devuelve un ranking dado su nombre

        private static Player GetPlayerByName(string namePlayer)//devuelve un jugador dado su nick
        {
            Player player = null;
            foreach (Player p in Players)
            {
                if (p.NickName == namePlayer)
                {
                    player = p;
                    break;
                }
            }
            return player;
        }

        //private static Genres GetGenreByName(string nameGenre)//devuelve un genero dado su nombre
        //{
        //    Genres genre = 0;
        //    foreach (Genres g in Enum.GetValues(typeof(Genres))
        //    {
        //       if()
        //        {
        
        //        }
        //    }

        //    return genre;
        //}

        private static string ConvertPlayerToString() //metodo para convertir los jugadores en string para exportarlo
        {
            string data = "";

            foreach (Player p in Players)
            {
                string playerData = "";
                playerData = string.Format("{0} - {1} - {2}\n", p.NickName, p.Email, p.Country);
                data += playerData;
            }
            return data;

        }

        private static string ConvertGamesToString()//metodo para convertir los juegos en string para exportarlo
        {
            string data = "";
            foreach (Game g in Games)
            {
                string gameData = "";
                string platformList = "";
                gameData = string.Format("{0} - {1} - {2} -", g.Name, g.Genre, g.ReleaseDate);//TODO hacer que se exporte las plataformas
                
                foreach (Platforms p in g.Platforms)
                {
                    string platformData = p.ToString();
                   platformList += platformData + ", ";
                   
                }
                gameData += platformList;

                data += gameData+ "\n";
            }

            return data;
        }

        private static string CovertScoresToString()
        {
            string data = "";
            foreach(Game g in Games)
            {
                string gameData = string.Format("{0}-", g.Name);
                foreach(Ranking r in g.Rankings.Values)
                {
                    gameData += r.Name + "-";
                    foreach(Score sc in r.Scores)
                    {
                        gameData += sc.NickName + "=" + sc.Points+", ";
                    }
                }
                data += gameData + "\n";
            }
            return data;
        }

      

        #endregion

        //Parte 4 introducir comandos
        #region Parte 4 Introducir comandos
        public static void Comands() {

            bool res = true;
            while (res)
            {
                Console.WriteLine("---- Import.\n---- Export.\n---- Oldest. \n---- ScoreCount (gameName) (rankingName)\n---- gamesCountByGenren(gameName)\n---- gamesByPlayer.\n---- Salir");
                Console.Write( "Introduce un comando: ");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            string[] splitted = frase.Split(' ');
            string comand = splitted[0];
            string valorNameGame = "";
            string valorNameRanking = "";
            string valorNameGenre = "";

                if (splitted.Length == 3)
            {
                valorNameGame = splitted[1];
               
                valorNameRanking = splitted[2];
            }

                if (splitted.Length == 2)
                {
                    valorNameGenre = splitted[1];
                }
            switch (comand)
            {
                case "import":
                    GameServices.Import();
                    break;

                case "export":
                        string path = "../../Resources/GamesService.txt";
                    GameServices.Export(path);
                    break;

                    case "oldest":
                        Console.WriteLine(OldestGame());
                        break;
                case "scorecount":
                        Console.WriteLine(GameServices.NumScoresRankingGame(valorNameGame, valorNameRanking)); 
                    break;

                    //case "gamesCountByGenre":

                    //    GameServices.NumGameGenre(valorNameGenre);
                    //    break;

                    case "gamesbyplayer":
                    GameServices.GamesforPlayer();
                    break;

                    case "salir":
                        res = false;
                        
                        break;

                default:
                    break;
            }

            }

        }

#endregion
    }
}
