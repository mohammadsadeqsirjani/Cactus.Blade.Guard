﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard Between(this IGuard _, float value, float minimum, float maximum)
    {
        return Guard.MustBe.Between(value, null, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, float value, string paramName, float minimum, float maximum)
    {
        return Guard.MustBe.Between(value, paramName, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, float value, string paramName, string message, float minimum, float maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}