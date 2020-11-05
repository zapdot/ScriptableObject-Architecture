﻿using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class ObjectEvent : UnityEvent<Object> {  }

    [CreateAssetMenu(
        fileName = "ObjectVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Object",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 1)]
    public sealed class ObjectVariable : BaseVariable<Object, ObjectEvent>
    {
    }
}