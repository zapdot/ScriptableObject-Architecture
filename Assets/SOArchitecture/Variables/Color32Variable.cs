using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class Color32Event : UnityEvent<Color32> { }

	[CreateAssetMenu(
	    fileName = "Color32Variable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Structs/Color32",
	    order = 120)]
	public sealed class Color32Variable : BaseVariable<Color32, Color32Event>
	{
	}
}