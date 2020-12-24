﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static double NotDefault(this IGuard _, double input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static double NotDefault(this IGuard _, double input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static double NotDefault(this IGuard _, double input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<double>(input, paramName, message);
    }
}