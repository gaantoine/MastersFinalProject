// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MastersFinalProject : ModuleRules
{
	public MastersFinalProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MastersFinalProject",
			"MastersFinalProject/Variant_Horror",
			"MastersFinalProject/Variant_Horror/UI",
			"MastersFinalProject/Variant_Shooter",
			"MastersFinalProject/Variant_Shooter/AI",
			"MastersFinalProject/Variant_Shooter/UI",
			"MastersFinalProject/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
