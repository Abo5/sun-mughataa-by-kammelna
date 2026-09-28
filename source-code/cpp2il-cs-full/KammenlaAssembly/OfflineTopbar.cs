using System;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class OfflineTopbar : MonoBehaviour
{
	private GameObject menuContent;

	private GameObject gameContent;

	private SlideAnimationHelper statisticsSlider;

	private GameEventsChannel gameEventsChannel;

	private KGame _game;

	private void Start()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f5: Expected I, but got O
		menuContent.SetActive(value: true);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1864;
		gameContent.SetActive(value: false);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		((KGame)obj7).OnGameInitialized += action;
	}

	private void HandleGameInitialized()
	{
		menuContent.SetActive(value: false);
		gameContent.SetActive(value: true);
	}

	public void Help()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_05a1: Expected I, but got O
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_057f: Expected O, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0350: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected I, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_038b: Expected O, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected I, but got Unknown
		//IL_041d: Expected I, but got O
		//IL_042d: Expected O, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_04cb: Expected O, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected I, but got Unknown
		//IL_0522: Expected O, but got I4
		//IL_0468: Expected O, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E65D2]");
		nint num = 0;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1856;
		object confirmText = "WhiteSmoke" + 1504;
		object cancelText = "Network Authentication Required" + 248;
		Action action = default(Action);
		object obj7 = default(object);
		object obj9 = default(object);
		object obj10 = default(object);
		IntPtr intPtr = default(IntPtr);
		object obj21 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr3 = default(IntPtr);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateConfirm(action, (string)confirmText, (string)cancelText);
			object obj6;
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj3 = typeof(System.IOAsyncCallback) + 392;
				object obj4 = "ThisIsFakeReceiptData" + 2680;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v11-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj7 = obj6 + 16;
					obj5--;
					bool flag = (nint)obj5 != 1;
					obj6 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_012f;
				}
				object obj8 = num2 + obj6;
				num = (nint)(obj8 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag2 = obj9 == null;
				obj7 = obj6;
				if (!flag2)
				{
					goto IL_01ca;
				}
			}
			goto IL_0530;
			IL_0289:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v411 @ X0_v18 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				goto IL_0324;
			}
			obj7 = obj6;
			num = intPtr;
			goto IL_0530;
			IL_053e:
			object obj12 = obj7 + 9;
			object obj13 = num + obj12;
			object obj14 = obj13 + 312;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v5+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v288 @ X2_v4 (should have been resolved before IL gen)");
			continue;
			IL_0324:
			object obj17 = typeof(System.IOAsyncCallback) + 368;
			object obj18 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v15+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v15+B0]");
			obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v1-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj6 = obj7 + 16;
				obj19--;
				bool flag4 = (nint)obj19 != 1;
				obj7 = obj6;
				if (flag4)
				{
					continue;
				}
				goto IL_03d4;
			}
			goto IL_04d5;
			IL_04a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v12+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v343 @ X2_v10 (should have been resolved before IL gen)");
			goto IL_04d5;
			IL_012f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X0_v22 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag5 = obj9 == null;
			object obj23 = !flag5;
			obj6 = obj7;
			if (obj23 != null)
			{
				goto IL_01ca;
			}
			num = intPtr2;
			goto IL_0530;
			IL_04d5:
			object obj24 = obj7 + 3;
			object obj25 = obj18 + obj24;
			num = (nint)(obj25 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			object obj26 = !flag6;
			if (obj26 != null)
			{
				goto IL_0415;
			}
			goto IL_0530;
			IL_01ca:
			object obj27 = typeof(System.IOAsyncCallback) + 384;
			object obj28 = "DNQUALIFIER" + 3648;
			object obj29 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0289;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+B0]");
			obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v1-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj6 = obj7 + 16;
				obj30--;
				bool flag7 = (nint)obj30 != 1;
				obj7 = obj6;
				if (flag7)
				{
					continue;
				}
				goto IL_0289;
			}
			object obj31 = obj29 + obj7;
			num = (nint)(obj31 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = obj10 == null;
			obj6 = obj7;
			if (!flag8)
			{
				goto IL_0324;
			}
			goto IL_0530;
			IL_03d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X0_v14 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag9 = ex == null;
			obj7 = obj6;
			num = intPtr3;
			if (!flag9)
			{
				goto IL_0415;
			}
			goto IL_0530;
			IL_0415:
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v1-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj7 += 16;
					obj32--;
					if ((nint)obj32 != 1)
					{
						continue;
					}
					goto IL_04a9;
				}
				goto IL_053e;
			}
			goto IL_04a9;
			IL_0530:
			ex = new NullReferenceException();
			goto IL_053e;
		}
	}

	private void GoToHelp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Tutorial);
	}

	public void ToggleStatistics(bool isOn)
	{
		if (isOn)
		{
			statisticsSlider.SlideIn();
		}
		else
		{
			statisticsSlider.SlideOut();
		}
	}

	public void ExitGame()
	{
		gameEventsChannel.TriggerExitGame();
	}
}
