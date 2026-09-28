using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class CurrentGameSprite : MonoBehaviour
{
	private Image target;

	private Sprite baloot;

	private Sprite tarneeb;

	private Sprite jackaroo;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_0162: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A9B]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		obj4 = obj8;
		if (obj10 != null)
		{
			return;
		}
		goto IL_0178;
		IL_0178:
		object obj11 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image = default(Image);
		target = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00a0:
		if ((bool)obj5)
		{
			return;
		}
		goto IL_0178;
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A9C]");
		object obj3 = (nint)0 & (nint)1;
		Image image;
		Image image2;
		if (obj3 != null)
		{
			image = target;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			image2 = target;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			image = target;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			image2 = target;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		bool flag3 = (object)image2 == null;
		object obj6 = !flag3;
		image = image2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_009f;
		IL_0091:
		currentGame = Preferences.CurrentGame;
		goto IL_009f;
		IL_009f:
		if (currentGame == Games.Jackaroo)
		{
			object obj7 = 56;
		}
		else
		{
			object obj7 = 40;
		}
		if (currentGame == Games.Tarneeb)
		{
			object obj7 = 48;
		}
		Image image3 = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CurrentGameSprite)+v135 @ X8_v9]");
		image3.sprite = (Sprite)0;
	}
}
