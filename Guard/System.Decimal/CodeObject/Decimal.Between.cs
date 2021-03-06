﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static decimal Between(this IGuard _, decimal value, decimal minimum, decimal maximum)
    {
        return Guard.MustBe.Between(value, null, null, minimum, maximum);
    }

    public static decimal Between(this IGuard _, decimal value, string paramName, decimal minimum, decimal maximum)
    {
        return Guard.MustBe.Between(value, paramName, null, minimum, maximum);
    }

    public static decimal Between(this IGuard _, decimal value, string paramName, string message, decimal minimum, decimal maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}