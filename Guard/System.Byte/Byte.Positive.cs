﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Positive(this IGuard _, byte input)
    {
        return Guard.MustBe.Positive<byte>(input);
    }

    public static IGuard Positive(this IGuard _, byte input, string paramName)
    {
        return Guard.MustBe.Positive<byte>(input, paramName);
    }

    public static IGuard Positive(this IGuard _, byte input, string paramName, string message)
    {
        return Guard.MustBe.Positive<byte>(input, paramName, message);
    }
}