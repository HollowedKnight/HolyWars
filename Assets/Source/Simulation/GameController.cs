﻿using Entitas;
using Source.ScriptableObjects;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private ViewLibrary _viewLibrary;

    private Systems _systems;
    private Contexts _contexts;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        _systems = CreateSystems(_contexts);
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }

    private Systems CreateSystems(Contexts contexts)
    {
        return new Feature("Systems")
            .Add(new InputFeature(contexts))
            .Add(new GameFeature(contexts))
            .Add(new ViewFeature(contexts));
    }
}