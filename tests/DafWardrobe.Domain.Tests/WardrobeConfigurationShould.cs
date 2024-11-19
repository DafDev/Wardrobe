using DafWardrobe.Domain.Tests.TestData;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DafWardrobe.Domain.Tests;
public class WardrobeConfigurationShould
{
    [Theory]
    [ClassData(typeof(WadrobeConfigurationTestData))]
    public void GivenConfigurationShouldReturnSize(WardrobeConfiguration configurations, int totalSize)
    {
        //Given & When
        configurations.Size.Should().Be(totalSize);
    }
}
