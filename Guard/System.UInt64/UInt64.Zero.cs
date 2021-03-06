﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, ulong input)
    {
        return Guard.MustBe.Zero<ulong>(input);
    }

    public static IGuard Zero(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.Zero<ulong>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.Zero<ulong>(input, paramName, message);
    }
}