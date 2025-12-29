using FootyHub.Domain.Enums;

namespace FootyHub.Domain.ValueObjects;

public class Position
{
    public string Code { get; private set; } = null!;

    public string DisplayName { get; private set; } = null!;

    public PositionCategory Category { get; private set; }

    private Position() { }

    public Position(string code, PositionCategory category, string displayName)
    {
        Code = code;
        Category = category;
        DisplayName = displayName;

    }

    private Position(string code, string name, PositionCategory cat)
        => (Code, DisplayName, Category) = (code, name, cat);


    public static Position Striker => new Position("ST", "Striker", PositionCategory.Attacker);
    public static Position CenterBack => new Position("CB", "Center Back", PositionCategory.Defender);
    public static Position WingBack => new Position("WB", "Wing Back", PositionCategory.WingBack);
    public static Position MidFielder => new Position("MF", "Midfielder", PositionCategory.Midfielder);
    public static Position Winger => new Position("FW", "Winger", PositionCategory.Winger);

    public bool IsOutfieldPlayer => Category != PositionCategory.Goalkeeper;



    public decimal GetLoadMultiplier() => Category switch
    { PositionCategory.Goalkeeper => 0.6m,
      PositionCategory.Defender => 0.8m,
      PositionCategory.WingBack => 1.0m,
      PositionCategory.Midfielder => 1.2m,
      PositionCategory.Winger => 1.1m,
      PositionCategory.Attacker => 1.3m,
      _ => 1.0m
    };
}
