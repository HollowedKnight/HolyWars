//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ViewEntity {

    public ViewComponent view { get { return (ViewComponent)GetComponent(ViewComponentsLookup.View); } }
    public bool hasView { get { return HasComponent(ViewComponentsLookup.View); } }

    public void AddView(UnityEngine.GameObject newGameObject) {
        var index = ViewComponentsLookup.View;
        var component = CreateComponent<ViewComponent>(index);
        component.GameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplaceView(UnityEngine.GameObject newGameObject) {
        var index = ViewComponentsLookup.View;
        var component = CreateComponent<ViewComponent>(index);
        component.GameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemoveView() {
        RemoveComponent(ViewComponentsLookup.View);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ViewMatcher {

    static Entitas.IMatcher<ViewEntity> _matcherView;

    public static Entitas.IMatcher<ViewEntity> View {
        get {
            if (_matcherView == null) {
                var matcher = (Entitas.Matcher<ViewEntity>)Entitas.Matcher<ViewEntity>.AllOf(ViewComponentsLookup.View);
                matcher.componentNames = ViewComponentsLookup.componentNames;
                _matcherView = matcher;
            }

            return _matcherView;
        }
    }
}
