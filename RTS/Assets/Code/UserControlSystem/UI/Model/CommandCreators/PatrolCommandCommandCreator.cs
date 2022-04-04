using Abstractions.Commands.CommandsInterfaces;
using Code.Core;
using UnityEngine;
using Zenject;

namespace UserControlSystem.CommandCreators
{
    public class PatrolCommandCommandCreator : CancellableCommandCreatorBase<IPatrolCommand, Vector3>
    {
        [Inject] private SelectableValue _selectable;

        protected override IPatrolCommand createCommand(Vector3 argument) =>
            new PatrolCommand(_selectable.CurrentValue.PivotPoint.position, argument);
    }
}