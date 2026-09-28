using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MonthlyTournamentEligibility : AvatarComponent
{
	private enum BehaviourOption
	{
		WaitInitialization,
		BindToMyUserVariable,
		LoadMyLastSavedValue
	}

	private enum NotEligibleOption
	{
		ShowNotEligible,
		HideEligibility
	}

	private BehaviourOption behaviourOption;

	private NotEligibleOption notEligibleOption;

	private GameObject monthlyTournamentEligibility;

	private MonthlyTournamentEligibilitySprites sprites;

	private Image image;

	private TextMeshProUGUI notEligibleText;

	private TextMeshProUGUI title;

	private MonthlyTournamentEligibilityType type;

	private const string NotQualified = "Unqualified for any championship";

	private const string CanRegister = "Eligible To Reserve";

	public static MonthlyTournamentEligibilityType LastSavedEligibilityType
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object obj = "Material with texture name \"" + 2528;
			object obj2 = (nint)0 + (nint)2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
			MonthlyTournamentEligibilityType result = default(MonthlyTournamentEligibilityType);
			return result;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object obj = "Material with texture name \"" + 2528;
			object obj2 = (nint)0 + (nint)2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81564");
		}
	}

	private void Start()
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_013c: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_00f1: Expected I, but got O
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		if (behaviourOption != BehaviourOption.LoadMyLastSavedValue)
		{
			if (behaviourOption == BehaviourOption.BindToMyUserVariable)
			{
				GameObject go = base.gameObject;
				object obj = typeof(Queue<string>) + 848;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				object obj5 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)192;
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj6);
				object varName = "m_StencilDeferredPS" + 2688;
				VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
				UpdateLastSavedEligibility();
			}
		}
		else
		{
			object obj7 = "Material with texture name \"" + 2528;
			object obj8 = (nint)0 + (nint)2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
			MonthlyTournamentEligibilityType typeToInit = default(MonthlyTournamentEligibilityType);
			Init(typeToInit);
		}
	}

	public void Init(MonthlyTournamentEligibilityType typeToInit)
	{
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected I4, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		if (typeToInit != MonthlyTournamentEligibilityType.NotEligible)
		{
			GameObject gameObject = notEligibleText.gameObject;
			gameObject.SetActive(value: false);
			GameObject gameObject2 = image.gameObject;
			gameObject2.SetActive(value: true);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+E4]");
			if ((nint)0 != 0)
			{
				bool flag = title;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_0324;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)title)
				{
					goto IL_0324;
				}
			}
			goto IL_034b;
		}
		bool active = notEligibleOption == NotEligibleOption.ShowNotEligible;
		monthlyTournamentEligibility.SetActive(active);
		GameObject gameObject3 = notEligibleText.gameObject;
		bool active2 = notEligibleOption == NotEligibleOption.ShowNotEligible;
		gameObject3.SetActive(active2);
		object obj4 = typeof(Queue<string>) + 848;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(localUser);
		object text = "UInt16" + 3656;
		object obj8 = "Drop Menu Toggle" + 2208;
		object obj9 = tournamentPoints - 1;
		bool flag4 = (nint)obj9 < 0;
		int num = tournamentPoints ^ 1;
		int num2 = tournamentPoints ^ obj9;
		int num3 = num & num2;
		bool flag5 = num3 < 0;
		bool flag6 = flag4 == flag5;
		object obj10 = !flag6;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			text = obj8;
		}
		TextMeshProExtensions.Localize(notEligibleText, (string)text);
		GameObject gameObject4 = image.gameObject;
		gameObject4.SetActive(value: false);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			if (!title)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = title;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				return;
			}
		}
		GameObject gameObject5 = title.gameObject;
		gameObject5.SetActive(value: false);
		return;
		IL_034b:
		Sprite icon = sprites.GetIcon(typeToInit);
		image.sprite = icon;
		return;
		IL_0324:
		GameObject gameObject6 = title.gameObject;
		gameObject6.SetActive(value: true);
		goto IL_034b;
	}

	public static void UpdateLastSavedEligibility()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_0164: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DD8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		MonthlyTournamentEligibilityType monthlyTournamentEligibilityType = SFSKammelnaUserExtensions.GetMonthlyTournamentEligibility(localUser);
		object obj9 = "Material with texture name \"" + 2528;
		object obj10 = (nint)0 + (nint)2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81564");
	}

	public static void ClearLastSavedEligibility()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "Material with texture name \"" + 2528;
		object obj2 = (nint)0 + (nint)2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81564");
	}

	public override void Initialize(AvatarData avatarData)
	{
		Init(avatarData.<EligibilityType>k__BackingField);
	}

	public override void Initialize(User userData)
	{
		MonthlyTournamentEligibilityType typeToInit = SFSKammelnaUserExtensions.GetMonthlyTournamentEligibility(userData);
		Init(typeToInit);
	}

	public override void Clear()
	{
		Init(MonthlyTournamentEligibilityType.NotEligible);
	}

	private void <Start>b__15_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D07]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		MonthlyTournamentEligibilityType typeToInit = SFSKammelnaUserExtensions.GetMonthlyTournamentEligibility(localUser);
		Init(typeToInit);
	}
}
