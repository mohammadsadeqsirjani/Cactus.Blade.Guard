﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Null(double? input)
    {
        return Guard.MustBe.Null(input);
    }

    public static IGuard Null(double? input, string paramName)
    {
        return Guard.MustBe.Null(input, paramName);
    }

    public static IGuard Null(double? input, string paramName, string message)
    {
        return Guard.MustBe.Null(input, paramName, message);
    }
}