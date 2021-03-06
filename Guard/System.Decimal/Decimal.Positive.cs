﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, decimal input)
    {
        return Guard.MustBe.Positive<decimal>(input);
    }

    public static IGuard Positive(this IGuard _, decimal input, string paramName)
    {
        return Guard.MustBe.Positive<decimal>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, decimal input, string paramName, string message)
    {
        return Guard.MustBe.Positive<decimal>(input, paramName, message);
    }
}