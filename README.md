# About SodiumUE4
An easy to use public and private cryptography plugin for Unreal Engine 4 based on libsodium.

It currently works only on Win64 builds of UE4. Eventually Mac and Android is planned. The plugin is very simple (due to portable nature of libsodium), so it works on most versions of UE4.

Last tested on: **4.25.1 with VS2019**

## Installation

1. *git clone --recursive* this repo to your UnrealProject/Plugins/ folder.
2. Compile Source\ThirdParty\libsodium\libsodium.sln first, this will generate the sodium library. Use x64 and Release options as target.
3. Regenerate code for your UE4 project (right click YourGame.uproject to do it)
4. Add "SodiumUE4" to YourGame.Build.cs in PublicDependencyModuleNames
5. Open and Build your game in Visual Studio.
6. Start editor as usual, allow it to compile SodiumUE4, this should only happen once.
7. Build/Package your game as you normally would.

### License
https://opensource.org/licenses/MIT

### libsodium license:
https://opensource.org/licenses/ISC


# Usage

![Public encryption](http://i.imgur.com/ezgBj7v.jpg)
