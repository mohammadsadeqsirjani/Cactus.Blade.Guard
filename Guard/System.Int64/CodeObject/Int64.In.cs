﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static IGuard In(this IGuard _, long value, params long[] values)
    {
        return Guard.MustBe.In(value, null, null, values);
    }

    public static IGuard In(this IGuard _, long value, string paramName, params long[] values)
    {
        return Guard.MustBe.In(value, paramName, null, values);
    }

    public static IGuard In(this IGuard _, long value, string paramName, string message, params long[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}