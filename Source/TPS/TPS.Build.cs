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
			PublicAdditionalLibraries.Add("libcrypto.a");
			PublicAdditionalLibraries.Add("libssl.a");
			PublicAdditionalLibraries.Add("libpthread.a");
			PublicAdditionalLibraries.Add("libresolv.a");
			PublicAdditionalLibraries.Add("libmysqlcppconn8-static.a");
		}
	}
}
