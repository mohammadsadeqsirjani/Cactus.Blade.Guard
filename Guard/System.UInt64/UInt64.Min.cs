﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Min(ulong input, ulong minimum)
    {
        return Guard.MustBe.Min(input, minimum);
    }

    public static IGuard Min(ulong input, ulong minimum, string paramName)
    {
        return Guard.MustBe.Min(input, minimum, paramName);
    }

    public static IGuard Min(ulong input, ulong minimum, string paramName, string message)
    {
        return Guard.MustBe.Min(input, minimum, paramName, message);
    }
}