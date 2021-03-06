﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard PositiveOrZero(this IGuard _, decimal input)
    {
        return Guard.MustBe.PositiveOrZero<decimal>(input);
    }

    public static IGuard PositiveOrZero(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.PositiveOrZero<decimal>(input, paramName);
    }

    public static IGuard PositiveOrZero(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.PositiveOrZero<decimal>(input, paramName, message);
    }
}