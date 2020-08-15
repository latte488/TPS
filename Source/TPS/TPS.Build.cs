// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class TPS : ModuleRules
{
	public TPS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

		if (Target.Platform == UnrealTargetPlatform.Linux)
        {
			PublicSystemIncludePaths.Add("/usr/include/mysql-cppconn-8/");
			PublicAdditionalLibraries.Add("crypto");
			PublicAdditionalLibraries.Add("ssl");
			PublicAdditionalLibraries.Add("pthread");
			PublicAdditionalLibraries.Add("resolv");
			PublicAdditionalLibraries.Add("mysqlcppconn8-static");
		}
	}
}
