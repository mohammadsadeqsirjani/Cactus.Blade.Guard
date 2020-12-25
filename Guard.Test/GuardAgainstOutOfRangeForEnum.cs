﻿using Cactus.Blade.Guard;
using System.ComponentModel;
using Xunit;

namespace Guard.Test
{
    public class GuardMustBeOutOfRangeForEnum
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void DoesNothingGivenInRangeValue(int enumValue)
        {
            Cactus.Blade.Guard.Guard.MustBe.OutOfRange<TestEnum>(enumValue, nameof(enumValue));
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(6)]
        [InlineData(10)]
        public void ThrowsGivenOutOfRangeValue(int enumValue)
        {
            var exception = Assert.Throws<InvalidEnumArgumentException>(() => Cactus.Blade.Guard.Guard.MustBe.OutOfRange<TestEnum>(enumValue, nameof(enumValue)));
            Assert.Equal(nameof(enumValue), exception.ParamName);
        }

        [Theory]
        [InlineData(TestEnum.Budgie)]
        [InlineData(TestEnum.Cat)]
        [InlineData(TestEnum.Dog)]
        [InlineData(TestEnum.Fish)]
        [InlineData(TestEnum.Frog)]
        [InlineData(TestEnum.Penguin)]
        public void DoesNothingGivenInRangeEnum(TestEnum enumValue)
        {
            Cactus.Blade.Guard.Guard.MustBe.OutOfRange(enumValue, nameof(enumValue));
        }


        [Theory]
        [InlineData((TestEnum)(-1))]
        [InlineData((TestEnum)6)]
        [InlineData((TestEnum)10)]
        public void ThrowsGivenOutOfRangeEnum(TestEnum enumValue)
        {
            var exception = Assert.Throws<InvalidEnumArgumentException>(() => Cactus.Blade.Guard.Guard.MustBe.OutOfRange(enumValue, nameof(enumValue)));
            Assert.Equal(nameof(enumValue), exception.ParamName);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void ReturnsExpectedValueGivenInRangeValue(int enumValue)
        {
            var expected = enumValue;
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.MustBe.OutOfRange<TestEnum>(enumValue, nameof(enumValue)));
        }

        [Theory]
        [InlineData(TestEnum.Budgie)]
        [InlineData(TestEnum.Cat)]
        [InlineData(TestEnum.Dog)]
        [InlineData(TestEnum.Fish)]
        [InlineData(TestEnum.Frog)]
        [InlineData(TestEnum.Penguin)]
        public void ReturnsExpectedValueGivenInRangeEnum(TestEnum enumValue)
        {
            var expected = enumValue;
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.MustBe.OutOfRange(enumValue, nameof(enumValue)));
        }

    }


    public enum TestEnum
    {
        Cat = 0,
        Dog = 1,
        Fish = 2,
        Budgie = 3,
        Penguin = 4,
        Frog = 5
    }
}
