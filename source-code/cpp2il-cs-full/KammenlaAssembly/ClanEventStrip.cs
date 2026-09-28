using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;

public abstract class ClanEventStrip : ListViewItem<ClanFeedEventDataHolder, int>, IListViewItemExtra
{
	protected AvatarInitializer avatar;

	protected TextMeshProUGUI text;

	private ListViewItemExtra _extra;

	public ClanFeedModel Model
	{
		get
		{
			//IL_0024: Expected O, but got I
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+18]");
				return (ClanFeedModel)0;
			}
			return null;
		}
	}

	public ListViewItemExtra Extra => _extra;

	public override void Setup(ClanFeedEventDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_014f: Expected I, but got O
		//IL_015f: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00f6: Expected I, but got O
		//IL_0113: Expected I, but got O
		//IL_0138: Expected O, but got I4
		object obj = (nint)0 + (nint)1576;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Action action = default(Action);
		Action action2 = default(Action);
		while (true)
		{
			((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				bool flag = _extra != null;
				bool flag2 = !flag;
				object obj4 = !flag2;
				object obj5 = 0;
				UnityEngine.Object obj6 = null;
				if (obj4 == null)
				{
					goto IL_013d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = _extra != null;
				bool flag4 = !flag3;
				object obj5 = 0;
				UnityEngine.Object obj6 = null;
				if (flag4)
				{
					goto IL_013d;
				}
			}
			object obj7 = typeof(SqlSingle[]) + 2376;
			object obj8 = (nint)0 + (nint)944;
			object obj9 = (nint)0 + (nint)952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj8);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor(this, (IntPtr)obj9);
			_extra.Setup(firstTime, action, action2);
			object obj10 = 0;
			goto IL_013d;
			IL_013d:
			ClanFeedModel <Model>k__BackingField = datum.<Model>k__BackingField;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4 (Il2CppClass<ClanEventStrip>)+328]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4 (Il2CppClass<ClanEventStrip>)+330]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v4 (should have been resolved before IL gen)");
		}
	}

	public virtual void Initialize(ClanFeedModel model)
	{
	}

	protected void InitializeAvatar(ClanFeedModel model)
	{
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_003c: Expected I, but got O
		//IL_004c: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		ClanFeedModel clanFeedModel = default(ClanFeedModel);
		bool flag = clanFeedModel == null;
		ClanFeedModel clanFeedModel2 = clanFeedModel;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		ClanFeedModel clanFeedModel3;
		object obj2;
		if (!flag)
		{
			ClanFeedData clanFeedData = clanFeedModel.Data;
			if (clanFeedModel.Data == null)
			{
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				obj4 = avatar;
				clanFeedModel2 = null;
				obj5 = avatar;
				clanFeedModel3 = null;
				if (obj3 != null)
				{
					goto IL_006b;
				}
				goto IL_00f8;
			}
			nint num = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v10 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+180]");
			clanFeedModel = (ClanFeedModel)0;
			ClanFeedModel avatarData = (ClanFeedModel)(object)clanFeedModel.Data.AvatarData;
			clanFeedModel2 = avatarData;
		}
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		obj4 = avatar;
		obj5 = avatar;
		clanFeedModel3 = clanFeedModel2;
		if (!flag3)
		{
			goto IL_006b;
		}
		goto IL_00f8;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = obj5 != null;
		bool flag5 = !flag4;
		clanFeedModel2 = clanFeedModel3;
		if (!flag5)
		{
			goto IL_0136;
		}
		return;
		IL_0136:
		if (clanFeedModel2 != null)
		{
			avatar.Initialize((AvatarData)(object)clanFeedModel2);
		}
		return;
		IL_006b:
		bool flag6 = obj4 != null;
		bool flag7 = !flag6;
		object obj6 = !flag7;
		if (obj6 == null)
		{
			return;
		}
		goto IL_0136;
	}

	public void ReassertPinned()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85B3]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object extra;
		UnityEngine.Object extra2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			extra = _extra;
			extra2 = _extra;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			extra = _extra;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			extra2 = _extra;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = extra2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		ListViewItemExtra extra3 = _extra;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+60]");
		extra3.ReassertPinned(pinned: false);
		return;
		IL_0091:
		if (extra != null)
		{
			goto IL_00b8;
		}
	}

	protected override void OnPinnedChanged(bool pinned, bool animated)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85B4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object extra;
		UnityEngine.Object extra2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			extra = _extra;
			extra2 = _extra;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			extra = _extra;
			extra2 = _extra;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = extra2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		_extra.ApplyPinned(pinned, animated);
		return;
		IL_0091:
		if (extra != null)
		{
			goto IL_00b8;
		}
	}

	protected override void OnDatumPinnedChanged(bool pinned)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85B5]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object extra;
		UnityEngine.Object extra2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			extra = _extra;
			extra2 = _extra;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			extra = _extra;
			extra2 = _extra;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = extra2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		_extra.SetDatumPinned(pinned);
		return;
		IL_0091:
		if (extra != null)
		{
			goto IL_00b8;
		}
	}

	protected ClanEventStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <Setup>b__7_0()
	{
		//IL_0060: Expected O, but got I
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+58]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void <Setup>b__7_1()
	{
		//IL_0060: Expected O, but got I
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X3_v1 (should have been resolved before IL gen)");
		}
	}
}
