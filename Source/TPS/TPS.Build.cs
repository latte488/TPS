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

			string LibPath = Path.Combine(ModuleDirectory, "../../Binaries/Linux");

			PublicSystemLibraryPaths.Add(LibPath);
			/*
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "libcrypto"));
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "libssl.a"));
			
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "libpthread.a"));
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "libresolv.a"));
			*/
			PublicAdditionalLibraries.Add(Path.Combine(LibPath, "libmysqlcppconn8-static.a"));
			
			PublicSystemLibraryPaths.Add(LibPath);
			PublicAdditionalLibraries.Add("mysqlcppconn8");
			RuntimeDependencies.Add(Path.Combine(LibPath, "libmysqlcppconn8.so"));
		}
	}
}
