using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;

namespace Code.Core
{
    public class StopCommand : CommandExecutorBase<IStopCommand>
    {
        public override void ExecuteSpecificCommand(IStopCommand command)
        {
            
        }
    }
}