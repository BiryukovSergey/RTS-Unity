using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public class ProduceUnitCommandHeir : IProduceUnitCommand
    {
        public GameObject UnitPrefab { get; }
    }
}