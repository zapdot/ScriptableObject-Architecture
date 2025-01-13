using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "ColorCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "Structs/Color",
	    order = 120)]
	public sealed class ColorCollection : Collection<Color>
	{
	}
}