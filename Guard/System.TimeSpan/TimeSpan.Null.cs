﻿using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Null(TimeSpan input)
    {
        return Guard.MustBe.Null(input, null, null);
    }

    public static IGuard Null(TimeSpan input, string paramName)
    {
        return Guard.MustBe.Null(input, paramName, null);
    }

    public static IGuard Null(TimeSpan input, string paramName, string message)
    {
        return Guard.MustBe.Null(input, paramName, message);
    }
}