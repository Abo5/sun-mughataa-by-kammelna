using System;
using UnityEngine;

namespace UI.Conditions;

public interface ICondition
{
	bool Satisfied { get; }

	event Action OnConditionChanged;

	void Setup(GameObject gm);

	void Teardown();
}
