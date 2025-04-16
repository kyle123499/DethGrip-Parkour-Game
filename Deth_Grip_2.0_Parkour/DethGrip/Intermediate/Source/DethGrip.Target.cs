using UnrealBuildTool;

public class DethGripTarget : TargetRules
{
	public DethGripTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DethGrip");
	}
}
