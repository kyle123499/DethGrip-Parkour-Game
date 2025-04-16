using UnrealBuildTool;

public class DethGripServerTarget : TargetRules
{
	public DethGripServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DethGrip");
	}
}
