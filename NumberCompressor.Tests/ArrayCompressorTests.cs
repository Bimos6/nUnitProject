using NUnit.Framework;
using System;
using NumberCompressor;

namespace NumberCompressor.Tests
{
    [TestFixture]
    public class ArrayCompressorTests
    {
        [Test]
        public void CompressNumbers_WithConsecutiveDuplicates_RemovesThem()
        {
            int[] input = new int[] { 1, 1, 2, 2, 3 };
            int[] expected = new int[] { 1, 2, 3 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithNonConsecutiveDuplicates_KeepsThem()
        {
            int[] input = new int[] { 0, 0, 1, 1, 0 };
            int[] expected = new int[] { 0, 1, 0 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithEmptyArray_ReturnsEmptyArray()
        {
            int[] input = Array.Empty<int>();
            int[] expected = Array.Empty<int>();

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithSingleElement_ReturnsSameArray()
        {
            int[] input = new int[] { 42 };
            int[] expected = new int[] { 42 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithNoDuplicates_ReturnsSameArray()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithAllSameNumbers_ReturnsSingleElement()
        {
            int[] input = new int[] { 7, 7, 7, 7, 7 };
            int[] expected = new int[] { 7 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithLongDuplicatesSequence_WorksCorrectly()
        {
            int[] input = new int[] { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 5, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithNegativeNumbers_WorksCorrectly()
        {
            int[] input = new int[] { -1, -1, -2, -2, -3, -3 };
            int[] expected = new int[] { -1, -2, -3 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompressNumbers_WithNullInput_ThrowsArgumentNullException()
        {
            int[] input = null;

            Assert.That(() => ArrayCompressor.CompressNumbers(input),
                Throws.ArgumentNullException);
        }

        [Test]
        public void CompressNumbers_WithComplexPattern_HandlesCorrectly()
        {
            int[] input = new int[] { 1, 1, 2, 2, 2, 1, 1, 3, 3, 2, 2, 2 };
            int[] expected = new int[] { 1, 2, 1, 3, 2 };

            int[] result = ArrayCompressor.CompressNumbers(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}