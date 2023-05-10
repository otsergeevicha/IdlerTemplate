﻿using UnityEngine;

namespace Services.Inputs
{
    public interface IInputService
    {
        Vector2 Axis { get; }
        void OnMoveControls();
        void OffMoveControls();
    }
}