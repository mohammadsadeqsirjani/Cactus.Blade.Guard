﻿using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    public static decimal NegativeOrZero(this IGuardClause _, decimal input)
    {
        return Guard.Against.NegativeOrZero<decimal>(input);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    public static decimal NegativeOrZero(this IGuardClause _, decimal input, string paramName)
    {
        return Guard.Against.NegativeOrZero<decimal>(input, paramName);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    public static decimal NegativeOrZero(this IGuardClause _, decimal input, string paramName, string message)
    {
        return Guard.Against.NegativeOrZero<decimal>(input, paramName, message);
    }
}