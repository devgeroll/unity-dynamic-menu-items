using System;
using System.Reflection;

namespace UnityEditor
{
    public static class DynamicEditorMenu
    {
        private static MethodInfo addMenuItem;
        private static MethodInfo addSeparator;
        private static MethodInfo removeMenuItem;
        private static MethodInfo menuItemExists;

        [InitializeOnLoadMethod]
        private static void Init()
        {
            Type menuType = typeof(Menu);

            addMenuItem = menuType.GetMethod("AddMenuItem", BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
            addSeparator = menuType.GetMethod("AddSeparator", BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
            removeMenuItem = menuType.GetMethod("RemoveMenuItem", BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
            menuItemExists = menuType.GetMethod("MenuItemExists", BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public static void AddMenuItem(string name, string shortcut, bool active, int priority, Action execute, Func<bool> validate)
        {
            if (addMenuItem == null)
                Init();

            addMenuItem?.Invoke(null, new object[] { name, shortcut, active, priority, execute, validate });
        }

        public static void AddSeparator(string name, int priority)
        {
            if (addSeparator == null)
                Init();

            addSeparator?.Invoke(null, new object[] { name, priority });
        }

        public static void RemoveMenuItem(string name)
        {
            if (removeMenuItem == null)
                Init();

            removeMenuItem?.Invoke(null, new object[] { name });
        }

        public static bool MenuItemExists(string menuPath)
        {
            if (menuItemExists == null)
                Init();

            if (menuItemExists != null)
                return (bool)menuItemExists.Invoke(null, new object[] { menuPath });

            return false;
        }
    }

}