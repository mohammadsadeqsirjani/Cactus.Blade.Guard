﻿using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static DateTimeOffset Default(this IGuardClause _, DateTimeOffset input)
    {
        return Guard.Against.Default<DateTimeOffset>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static DateTimeOffset Default(this IGuardClause _, DateTimeOffset input, string paramName)
    {
        return Guard.Against.Default<DateTimeOffset>(input, paramName, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static DateTimeOffset Default(this IGuardClause _, DateTimeOffset input, string paramName, string message)
    {
        return Guard.Against.Default<DateTimeOffset>(input, paramName, message);
    }
}