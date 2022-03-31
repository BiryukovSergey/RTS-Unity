using System;
using Abstractions.Commands.CommandsInterfaces;
using Code.Core;
using Zenject;

namespace UserControlSystem.CommandCreators
{
    public class AttackCommandCommandCreator : CommandCreatorBase<IAttackCommand>
    {
        [Inject] private AssetsContext _context;

        protected override void classSpecificCommandCreation(Action<IAttackCommand> creationCallback)
        {
            creationCallback?.Invoke(_context.Inject(new AttackCommand()));
        }
    }
}