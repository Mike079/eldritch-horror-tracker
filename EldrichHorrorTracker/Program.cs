
using EldrichHorrorTracker.Assets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace EldrichHorrorTracker
{
    class Program
    {
        readonly static string SaveDirectory = AppDomain.CurrentDomain.BaseDirectory + "../../../SaveFiles/";

        static void Main(string[] args)
        {
            try
            {
                // Prepare objects
                var board = new Board();
                board.Players = new List<Player>();
                board.Locations = new List<Location>();

                SetupTestData(board);

                SaveGameState(board, "First Test save file");

                LoadGameState(out Board loadedGame, "Load This Save");

                Console.WriteLine(JsonConvert.SerializeObject(loadedGame, Formatting.Indented));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
        }

        private static void LoadGameState(out Board loadedGame, string saveFileName)
        {
            string fullFileName = SaveDirectory + saveFileName + ".json";

            loadedGame = JsonConvert.DeserializeObject<Board>(File.ReadAllText(fullFileName));
        }

        private static void SaveGameState(Board board, string saveFileName)
        {
            var serializedGame = JsonConvert.SerializeObject(board, Formatting.Indented);

            // TODO: Improve this save function
            File.WriteAllText(SaveDirectory + saveFileName + ".json", serializedGame);
        }

        private static void SetupTestData(Board board)
        {
            board.Players.Add(new Player()
            {
                Name = "Ching Lee",
                LocationIdentifier = "12",
                Health = 5,
                Sanity = 3,
                TrainTicketCount = 1,
                PlaneTicketCount = 0,
                IsLeader = true,
                Assets = new List<string>() { "Lucky Rabbit's Foot", "Lucky Charm" },
                Artifacts = new List<string>() { "Some Shiney Gem" },
                Conditions = new List<string>() { "Dark Pact" },
                Improvements = new List<string>() { "+2 Perception", "+1 Strength" }
            });

            board.Locations = new List<Location>() {
                new Location() {
                Identifier = "1",
                ClueCount = 1,
                EldrichTokenCount = 0,
                GateToken = true,
                RumorToken = false,
                ExclamationToken = false,
                MonsterNames = new List<string>(){ "Deep One", "Vampire" }},

                new Location{
                    Identifier = "San Francisco",
                    ClueCount = 0,
                    EldrichTokenCount = 1,
                    GateToken = false,
                    RumorToken = true,
                    ExclamationToken = true,
                }
            };

            board.ChosenOne = "The Dark Lord Cthulhu";
            board.CurrentMystery = "Some spooky mystery";
            board.CurrentMysteryProgress = "2 clues";
            board.DoomTrackerLocation = 10;
            board.ExpeditionLocation = "Antarctica";
            board.OmenTrackLocation = OmenTrackSymbols.RedBall;
            board.OngoingMythos = new List<string> { "Some spookey mythos card. 1 Clue" };
            board.RemainingMythos = new List<string>() { "1 mythos card", "some other mythos card" };
            board.SolvedMysteries = new List<string>() { "Some mystery we already solved" };
        }
    }
}
