using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Code.Core
{
    public class AttackCommand : /*CommandExecutorBase<IAttackCommand>,*/IAttackCommand
    {
       /* public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            Debug.Log("Attack");
        }*/

        public IAttackable Target { get; }
        public AttackCommand(IAttackable target)
        {
            Target = target;
        }

    }
}