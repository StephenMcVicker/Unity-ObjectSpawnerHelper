# Unity-ObjectSpawnerHelper
A simple class to help you spawn objects easily using the Inspector or quickly through code.
Note: This is not for designing levels. This is for when your game is running/in-play mode for you to easily spawn your objects through code after setting them in the inspector. It's not for designing levels/when not in play mode (I had some people confused on that).


![ViewInInspector](https://pbs.twimg.com/media/DoIndi3UYAAZ1qP.jpg)

## Installation
Download ObjectToSpawn class and drag it into your Assets folder / any sub folder of your choosing.
SpawnExample class is not required but shows a simple use case.

## Usage
Make a 
```c#
Public ObjectToSpawn variableName;
```
variable (call it whatever you want) in your class. 
Save your code.
Go back to the Inspector window and you'll see the ObjectToSpawn on your component. Expand it and set it's variables.
In your code when you want the object (prefab or whatever) to spawn just call
```c#
variableName.Spawn();
```

I find this very helpful for quicking spawning objects, such as effects, without the new for too much code writing. It may help you.
If it does be sure to let me know on Twitter: https://twitter.com/stephenmcvicker
