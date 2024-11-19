//using FluentAssertions;

//namespace DafWardrobe.Domain.Tests;

//public class WardrobeTests
//{
//    private readonly Wardrobe _sut = new();

//    [Theory]
//    [MemberData(nameof(WardrobeData))]
//    public void GetAllCombinations(int wallLength, IEnumerable<WardrobeConfiguration> wardrobeConfigurations)
//    {
//        // Given & When
//        var actual = _sut.GetAllConfigurations(wallLength);

//        // Should
//        actual.Should().BeEquivalentTo(wardrobeConfigurations);
//    }

//    public static TheoryData<int,IEnumerable<WardrobeConfiguration>> WardrobeData()
//    {
//        var configfor250_1 = new WardrobeConfiguration
//        {
//            Elements = [WardrobeSizes.Large, WardrobeSizes.Medium, WardrobeSizes.Medium]
//        };
//        var configfor250_2 = new WardrobeConfiguration
//        {
//            Elements = [WardrobeSizes.Small, WardrobeSizes.Small, WardrobeSizes.Small, WardrobeSizes.Small, WardrobeSizes.Small]
//        };
//        var configfor250_3 = new WardrobeConfiguration
//        {
//            Elements = [WardrobeSizes.Large, WardrobeSizes.Large, WardrobeSizes.Small]
//        };
//        List<WardrobeConfiguration> configsFor250cm = [configfor250_1, configfor250_2, configfor250_3];
//        return new()
//        {
//            { 49, [] },
//            { 50, [new WardrobeConfiguration { Elements = [WardrobeSizes.Small] }] },
//            { 250, configsFor250cm}
//        };
//    }

//}