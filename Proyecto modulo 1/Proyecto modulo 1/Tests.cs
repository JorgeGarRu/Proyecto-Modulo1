using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_modulo_1
{
    public class Tests
    {
        public static void DoTest()
        {
            #region Prueba de ToString de ranking

            //Score s1 = new Score("Jorongo", 2000);
            //Score s2 = new Score("Minitanke", 300);

            //List<Score> lista1 = new List<Score>() { s1, s2 };

            //Ranking r1 = new Ranking("Muertes", lista1);

            //Console.WriteLine(r1);
            #endregion

            #region Prueba de ToString de game

            //Score s1 = new Score("Jorongo", 2000);
            //Score s2 = new Score("Minitanke", 300);

            //List<Score> lista1 = new List<Score>() { s1, s2 };
            //List<Score> lista2 = new List<Score>() { s1 };

            //Ranking r1 = new Ranking("Muertes", lista1);
            //Ranking r2 = new Ranking("Tiros", lista2);

            //Dictionary<Platforms, Ranking> d1 = new Dictionary<Platforms, Ranking>();
            //List<Platforms> Plat1 = new List<Platforms>() { Platforms.PS4, Platforms.XBOXONE, Platforms.PC };

            //d1.Add(Platforms.PS4, r1);
            //d1.Add(Platforms.XBOXONE, r2);

            //Game juego1 = new Game("COD", Genres.Action, Plat1, 2017, d1);

            //Console.WriteLine(juego1);
            #endregion

            #region Prueba Funcionalidades

            Player p1 = new Player("Jorongo", "jorongo94@gmail.com", Countries.Spain);
            Player p2 = new Player("Minitanke", "minitanke94@gmail.com", Countries.Spain);
            Player p3 = new Player("Andres", "jfkejfkjefk", Countries.Australia);

            Score s1 = new Score("Jorongo", 2000);
            Score s2 = new Score("Minitanke", 300);
            Score s3 = new Score("Andres", 200);

            List<Score> lista1 = new List<Score>() { s1, s2 };
            List<Score> lista2 = new List<Score>() { s3 };

            Ranking r1 = new Ranking("Muertes", lista1);
            Ranking r2 = new Ranking("Tiros", lista2);

            Dictionary<Platforms, Ranking> d1 = new Dictionary<Platforms, Ranking>();

            List<Platforms> Plat1 = new List<Platforms>() { Platforms.PS4, Platforms.XBOXONE, Platforms.PC };

            d1.Add(Platforms.PS4, r1);
            d1.Add(Platforms.XBOXONE, r2);

            Dictionary<Platforms, Ranking> d2 = new Dictionary<Platforms, Ranking>();
            d2.Add(Platforms.PS4, r1);
            d2.Add(Platforms.XBOXONE, r2);

            Game juego1 = new Game("COD", Genres.Action, Plat1, 2017, d1);



            Game juego2 = new Game("Call", Genres.Action, Plat1, 1990, d2);

            GameServices.Games.Add(juego1);
            GameServices.Games.Add(juego2);

            GameServices.Players.Add(p1);
            GameServices.Players.Add(p2);
            GameServices.Players.Add(p3);

            ////Console.WriteLine(GameServices.OldestGame()); //Funciona
            ////Console.WriteLine(GameServices.NumGameGenre(Genres.Action));//Funciona
            ////Console.WriteLine(GameServices.GameMoreNumScore());//funciona
            ////Console.WriteLine(GameServices.NumScoresRankingGame("COD","Muertes"));//Funciona
            ////Console.WriteLine(GameServices.ExistGameWithNameCall());//Funciona
            ////GameServices.GamesPlayer("Minitanke");//funciona
            //Console.WriteLine(GameServices.GamesforPlayer()); 
            #endregion

            #region Exportar


            //Player p1 = new Player("Jorongo", "jorongo94@gmail.com", Countries.Spain);
            //Player p2 = new Player("Minitanke", "minitanke94@gmail.com", Countries.Spain);

            //Score s1 = new Score("Jorongo", 2000);
            //Score s2 = new Score("Minitanke", 300);

            //List<Score> lista1 = new List<Score>() { s1, s2 };
            //List<Score> lista2 = new List<Score>() { s1 };

            //Ranking r1 = new Ranking("Muertes", lista1);
            //Ranking r2 = new Ranking("Tiros", lista2);

            //Dictionary<Platforms, Ranking> d1 = new Dictionary<Platforms, Ranking>();

            //List<Platforms> Plat1 = new List<Platforms>() { Platforms.PS4, Platforms.XBOXONE, Platforms.PC };

            //d1.Add(Platforms.PS4, r1);
            //d1.Add(Platforms.XBOXONE, r2);

            //Dictionary<Platforms, Ranking> d2 = new Dictionary<Platforms, Ranking>();
            //d2.Add(Platforms.PS4, r1);

            //Game juego1 = new Game("COD", Genres.Action, Plat1, 2017, d1);

            ////Console.WriteLine(juego1);

            //Game juego2 = new Game("Call", Genres.Action, Plat1, 1990, d2);

            //GameServices.Games = new List<Game>() { juego1, juego2 };
            //GameServices.Players = new List<Player>() { p1, p2 };
            //GameServices.Export();

            #endregion

            #region Introducir comandos
            GameServices.Comands();
            #endregion
        }
    }
}
