using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class PlayerCheatingBox : BaseCheatingBox
{
	private RectTransform seatIndicator;

	protected override void SetupBox(int player)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		int index = default(int);
		KPlayer playerByIndex = game.GetPlayerByIndex(index);
		string nickName = playerByIndex.NickName;
		TextMeshProExtensions.FixArabic(title, nickName);
		Userbox activeUserbox = gameVisual.GetActiveUserbox(playerByIndex);
		Transform transform = activeUserbox.transform;
		object obj = typeof(UsageHint) + 928;
		Vector3 position = transform.position;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector = VectorExtensions.ClosestDirection((Vector3)0);
		Vector2 anchoredPosition = seatIndicator.anchoredPosition;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0153;
			}
		}
		else
		{
			_ = 1;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_0153;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = (object)seatIndicator == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		seatIndicator.anchoredPosition = (Vector2)0;
	}

	public override void Populate(int player, List<Card> chCards, KPlayer cc, bool dimCatcherTeam = false)
	{
		//IL_006c: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected I4, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_024a: Expected O, but got I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected I4, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected I4, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected I4, but got Unknown
		//IL_0329: Expected O, but got I
		//IL_0329: Expected O, but got I
		//IL_0129: Expected O, but got I
		List<Card> chCards2 = default(List<Card>);
		base.Populate(player, chCards2, cc, dimCatcherTeam);
		CheatingCard[] array = cheatingCards;
		bool flag = default(bool);
		bool flag2 = default(bool);
		if (cheatingCards != null)
		{
			if (!dimCatcherTeam)
			{
				return;
			}
			object obj = array.Length - 1;
			flag = (nint)obj < 0;
			int num = array.Length ^ 1;
			object obj2 = array.Length ^ obj;
			int num2 = num & obj2;
			flag2 = num2 < 0;
			if (cc == null)
			{
				goto IL_036c;
			}
			if (array.Length < 1)
			{
				return;
			}
			object obj3 = cheatingCards + 32;
			object obj4 = 0;
			while ((object)game != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X25_v3+v63 @ X24_v3*8]");
				object obj5 = 0;
				int playerTeam = game.GetPlayerTeam(cc.<Index>k__BackingField);
				bool flag3 = (object)game == null;
				chCards2 = null;
				if (flag3)
				{
					break;
				}
				int playerTeam2 = game.GetPlayerTeam(player);
				obj = playerTeam - playerTeam2;
				flag = (nint)obj < 0;
				num = playerTeam ^ playerTeam2;
				obj2 = playerTeam ^ obj;
				num2 = num & obj2;
				flag2 = num2 < 0;
				bool flag4 = playerTeam != playerTeam2;
				chCards2 = null;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X25_v3+v63 @ X24_v3*8]");
					flag3 = (nint)0 == 0;
					chCards2 = null;
					if (flag3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v5+20]");
					flag3 = (nint)0 == 0;
					chCards2 = null;
					if (flag3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v5+20]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v5+28]");
					((Image)num3).sprite = (Sprite)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v5+58]");
					bool flag5 = (nint)0 == 0;
					flag3 = !flag5;
					chCards2 = null;
					if (!flag3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v5+58]");
					((Selectable)0).interactable = false;
					chCards2 = null;
				}
				obj4++;
				obj = obj4 - array.Length;
				flag = (nint)obj < 0;
				num = obj4 ^ array.Length;
				obj2 = obj4 ^ obj;
				num2 = num & obj2;
				flag2 = num2 < 0;
				if ((nint)obj4 < array.Length)
				{
					continue;
				}
				return;
			}
		}
		goto IL_035e;
		IL_035e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_036c;
		IL_036c:
		if (flag != flag2)
		{
			return;
		}
		goto IL_035e;
	}
}
