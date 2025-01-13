using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AudioClipCollection.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_COLLECTION + "AudioClip",
	    order = 120)]
	public sealed class AudioClipCollection : Collection<AudioClip>
	{
	}
}