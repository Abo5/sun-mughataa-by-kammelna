using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public abstract class ClanEventStrip_LiveActivityResult : ClanEventStrip
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, bool> <>9__5_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <JoinNames>b__5_0(string n)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0072: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(n);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private const string AND_KEY = "and";

	private AvatarInitializer _avatarInitializer2;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00df: Expected I, but got O
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2352;
		object obj2 = obj;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v4-8]");
			if (0 == (nint)obj2)
			{
				nint num4 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v131 @ X8_v7 (Il2CppClass<ClanEventStrip_LiveActivityResult>)+338] (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	protected abstract void Populate(LiveActivityResultClanFeedData data);

	protected void BindWinnerAvatars(LiveActivityResultClanFeedData data)
	{
		BindAvatar(avatar, data.<WinnerUserIds>k__BackingField, 0);
		BindAvatar(_avatarInitializer2, data.<WinnerUserIds>k__BackingField, 1);
	}

	protected static string JoinNames(List<string> names)
	{
		//IL_0190: Expected O, but got I4
		//IL_01a0: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_01de: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_020e: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_0240: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0278: Expected O, but got I
		//IL_0289: Expected I, but got O
		//IL_02a7: Expected O, but got I
		//IL_00ba: Expected O, but got I
		if (names != null)
		{
			object obj = typeof(CardUtils.<>c) + 616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = (nint)0 + (nint)3784;
			object obj5 = (nint)0 + (nint)2736;
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v4+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+8]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v17+B8]");
					obj7 = 0;
				}
				object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = (nint)0 + (nint)3512;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj7, (IntPtr)obj12);
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v16+B8]");
				object obj14 = (nint)0 + (nint)8;
				obj14 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			object input = "alignContent" + 264;
			object obj15 = (nint)0 + (nint)3072;
			IEnumerable<object> source = Enumerable.Where(names, predicate);
			List<object> values = Enumerable.ToList(source);
			object obj16 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input);
			string separator = (string)obj15 + text + (string)obj15;
			return string.Join(separator, (IEnumerable<string>)values);
		}
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+90]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+B8]");
		return (string)0;
	}

	protected static void BindAvatar(AvatarInitializer slot, List<long> userIds, int index)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_011e: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected I4, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85C5]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = slot == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_012c;
		IL_012c:
		if (userIds != null)
		{
			GameObject gameObject = slot.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [userIds @ X1 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj7 = (nint)index - (nint)0;
			bool flag4 = (nint)obj7 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [userIds @ X1 (System.Collections.Generic.List`1<System.Int64>)+18]");
			int num = (int)((nint)index ^ (nint)0);
			int num2 = index ^ obj7;
			int num3 = num & num2;
			bool flag5 = num3 < 0;
			bool flag6 = flag4 == flag5;
			bool active = !flag6;
			gameObject.SetActive(active);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [userIds @ X1 (System.Collections.Generic.List`1<System.Int64>)+18]");
			if ((nint)index < (nint)0)
			{
				long num4 = userIds.get_Item(index);
				long num5 = default(long);
				string dbId = num5.ToString();
				slot.InitializeFriendWithDbId(dbId);
				return;
			}
		}
		else
		{
			GameObject gameObject2 = slot.gameObject;
			gameObject2.SetActive(value: false);
		}
		slot.Clear();
		return;
		IL_007d:
		if (slot == null)
		{
			return;
		}
		goto IL_012c;
	}

	protected ClanEventStrip_LiveActivityResult()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
