using System;
using AutoFixture.Xunit2;
using Xunit;

namespace RiderTestProject
{
    public class Tests
    {        
        [Theory]
        [InlineData(10)]
        public void DetectedProperly(int v)
        {
            ++v;
        }
        
        [Theory]
        [AutoData]
        public void NotDetectedProperly(int v)
        {
            ++v;
        }
    }
}