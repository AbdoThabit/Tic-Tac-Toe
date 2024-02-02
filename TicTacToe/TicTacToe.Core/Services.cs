using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        public static DataTable getAllGamesResult()
        {
            string cmd = "select g.gid, p1.name as Player1Name ,g.P1Score as Player1Score, p2.name as player2Name ,g.P2Score as Player2Score ,g.GameDate from Player p1 join Game g on p1.Id = g.P1Id join Player p2 on p2.Id = g.P2Id";
            string connectionString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";
            return DBContext.Select(cmd,connectionString);
        }
        public static void updateGametable(int score1,int score2,int id)
        {
            string cmd = $"update game set P1Score = {score1} ,P2Score = {score2} where gid = {id}";
            string connectionString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";

            DBContext.ExecuteNonQuery(cmd, connectionString);
        }
        public static void deleteFromeGame( int id)
        {
            string cmd = $"delete from game where gid = {id}";
            string connectionString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";

            DBContext.ExecuteNonQuery(cmd, connectionString);
        }
        public static DataTable getMaxScores()
        {
            string cmd = "SELECT name,Score FROM player where name != 'Computer' and Score != 0ORDER BY Score DESC ";
            string connectionString = "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True";
            return DBContext.Select(cmd, connectionString);   

        }
    }
}

