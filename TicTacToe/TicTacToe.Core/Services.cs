using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Data;

namespace TicTacToe.Core
{
    public class Services
    {
        public static string capitalizeName(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        public static bool PlayerExited(string name)
        {

            string cmdString = $"select id from player where name = '{capitalizeName(name)}'";
            string conString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";
            return DBContext.isExited(cmdString, conString);
        }
        public static int insertPlayer(string name)
        {
            string cmdString = $"insert into player values ('{capitalizeName(name)}',0)";
            string conString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";
            return DBContext.ExecuteNonQuery(cmdString, conString);
        }
        public static int getPlayerID(string name)
        {
            string cmdString = $"select id from player where name = '{capitalizeName(name)}'";
            string conString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";
            return DBContext.SelectSclaer(cmdString, conString);
        }
        public static void insertintoGame(string player1Name, string player2Name, int player1Score, int player2Score)
        {
            string cmdString, conString;
            int player1Id, player2Id;

            if (Services.PlayerExited(player1Name)) player1Id = Services.getPlayerID(player1Name);
            else
            {
                Services.insertPlayer(player1Name);
                player1Id = Services.getPlayerID(player1Name);
            }

            if (Services.PlayerExited(player2Name)) player2Id = Services.getPlayerID(player2Name);
            else
            {
                Services.insertPlayer(player2Name);
                player2Id = Services.getPlayerID(player2Name);
            }
            cmdString = $"insert into game values ({player1Id},{player2Id},{player1Score},{player2Score},GETDATE())";
            conString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";
            DBContext.ExecuteNonQuery(cmdString, conString);


        }
        
    }
}

