
namespace DafWardrobe.Domain;

public class Wardrobe
{
    public const int SMALL = 50;
    public const int MEDIUM = 75;
    public const int LARGE = 100;
    public const int EXTRA_LARGE = 120;
    private readonly List<int> _wardrobeElementSizes;
    private readonly Dictionary<int,string> _wardrobeElementSizes2;

    public Wardrobe()
    {
        _wardrobeElementSizes = [SMALL, MEDIUM, LARGE, EXTRA_LARGE];
        _wardrobeElementSizes2 = new()
        {
            {SMALL, "Small" },
            {MEDIUM, "Medium" },
            {LARGE, "Large" },
            {EXTRA_LARGE, "ExtraLarge" }
        };
    }

    public IEnumerable<WardrobeConfiguration> GetAllConfigurations(int wallLength)
    {
        var configurations = new List<WardrobeConfiguration>();
        if (wallLength == 0  || wallLength <= _wardrobeElementSizes.Min())
            return [];
        foreach ( var piece in _wardrobeElementSizes )
        {
        }
        return configurations;
    }
}
