﻿using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Null(DateTime? input)
    {
        return Guard.MustBe.Null(input, null, null);
    }

    public static IGuard Null(DateTime? input, string paramName)
    {
        return Guard.MustBe.Null(input, paramName, null);
    }

    public static IGuard Null(DateTime? input, string paramName, string message)
    {
        return Guard.MustBe.Null(input, paramName, message);
    }
}