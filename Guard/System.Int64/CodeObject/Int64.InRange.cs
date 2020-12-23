﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static long InRange(this IGuard _, long value, long minimum, long maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static long InRange(this IGuard _, long value, string paramName, long minimum, long maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static long InRange(this IGuard _, long value, string paramName, string message, long minimum, long maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}