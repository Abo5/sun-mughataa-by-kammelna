using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class MonthlyTournamentTrophyMenuCelebration : MonoBehaviour
{
	private Achievement trophy;

	private void Awake()
	{
		GameObject gameObject = trophy.gameObject;
		gameObject.SetActive(value: false);
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01b7: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0200: Expected O, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_0110: Expected I, but got O
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E630D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
		if (SFSKammelnaUserExtensions.HasTrophyCelebration(localUser))
		{
			object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)200;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj10);
			object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestMyProfile(action);
		}
	}

	private void AnimateMonthlyTournamentTrophy()
	{
		//IL_0039: Expected O, but got I4
		//IL_005e: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I
		//IL_010a: Expected F4, but got O
		//IL_010a: Expected O, but got I4
		RectTransform target = UIExtensions.rectTransform(trophy);
		int num = ShortcutExtensions.DOKill(target, complete: true);
		RectTransform rectTransform = UIExtensions.rectTransform(trophy);
		RectTransform rectTransform2 = UIExtensions.rectTransform(trophy);
		Vector2 sizeDelta = rectTransform2.sizeDelta;
		rectTransform.localPosition = (Vector3)0;
		GameObject gameObject = trophy.gameObject;
		object obj = (nint)0 + (nint)2904;
		object obj2 = (nint)0 + (nint)2776;
		gameObject.SetActive(value: true);
		RectTransform target2 = UIExtensions.rectTransform(trophy);
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+B8]");
		object obj5 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(target2, (Vector3)0, (float)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void <Start>b__2_0(PlayerProfileModel myProfile)
	{
		UserAchievementModel celebrationTrophy = myProfile.GetCelebrationTrophy();
		if (celebrationTrophy != null)
		{
			GameAchievementViewModel achievementModel = trophy.GetAchievementModel();
			trophy.Initialize(achievementModel, celebrationTrophy);
			AnimateMonthlyTournamentTrophy();
		}
	}
}
