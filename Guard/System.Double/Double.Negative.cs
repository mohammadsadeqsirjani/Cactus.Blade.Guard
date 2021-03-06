﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static IGuard Negative(this IGuard _, double input)
    {
        return Guard.MustBe.Negative<double>(input);
    }

    public static IGuard Negative(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.Negative<double>(input, paramName);
    }

    public static IGuard Negative(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.Negative<double>(input, paramName, message);
    }
}