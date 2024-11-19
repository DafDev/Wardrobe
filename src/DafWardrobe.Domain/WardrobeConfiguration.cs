using DafWardrobe.Domain.Models;

namespace DafWardrobe.Domain;
public class WardrobeConfiguration
{
    public IEnumerable<WardrobeElement> Elements { get; set; } = [];
    public int Size { get => Elements.Sum(elem => elem.Size); }
}
