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
    public static double Default(this IGuard _, double input)
    {
        return Guard.Against.Default<double>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is default for that type.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double Default(this IGuard _, double input, string paramName)
    {
        return Guard.Against.Default<double>(input, paramName, null);
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
    public static double Default(this IGuard _, double input, string paramName, string message)
    {
        return Guard.Against.Default<double>(input, paramName, message);
    }
}