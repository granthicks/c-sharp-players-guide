/* War Preparations
*
* - Swords can be made out of the following materials: bronze, iron, steel, and the rare binarium. Create an enumeration to represent the material type.
* - Gemstones can be attached to a sword, which gives them strange powers through Cygnus and Lyra’s touch. Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone. Or no gemstone at all. Create an enumeration to represent a gemstone type.
* - Create a Sword record with a material, gemstone, length, and crossguard width.
* - In your main program, create a basic Sword instance made out of iron and with no gemstone. Then
*   create two variations on the basic sword using with expressions.
* - Display all three sword instances with code like Console.WriteLine(original);
*/

Console.Title = "War Preparations";

Sword original = new Sword(MaterialType.Iron, GemstoneType.None, 1.2, 0.2);
Sword withMaterial = original with { Material = MaterialType.Binarium };
Sword withGemstone = original with { Gemstone = GemstoneType.Bitstone };

Console.WriteLine("War Preparations: Swords");
Console.WriteLine(original);
Console.WriteLine(withMaterial);
Console.WriteLine(withGemstone);

public record Sword(MaterialType Material, GemstoneType Gemstone, double Length, double CrossguardWidth);

public enum MaterialType
{
    Bronze,
    Iron,
    Steel,
    Binarium
}

public enum GemstoneType
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    None
}
