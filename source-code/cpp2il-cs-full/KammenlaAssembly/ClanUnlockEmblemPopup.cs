using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class ClanUnlockEmblemPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass2_0
	{
		public ClanUnlockEmblemPopup <>4__this;

		public int tier;

		public int clanId;

		public Func<ClanEmblemTierModel, bool> <>9__1;

		internal void <Initialize>b__0(List<ClanEmblemTierModel> tiers)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0154: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected O, but got Unknown
			//IL_01ba: Expected O, but got I4
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_01f2: Expected O, but got I
			//IL_0200: Expected I, but got O
			//IL_031e: Expected O, but got I4
			//IL_028b: Expected O, but got I
			//IL_02aa: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8682]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <>4__this;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0170;
			IL_02ed:
			ClanEmblemLoader emblem;
			int num;
			FileInfoModel emblem2;
			emblem.Load(num, emblem2);
			return;
			IL_0170:
			if (tiers != null)
			{
				object obj11 = this + 32;
				Func<object, bool> predicate = (Func<object, bool>)obj11;
				bool flag5 = obj11 == null;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 616;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj14 = (nint)0 + (nint)840;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj14);
					<>9__1 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				object obj15 = Enumerable.FirstOrDefault(tiers, predicate);
				ClanUnlockEmblemPopup clanUnlockEmblemPopup = <>4__this;
				emblem = clanUnlockEmblemPopup.emblem;
				num = clanId;
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v8 (System.Object)+18]");
					emblem2 = (FileInfoModel)0;
					bool flag6 = (object)clanUnlockEmblemPopup.emblem == null;
					object obj16 = !flag6;
					if (obj16 != null)
					{
						goto IL_02ed;
					}
				}
				else
				{
					bool flag7 = (object)clanUnlockEmblemPopup.emblem == null;
					object obj17 = !flag7;
					emblem2 = null;
					if (obj17 != null)
					{
						goto IL_02ed;
					}
				}
				throw new NullReferenceException();
			}
			ClanUnlockEmblemPopup clanUnlockEmblemPopup2 = <>4__this;
			emblem = clanUnlockEmblemPopup2.emblem;
			num = clanId;
			emblem2 = null;
			goto IL_02ed;
			IL_0091:
			bool flag8 = obj5 == null;
			bool flag9 = !flag8;
			obj9 = 0;
			obj10 = null;
			if (!flag9)
			{
				return;
			}
			goto IL_0170;
		}

		internal bool <Initialize>b__1(ClanEmblemTierModel t)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (t != null)
			{
				object obj = t.Tier - tier;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private ClanEmblemLoader emblem;

	private PopupUI _popup;

	public void Initialize(int clanId, int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		//IL_0101: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(Queue<string>) + 728;
		object obj5 = (nint)0 + (nint)1976;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 728;
		object obj7 = (nint)0 + (nint)832;
		_popup.PopFromCenter();
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClanEmblemTiers(action);
	}
}
