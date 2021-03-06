﻿using ArclightWrench.Simulation.Logic.Game;
using ArclightWrench.Simulation.Logic.Input;
using Entitas;
using Source.ScriptableObjectsDefinition;
using UnityEngine;

namespace ArclightWrench.Simulation
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private ViewLibrary _viewLibrary;

        [SerializeField]
        private ActorGameEvent _spawnEvent;
    
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
                .Add(new GameFeature(contexts));
        }
    }
}