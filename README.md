# Unity Dynamic Menu Items
DynamicEditorMenu is a utility class for managing Unity Editor menu items dynamically.

It provides methods to add, remove, and check the existence of menu items and separators in the Unity Editor menu. The class uses reflection to access internal Unity methods for menu management. The available methods include:
- AddMenuItem: Adds a new menu item with specified parameters.
- AddSeparator: Adds a separator to the menu.
- RemoveMenuItem: Removes a menu item by name.
- MenuItemExists: Checks if a menu item exists by its path.

The class initializes the required MethodInfo objects on load using the InitializeOnLoadMethod attribute.

# Known Issue:
If a base menu item created with this script didn't exist before, it will only appear when the pointer is over the menu panel.
