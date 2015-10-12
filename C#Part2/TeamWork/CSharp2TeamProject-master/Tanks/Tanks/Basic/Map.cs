using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic
{
    public class Map
    {
        public Map(Level level)
        {
            this.Level = level;   
        }

        public Level Level { get; set; }
        public string MapAsString { get; set; }
        public char[,] Matrix { get; set; }

        private void MakeMap()
        {
            this.Matrix = new char[World.Instance.Height, World.Instance.Width];

            if (this.Level == Level.One)
            {
                this.MapAsString = "";

            }
            else if (this.Level == Level.Two)
            {
                this.MapAsString = "";
            }
            else if (this.Level == Level.Three)
            {
                this.MapAsString = "";
            }
            else if (this.Level == Level.Four)
            {
                this.MapAsString = "";
            }
            else if (this.Level == Level.Five)
            {
                this.MapAsString = "";
            }
            else throw new Exception("Invalid level " + this.Level);
        }

        public void PrintMap()
        {
            if (this.MapAsString.Length <= 0) throw new Exception("Map is not initialized" + this.MapAsString);
            UI.ConsoleHelper.ClearAndResetConsole();
            UI.ConsoleHelper.WriteOnPosition(this.MapAsString, 0, 0);
        }

        public void PlaceObject (Position position, WorldObject obj)
        {
            UI.ConsoleHelper.ClearAndResetConsole();
            UI.ConsoleHelper.WriteOnPosition(obj.Suit.StringRepresentation, position.X, position.Y, obj.Suit.ForegroundColor, obj.Suit.BackgroundColor);

        }
    }
}
