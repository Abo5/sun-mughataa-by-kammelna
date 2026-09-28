using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CountMeter : AvatarComponent
{
	private enum CounterType
	{
		Likes,
		Achievements,
		TournamentPoints
	}

	private sealed class <>c__DisplayClass13_0
	{
		public CountMeter <>4__this;

		public User userData;

		internal void <Initialize>b__0()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0122: Expected I4, but got I8
			//IL_013c: Expected O, but got I4
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_005a: Expected O, but got I
			//IL_0084: Expected O, but got I4
			CountMeter countMeter = <>4__this;
			object obj = typeof(CardUtils.<>c) + 2760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			int num = (countMeter.currentValue = SFSExtensions.GetVariable(userData, friendlyName, 0));
			int num2 = (int)(num & 0x80000000L);
			bool flag = num2 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(SqlSingle[]) + 3912;
				object obj4 = (nint)0 + (nint)2800;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tweener tweener = AnimationExtensions.DONumber(countMeter.CountValue, num, 0.3f, useCommas: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			}
		}
	}

	public TextMeshProUGUI CountValue;

	private CounterType counterType;

	private int currentValue;

	private bool isInitialized;

	private string userVariable
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			return EnumExtensions.GetFriendlyName(enumeration);
		}
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001c: Expected I, but got O
		//IL_0128: Expected I4, but got I8
		//IL_0142: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_009a: Expected O, but got I4
		int num = ShortcutExtensions.DOKill(CountValue);
		TextMeshProUGUI countValue = CountValue;
		object text = ", stale={0}" + 120;
		nint num2 = (nint)countValue;
		countValue.text = (string)text;
		if (!isInitialized)
		{
			return;
		}
		int num3 = (int)(currentValue & 0x80000000L);
		bool flag = num3 == 0;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(SqlSingle[]) + 3912;
			object obj3 = (nint)0 + (nint)2800;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(CountValue, currentValue, 0.3f, useCommas: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private void ResetMeter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Expected I, but got O
		//IL_0034: Expected O, but got I
		//IL_0044: Expected O, but got I
		while (true)
		{
			int num = ShortcutExtensions.DOKill(CountValue);
			TextMeshProUGUI countValue = CountValue;
			object obj = ", stale={0}" + 120;
			object obj2 = obj;
			nint num2 = (nint)countValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v48 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void AnimateMeter()
	{
		//IL_00ba: Expected I4, but got I8
		//IL_00d4: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		int num = (int)(currentValue & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(SqlSingle[]) + 3912;
			object obj3 = (nint)0 + (nint)2800;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(CountValue, currentValue, 0.3f, useCommas: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	public void InitializeMeter(int newValue)
	{
		//IL_013e: Expected I4, but got I8
		//IL_0158: Expected O, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Expected I, but got O
		int num = default(int);
		currentValue = num;
		isInitialized = true;
		if (currentValue != num)
		{
			int num2 = ShortcutExtensions.DOKill(CountValue);
			TextMeshProUGUI countValue = CountValue;
			object text = ", stale={0}" + 120;
			nint num3 = (nint)countValue;
			countValue.text = (string)text;
		}
		int num4 = (int)(currentValue & 0x80000000L);
		bool flag = num4 == 0;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(SqlSingle[]) + 3912;
			object obj3 = (nint)0 + (nint)2800;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(CountValue, currentValue, 0.3f, useCommas: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	public void UpdateMeter(int newValue)
	{
		//IL_0089: Expected I4, but got I8
		//IL_00a3: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_0059: Expected O, but got I4
		int num = default(int);
		currentValue = num;
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(SqlSingle[]) + 3912;
			object obj3 = (nint)0 + (nint)2800;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(CountValue, num, 0.3f, useCommas: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	public override void Initialize(AvatarData avatarData)
	{
		//IL_005a: Expected O, but got I4
		if (counterType != CounterType.TournamentPoints)
		{
			if (counterType != CounterType.Achievements)
			{
				bool flag = counterType == CounterType.Likes;
				object obj = !flag;
				if (obj == null)
				{
					InitializeMeter(avatarData.<Likes>k__BackingField);
				}
				else
				{
					InitializeMeter(0);
				}
			}
			else
			{
				InitializeMeter(avatarData.<AchievementsCount>k__BackingField);
			}
		}
		else
		{
			InitializeMeter(avatarData.<TournamentPoints>k__BackingField);
		}
	}

	public override void Initialize(User userData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_02c3: Expected I4, but got I8
		//IL_00fb: Expected O, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I4
		//IL_02e0: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0290: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_043e: Expected O, but got I4
		//IL_031b: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0494: Expected O, but got I
		//IL_04a5: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = userData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj5 = obj4;
		object obj6 = typeof(CardUtils.<>c) + 2760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj7 = typeof(UsageHint) + 8;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v7+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_013c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v7+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X10_v15-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_013c;
		}
		object obj11 = obj10 + 24;
		object obj12 = obj8 + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v67+8]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v354 @ X0_v67] (should have been resolved before IL gen)");
		object obj14 = default(object);
		bool flag = obj14 == null;
		object obj15 = !flag;
		string text = friendlyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v67+8]");
		int num2 = 0;
		if (obj15 != null)
		{
			goto IL_0195;
		}
		goto IL_02b6;
		IL_0195:
		object obj16 = typeof(Queue<string>) + 848;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v48+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		int variable = SFSExtensions.GetVariable(localUser, friendlyName2, 0);
		num2 = 0;
		int newValue = variable;
		goto IL_054d;
		IL_035c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v433 @ X0_v40] (should have been resolved before IL gen)");
		object obj20 = default(object);
		bool flag3 = obj20 == null;
		object obj21 = !flag3;
		num2 = 19;
		if (obj21 == null)
		{
			return;
		}
		goto IL_03f6;
		IL_054d:
		InitializeMeter(newValue);
		object obj22 = obj4;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v9+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_035c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v9+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X10_v8-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_035c;
		}
		object obj26 = obj25 + 19;
		object obj27 = obj23 + obj26;
		object obj28 = obj27 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v469 @ X0_v43] (should have been resolved before IL gen)");
		object obj29 = default(object);
		if (obj29 != null)
		{
			goto IL_03f6;
		}
		return;
		IL_03f6:
		GameObject go2 = base.gameObject;
		object obj30 = typeof(Queue<string>) + 848;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj32 = !flag4;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration3 = default(Enum);
		string friendlyName3 = EnumExtensions.GetFriendlyName(enumeration3);
		object obj34 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)3776;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj35);
		VariableBinderExtensions.Bind(go2, localUser2, friendlyName3, action);
		return;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v64+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ X0_v64] (should have been resolved before IL gen)");
		object obj36 = default(object);
		bool flag5 = obj36 == null;
		text = friendlyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v64+8]");
		num2 = 0;
		if (!flag5)
		{
			goto IL_0195;
		}
		goto IL_02b6;
		IL_02b6:
		newValue = -1;
		goto IL_054d;
	}

	public override void Clear()
	{
		InitializeMeter(0);
	}
}
