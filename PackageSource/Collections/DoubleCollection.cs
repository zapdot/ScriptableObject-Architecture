using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "DoubleCollection.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_COLLECTION + "double",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 8)]
    public sealed class DoubleCollection : Collection<double>
    {
    }
}