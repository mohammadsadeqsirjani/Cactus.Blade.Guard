﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard InRange(this IGuard _, double value, double minimum, double maximum)
    {
        return Guard.MustBe.InRange(value, null, null, minimum, maximum);
    }

    public static IGuard InRange(this IGuard _, double value, string paramName, double minimum, double maximum)
    {
        return Guard.MustBe.InRange(value, paramName, null, minimum, maximum);
    }

    public static IGuard InRange(this IGuard _, double value, string paramName, string message, double minimum, double maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}