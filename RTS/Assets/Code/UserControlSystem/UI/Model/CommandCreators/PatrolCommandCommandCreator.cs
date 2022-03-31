using System;
using Abstractions.Commands.CommandsInterfaces;
using Code.Core;
using Zenject;

namespace UserControlSystem.CommandCreators
{
    public class PatrolCommandCommandCreator : CommandCreatorBase<IPatrolCommand>
    {
        [Inject] private AssetsContext _context;

        protected override void classSpecificCommandCreation(Action<IPatrolCommand> creationCallback)
        {
            creationCallback?.Invoke(_context.Inject(new PatrolCommand()));
        }
    }
}