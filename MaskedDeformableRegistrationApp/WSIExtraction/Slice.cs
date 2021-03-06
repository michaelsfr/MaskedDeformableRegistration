﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedDeformableRegistrationApp.WSIExtraction
{
    /// <summary>
    /// Class represents data of wsi images.
    /// </summary>
    class Slice
    {
        public string Path { get; set; }
        public string WsiSourcePath { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
