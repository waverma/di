﻿using System.Collections.Generic;
using System.Drawing;

namespace TagsCloudVisualization.Printing
{
    public interface IRectanglesReCalculator
    {
        IList<Rectangle> RecalculateRectangles(IList<Rectangle> rectangles, Size defaultMaxSize);
        IList<Rectangle> MoveToCenter(IList<Rectangle> rectangles);
    }
}