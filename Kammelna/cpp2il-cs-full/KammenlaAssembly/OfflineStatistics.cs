using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OfflineStatistics : MonoBehaviour
{
	private Image ratioProgress;

	private TextMeshProUGUI ratioText;

	private TextMeshProUGUI winsCount;

	private TextMeshProUGUI losesCount;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0044: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		OfflineUserInfo.OnStateUpdate += action;
		UpdateStatistics();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		OfflineUserInfo.OnStateUpdate -= action;
	}

	private void HandleOfflineUserInfoStateUpdate()
	{
		UpdateStatistics();
	}

	private unsafe void UpdateStatistics()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected I4, but got Unknown
		CachedUserInfoModel currentGameUserModel = OfflineUserInfo.CurrentGameUserModel;
		float fillAmount = currentGameUserModel.GameStatistics.WinRatio();
		object obj = ", stale={0}" + 3448;
		ratioProgress.fillAmount = fillAmount;
		float num = currentGameUserModel.GameStatistics.WinRatio();
		float num2 = default(float);
		string text = num2.ToString((string)obj);
		ratioText.text = text;
		int num3 = currentGameUserModel.GameStatistics + 20;
		string text2 = ((int*)num3)->ToString();
		winsCount.text = text2;
		int num4 = currentGameUserModel.GameStatistics.Loses();
		int num5 = default(int);
		string text3 = num5.ToString();
		losesCount.text = text3;
	}

	public void ClearStatistics()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0191: Expected I, but got O
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0076: Expected I, but got O
		//IL_0086: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2000;
		object confirmText = "WhiteSmoke" + 1504;
		object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
		Action action = default(Action);
		object obj5 = default(object);
		object obj7 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(null, (IntPtr)obj2);
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, (string)confirmText, (string)cancelText);
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.WithTheme(PopupWindow.Theme.InGame);
			object obj3 = typeof(System.IOAsyncCallback) + 368;
			nint num = (nint)popupWindowBuilderAttributes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X10_v4-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj5 += 16;
					obj4--;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_0102;
				}
				goto IL_012e;
			}
			goto IL_0102;
			IL_0102:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v9+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v150 @ X2_v6 (should have been resolved before IL gen)");
			goto IL_012e;
			IL_012e:
			object obj9 = obj5 + 9;
			object obj10 = num + obj9;
			object obj11 = obj10 + 312;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v8+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v151 @ X2_v7 (should have been resolved before IL gen)");
		}
	}

	public void ShareStatistics()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_012f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E65D0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)216;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)216;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		StatisticsScreenshot statisticsScreenshot = default(StatisticsScreenshot);
		bool flag3 = (object)statisticsScreenshot == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		goto IL_00a0;
		IL_00a0:
		statisticsScreenshot.ShareStatistics();
	}
}
