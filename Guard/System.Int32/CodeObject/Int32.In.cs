﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;
using System.Linq;

public static partial class GuardExtension
{
    public static int In(this IGuard _, int value, params int[] values)
    {
        return Guard.Against.In(value, null, null, values);
    }

    public static int In(this IGuard _, int value, string paramName, params int[] values)
    {
        return Guard.Against.In(value, paramName, null, values);
    }

    public static int In(this IGuard _, int value, string paramName, string message, params int[] values)
    {
        paramName ??= nameof(value);
        message ??= Message.In(value, values);

        if (!values.Any())
            throw new ArgumentNullException(Message.Null(values), nameof(values));

        if (value.In(values)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}