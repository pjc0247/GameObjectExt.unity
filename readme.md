GameObjectExt
====

__Find__
```c#
var obj = GameObject.Find("object");

var obj = "object".Find();
```

__Find(T)__
```c#
var component = GameObject.Find("object").GetComponent<Foo>();

var component = "object".Find<Foo>();
```

__Transform__
```c#
var t = GameObject.Find("object").transform;

var t = "object".Transform();
```

__SetParent__
```c#
var child = GameObject.Find("child").transform;
var parent = GameObject.Find("parent").transform;
child.SetParent(parent);

"child".SetParent("parent");
// or
"child".SetParent(parentGameObject);
"child".SetParent(parentTransform);
```

Shorcuts for UI Components
----
__GetText__
```c#
var msg = GameObject.Find("object").GetComponent<Text>().text;

var msg = "object".GetText();
```

__GetSelectedOption__
```c#
var dropdown = GameObject.Find("object").GetComponent<Dropdown>();
var msg = dropdown.options[dropdown.value];

var msg = "object".GetSelectedOption();
```

__IsOn__
```c#
var isOn = GameObject.Find("object").GetComponent<Toggle>().isOn;

var isOn = "object".IsOn();
```
