using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class AnimationCurveEvent : UnityEvent<AnimationCurve> { }

	[CreateAssetMenu(
	    fileName = "AnimationCurveVariable.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "AnimationCurve",
	    order = 120)]
	public sealed class AnimationCurveVariable : BaseVariable<AnimationCurve, AnimationCurveEvent>
	{
	}
}