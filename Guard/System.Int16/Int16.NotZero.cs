﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard NotZero(this IGuard _, short input)
    {
        return Guard.MustBe.NotZero<double>(input);
    }

    public static IGuard NotZero(this IGuard _, short input, string paramName)
    {
        return Guard.MustBe.NotZero<double>(input, paramName);
    }


    public static IGuard NotZero(this IGuard _, short input, string paramName, string message)
    {
        return Guard.MustBe.NotZero<short>(input, paramName, message);
    }
}