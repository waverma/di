﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using TagsCloudVisualization;
using TagsCloudVisualization.Printing;

namespace TagsCloudVisualizationTest
{
    public class SaveBitmapWhenFailure : Attribute
    {
        public string SavePath { get; private set; }
        
        public bool TrySave(IEnumerable<Rectangle> rectangles, string methodName)
        {
            SavePath = Path.GetFullPath($"..\\..\\TestBitmaps{Path.DirectorySeparatorChar}Failure__{methodName}.jpg");
            
            try
            {
                new RectanglePrinter()
                    .GetBitmap(rectangles)  // Throw ArgumentException while creating too big bmp.
                    .Save(SavePath, ImageFormat.Jpeg);
            }
            catch (ArgumentException _)
            {
                return false;
            }

            return true;
        }
    }
}