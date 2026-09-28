using System;

namespace UI.Conditions;

[Serializable]
public class StcPaySupportedCondition : BoolCondition
{
	protected override bool ActualValue => StcPurchaseControllerUi.IsSupported;

	public StcPaySupportedCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
