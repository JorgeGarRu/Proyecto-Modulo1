using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_modulo_1
{
    public class Player
    {
        //Propiedades
        #region Propiedades

        private string nickName;

        public string NickName
        {
            get { return nickName; }
           
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        private Countries country;

        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }



        #endregion

        //Constructores
        #region Constructores
        public Player(string nickName, string email, Countries country)
        {
            this.nickName = nickName;
            this.email = email;
            this.country = country;
        }

        public Player(string datas)
        {
            string[] playerSplit = datas.Split('-');
            this.nickName = playerSplit[0];
            this.email = playerSplit[1];
            this.country = (Countries)int.Parse(playerSplit[2]);
        }

#endregion

        //To Equals
        public override bool Equals(object obj)
        {
            if(obj is Player)
            {
                Player aux = (Player)obj;
                return this.NickName == aux.NickName;
            }
            return false;
        }

        //To String
        public override string ToString()
        {
            string s = string.Format("{0} - {1} - {2}", NickName, Email, Country);
            return s;
        }
    }
}
