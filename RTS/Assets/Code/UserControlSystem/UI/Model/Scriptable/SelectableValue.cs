using System;
using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObjectValueBase<ISelecatable>
    {
        public ISelecatable CurrentValue { get; private set; }
        public Action<ISelecatable> OnSelected;

        public void SetValue(ISelecatable value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }
    }
}