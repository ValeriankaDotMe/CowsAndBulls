using CowsAndBulls.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls.Database
{
    static class PlayerBase
    {
        private static LinkedList<Player> playerBase;

        public static void InitializePlayerBase()
        {
            playerBase = new LinkedList<Player>();
        }

        public static void AddPlayer(Player player)
        {
            if (!playerBase.Any(p => p.Username == player.Username))
            {
                playerBase.AddLast(player);
            }
        }

        public static Player GetPlayer(string username)
        {
            return playerBase.First(p => p.Username == username);
        }

        public static bool ContainsPlayer(string username)
        {
            return playerBase.Any(p => p.Username == username);
        }

        public static void SerializePlayerBase()
        {
            try
            {
                using (Stream stream = File.Open("players.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, playerBase);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void DeserializePlayerBase()
        {
            try
            {
                using (Stream stream = File.Open("players.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    playerBase = (LinkedList<Player>)bin.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                InitializePlayerBase();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static LinkedList<Player> GetPlayerBase()
        {
            return playerBase;
        }
    }
}
