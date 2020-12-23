﻿using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static byte Between(this IGuard _, byte value, byte minimum, byte maximum)
    {
        return Guard.Against.Between(value, null, null, minimum, maximum);
    }

    public static byte Between(this IGuard _, byte value, string paramName, byte minimum, byte maximum)
    {
        return Guard.Against.Between(value, paramName, null, minimum, maximum);
    }

    public static byte Between(this IGuard _, byte value, string paramName, string message, byte minimum, byte maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}