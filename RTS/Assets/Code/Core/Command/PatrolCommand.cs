using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Code.Core
{
    public class PatrolCommand : IPatrolCommand
    {  
        public Vector3 From { get; }
        public Vector3 ToTarget { get; }
        public PatrolCommand(Vector3 from,Vector3 toTarget)
        {
            From = from;
            ToTarget = toTarget;
        }
    }
}