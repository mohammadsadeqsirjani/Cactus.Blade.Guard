﻿using Cactus.Blade.Guard;
using System;
using System.ComponentModel;

public static partial class GuardExtension
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="input"/> is less than <paramref name="rangeFrom"/> or greater than <paramref name="rangeTo"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static decimal OutOfRange(this IGuardClause _, decimal input, decimal rangeFrom, decimal rangeTo)
    {
        return Guard.Against.OutOfRange<decimal>(input, rangeFrom, rangeTo);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="input"/> is less than <paramref name="rangeFrom"/> or greater than <paramref name="rangeTo"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static decimal OutOfRange(this IGuardClause _, decimal input, string paramName, decimal rangeFrom, decimal rangeTo)
    {
        return Guard.Against.OutOfRange<decimal>(input, paramName, rangeFrom, rangeTo);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="input"/> is less than <paramref name="rangeFrom"/> or greater than <paramref name="rangeTo"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static decimal OutOfRange(this IGuardClause _, decimal input, string paramName, string message, decimal rangeFrom, decimal rangeTo)
    {
        return Guard.Against.OutOfRange<decimal>(input, paramName, message, rangeFrom, rangeTo);
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException" /> if <paramref name="input"/> is not a valid enum value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static decimal OutOfRange<T>(this IGuardClause _, decimal input) where T : struct, Enum
    {
        return Guard.Against.OutOfRange<T>(input, null, null);
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException" /> if <paramref name="input"/> is not a valid enum value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static decimal OutOfRange<T>(this IGuardClause _, decimal input, string paramName) where T : struct, Enum
    {
        return Guard.Against.OutOfRange<T>(input, paramName, null);
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException" /> if <paramref name="input"/> is not a valid enum value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <param name="input"></param>
    /// <param name="paramName"></param>
    /// <param name="message"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public static decimal OutOfRange<T>(this IGuardClause _, decimal input, string paramName, string message) where T : struct, Enum
    {
        if (!Enum.IsDefined(typeof(T), input))
            throw new InvalidEnumArgumentException(paramName, input.ToInt32(), typeof(T));

        return input;
    }
}