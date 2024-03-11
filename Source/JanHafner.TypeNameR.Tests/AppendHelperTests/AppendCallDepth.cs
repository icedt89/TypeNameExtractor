﻿using FluentAssertions;
using JanHafner.TypeNameR.Helper;
using System.Text;
using Xunit;

namespace JanHafner.TypeNameR.Tests.AppendHelperTests;

public sealed class AppendCallDepth
{
    [Fact]
    public void AppendsCorrectly()
    {
        // Arrange
        var stringBuilder = new StringBuilder();
        uint callDepth = 34;

        // Act
        stringBuilder.AppendCallDepth(callDepth);

        // Assert
        stringBuilder.ToString().Should().Be($"{Constants.RecursionMarkWithLeadingAndEndingSpace}{callDepth}");
    }
}