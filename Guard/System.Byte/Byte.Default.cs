﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, byte input)
    {
        return Guard.MustBe.Default<byte>(input);
    }

    public static IGuard Default(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.Default<byte>(input, paramName);
    }

    public static IGuard Default(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.Default<byte>(input, paramName, message);
    }
}