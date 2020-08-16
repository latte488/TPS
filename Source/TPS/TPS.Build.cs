// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class TPS : ModuleRules
{
	public TPS(ReadOnlyTargetRules Target) : base(Target)
	{
		bEnableExceptions = true;

		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

		if (Target.Platform == UnrealTargetPlatform.Linux)
        {
			PublicSystemIncludePaths.Add("/usr/include/mysql-cppconn-8");
			string LibPath = Path.Combine(ModuleDirectory, "../../ThirdParty/MySQLConnector8");
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "libmysqlcppconn8.so"));
		}
	}
}
