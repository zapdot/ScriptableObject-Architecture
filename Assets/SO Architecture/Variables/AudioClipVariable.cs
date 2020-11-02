using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class AudioClipEvent : UnityEvent<AudioClip> { }

	[CreateAssetMenu(
	    fileName = "AudioClipVariable.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "AudioClip",
	    order = 120)]
	public sealed class AudioClipVariable : BaseVariable<AudioClip, AudioClipEvent>
	{
	}
}