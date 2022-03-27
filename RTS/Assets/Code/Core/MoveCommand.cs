using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;

namespace Code.Core
{
    public class MoveCommand : CommandExecutorBase<IMoveCommand>
    {
        public override void ExecuteSpecificCommand(IMoveCommand command)
        {
            
        }
    }
}