# UnityUtilities

This is a package of utility files that are useful to include when starting a project.

## Requirement

* Unity Editor 2021.2.18f1 

It should work with other versions, but we haven't tested it.

## Installation

### Install via UPM (using Git URL)

1. Navigate to your project's Packages folder and open the manifest.json file.
2. Add this line in `dependencies`.
```
"dependencies": {
    "studio.shirokurohitsuji.unity-utilities": "https://github.com/shirokurohitsuji/UnityUtilities.git"
}
```
3. UPM should install the package.

## Contents

### Editor
#### Editor/Actions
* **EditorScreenCapture**:
  You can take a screen capture of the game window from Edit/ScreenCapture.

#### Editor/Utility
* **AddNameSpace**:
  It can automatically add the namespace to the new class when you create the new .cs file.

### Runtime
#### Utility
* **ColorHtml**:
  You can convert hex code to rgb color easily.
```c#
Color color = new ColorHtml("#FFFFFF");
```

* **DictionaryExtension**: `GetValueIfExists` allows you to get a value if exists.

* **EnumerableExtension**: Extracts one or a specified number of random values from an enumerable.

* **EnumExtension**: You can get the random value, the number of items of specified enum, and all the value.  Also, you can parse string to enum more easily.

* **IntExtension**: Calculate modulo even if it uses negative value.

* **ObservableExtension**: Show debug log for each items streamed for UniRx.

* **LinqExtension**: Show debug log or do something for LINQ.

* **ListExtension**: Get the value even if the index is more than the count of the list and shuffle the list.


## Author

[SHIROKUROHTISUJI](https://shirokurohitsuji.studio/)

## License

**UnityUtilities** is under [MIT license](https://en.wikipedia.org/wiki/MIT_License).
