﻿using Infrastructure.Services;
using UnityEngine;

namespace Services.Inputs
{
    public interface IInputService : IService
    {
        Vector2 Axis { get; }
        void OnMoveControls();
        void OffMoveControls();
    }
}