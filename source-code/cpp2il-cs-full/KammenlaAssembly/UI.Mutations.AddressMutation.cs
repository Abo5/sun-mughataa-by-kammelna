using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace UI.Mutations;

[Serializable]
public class AddressMutation : IMutation
{
	private AssetReferenceGameObject address;

	private PrefabInitializer initializer;

	private AssetReferenceGameObject _originalAddress;

	public void Setup(GameObject gm)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		PrefabInitializer prefabInitializer = initializer;
		object obj = this + 32;
		obj = prefabInitializer.address;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = initializer + 32;
		obj = address;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void UndoMutation()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = initializer + 32;
		obj = _originalAddress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
