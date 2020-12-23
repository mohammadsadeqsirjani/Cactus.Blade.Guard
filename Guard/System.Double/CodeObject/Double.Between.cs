﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static double Between(this IGuard _, double value, double minimum, double maximum)
    {
        return Guard.Against.Between(value, null, null, minimum, maximum);
    }

    public static double Between(this IGuard _, double value, string paramName, double minimum, double maximum)
    {
        return Guard.Against.Between(value, paramName, null, minimum, maximum);
    }

    public static double Between(this IGuard _, double value, string paramName, string message, double minimum, double maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}