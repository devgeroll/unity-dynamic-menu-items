using UnityEngine;

namespace UnityEditor
{
    public static class TestMenu
    {
        [InitializeOnLoadMethod]
        private static void Init()
        {
            Debug.Log(DynamicEditorMenu.MenuItemExists("Actions/SubMenu/Etc"));

            DynamicEditorMenu.AddMenuItem("Actions/SubMenu/Etc", "", false, 0, () =>
            {
                Debug.Log("Test");
            }, () => true);

            DynamicEditorMenu.AddSeparator("Actions/SubMenu/", 5);

            DynamicEditorMenu.AddMenuItem("Actions/SubMenu/Next", "", false, 10, () =>
            {
                Debug.Log("Test");
            }, () => true);

            DynamicEditorMenu.AddMenuItem("Actions/SubMenu/Remove", "", false, 10, () =>
            {
                Debug.Log("Test");
            }, () => true);

            Debug.Log(DynamicEditorMenu.MenuItemExists("Actions/SubMenu/Etc"));

            DynamicEditorMenu.RemoveMenuItem("Actions/SubMenu/Remove");
        }
    }

}