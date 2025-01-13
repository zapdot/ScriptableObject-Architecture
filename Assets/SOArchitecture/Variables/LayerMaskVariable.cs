using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class LayerMaskEvent : UnityEvent<LayerMask> { }

	[CreateAssetMenu(
	    fileName = "LayerMaskVariable.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "LayerMask",
	    order = 120)]
	public sealed class LayerMaskVariable : BaseVariable<LayerMask, LayerMaskEvent>
	{
	}
}
