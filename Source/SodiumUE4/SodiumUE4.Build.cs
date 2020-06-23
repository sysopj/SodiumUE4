// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class SodiumUE4 : ModuleRules
{


    public SodiumUE4(ReadOnlyTargetRules Target) : base(Target)
	{


        PublicDefinitions.Add("SODIUM_STATIC=1");
        PublicDefinitions.Add("SODIUM_EXPORT=");

        string sodiumIncludes = Path.Combine(ModuleDirectory, "../ThirdParty/libsodium/");

		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public", "SodiumUE4/Public", sodiumIncludes));
		//PublicIncludePaths.AddRange(new string[] {"../SodiumUE4/Public",sodiumIncludes});


		PrivateIncludePaths.AddRange(new string[] {"./SodiumUE4/Private"});
			
		
		PublicDependencyModuleNames.AddRange(new string[]{"Core"});
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]{
				"CoreUObject",
				"Engine",
                "Slate",
                "SlateCore",
                "Projects"
            }
			);
	

        string PlatformString = (Target.Platform == UnrealTargetPlatform.Win64) ? "x64" : "Win32";
        string path = Path.Combine(ModuleDirectory, "../ThirdParty/libsodium/Build/Release/"+ PlatformString + "/libsodium.lib");

        PublicAdditionalLibraries.Add(path);
    }
}
