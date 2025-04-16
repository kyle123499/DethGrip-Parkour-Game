using UnrealBuildTool;

public class DethGripClientTarget : TargetRules
{
	public DethGripClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DethGrip");
	}
}
