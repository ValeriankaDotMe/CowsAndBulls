using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls.Entities
{
    [Serializable()]
    class Player : IComparable<Player>
    {
        private string username;
        private uint gamesPlayed;
        private uint highScore;

        public Player(string username)
        {
            this.Username = username;
            this.gamesPlayed = 0;
            this.highScore = 0;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                if (value.Length > 20)
                {
                    value = value.Substring(0, 20);
                }

                this.username = value;
            }
        }

        public uint GamesPlayed
        {
            get
            {
                return this.gamesPlayed;
            }
        }

        public uint HighScore
        {
            get
            {
                return this.highScore;
            }
        }

        public void PlayGame()
        {
            this.gamesPlayed++;
        }

        public void AddScore(uint score)
        {
            if (this.highScore < score)
            {
                this.highScore = score;
            }
        }

        public int CompareTo(Player other)
        {
            return this.Username.CompareTo(other.Username);
        }
    }
}
