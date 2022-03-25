﻿using Moq;
using Xunit;

namespace JanHafner.TypeNameExtractor.Tests.TypeNameExtractorExtensionsTests;

public sealed class ExtractReadableName
{
    [Fact]
    public void CallsTheTypeNameExtractorWithTheSuppliedType()
    {
        // Arrange
        var typeNameExtractorMock = new Mock<ITypeNameExtractor>();

        // Act
        typeNameExtractorMock.Object.ExtractReadableName<GenericTestClass<TestClass>>();

        // Assert
        typeNameExtractorMock.Verify(tne => tne.ExtractReadableName(typeof(GenericTestClass<TestClass>)), Times.Once);
    }

    [Fact]
    public void ThrowsExceptionIfTypeNameExtractorIsNull()
    {
        // Arrange
        ITypeNameExtractor? readableTypeNameExtractor = null;

        // Act, Assert
        Assert.Throws<ArgumentNullException>(() => readableTypeNameExtractor!.ExtractReadableName<GenericTestClass<TestClass>>());
    }
}
