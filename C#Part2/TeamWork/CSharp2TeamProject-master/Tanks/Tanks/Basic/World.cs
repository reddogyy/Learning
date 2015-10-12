using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Basic.Interfaces;

namespace Tanks.Basic
{
    public sealed class World : IWorld
    {
        static readonly World _instance = new World();

        public static World Instance
        {
            get
            {
                return _instance;
            }
        }

        World()
        {
            Initialize();
        }

        ///<summary>
        /// Properties
        ///</summary>        

        public int Height
        {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public int Width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public Level CurrentLevel { get; set; }

        public Map Map { get; set; }

        ///<summary>
        /// Methods
        ///</summary>

        private void Initialize()
        {
            UI.ConsoleHelper.ResizeConsole(40, 60);
            this.CurrentLevel = Level.One;
            MakeMap();
        }

        private void MakeMap()
        {
            this.Map = new Map(this.CurrentLevel);
            this.Map.PrintMap();
        }
    }
}
