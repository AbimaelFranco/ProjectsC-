/// <summary>
/// Represents a hero character in the terminal game with basic attributes.
/// </summary>
public class Hero
{
    /// <summary>
    /// Gets or sets the name of the hero. Defaults to "Hero".
    /// </summary>
    public string Name { get; set; } = "Hero";

    /// <summary>
    /// Gets or sets the position of the hero as a string. Defaults to "00".
    /// </summary>
    public string Position { get; set; } = "00";

    /// <summary>
    /// Gets or sets the health points of the hero. Defaults to 100.
    /// </summary>
    public float Health { get; set; } = 100;

    /// <summary>
    /// Gets or sets the damage points the hero can inflict. Defaults to 5.
    /// </summary>
    public float Damage { get; set; } = 5;

    /// <summary>
    /// Gets or sets the experience points of the hero. Defaults to 0.
    /// </summary>
    public int Experience { get; set; } = 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="Hero"/> class with default attribute values.
    /// </summary>
    public Hero()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Hero"/> class with a specified name.
    /// </summary>
    /// <param name="name">The name to assign to the hero.</param>
    public Hero(string name)
    {
        Name = name;
    }
}
