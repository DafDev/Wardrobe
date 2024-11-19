using DafWardrobe.Domain.Models;

namespace DafWardrobe.Domain.Tests.Models;

internal class WardrobeElementsTestData : TheoryData<WardrobeElement, int, bool>
{
    public WardrobeElementsTestData()
    {
        Add(new SmallWardrobeElement(), 80, true);
        Add(new SmallWardrobeElement(), 30, false);
        Add(new MediumWardrobeElement(), 80, true);
        Add(new MediumWardrobeElement(), 50, false);
        Add(new LargeWardrobeElement(), 120, true);
        Add(new LargeWardrobeElement(), 30, false);
        Add(new ExtraLargeWardrobeElement(), 120, true);
        Add(new ExtraLargeWardrobeElement(), 30, false);
    }
}