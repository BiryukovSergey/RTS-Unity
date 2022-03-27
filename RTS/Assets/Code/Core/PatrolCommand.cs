using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;

namespace Code.Core
{
    public class PatrolCommand : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            
        }
    }
}