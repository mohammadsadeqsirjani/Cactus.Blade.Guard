﻿using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    private static T NegativeOrZero<T>(this IGuardClause _, T input) where T : struct, IComparable
    {
        return Guard.Against.NegativeOrZero(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    private static T NegativeOrZero<T>(this IGuardClause _, T input, string paramName) where T : struct, IComparable
    {
        return Guard.Against.NegativeOrZero(input, paramName, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    private static T NegativeOrZero<T>(this IGuardClause _, T input, string paramName, string message) where T : struct, IComparable
    {
        paramName ??= nameof(input);
        message ??= $"Required input {paramName} cannot be zero or negative.";

        if (input.CompareTo(default(T)) <= 0)
            throw new ArgumentException(message, paramName);

        return input;
    }
}
