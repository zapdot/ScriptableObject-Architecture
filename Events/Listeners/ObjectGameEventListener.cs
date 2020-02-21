using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Object Event Listener")]
    public sealed class ObjectGameEventListener : BaseGameEventListener<Object, ObjectGameEvent, ObjectUnityEvent>
    {
    }
}