using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using Code.Core;

namespace UserControlSystem.CommandCreators
{
    public class AttackCommandCommandCreator : CancellableCommandCreatorBase<IAttackCommand, IAttackable>
    {
        protected override IAttackCommand createCommand(IAttackable argument) => new AttackCommand(argument);

    }
}