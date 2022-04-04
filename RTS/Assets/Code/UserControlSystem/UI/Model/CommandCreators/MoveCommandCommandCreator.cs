using Abstractions.Commands.CommandsInterfaces;
using Code.Core;
using UnityEngine;

namespace UserControlSystem.CommandCreators
{
    public class MoveCommandCommandCreator : CancellableCommandCreatorBase<IMoveCommand, Vector3>

    {
        protected override IMoveCommand createCommand(Vector3 argument) => new MoveCommand(argument);
    }
}