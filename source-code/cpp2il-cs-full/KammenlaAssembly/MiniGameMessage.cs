using System;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class MiniGameMessage : MonoBehaviour
{
	private GameObject message;

	private TextMeshProUGUI timeMessage;

	private GameObject miniGameNextTrialTime;

	private DateTimeText timer;

	private const string RemainingTime = "Remaining time for the next try";

	private const string DelayTime = "Remaining time to be able to play";

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)184;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2744;
		Initialize();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		MiniGame miniGame = default(MiniGame);
		miniGame.OnInitialized += action;
	}

	private void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_0280: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_01a4: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_0656: Expected O, but got I4
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected O, but got Unknown
		//IL_06a2: Expected O, but got I4
		//IL_06d5: Expected O, but got I
		//IL_06ef: Expected O, but got I4
		//IL_0459: Expected O, but got I
		//IL_07ff: Expected O, but got I4
		//IL_072d: Expected O, but got I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_086e: Expected O, but got I
		//IL_0888: Expected O, but got I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_055b: Expected O, but got I
		//IL_0925: Expected O, but got I
		//IL_093a: Expected O, but got I
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_08dd: Expected O, but got I4
		//IL_05dc: Expected O, but got I
		//IL_05f1: Expected O, but got I
		//IL_0611: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64BB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v101+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v101+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool canNotPlayMiniGameOnWeb = MiniGameInfo.CanNotPlayMiniGameOnWeb;
		bool flag3 = !canNotPlayMiniGameOnWeb;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00a7;
		}
		goto IL_0161;
		IL_05cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v51+B8]");
		object obj8 = 0;
		object obj9;
		object key = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v30+10]");
		DateTime date = Prefs.GetDate((string)key, (DateTime)0);
		bool flag4 = (object)timer == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_0943;
		}
		goto IL_0982;
		IL_0943:
		timer.SetDate(date);
		GameObject gameObject = message;
		goto IL_0961;
		IL_0961:
		GameObject gameObject2 = gameObject.gameObject;
		gameObject2.SetActive(value: false);
		return;
		IL_0085:
		if (MiniGameInfo.CanNotPlayMiniGameOnWeb)
		{
			goto IL_00a7;
		}
		goto IL_0161;
		IL_0161:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		object obj13;
		object obj14;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
			object obj12 = (nint)0 & (nint)1;
			bool flag5 = obj12 == null;
			obj13 = 152985600;
			obj14 = 152985600;
			if (!flag5)
			{
				goto IL_01d3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
			object obj15 = (nint)0 & (nint)1;
			bool flag6 = obj15 == null;
			object obj16 = !flag6;
			obj13 = 152985600;
			obj14 = 152985600;
			if (obj16 != null)
			{
				goto IL_01d3;
			}
		}
		_ = 1;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v80+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		obj13 = obj14;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_0210;
		}
		goto IL_02ee;
		IL_04ab:
		int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials >= 1)
		{
			goto IL_04d1;
		}
		goto IL_077b;
		IL_0743:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int miniGameRemainingTrials2 = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials2 >= 1)
		{
			goto IL_04d1;
		}
		goto IL_077b;
		IL_0476:
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v56+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = obj20;
		if (!flag8)
		{
			goto IL_04ab;
		}
		goto IL_0743;
		IL_01d3:
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v80+E4]");
		bool flag9 = (nint)0 == 0;
		obj19 = obj17;
		obj14 = obj13;
		if (!flag9)
		{
			goto IL_0210;
		}
		goto IL_02ee;
		IL_02ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int miniGameRemainingTrials3 = MiniGameInfo.MiniGameRemainingTrials;
		bool flag10 = miniGameRemainingTrials3 < 1;
		obj13 = obj14;
		if (!flag10)
		{
			goto IL_032b;
		}
		goto IL_0386;
		IL_0210:
		int miniGameRemainingTrials4 = MiniGameInfo.MiniGameRemainingTrials;
		if (miniGameRemainingTrials4 >= 1)
		{
			goto IL_032b;
		}
		obj14 = obj13;
		goto IL_0386;
		IL_032b:
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v64+E4]");
		if ((nint)0 != 0)
		{
			bool delayIsActive = MiniGameInfo.DelayIsActive;
			bool flag11 = !delayIsActive;
			obj14 = obj13;
			if (!flag11)
			{
				goto IL_0386;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool delayIsActive2 = MiniGameInfo.DelayIsActive;
			bool flag12 = !delayIsActive2;
			object obj23 = !flag12;
			obj14 = obj13;
			if (obj23 != null)
			{
				goto IL_0386;
			}
		}
		miniGameNextTrialTime.SetActive(value: false);
		gameObject = message;
		bool flag13 = (object)message == null;
		object obj24 = !flag13;
		if (obj24 != null)
		{
			goto IL_0961;
		}
		goto IL_0982;
		IL_0982:
		throw new NullReferenceException();
		IL_077b:
		object text = "Read object reference Id '{0}' for {1}." + 1496;
		TextMeshProExtensions.Localize(timeMessage, (string)text);
		miniGameNextTrialTime.SetActive(value: true);
		GameObject gameObject3 = message.gameObject;
		gameObject3.SetActive(value: false);
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v15+E4]");
		bool flag14 = (nint)0 == 0;
		object obj26 = !flag14;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime date2 = MiniGameInfo.MiniGameNextTrialTime;
		timer.SetDate(date2);
		return;
		IL_00a7:
		miniGameNextTrialTime.SetActive(value: false);
		GameObject gameObject4 = message.gameObject;
		gameObject4.SetActive(value: true);
		return;
		IL_04d1:
		object text2 = "Read object reference Id '{0}' for {1}." + 1504;
		TextMeshProExtensions.Localize(timeMessage, (string)text2);
		miniGameNextTrialTime.SetActive(value: true);
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v33+E4]");
		object obj28;
		object obj30;
		if ((nint)0 != 0)
		{
			obj28 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B9]");
			object obj29 = (nint)0 & (nint)1;
			bool flag15 = obj29 == null;
			obj30 = obj28;
			if (!flag15)
			{
				goto IL_0580;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B9]");
			object obj31 = (nint)0 & (nint)1;
			bool flag16 = obj31 == null;
			object obj32 = !flag16;
			obj30 = obj28;
			if (obj32 != null)
			{
				goto IL_0580;
			}
		}
		_ = 1;
		obj9 = "m_StencilDeferredPS" + 1808;
		object obj33 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v51+E4]");
		bool flag17 = (nint)0 == 0;
		object obj34 = !flag17;
		object obj35 = obj9;
		object obj36 = obj33;
		obj28 = obj30;
		if (obj34 != null)
		{
			goto IL_05cc;
		}
		goto IL_0903;
		IL_0386:
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool delayIsActive3 = MiniGameInfo.DelayIsActive;
			bool flag18 = !delayIsActive3;
			object obj38 = !flag18;
			if (obj38 != null)
			{
				goto IL_0416;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (MiniGameInfo.DelayIsActive)
			{
				goto IL_0416;
			}
		}
		goto IL_077b;
		IL_0903:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj39 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v39+B8]");
		object obj40 = 0;
		object key2 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v24+10]");
		date = Prefs.GetDate((string)key2, (DateTime)0);
		goto IL_0943;
		IL_0580:
		obj9 = "m_StencilDeferredPS" + 1808;
		obj33 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v51+E4]");
		bool flag19 = (nint)0 == 0;
		obj35 = obj9;
		obj36 = obj33;
		if (!flag19)
		{
			goto IL_05cc;
		}
		goto IL_0903;
		IL_0416:
		object obj41 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v20+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64B7]");
			object obj42 = (nint)0 & (nint)1;
			if (obj42 != null)
			{
				goto IL_0476;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v5+4B7]");
			object obj43 = (nint)0 & (nint)1;
			bool flag20 = obj43 == null;
			object obj44 = !flag20;
			if (obj44 != null)
			{
				goto IL_0476;
			}
		}
		_ = 1;
		obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v56+E4]");
		bool flag21 = (nint)0 == 0;
		object obj45 = !flag21;
		obj21 = obj20;
		if (obj45 != null)
		{
			goto IL_04ab;
		}
		goto IL_0743;
	}
}
