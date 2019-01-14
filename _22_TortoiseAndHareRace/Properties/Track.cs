using System;
namespace _22_TortoiseAndHareRace.Properties
{
    public class Track
    {
        public int TrackLength = 10;
        public int NumOfRunners = 2;

        public string[,] Tracks { get; set; }

        public Track()
        {
            Tracks = new string[TrackLength + 1, NumOfRunners];
        }

        public void DisplayRaceTrack()
        {
            Console.WriteLine();
            for (var i = 0; i <= TrackLength; i++)
            {
                Console.Write(i + "  |  ");
                for (var c = 0; c < NumOfRunners; c++)
                {
                    if (Tracks[i, c] == null)
                        Console.Write("  |  ");
                    else
                        Console.Write(Tracks[i,c] + " | ");
                }
                Console.WriteLine();
            }
        }

        public void RunnerPosition(Runner runner)
        {
            Tracks[runner.OrigPosition, runner.Lane] = null;
            Tracks[runner.CurrentPosition, runner.Lane] = runner.RunnerSymbol;
        }

    }
}
