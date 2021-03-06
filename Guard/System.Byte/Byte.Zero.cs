﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Zero(this IGuard _, byte input)
    {
        return Guard.MustBe.Zero<byte>(input);
    }

    public static IGuard Zero(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.Zero<byte>(input, paramName);
    }


    public static IGuard Zero(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.Zero<byte>(input, paramName, message);
    }
}