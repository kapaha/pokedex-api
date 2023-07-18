namespace PokedexAPI.Models;

public partial class Pokemon
{
    public short Ndex { get; set; }

    public string Name { get; set; } = null!;

    public string Type1 { get; set; } = null!;

    public string? Type2 { get; set; }

    public string ImageUrl { get; set; } = null!;
}
