﻿using System;

namespace VH.MiniService.Common.Service.Options
{
    public class HealthChecksOptions
    {
        public bool Enable { get; init; } = true;
        public string[] Tags { get; init; } = Array.Empty<string>();
    }
}
