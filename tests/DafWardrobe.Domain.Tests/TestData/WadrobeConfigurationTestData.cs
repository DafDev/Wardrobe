using DafWardrobe.Domain.Models;

namespace DafWardrobe.Domain.Tests.TestData;
public class WadrobeConfigurationTestData : TheoryData<WardrobeConfiguration, int>
{
    public WadrobeConfigurationTestData()
    {
        var smallElement = new SmallWardrobeElement();
        var mediumElement = new MediumWardrobeElement();
        var largeElement = new LargeWardrobeElement();
        var extraLargeElement = new ExtraLargeWardrobeElement();
        var smallWardobe = new WardrobeConfiguration
        {
            Elements = [smallElement]
        };
        var veryLargeWardrobe = new WardrobeConfiguration
        {
            Elements = [mediumElement, largeElement, extraLargeElement] 
        };
        Add(new WardrobeConfiguration(), 0);
        Add(smallWardobe, 50);
        Add(veryLargeWardrobe, 295);
    }
}
