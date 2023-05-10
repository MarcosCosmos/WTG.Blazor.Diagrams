﻿using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models.Base;
using System;

namespace Blazor.Diagrams.Core.Models;

public class ResizerModel : Model
{
    public ResizerModel(NodeModel parent, ResizerPosition alignment)
    {
        Parent = parent;
        Alignment = alignment;
    }

    public NodeModel Parent { get; }
    public ResizerPosition Alignment { get; }

    public bool ResizingEnabled { get; set; }
    public bool OnlyResizeWhenSelected { get; set; }

    public Size MinimumDimensions { get; set; }

    public Action<Size>? SizeChange { get; set; }
}

public enum ResizerPosition
{
    TopRight,
    TopLeft,
    BottomRight,
    BottomLeft
}
