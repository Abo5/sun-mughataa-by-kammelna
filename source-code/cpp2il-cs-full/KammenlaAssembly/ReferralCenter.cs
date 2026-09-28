using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ReferralCenter : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public UserReferralRewardModel reward;

		internal void <OnRewardClaimed>b__0(ReferralCongratsPopup instance)
		{
			instance.Populate(reward);
		}
	}

	private ReferralRewardsListView list;

	private Button claimAllButton;

	private TextMeshProUGUI shareCount;

	private Button shareButton;

	private ComponentReference<ReferralCongratsPopup> congratsPopupRef;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		//IL_00c4: Expected O, but got I4
		//IL_0107: Expected I, but got O
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_015c: Expected I, but got O
		object obj = typeof(List<Tween>) + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2008;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3968;
		object obj6 = (nint)0 + (nint)2016;
		this.list.SetData((List<UserReferralRewardModel>)(object)list);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ReferralHandler.CallWhenReady(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		ReferralHandler.OnRewardClaimed += action2;
		Button button = shareButton;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj10 = (nint)0 + (nint)2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj10);
		button.m_OnClick.AddListener(unityAction);
	}

	private void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_01fb: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_02c2: Expected O, but got I
		//IL_0373: Expected O, but got I4
		//IL_0330: Expected O, but got I4
		//IL_03b0: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6610]");
		object obj3 = (nint)0 & (nint)1;
		ReferralRewardsListView referralRewardsListView;
		ReferralRewardsListView referralRewardsListView2;
		if (obj3 != null)
		{
			referralRewardsListView = list;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			referralRewardsListView2 = list;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			referralRewardsListView = list;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			referralRewardsListView2 = list;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		referralRewardsListView = referralRewardsListView2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00e8;
		}
		goto IL_0219;
		IL_0314:
		bool flag4 = (object)claimAllButton == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_03a0;
		}
		goto IL_03f8;
		IL_03a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v6+B8]");
		object obj11 = 0;
		Button button = claimAllButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v8+11]");
		button.interactable = false;
		List<UserReferralModel> successfulReferrals = ReferralHandler.SuccessfulReferrals;
		int num = default(int);
		string text = num.ToString();
		shareCount.text = text;
		return;
		IL_03f8:
		throw new NullReferenceException();
		IL_0091:
		obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
		object obj12 = (nint)0 & (nint)1;
		bool flag5 = obj12 == null;
		obj9 = obj6;
		referralRewardsListView2 = referralRewardsListView;
		if (!flag5)
		{
			goto IL_00e8;
		}
		goto IL_0219;
		IL_0219:
		_ = 1;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		referralRewardsListView = referralRewardsListView2;
		if (obj14 != null)
		{
			goto IL_011d;
		}
		goto IL_025f;
		IL_00e8:
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		referralRewardsListView2 = referralRewardsListView;
		if (!flag7)
		{
			goto IL_011d;
		}
		goto IL_025f;
		IL_025f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<UserReferralRewardModel>> referralRewards = CachedModels.ReferralRewards;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)referralRewards;
		referralRewardsListView = referralRewardsListView2;
		goto IL_028c;
		IL_011d:
		CachedModel<List<UserReferralRewardModel>> referralRewards2 = CachedModels.ReferralRewards;
		bool flag8 = referralRewards2 == null;
		object obj15 = !flag8;
		cachedModel = (CachedModel<object>)(object)referralRewards2;
		if (obj15 != null)
		{
			goto IL_028c;
		}
		goto IL_03f8;
		IL_028c:
		object model = cachedModel.Model;
		referralRewardsListView.SetData((List<UserReferralRewardModel>)model);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459D]");
		object obj16 = (nint)0 & (nint)1;
		object obj17;
		if (obj16 != null)
		{
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v6+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = obj17;
			if (!flag9)
			{
				goto IL_0314;
			}
		}
		else
		{
			_ = 1;
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v6+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			object obj18 = obj17;
			if (obj19 != null)
			{
				goto IL_0314;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj2;
		goto IL_03a0;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3968;
		object obj2 = (nint)0 + (nint)2016;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			ReferralHandler.OnRewardClaimed -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ReferralHandler.OnRewardClaimed -= action;
	}

	private void ShareGame()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_004c: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		object msgBody = "LAK" + 2136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj8 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	private void Share(string referralUrl)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object key = "placementId" + 2768;
		object obj2 = (nint)0 + (nint)2336;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationText.GetText((string)key);
		string message = text + (string)obj2 + referralUrl;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			KUtil.Share(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.Share(message);
	}

	private void OnRewardClaimed(UserReferralRewardModel reward)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0344: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_03d4: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0114: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_014f: Expected I, but got O
		//IL_0394: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_028c: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_048b: Expected O, but got I4
		//IL_02f9: Expected O, but got I4
		//IL_0526: Expected O, but got I4
		//IL_053c: Expected O, but got I
		//IL_05e6: Expected O, but got I4
		//IL_059e: Expected O, but got I
		//IL_062a: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj4 = obj2 + 16;
		obj4 = reward;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6615]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 != null)
		{
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00b6;
			}
		}
		else
		{
			_ = 1;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00b6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		PopupWindow.DismissMessage();
		bool flag2 = obj4 == null;
		object obj10 = !flag2;
		object obj11 = obj9;
		if (obj10 != null)
		{
			goto IL_00f4;
		}
		goto IL_03aa;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13;
		object obj12 = obj13;
		Action<object> action2;
		Action<object> action = action2;
		obj11 = obj9;
		object obj15;
		object obj14 = obj15;
		ReferralRewardsListView referralRewardsListView2;
		ReferralRewardsListView referralRewardsListView = referralRewardsListView2;
		goto IL_0262;
		IL_0262:
		object obj16 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6616]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02d6;
			}
		}
		else
		{
			_ = 1;
			object obj18 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+E4]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 != null)
			{
				goto IL_02d6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<UserReferralRewardModel>> referralRewards = CachedModels.ReferralRewards;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)referralRewards;
		goto IL_04fd;
		IL_058e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v33+B8]");
		object obj20 = 0;
		Button button = claimAllButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v24+11]");
		button.interactable = false;
		return;
		IL_00b6:
		obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		PopupWindow.DismissMessage();
		bool flag4 = obj4 == null;
		obj11 = obj9;
		if (!flag4)
		{
			goto IL_00f4;
		}
		goto IL_03aa;
		IL_03aa:
		object obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object error = "Index = {0} position = {1}" + 1736;
		PopupWindow.SetError((string)error);
		PopupWindow.SetLoading(loading: false);
		referralRewardsListView = list;
		object obj23 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v52+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		action = null;
		obj14 = 0;
		if (obj24 == null)
		{
			obj13 = obj12;
			action2 = null;
			obj9 = obj11;
			obj15 = 0;
			referralRewardsListView2 = list;
			goto IL_022b;
		}
		goto IL_0262;
		IL_04fd:
		object model = cachedModel.Model;
		referralRewardsListView.SetData((List<UserReferralRewardModel>)model);
		object obj25 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459D]");
		object obj26 = (nint)0 & (nint)1;
		object obj27;
		if (obj26 != null)
		{
			obj27 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v33+E4]");
			bool flag7 = (nint)0 == 0;
			object obj28 = obj27;
			if (!flag7)
			{
				goto IL_058e;
			}
		}
		else
		{
			_ = 1;
			obj27 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v33+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			object obj28 = obj27;
			if (obj29 != null)
			{
				goto IL_058e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj27 = obj11;
		bool flag9 = (object)claimAllButton == null;
		object obj30 = !flag9;
		if (obj30 != null)
		{
			goto IL_058e;
		}
		goto IL_0638;
		IL_0638:
		throw new NullReferenceException();
		IL_02d6:
		CachedModel<List<UserReferralRewardModel>> referralRewards2 = CachedModels.ReferralRewards;
		bool flag10 = referralRewards2 == null;
		object obj31 = !flag10;
		cachedModel = (CachedModel<object>)(object)referralRewards2;
		if (obj31 != null)
		{
			goto IL_04fd;
		}
		goto IL_0638;
		IL_00f4:
		object obj32 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3264;
		object obj33 = (nint)0 + (nint)3496;
		object obj34 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj35 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj33);
		object obj36 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v57+E4]");
		bool flag11 = (nint)0 == 0;
		object obj37 = !flag11;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj13 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		referralRewardsListView2 = list;
		obj23 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v52+E4]");
		bool flag12 = (nint)0 == 0;
		object obj38 = !flag12;
		action2 = action3;
		obj15 = 1;
		obj12 = obj35;
		action = action3;
		obj11 = obj9;
		obj14 = 1;
		referralRewardsListView = list;
		if (obj38 == null)
		{
			goto IL_022b;
		}
		goto IL_0262;
	}

	public void Back()
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
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6551]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
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
			object obj4 = (nint)0 + (nint)2184;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		bool flag3 = (object)screenManager == null;
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
		screenManager.Back();
	}

	public void ClaimAll()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		object msgBody = "LAK" + 2136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			ReferralHandler.ClaimAllRewards();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ReferralHandler.ClaimAllRewards();
	}

	private static void ShowLoading()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6614]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object msgBody;
		if (obj3 != null)
		{
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			msgBody = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			msgBody = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowLoading((string)msgBody);
		return;
		IL_0094:
		PopupWindow.ShowLoading((string)obj4);
	}

	private static void HideLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6615]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
	}
}
