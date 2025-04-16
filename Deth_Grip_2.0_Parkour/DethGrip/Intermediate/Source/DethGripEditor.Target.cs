using UnrealBuildTool;

public class DethGripEditorTarget : TargetRules
{
	public DethGripEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DethGrip");
	}
}
