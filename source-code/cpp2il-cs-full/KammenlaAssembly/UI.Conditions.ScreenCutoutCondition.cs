using System;

namespace UI.Conditions;

[Serializable]
public class ScreenCutoutCondition : BoolCondition
{
	public override string Name => "HH:mm:ss.ffZ" + 872;

	protected override bool ActualValue => ScreenUtility.HasScreenCutout;

	public ScreenCutoutCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
