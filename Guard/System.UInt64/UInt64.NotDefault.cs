﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, ulong input)
    {
        return Guard.MustBe.NotDefault<ulong>(input);
    }

    public static IGuard NotDefault(this IGuard _, ulong input, string paramName)
    {
        return Guard.MustBe.NotDefault<ulong>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, ulong input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<ulong>(input, paramName, message);
    }
}