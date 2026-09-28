using UnityEngine;

namespace UI.Mutations;

public interface IMutation
{
	void Setup(GameObject gm);

	void Teardown();

	void PerformMutation();

	void UndoMutation();
}
