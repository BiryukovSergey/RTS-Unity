using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;

namespace Code.Core
{
    public class AttackCommand : CommandExecutorBase<IAttackCommand>,IAttackCommand
    {
        public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            
        }
    }
}