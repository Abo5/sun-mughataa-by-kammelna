using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class SpriteToggler : BaseToggler
{
	private Image imageReference;

	private Sprite alternativeSprite;

	private bool AlsoSetNativeSize;

	private Sprite originalSprite;

	private Sprite _prefabAlternativeSprite;

	private bool _isOn;

	public Image ImageReference => imageReference;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A7A]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			obj5 = imageReference;
			obj6 = imageReference;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = imageReference;
			obj6 = imageReference;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		object obj9 = 0;
		if (!flag4)
		{
			goto IL_0174;
		}
		goto IL_01b2;
		IL_01b2:
		object obj10 = this + 80;
		obj10 = alternativeSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0174:
		Image image = imageReference;
		object obj11 = this + 72;
		obj11 = image.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj9 = obj8;
		goto IL_01b2;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		obj8 = 0;
		if (obj12 != null)
		{
			goto IL_0174;
		}
		obj9 = 0;
		goto IL_01b2;
	}

	public void RestoreAlternativeSpriteToPrefab()
	{
		SetAlternativeSprite(_prefabAlternativeSprite);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 48;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetOriginalSprite(Sprite sprite)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_0090: Expected O, but got I4
		//IL_002b: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_0190: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0104: Expected I, but got O
		//IL_0114: Expected O, but got I
		//IL_0124: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 72;
		Sprite sprite2 = default(Sprite);
		obj2 = sprite2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3-18]");
			if ((Object)0 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3-18]");
			bool flag = (Object)0 == null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				return;
			}
		}
		bool flag3 = !_isOn;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			object obj7 = 56;
		}
		else
		{
			object obj7 = 72;
		}
		Image image = imageReference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteToggler)+v187 @ X8_v8]");
		image.sprite = (Sprite)0;
		if (AlsoSetNativeSize)
		{
			Image image2 = imageReference;
			nint num = (nint)image2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10 (Il2CppClass<UnityEngine.UI.Image>)+408]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10 (Il2CppClass<UnityEngine.UI.Image>)+410]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v168 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	public void SetAlternativeSprite(Sprite sprite)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_0090: Expected O, but got I4
		//IL_002b: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_0190: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0104: Expected I, but got O
		//IL_0114: Expected O, but got I
		//IL_0124: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 56;
		Sprite sprite2 = default(Sprite);
		obj2 = sprite2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3-8]");
			if ((Object)0 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3-8]");
			bool flag = (Object)0 == null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				return;
			}
		}
		bool flag3 = !_isOn;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			object obj7 = 56;
		}
		else
		{
			object obj7 = 72;
		}
		Image image = imageReference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteToggler)+v187 @ X8_v8]");
		image.sprite = (Sprite)0;
		if (AlsoSetNativeSize)
		{
			Image image2 = imageReference;
			nint num = (nint)image2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10 (Il2CppClass<UnityEngine.UI.Image>)+408]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10 (Il2CppClass<UnityEngine.UI.Image>)+410]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v168 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	protected override void ToggleOn()
	{
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		_isOn = true;
		imageReference.sprite = alternativeSprite;
		if (AlsoSetNativeSize)
		{
			Image image = imageReference;
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<UnityEngine.UI.Image>)+408]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<UnityEngine.UI.Image>)+410]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v87 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	protected override void ToggleOff()
	{
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		_isOn = false;
		imageReference.sprite = originalSprite;
		if (AlsoSetNativeSize)
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
