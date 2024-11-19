using DafWardrobe.Domain.Models;
using FluentAssertions;

namespace DafWardrobe.Domain.Tests.Models;
public class WardrobeElementsShould
{
    [Theory]
    [ClassData(typeof(WardrobeElementsTestData))]
    public void GivenElementsAndWallLenghtWhenFitsShouldReturnExpected(WardrobeElement element, int wallLenght, bool expected)
    {
        //Given & When
        var actual = element.Fits(wallLenght);
        
        //Should
        actual.Should().Be(expected);
    }
}
