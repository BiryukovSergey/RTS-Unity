using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Code.Core
{
    public class PatrolCommand : CommandExecutorBase<IPatrolCommand>,IPatrolCommand
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log("Patrol");
        }

        public Vector3 From { get; }
        public Vector3 To { get; }
        public PatrolCommand(Vector3 from,Vector3 to)
        {
            From = from;
            To = to;
        }
    }
}