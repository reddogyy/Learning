using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Basic.Interfaces;

namespace Tanks.Basic.Colision_Detection
{
    public sealed class ColisionDetection : IColisionDetection
    {
        static readonly ColisionDetection _instance = new ColisionDetection();

        public static ColisionDetection Instance
        {
            get
            {
                return _instance;
            }
        }

        ColisionDetection()
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

        ///<summary>
        /// Methods
        ///</summary> 

        private void Initialize()
        {

        }
    }
}
