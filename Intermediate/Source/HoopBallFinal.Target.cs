using UnrealBuildTool;

public class HoopBallFinalTarget : TargetRules
{
	public HoopBallFinalTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HoopBallFinal");
	}
}
