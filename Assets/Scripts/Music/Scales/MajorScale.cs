using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Music.Scales
{
    class MajorScale : IScales
    {
        public Steps[] ScaleForm { get; set; }

        public MajorScale()
        {
            ScaleForm = new Steps[]{ (Steps)2, (Steps)2, (Steps)1, (Steps)2, (Steps)2, (Steps)2, (Steps)1 };
        }
    }
}
