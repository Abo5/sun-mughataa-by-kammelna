using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class LeaveClanPanel : MonoBehaviour
{
	private const string LEFT_CLAN_TOAST_KEY = "clan_left";

	private const string LEAVE_FAILED_TITLE_KEY = "leave_clan_failed_title";

	private const string LEAVE_FAILED_CONTENT_KEY = "leave_clan_failed_content";

	private const string OWNER_BODY_KEY = "leave_clan_owner_body";

	private TextMeshProUGUI bodyText;

	private AvatarInitializer myAvatar;

	private AvatarInitializer nextOwnerAvatar;

	private Button transferOwnershipButton;

	private Button cancelButton;

	private Button leaveButton;

	private PopupUI popup;

	private ClansSerializedUtils clanUtils;

	private Action _onLeft;

	private Action<ClanModel> _onClanRefreshed;

	private ClanMemberViewModel _suggestedOwner;

	private void Awake()
	{
		SubscribeButtons();
	}

	private void OnDestroy()
	{
		UnsubscribeButtons();
	}

	public void Initialize(Action onLeft = null, Action<ClanModel> onClanRefreshed = null)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0061: Expected O, but got I4
		object obj = this + 96;
		Action action = default(Action);
		obj = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 104;
		obj2 = onClanRefreshed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X21_v3-18]");
		object obj3 = 0;
		object obj4 = typeof(Queue<string>) + 848;
		object obj5 = (nint)0 + (nint)2200;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		myAvatar.Initialize(localUser);
		ShowAsLoading();
		FetchSuggestedOwner();
	}

	private void FetchSuggestedOwner()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 232;
		object obj4 = (nint)0 + (nint)616;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<ClanResult<object>> action = default(Action<ClanResult<object>>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetSuggestedOwner((Action<ClanResult<ClanMemberViewModel>>)(object)action);
	}

	private void OnSuggestedOwnerResult(ClanResult<ClanMemberViewModel> result)
	{
		//IL_000c: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		object obj = (nint)0 + (nint)1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @439BB40");
		object obj2 = default(object);
		if (obj2 != null)
		{
			ClanMemberViewModel clanMemberViewModel = default(ClanMemberViewModel);
			if (clanMemberViewModel != null)
			{
				object obj3 = this + 112;
				obj3 = clanMemberViewModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X21_v6-28]");
				((Selectable)0).interactable = true;
				ShowSuccessorState(clanMemberViewModel);
			}
			else
			{
				HandleMissingSuccessor();
			}
		}
		else
		{
			IntPtr intPtr = default(IntPtr);
			OnLoadSuggestedOwnerFailed((KammelnaError)(nint)intPtr);
		}
	}

	private void SubscribeButtons()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		Button button = transferOwnershipButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = cancelButton;
		object obj3 = (nint)0 + (nint)576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = leaveButton;
		object obj4 = (nint)0 + (nint)584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		button3.m_OnClick.AddListener(unityAction3);
	}

	private void UnsubscribeButtons()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		Button button = transferOwnershipButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = cancelButton;
		object obj3 = (nint)0 + (nint)576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.RemoveListener(unityAction2);
		Button button3 = leaveButton;
		object obj4 = (nint)0 + (nint)584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		button3.m_OnClick.RemoveListener(unityAction3);
	}

	private void ShowAsLoading()
	{
		//IL_005d: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_007d: Expected O, but got I
		GameObject gameObject = nextOwnerAvatar.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = transferOwnershipButton.gameObject;
		gameObject2.SetActive(value: false);
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+B8]");
		object text = 0;
		bodyText.text = (string)text;
		leaveButton.interactable = false;
	}

	private void ShowSuggestedOwner(ClanMemberViewModel suggestedOwner)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		if (suggestedOwner != null)
		{
			object obj = this + 112;
			obj = suggestedOwner;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X21_v3-28]");
			((Selectable)0).interactable = true;
			ShowSuccessorState(suggestedOwner);
		}
		else
		{
			HandleMissingSuccessor();
		}
	}

	private void HandleMissingSuccessor()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00be: Expected I, but got O
		//IL_00ce: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_0180: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85F3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00e8;
		}
		object obj4 = "WhiteSmoke" + 3328;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = obj4;
		if (!flag)
		{
			goto IL_0094;
		}
		goto IL_013d;
		IL_013d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogError(obj6);
		ShowFailurePopup();
		PopupUI popupUI = popup;
		bool flag2 = (object)popup == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b6;
		IL_0094:
		KLogger.LogError(obj4);
		ShowFailurePopup();
		popupUI = popup;
		goto IL_00b6;
		IL_00b6:
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7 (Il2CppClass<PopupUI>)+198]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7 (Il2CppClass<PopupUI>)+1A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_00e8;
		IL_00e8:
		_ = 1;
		obj4 = "WhiteSmoke" + 3328;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj6 = obj4;
		if (obj10 != null)
		{
			goto IL_0094;
		}
		goto IL_013d;
	}

	private void ShowSuccessorState(ClanMemberViewModel successor)
	{
		//IL_006c: Expected I, but got O
		//IL_00a4: Expected I, but got O
		//IL_00dd: Expected I, but got O
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0135: Expected I, but got O
		//IL_013e: Expected O, but got I4
		//IL_0160: Expected I, but got O
		//IL_0169: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_020c: Expected I, but got O
		//IL_01aa: Expected I, but got O
		//IL_01ba: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_01e8: Expected O, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		bool flag = (object)nextOwnerAvatar == null;
		AvatarData avatarData = successor;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			GameObject gameObject = nextOwnerAvatar.gameObject;
			bool flag2 = (object)gameObject == null;
			avatarData = null;
			if (!flag2)
			{
				gameObject.SetActive(value: true);
				AvatarData avatarData2 = successor;
				bool flag3 = (object)nextOwnerAvatar == null;
				nint num = unchecked((nint)null);
				avatarData = null;
				if (!flag3)
				{
					nextOwnerAvatar.Initialize(avatarData2);
					bool flag4 = (object)transferOwnershipButton == null;
					num = unchecked((nint)null);
					avatarData = avatarData2;
					if (!flag4)
					{
						GameObject gameObject2 = transferOwnershipButton.gameObject;
						bool flag5 = (object)gameObject2 == null;
						num = unchecked((nint)null);
						avatarData = null;
						if (!flag5)
						{
							object obj = typeof(TypeConverter<ushort, char>) + 3400;
							gameObject2.SetActive(value: true);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							bool flag6 = successor == null;
							num = unchecked((nint)null);
							avatarData = (AvatarData)1;
							if (!flag6)
							{
								object[] array = default(object[]);
								bool flag7 = array == null;
								num = unchecked((nint)null);
								avatarData = (AvatarData)1;
								if (!flag7)
								{
									bool flag8 = successor.Name == null;
									AvatarData avatarData3 = (AvatarData)1;
									if (!flag8)
									{
										nint num2 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
										avatarData3 = (AvatarData)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag9 = ex == null;
										num = unchecked((nint)null);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
										avatarData = (AvatarData)0;
										if (flag9)
										{
											goto IL_028b;
										}
									}
									bool flag10 = array.Length == 0;
									num = unchecked((nint)null);
									avatarData = avatarData3;
									if (!flag10)
									{
										object text = "java.io.FileOutputStream" + 2088;
										object obj2 = array + 32;
										obj2 = successor.Name;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										TextMeshProExtensions.Localize(bodyText, (string)text, array);
										return;
									}
									goto IL_027d;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_027d;
		IL_028b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_027d:
		ex = new IndexOutOfRangeException();
		goto IL_028b;
	}

	private void OnLoadSuggestedOwnerFailed(KammelnaError error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object format = "WhiteSmoke" + 3320;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = text;
		}
		KLogger.LogError(obj6);
		ShowFailurePopup();
		popup.HidePopup();
	}

	private void OnTransferOwnershipClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008d: Expected I, but got O
		//IL_004b: Expected I, but got O
		//IL_005b: Expected O, but got I
		//IL_006b: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj2 = (nint)0 + (nint)608;
		Action<object> action = default(Action<object>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor((object)this, (IntPtr)obj2);
			clanUtils.OpenClanTransferOwnershipPopup(action);
			PopupUI popupUI = popup;
			nint num = (nint)popupUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<PopupUI>)+198]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<PopupUI>)+1A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v68 @ X2_v4 (should have been resolved before IL gen)");
		}
	}

	private void OnOwnershipTransferred(ClanModel refreshedClan)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		//IL_0096: Expected I, but got O
		//IL_00a6: Expected O, but got I
		//IL_00b6: Expected O, but got I
		while (true)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Action<ClanModel> onClanRefreshed = _onClanRefreshed;
			if (_onClanRefreshed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X8_v3 (System.Action`1<ClanModel>)+18] (should have been resolved before IL gen)");
			}
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				if (this == null)
				{
					break;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = this == null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					break;
				}
			}
			PopupUI popupUI = popup;
			nint num = (nint)popupUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppClass<PopupUI>)+198]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppClass<PopupUI>)+1A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private void OnCancelClicked()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		PopupUI popupUI = popup;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnLeaveClicked()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_0091: Expected I, but got O
		//IL_00ae: Expected I, but got O
		leaveButton.interactable = false;
		transferOwnershipButton.interactable = false;
		ClanMemberViewModel suggestedOwner = _suggestedOwner;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)600;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
		object obj4 = (nint)0 + (nint)592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)obj4);
		ClanLeaveFlow.TransferAndLeave(suggestedOwner.UserId, action, (Action<KammelnaError>)(object)action2);
	}

	private void OnLeaveSucceeded()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0190: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_0044: Expected O, but got I
		//IL_00b0: Expected O, but got I4
		//IL_00fa: Expected I, but got O
		//IL_010a: Expected O, but got I
		//IL_011a: Expected O, but got I
		object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3720;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		while (true)
		{
			LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Toast.Show(text2, (Vector2)0, 0f);
			Action onLeft = _onLeft;
			bool flag2 = _onLeft == null;
			Vector2 vector = (Vector2)0;
			if (!flag2)
			{
				vector = (Vector2)(nint)((Delegate)onLeft).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (this == null)
				{
					break;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = this == null;
				bool flag4 = !flag3;
				object obj6 = !flag4;
				if (obj6 != null)
				{
					break;
				}
			}
			leaveButton.interactable = true;
			transferOwnershipButton.interactable = true;
			PopupUI popupUI = popup;
			nint num = (nint)popupUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6 (Il2CppClass<PopupUI>)+198]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6 (Il2CppClass<PopupUI>)+1A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	private void OnLeaveFailed(KammelnaError error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85FA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			ShowFailurePopup();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0079;
			}
		}
		else
		{
			_ = 1;
			ShowFailurePopup();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0079;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_012d;
		IL_012d:
		leaveButton.interactable = true;
		transferOwnershipButton.interactable = true;
		return;
		IL_0079:
		if (this == null)
		{
			return;
		}
		goto IL_012d;
	}

	private static void ShowFailurePopup()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_009e: Expected I, but got O
		//IL_00ae: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_00e9: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0187: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0270: Expected I, but got O
		//IL_0294: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85FB]");
		nint num = 0;
		object buttonText = "Network Authentication Required" + 3128;
		object text = "java.io.FileOutputStream" + 2072;
		object obj3 = default(object);
		object obj4 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj11 = default(object);
		object obj17 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)buttonText);
			LocalizableText title = TextMeshProExtensions.Localize((string)text);
			nint num2;
			if (popupWindowBuilder != null)
			{
				object text2 = "java.io.FileOutputStream" + 2064;
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
				LocalizableText localizableText = TextMeshProExtensions.Localize((string)text2);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0132;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4 = obj3 + 16;
						obj2--;
						bool flag = (nint)obj2 != 1;
						obj3 = obj4;
						if (flag)
						{
							continue;
						}
						goto IL_0132;
					}
					goto IL_023f;
				}
			}
			goto IL_02aa;
			IL_02aa:
			ex = new NullReferenceException();
			goto IL_02b8;
			IL_02b8:
			object obj5 = obj4 + 9;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v5+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v184 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_0213:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v14+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_023f;
			IL_023f:
			object obj13 = obj3 + 1;
			object obj14 = num2 + obj13;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ X0_v20] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj4 = obj3;
			if (obj16 != null)
			{
				goto IL_016b;
			}
			goto IL_02aa;
			IL_0132:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v17] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_016b;
			}
			goto IL_02aa;
			IL_016b:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj4 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0213;
				}
				goto IL_02b8;
			}
			goto IL_0213;
		}
	}

	private void SetLoading(bool isLoading)
	{
		bool interactable = (byte)((isLoading ? 1u : 0u) ^ 1u) != 0;
		leaveButton.interactable = interactable;
		bool interactable2 = (byte)((isLoading ? 1u : 0u) ^ 1u) != 0;
		transferOwnershipButton.interactable = interactable2;
	}

	private void CloseSelf()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		PopupUI popupUI = popup;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
