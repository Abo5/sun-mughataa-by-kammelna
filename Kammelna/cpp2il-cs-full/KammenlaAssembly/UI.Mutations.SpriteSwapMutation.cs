using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Mutations;

[Serializable]
public class SpriteSwapMutation : IMutation
{
	private Image imageReference;

	private Sprite alternativeSprite;

	private bool setNativeSize;

	private Sprite _originalSprite;

	public void Setup(GameObject gm)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Image image = imageReference;
		object obj = this + 40;
		obj = image.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_006a: Expected O, but got I
		imageReference.sprite = alternativeSprite;
		if (setNativeSize)
		{
			Image image = imageReference;
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (Il2CppClass<UnityEngine.UI.Image>)+408]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (Il2CppClass<UnityEngine.UI.Image>)+410]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v89 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public void UndoMutation()
	{
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_006a: Expected O, but got I
		imageReference.sprite = _originalSprite;
		if (setNativeSize)
		{
			Image image = imageReference;
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (Il2CppClass<UnityEngine.UI.Image>)+408]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (Il2CppClass<UnityEngine.UI.Image>)+410]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v89 @ X2_v3 (should have been resolved before IL gen)");
		}
	}
}
