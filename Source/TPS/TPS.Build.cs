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
			PublicSystemIncludePaths.Add("/usr/include/mysql-cppconn-8");
			string LibPath = "/usr/lib/x86_64-linux-gnu";
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "crypto"));
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "ssl.a"));
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "pthread.a"));
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "resolv.a"));
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "mysqlcppconn8-static.a"));
		}
	}
}
