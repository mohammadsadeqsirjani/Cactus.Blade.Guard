﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static IGuard NotIn(this IGuard _, long value, params long[] values)
    {
        return Guard.MustBe.NotIn(value, null, null, values);
    }

    public static IGuard NotIn(this IGuard _, long value, string paramName, params long[] values)
    {
        return Guard.MustBe.NotIn(value, paramName, null, values);
    }

    public static IGuard NotIn(this IGuard _, long value, string paramName, string message, params long[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.NotIn(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.NotIn(values)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}