
namespace DafWardrobe.Domain.Models;
public abstract class WardrobeElement
{
    public int Size { get; protected set; }

    public bool Fits(int wallLength) => Size <= wallLength;
}
