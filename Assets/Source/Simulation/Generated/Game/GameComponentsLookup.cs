//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentsLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int Actor = 0;
    public const int GameObject = 1;
    public const int Position = 2;
    public const int SpawnActorCommand = 3;

    public const int TotalComponents = 4;

    public static readonly string[] componentNames = {
        "Actor",
        "GameObject",
        "Position",
        "SpawnActorCommand"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(ActorComponent),
        typeof(GameObjectComponent),
        typeof(PositionComponent),
        typeof(SpawnActorCommandComponent)
    };
}
