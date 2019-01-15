using System;
namespace _22_TortoiseAndHareRace.Properties
{
    public class Albert : Runner
    {
        public Albert(int currentPosition, int lane, string name)
        {
            CurrentPosition = currentPosition;
            Lane = lane;
            Name = name;
            RunnerSymbol = "A";
            MoveDescription = $"{Name} is READY! SET! GO!";
            AllRunners.Add(this);
        }

        public override void CalculateMove()
        {
            var move = GetMoveType();

            if (move >= 1 && move <= 50)
            {
                MakeMove(MoveType.AlbertJump);
                MoveDescription = $"{Name} made Albert Jump (+5)";
            }
            else if (move >= 51 && move <= 70)
            {
                MakeMove(MoveType.Slip);
                MoveDescription = $"{Name} Slipped (-6)";
            }
            else
            {
                MakeMove(MoveType.SlowPlod);
                MoveDescription = $"{Name} moved Slow Plod (+1)";
            }
        }
    }
}
