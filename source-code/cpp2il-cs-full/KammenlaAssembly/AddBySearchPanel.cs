using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Features.GameReplay;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UI.UI_Themeing;
using UnityEngine;
using UnityEngine.UI;

public class AddBySearchPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static InputField.OnValidateInput <>9__5_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal char <Start>b__5_0(string _, int _, char addedChar)
		{
			//IL_000f: Expected O, but got I4
			//IL_001f: Expected O, but got I
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+88]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				return char.ToUpper(addedChar);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return char.ToUpper(addedChar);
		}
	}

	private InputFieldTMProUGUI inputField;

	private LastMatchStrip searchResultStrip;

	private TextMeshProUGUI placeHolder;

	private GameObject loadingIndicator;

	private UiToggler expandToggler;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0139: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_01e5: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0283: Expected O, but got I
		//IL_0294: Expected I, but got O
		//IL_02b2: Expected O, but got I
		//IL_0234: Expected O, but got I4
		//IL_0215: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E615C]");
		object obj3 = (nint)0 & (nint)1;
		InputFieldTMProUGUI inputFieldTMProUGUI;
		InputFieldTMProUGUI inputFieldTMProUGUI2;
		object obj4;
		if (obj3 != null)
		{
			inputFieldTMProUGUI = inputField;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			inputFieldTMProUGUI2 = inputField;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			inputFieldTMProUGUI = inputField;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			inputFieldTMProUGUI2 = inputField;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
		InputField.OnValidateInput value = (InputField.OnValidateInput)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_01c3;
		IL_00e6:
		inputFieldTMProUGUI.OnValidateInput += value;
		UpdatePlaceHolderBeforeRequest();
		return;
		IL_01c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj11 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)2592;
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v9+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = onValidateInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = (object)inputFieldTMProUGUI2 == null;
		object obj15 = !flag5;
		value = onValidateInput;
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00e6;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
		value = (InputField.OnValidateInput)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
		bool flag6 = (nint)0 == 0;
		inputFieldTMProUGUI2 = inputFieldTMProUGUI;
		if (!flag6)
		{
			goto IL_00e6;
		}
		goto IL_01c3;
	}

	private void OnDisable()
	{
		//IL_0011: Expected O, but got I
		object text = (nint)0 + (nint)2000;
		inputField.Text = (string)text;
		UpdateSize();
	}

	public void OnEndEdit()
	{
		UpdatePlaceHolderBeforeRequest();
		if (CodeIsValidForm())
		{
			LookupCode();
		}
	}

	private bool CodeIsValidForm()
	{
		//IL_0122: Expected I4, but got O
		//IL_005e: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		if ((object)inputField != null)
		{
			string text = inputField.Text;
			if (text != null)
			{
				object obj = text._stringLength - 5;
				bool flag = (nint)obj < 2;
				object obj2 = !flag;
				if (obj2 == null)
				{
					return true;
				}
				if ((object)inputField != null)
				{
					object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
					string text2 = inputField.Text;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+E4]");
					if ((nint)0 != 0)
					{
						return StringUtil.IsValidEmail(text2);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return StringUtil.IsValidEmail(text2);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool TextIsValidEmailForm()
	{
		//IL_0096: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if ((object)inputField != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			string text = inputField.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				return StringUtil.IsValidEmail(text);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return StringUtil.IsValidEmail(text);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool TextIsAppropriateCodeLength()
	{
		//IL_0094: Expected I4, but got O
		//IL_005e: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected I4, but got O
		if ((object)inputField != null)
		{
			string text = inputField.Text;
			if (text != null)
			{
				object obj = text._stringLength - 5;
				bool flag = (nint)obj < 2;
				object obj2 = !flag;
				return (byte)(int)(~obj2) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void LookupCode()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0066: Expected I, but got O
		loadingIndicator.SetActive(value: true);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 576;
		object obj2 = (nint)0 + (nint)3144;
		string text = inputField.Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.FindFriend(text, action);
	}

	private void FindFriendRequestCallback(KammelnaResponseModel<PlayerProfileModel> response)
	{
		loadingIndicator.SetActive(value: false);
		GameObject gameObject = placeHolder.gameObject;
		gameObject.SetActive(value: false);
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			PlayerProfileModel <Model>k__BackingField = response.<Model>k__BackingField;
			if (UserIsNotMe(<Model>k__BackingField.<userDbId>k__BackingField))
			{
				CreateNewStrip(response.<Model>k__BackingField);
				return;
			}
		}
		ShowPlaceHolder();
	}

	private static bool UserIsNotMe(long dbId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01a4: Expected I4, but got O
		//IL_0188: Expected O, but got I4
		//IL_00e4: Expected O, but got I8
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6160]");
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
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_0196;
		IL_00b8:
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj9 = dbId - intDbId;
		bool flag4 = obj9 == null;
		return !flag4;
		IL_0196:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_0196;
	}

	private void CreateNewStrip(PlayerProfileModel m)
	{
		//IL_0043: Expected I4, but got I8
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		GameObject gameObject = searchResultStrip.gameObject;
		gameObject.SetActive(value: true);
		LastMatchStrip lastMatchStrip = searchResultStrip;
		lastMatchStrip._playerID = (int)m.<userDbId>k__BackingField;
		AvatarData data = m;
		lastMatchStrip.avatar.Initialize(data);
		lastMatchStrip.addButton.interactable = true;
		LastMatchStrip lastMatchStrip2 = searchResultStrip;
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6161]");
		object obj2 = (nint)0 & (nint)1;
		long <userDbId>k__BackingField;
		long <userDbId>k__BackingField2;
		if (obj2 != null)
		{
			<userDbId>k__BackingField = m.<userDbId>k__BackingField;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			<userDbId>k__BackingField2 = m.<userDbId>k__BackingField;
			if (!flag)
			{
				goto IL_0117;
			}
		}
		else
		{
			_ = 1;
			<userDbId>k__BackingField = m.<userDbId>k__BackingField;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			<userDbId>k__BackingField2 = m.<userDbId>k__BackingField;
			if (obj4 != null)
			{
				goto IL_0117;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool interactable = FriendsManager.IsCompleteStranger(<userDbId>k__BackingField2);
		goto IL_01c7;
		IL_01c7:
		lastMatchStrip2.addButton.interactable = interactable;
		return;
		IL_0117:
		interactable = FriendsManager.IsCompleteStranger(<userDbId>k__BackingField);
		bool flag3 = (object)searchResultStrip == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01c7;
	}

	private bool IsCompleteStranger(PlayerProfileModel m)
	{
		//IL_0091: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (m != null)
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				return FriendsManager.IsCompleteStranger(m.<userDbId>k__BackingField);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FriendsManager.IsCompleteStranger(m.<userDbId>k__BackingField);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Clear()
	{
		GameObject gameObject = searchResultStrip.gameObject;
		gameObject.SetActive(value: false);
	}

	public void UpdateSize()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		bool isON;
		if (inputField.Selected)
		{
			isON = true;
		}
		else
		{
			string text = inputField.Text;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			isON = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}
		expandToggler.ToggleManual(isON);
	}

	private void ShowPlaceHolder()
	{
		GameObject gameObject = searchResultStrip.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = placeHolder.gameObject;
		gameObject2.SetActive(value: true);
		UpdatePlaceHolderAfterRequest();
	}

	private void HidePlaceHolder()
	{
		GameObject gameObject = placeHolder.gameObject;
		gameObject.SetActive(value: false);
	}

	private void UpdatePlaceHolderBeforeRequest()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_004c: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_023a: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0284: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6277]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_007f;
			}
		}
		_ = 1;
		InputFieldTMProUGUI inputFieldTMProUGUI = inputField;
		bool flag2 = (object)inputField == null;
		object obj7 = !flag2;
		obj3 = 1;
		if (obj7 != null)
		{
			goto IL_00a8;
		}
		goto IL_01e7;
		IL_0251:
		bool flag3 = CodeIsValidForm();
		object obj8 = "destinationTimeZone" + 2456;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		object obj10 = ~obj9;
		object text;
		if (obj10 != null)
		{
			text = obj8;
		}
		TextMeshProExtensions.Localize(placeHolder, (string)text);
		return;
		IL_0140:
		object obj11;
		TextMeshProExtensions.Localize(placeHolder, (string)obj11);
		return;
		IL_01f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException email;
		bool flag5 = StringUtil.IsValidEmail((string)(object)email);
		obj11 = "SERVICE_DISABLED" + 2272;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		text = obj11;
		if (obj12 != null)
		{
			goto IL_0140;
		}
		goto IL_0251;
		IL_007f:
		inputFieldTMProUGUI = inputField;
		if ((object)inputField != null)
		{
			goto IL_00a8;
		}
		goto IL_01e7;
		IL_01e7:
		email = new NullReferenceException();
		goto IL_01f5;
		IL_00a8:
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text2 = inputFieldTMProUGUI.Text;
		obj3 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+E4]");
		bool flag7 = (nint)0 == 0;
		email = (NullReferenceException)(object)text2;
		if (flag7)
		{
			goto IL_01f5;
		}
		bool flag8 = StringUtil.IsValidEmail(text2);
		obj11 = "SERVICE_DISABLED" + 2272;
		bool flag9 = !flag8;
		text = obj11;
		if (!flag9)
		{
			goto IL_0140;
		}
		goto IL_0251;
	}

	private void UpdatePlaceHolderAfterRequest()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_004c: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_01d1: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0223: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0274: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6278]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6276]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_007f;
			}
		}
		_ = 1;
		InputFieldTMProUGUI inputFieldTMProUGUI = inputField;
		bool flag2 = (object)inputField == null;
		object obj7 = !flag2;
		obj3 = 1;
		if (obj7 != null)
		{
			goto IL_00a8;
		}
		goto IL_01df;
		IL_0232:
		bool flag3 = CodeIsValidForm();
		object text = "destinationTimeZone" + 2456;
		object obj8 = "Network Authentication Required" + 848;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			text = obj8;
		}
		TextMeshProExtensions.Localize(placeHolder, (string)text);
		return;
		IL_0129:
		object text2 = "Network Authentication Required" + 840;
		TextMeshProExtensions.Localize(placeHolder, (string)text2);
		return;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException email;
		bool flag5 = StringUtil.IsValidEmail((string)(object)email);
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_0129;
		}
		goto IL_0232;
		IL_007f:
		inputFieldTMProUGUI = inputField;
		if ((object)inputField != null)
		{
			goto IL_00a8;
		}
		goto IL_01df;
		IL_01df:
		email = new NullReferenceException();
		goto IL_01ed;
		IL_00a8:
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text3 = inputFieldTMProUGUI.Text;
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		email = (NullReferenceException)(object)text3;
		if (flag7)
		{
			goto IL_01ed;
		}
		if (StringUtil.IsValidEmail(text3))
		{
			goto IL_0129;
		}
		goto IL_0232;
	}
}
