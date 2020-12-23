﻿using Cactus.Blade.Guard;

public static partial class GuardExtension
{
    public static short Negative(this IGuard _, short input)
    {
        return Guard.Against.Negative(input, null, null);
    }

    public static short Negative(this IGuard _, short input, string paramName)
    {
        return Guard.Against.Negative(input, paramName, null);
    }

    public static short Negative(this IGuard _, short input, string paramName, string message)
    {
        return Guard.Against.Negative<short>(input, paramName, message);
    }
}