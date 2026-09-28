using System;

namespace Testing.Validators;

public sealed class KeepEnabledAttribute : Attribute
{
	public readonly EnableState State;

	public KeepEnabledAttribute(EnableState state = EnableState.ActiveInHierarchy)
	{
		State = state;
	}
}
