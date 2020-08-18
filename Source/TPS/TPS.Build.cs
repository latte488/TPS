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
            string BasePath = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
			string MySQLConnectorPath = Path.Combine(BasePath, "ThirdParty", "MySQLConnector");
            string IncludePath = Path.Combine(MySQLConnectorPath, "include");
            string LibPath = Path.Combine(MySQLConnectorPath, "libmysqlconnector.so");
			PublicSystemIncludePaths.Add(IncludePath);
            PublicAdditionalLibraries.Add(LibPath);
            RuntimeDependencies.Add(LibPath);
        }
	}
}
