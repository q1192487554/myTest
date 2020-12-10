// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class OpenCV : ModuleRules
{
    //第三方库的路径
    private string ThirdPartyPath
    {
        get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../../ThirdParty")); }
    }

    public OpenCV(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[] {
				// ... add public include paths required here ...
			}
            );


        PrivateIncludePaths.AddRange(
            new string[] {
				// ... add other private include paths required here ...
			}
            );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
				// ... add other public dependencies that you statically link with here ...
			}
            );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
            );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
				// ... add any modules that your module loads dynamically here ...
			}
            );

        //第三方OpenCV的C++库
        string OpenCVPath = Path.Combine(ThirdPartyPath, "OpenCV");

        if (Target.Platform == UnrealTargetPlatform.Win64)//64位平台
        {
            string OpenCVIncludePath = Path.Combine(OpenCVPath, "Win64", "Include");
            string OpenCVLibPath = Path.Combine(OpenCVPath, "Win64", "Lib");

            PublicIncludePaths.Add(OpenCVIncludePath);
            PublicLibraryPaths.Add(OpenCVLibPath);
        }
        else if (Target.Platform == UnrealTargetPlatform.Win32)//32位平台
        {
            //32位的OpenCV库,仿照上面Win64的自己填写
        }
        //else if (Target.Platform == UnrealTargetPlatform.Mac)
        //{
        //    //Mac平台的,暂时管不到这个平台
        //}
    }
}
