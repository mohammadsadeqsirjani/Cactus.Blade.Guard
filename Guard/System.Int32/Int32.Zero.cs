﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, int input)
    {
        return Guard.MustBe.Zero<int>(input);
    }

    public static IGuard Zero(this IGuard _, int input, string paramName)
    {
        return Guard.MustBe.Zero<int>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, int input, string paramName, string message)
    {
        return Guard.MustBe.Zero<int>(input, paramName, message);
    }
}