// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

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
            string BasePath = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
			string LibPath = Path.Combine(BasePath, "ThirdParty", "MySQLConnector8");
            string MySQLConnectorLib = Path.Combine(LibPath, "libmysqlcppconn8.so");
			PublicAdditionalLibraries.Add(MySQLConnectorLib);
			RuntimeDependencies.Add(MySQLConnectorLib);
		}
	}
}
