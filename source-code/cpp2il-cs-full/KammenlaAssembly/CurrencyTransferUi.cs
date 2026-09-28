using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util.SystemHelpers;

public class CurrencyTransferUi : MonoBehaviour
{
	private sealed class <>c__DisplayClass31_0
	{
		public CurrencyTransferUi <>4__this;

		public int amount;

		internal void <SubmitTransaction>b__0(KammelnaResponseModel<bool> request)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00db: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_0176: Expected O, but got I4
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			//IL_01e6: Expected O, but got I4
			//IL_0223: Expected O, but got I4
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected O, but got Unknown
			//IL_03ef: Expected O, but got I
			//IL_0409: Expected O, but got I4
			//IL_027e: Expected O, but got I
			//IL_0447: Expected O, but got I4
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Expected O, but got Unknown
			//IL_0325: Expected O, but got I4
			//IL_036c: Expected F8, but got I4
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			//IL_038c: Expected O, but got I
			//IL_039d: Expected I8, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E692F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v44+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v44+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.SetLoading(loading: false);
			goto IL_0102;
			IL_02c8:
			decimal d;
			decimal num = decimal.Ceiling(d);
			int num2 = (int)num;
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string itemId = Tracker.ItemId(ResourceItemId.Transfer);
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Social, itemId, num2, ResourceCurrency.Aces);
			object action = "ThisIsFakeReceiptData" + 1704;
			object itemName = (nint)0 + (nint)2000;
			FirebaseTrack.CurrencyEvent((string)action, (string)itemName, num2);
			<>4__this.RefreshFeesInfo();
			return;
			IL_029b:
			object obj9;
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02c8;
			}
			goto IL_0455;
			IL_0455:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_02c8;
			IL_0074:
			PopupWindow.SetLoading(loading: false);
			bool flag3 = request == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0102;
			IL_0102:
			bool succeeded = request.Succeeded;
			CurrencyTransferUi currencyTransferUi = <>4__this;
			if (succeeded)
			{
				GiftsHandler.ShowGiftSentPopup(currencyTransferUi._giftInfo, GiftsHandler.GiftType.Coins, amount);
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.DismissMessage();
				<>4__this.ResetUi();
				obj9 = typeof(DataRelation) + 1368;
				object obj13 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				decimal num3 = amount;
				CurrencyTransferUi currencyTransferUi2 = <>4__this;
				TransferFeesModel transferFees = currencyTransferUi2._transferFees;
				d = num3 * 0m;
				object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
					object obj17 = (nint)0 & (nint)1;
					if (obj17 != null)
					{
						goto IL_029b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
					object obj18 = (nint)0 & (nint)1;
					bool flag6 = obj18 == null;
					object obj19 = !flag6;
					if (obj19 != null)
					{
						goto IL_029b;
					}
				}
				_ = 1;
				obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 != null)
				{
					goto IL_02c8;
				}
				goto IL_0455;
			}
			CurrencyTransferUi errorMessage = (CurrencyTransferUi)(object)request.ErrorMessage;
			errorMessage.ShowError((string)(object)errorMessage);
		}
	}

	private const string EnterAmountError = "Please enter transfer amount error";

	private const string ConfirmTransferMessage = "confirm_transfer_message";

	private Image userAvatar;

	private Image targetAvatar;

	private InputFieldTMProUGUI amountInput;

	private InputFieldTMProUGUI customMessage;

	private GameObject loadingIndicator;

	private TextMeshProUGUI transactionFee;

	private TextMeshProUGUI transactionTotal;

	private GameObject totalTransferredArea;

	private Button showTotalAreaButt;

	private ProgressBar transferBar;

	private TextMeshProUGUI totalTransferred;

	private TextMeshProUGUI limitInfo;

	private TransferFeesModel _transferFees;

	private GiftInfo _giftInfo;

	private decimal CurrencyTransferFee
	{
		get
		{
			TransferFeesModel transferFees = _transferFees;
			if (_transferFees != null)
			{
				return transferFees.<AppliedFees>k__BackingField;
			}
			return (decimal)new NullReferenceException();
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0188: Expected O, but got I
		//IL_01bf: Expected I, but got O
		//IL_01d0: Expected O, but got I
		//IL_01fc: Expected I, but got O
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0221: Expected O, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0261: Expected I, but got O
		//IL_028b: Expected O, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02e0: Expected O, but got I
		//IL_02f8: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6921]");
		object obj3 = (nint)0 & (nint)1;
		Image image;
		Image image2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			image = userAvatar;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			image2 = userAvatar;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			image = userAvatar;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			image2 = userAvatar;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		image = image2;
		goto IL_0168;
		IL_0168:
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj9 = (nint)0 + (nint)1232;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		UIExtensions.AssignAvatarImage(image, localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)1216;
		customMessage.OnValueChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj10);
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)1224;
		object obj13 = typeof(RegisteredWaitHandle) + 56;
		amountInput.OnValueChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj12);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action3;
		Button button = showTotalAreaButt;
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj17 = (nint)0 + (nint)1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj17);
		button.m_OnClick.AddListener(unityAction);
		UpdateTransactionInfo();
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0168;
	}

	private void OnEnable()
	{
		RefreshFeesInfo();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1224;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private void RefreshFeesInfo()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0052: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 664;
		object obj2 = (nint)0 + (nint)1208;
		loadingIndicator.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetTransferFee(action);
	}

	private unsafe void RefreshFeesUi()
	{
		//IL_0010: Expected O, but got I
		//IL_0525: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f9: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_0190: Expected O, but got Ref
		//IL_01b5: Expected O, but got Ref
		//IL_0235: Expected O, but got I4
		//IL_01cb: Expected I, but got O
		//IL_01db: Expected O, but got I
		//IL_01fd: Expected O, but got I4
		//IL_020d: Expected O, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_028f: Expected O, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_0328: Expected O, but got I
		//IL_035f: Expected O, but got Ref
		//IL_03e7: Expected O, but got I8
		//IL_03ff: Expected O, but got I4
		//IL_0408: Expected O, but got I4
		//IL_0375: Expected I, but got O
		//IL_0385: Expected O, but got I
		//IL_03a7: Expected O, but got I4
		//IL_03b0: Expected O, but got I4
		//IL_03c5: Expected O, but got I
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0488: Expected O, but got I
		//IL_04a2: Expected O, but got I4
		//IL_04ab: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj = 0;
		bool flag = _transferFees == null;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		OutOfMemoryException ex2;
		string text9;
		if (!flag)
		{
			object obj2 = "Material with texture name \"" + 3224;
			TextMeshProUGUI textMeshProUGUI = totalTransferred;
			text = (string)obj2;
			int num = default(int);
			string text2 = num.ToString((string)obj2);
			bool flag2 = _transferFees == null;
			string text3 = null;
			if (!flag2)
			{
				object obj3 = (nint)0 + (nint)3680;
				string text4 = num.ToString((string)obj2);
				text = (string)obj3;
				string text5 = text2 + (string)obj3 + text4;
				bool flag3 = (object)totalTransferred == null;
				object obj4 = 0;
				text3 = text4;
				if (!flag3)
				{
					object obj5 = typeof(TypeConverter<ushort, char>) + 3400;
					nint num2 = (nint)textMeshProUGUI;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v14 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
					text3 = (string)0;
					totalTransferred.text = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					bool flag4 = _transferFees == null;
					obj4 = 0;
					text = (string)2;
					if (!flag4)
					{
						object obj6 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array = default(object[]);
						bool flag5 = array == null;
						obj4 = 0;
						object obj7 = default(object);
						text = (string)(&obj7);
						if (!flag5)
						{
							string text6 = default(string);
							bool flag6 = text6 == null;
							string text7 = (string)(&obj7);
							if (!flag6)
							{
								nint num3 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
								text7 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag7 = ex == null;
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								if (flag7)
								{
									goto IL_04e3;
								}
							}
							bool flag8 = array.Length == 0;
							obj4 = 0;
							text = text7;
							if (!flag8)
							{
								object obj8 = array + 32;
								obj8 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								TransferFeesModel transferFees = _transferFees;
								bool flag9 = _transferFees == null;
								obj4 = 0;
								text = text6;
								if (flag9)
								{
									goto IL_04c7;
								}
								object obj9 = typeof(DataRelation) + 1368;
								decimal num4 = 100m;
								object obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v28+E4]");
								bool flag10 = (nint)0 == 0;
								object obj11 = !flag10;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								decimal <FeesAfterThreshold>k__BackingField = transferFees.<FeesAfterThreshold>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v22 (Kammelna.Server.WebRequests.TransferFeesModel)+30]");
								decimal num5 = <FeesAfterThreshold>k__BackingField * 0m;
								int num6 = (int)num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object obj12 = default(object);
								bool flag11 = obj12 == null;
								int num7 = default(int);
								string text8 = (string)(&num7);
								object obj13;
								if (!flag11)
								{
									nint num8 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
									text8 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag12 = ex == null;
									obj13 = 0;
									obj4 = 0;
									text3 = null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									if (flag12)
									{
										goto IL_04e3;
									}
								}
								object obj14 = array.Length & 0xFFFFFFFEL;
								bool flag13 = obj14 == null;
								obj13 = 0;
								obj4 = 0;
								text3 = null;
								text = text8;
								if (!flag13)
								{
									object obj15 = "tournament_participate_warning_body_with_tickets_warning_daily" + 336;
									object obj16 = array + 40;
									obj16 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									text9 = (string)obj15;
									TextMeshProExtensions.Localize(limitInfo, (string)obj15, array);
									UpdateTransactionInfo();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
									object obj17 = 0;
									bool flag14 = obj17 != obj;
									obj13 = 0;
									obj4 = 0;
									text3 = (string)(object)array;
									ex2 = (OutOfMemoryException)(object)this;
									if (!flag14)
									{
										return;
									}
									goto IL_0500;
								}
							}
							goto IL_04d5;
						}
					}
				}
			}
		}
		goto IL_04c7;
		IL_04c7:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_04d5;
		IL_04d5:
		ex = new IndexOutOfRangeException();
		goto IL_04e3;
		IL_0500:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		return;
		IL_04e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		ex2 = new OutOfMemoryException();
		text9 = null;
		goto IL_0500;
	}

	private void ToggleTotalArea()
	{
		TransferFeesModel transferFees = _transferFees;
		transferBar.Initialize(transferFees.<MonthlyThreshold>k__BackingField, transferFees.<Spent>k__BackingField);
	}

	private void OnValueChanged(string message)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		if (_giftInfo != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 3096;
			string input = message.Trim();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = InputSanitizer.SanitizeHtmlTags(input);
			object obj4 = _giftInfo + 24;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void OnConfigChanged()
	{
		UpdateTransactionInfo();
	}

	public void SetTargetUser(int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2880;
		ResetUi();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftInfo giftInfo = default(GiftInfo);
		giftInfo..ctor(dbId);
		object obj2 = this + 136;
		obj2 = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj2;
		Image image = targetAvatar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+10]");
		UIExtensions.AssignAvatarImageButLookForAvatarTimestampFirstBecauseIDontHaveIt(image, 0);
	}

	public void TransferClick()
	{
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_08d2: Expected I, but got O
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_03aa: Expected O, but got I
		//IL_03c4: Expected O, but got I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0416: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01ed: Expected I8, but got I4
		//IL_0227: Expected O, but got I4
		//IL_0272: Expected I, but got O
		//IL_02ac: Expected O, but got I4
		//IL_02b5: Expected O, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02df: Expected I, but got O
		//IL_02ef: Expected O, but got I
		//IL_0914: Expected O, but got I
		//IL_0940: Expected O, but got I4
		//IL_0949: Expected O, but got I4
		//IL_032a: Expected O, but got I
		//IL_0483: Expected O, but got I4
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected I, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0499: Expected I, but got O
		//IL_04a9: Expected O, but got I
		//IL_04d2: Expected O, but got I
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_0566: Expected O, but got I4
		//IL_056f: Expected O, but got I4
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_05ae: Expected O, but got I
		//IL_0644: Expected I, but got O
		//IL_0654: Expected O, but got I
		//IL_0676: Expected O, but got I4
		//IL_067f: Expected O, but got I4
		//IL_068f: Expected O, but got I
		//IL_05e9: Expected O, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_06b9: Expected I, but got O
		//IL_06c9: Expected O, but got I
		//IL_0758: Expected O, but got I4
		//IL_0761: Expected O, but got I4
		//IL_076a: Expected O, but got I4
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_07a8: Expected I, but got O
		//IL_07b8: Expected O, but got I
		//IL_07dc: Expected O, but got I4
		//IL_07ed: Expected O, but got I4
		//IL_07f6: Expected O, but got I4
		//IL_0806: Expected O, but got I
		//IL_0704: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_099a: Expected O, but got I4
		//IL_09a3: Expected O, but got I4
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6927]");
		nint num = 0;
		object obj;
		int result;
		decimal d;
		object obj9;
		object obj12;
		object obj10;
		string text2;
		if ((object)amountInput != null)
		{
			obj = typeof(DataRelation) + 1368;
			string text = amountInput.Text;
			bool flag = int.TryParse(text, out result);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			int num2 = result;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num2 = result;
			}
			decimal num3 = num2;
			TransferFeesModel transferFees = _transferFees;
			bool flag3 = _transferFees == null;
			text2 = null;
			num = (nint)_transferFees;
			if (!flag3)
			{
				object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				d = num3 * 0m;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
					object obj6 = (nint)0 & (nint)1;
					if (obj6 != null)
					{
						goto IL_012b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
					object obj7 = (nint)0 & (nint)1;
					bool flag4 = obj7 == null;
					object obj8 = !flag4;
					if (obj8 != null)
					{
						goto IL_012b;
					}
				}
				_ = 1;
				obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				obj12 = obj9;
				if (obj11 != null)
				{
					goto IL_0174;
				}
				goto IL_042c;
			}
		}
		goto IL_0814;
		IL_0814:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0822;
		IL_0866:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0745:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj13 = 0;
		object obj14 = 0;
		text2 = (string)9;
		object obj16 = default(object);
		object obj15 = obj16;
		goto IL_09b9;
		IL_0822:
		object obj18 = default(object);
		object obj17 = obj18 + 9;
		object obj19 = num + obj17;
		obj15 = obj19 + 312;
		goto IL_09b9;
		IL_0904:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag6 = array == null;
		obj13 = 0;
		obj14 = 0;
		string text3;
		string text5;
		if (!flag6)
		{
			bool flag7 = text3 == null;
			object obj20 = 1;
			if (!flag7)
			{
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
				bool flag8 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
				object obj21 = 0;
				if (flag8)
				{
					goto IL_0866;
				}
			}
			num = array.Length;
			if (array.Length == 0)
			{
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				object obj21 = obj20;
				goto IL_0866;
			}
			object text4 = "com.unity.services.authentication.profile" + 520;
			object obj22 = array + 32;
			obj22 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text4, array);
			object obj23 = default(object);
			bool flag9 = obj23 == null;
			obj13 = 0;
			obj14 = 0;
			text2 = null;
			if (!flag9)
			{
				object obj24 = typeof(System.IOAsyncCallback) + 384;
				object obj25 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v28+12E]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v28+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0632;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v28+B0]");
				object obj27 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v14-8]");
					if (0 == (nint)obj24)
					{
						break;
					}
					obj18 = obj27 + 16;
					obj26--;
					bool flag10 = (nint)obj26 != 1;
					obj27 = obj18;
					if (flag10)
					{
						continue;
					}
					goto IL_0632;
				}
				object obj28 = obj27 + 1;
				object obj29 = obj25 + obj28;
				object obj30 = obj29 + 312;
				num = (nint)obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v56+8]");
				text5 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v590 @ X0_v56] (should have been resolved before IL gen)");
				bool flag11 = ex == null;
				object obj31 = !flag11;
				obj18 = obj27;
				obj13 = 0;
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v56+8]");
				text2 = (string)0;
				if (obj31 != null)
				{
					goto IL_069d;
				}
			}
		}
		goto IL_0814;
		IL_0373:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_0904;
		IL_09b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X8_v3] (should have been resolved before IL gen)");
		return;
		IL_012b:
		obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v15+E4]");
		bool flag12 = (nint)0 == 0;
		obj12 = obj9;
		if (!flag12)
		{
			goto IL_0174;
		}
		goto IL_042c;
		IL_042c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj12;
		goto IL_0174;
		IL_0174:
		object input = "AvailableVoices" + 3920;
		object obj32 = typeof(SqlSingle[]) + 2376;
		object obj33 = (nint)0 + (nint)1240;
		object confirmText = "Complete" + 256;
		object obj34 = "COORDINATE_TYPE_GCJ_02" + 1864;
		decimal num5 = decimal.Ceiling(d);
		int num6 = (int)num5;
		long quantity = result + num6;
		object obj35 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v27+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v27+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		text3 = LocalizationUtil.Localize((string)input, quantity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj33);
		text2 = (string)obj34;
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateConfirm(action, (string)confirmText, (string)obj34);
		bool flag14 = popupWindowBuilderNeedsTitle == null;
		obj13 = 0;
		obj14 = 0;
		if (flag14)
		{
			goto IL_0814;
		}
		object obj37 = typeof(System.IOAsyncCallback) + 392;
		nint num7 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0373;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj39 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X10_v19-8]");
			if (0 == (nint)obj37)
			{
				break;
			}
			obj18 = obj39 + 16;
			obj38--;
			bool flag15 = (nint)obj38 != 1;
			obj39 = obj18;
			if (flag15)
			{
				continue;
			}
			goto IL_0373;
		}
		object obj40 = num7 + obj39;
		num = (nint)(obj40 + 312);
		obj18 = obj39;
		goto IL_0904;
		IL_069d:
		object obj41 = typeof(System.IOAsyncCallback) + 368;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0745;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v11-8]");
			bool flag16 = 0 == (nint)obj41;
			obj13 = 0;
			obj14 = 0;
			text2 = text5;
			if (flag16)
			{
				break;
			}
			obj18 += 16;
			obj42--;
			if ((nint)obj42 != 1)
			{
				continue;
			}
			goto IL_0745;
		}
		goto IL_0822;
		IL_0632:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj43 = default(object);
		num = (nint)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v53+8]");
		text5 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v574 @ X0_v53] (should have been resolved before IL gen)");
		bool flag17 = ex == null;
		obj13 = 0;
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v53+8]");
		text2 = (string)0;
		if (!flag17)
		{
			goto IL_069d;
		}
		goto IL_0814;
	}

	private void ResetUi()
	{
		//IL_0011: Expected O, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2000;
		amountInput.Text = (string)obj;
		customMessage.Text = (string)obj;
		if (_giftInfo != null)
		{
			object obj2 = _giftInfo + 24;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void InputChanged(string value)
	{
		UIExtensions.EnsureNumeric(amountInput);
		UpdateTransactionInfo();
	}

	private unsafe void UpdateTransactionInfo()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I4
		//IL_02d3: Expected I, but got O
		//IL_00ae: Expected I, but got O
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_019c: Expected I, but got O
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_0668: Expected O, but got I4
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_0596: Expected O, but got I
		//IL_05b0: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_025f: Expected O, but got I
		//IL_03a6: Expected O, but got I
		//IL_0509: Expected I, but got O
		//IL_0519: Expected O, but got I
		//IL_0536: Expected O, but got I
		//IL_0567: Expected I, but got O
		//IL_05ee: Expected O, but got I4
		//IL_0276: Expected O, but got I4
		//IL_0286: Expected O, but got I
		//IL_028f: Expected O, but got I4
		//IL_0297: Expected I, but got O
		//IL_0441: Expected O, but got I4
		//IL_0451: Expected O, but got I
		//IL_045a: Expected O, but got I4
		//IL_045f: Expected I, but got O
		//IL_0475: Expected I, but got O
		//IL_0485: Expected O, but got I
		//IL_04c5: Expected O, but got I4
		//IL_04d5: Expected O, but got I
		//IL_04de: Expected O, but got I4
		//IL_04ee: Expected O, but got I
		//IL_04f3: Expected I, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		TransferFeesModel transferFees = _transferFees;
		object obj7;
		decimal d;
		object obj15;
		nint num;
		if (_transferFees != null && (object)amountInput != null)
		{
			object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = amountInput.Text;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				bool flag = StringsExtensions.IsNullOrEmpty(text);
				bool flag2 = !flag;
				num = unchecked((nint)null);
				if (!flag2)
				{
					goto IL_00bc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = StringsExtensions.IsNullOrEmpty(text);
				bool flag4 = !flag3;
				object obj6 = !flag4;
				num = unchecked((nint)null);
				if (obj6 != null)
				{
					goto IL_00bc;
				}
			}
			if ((object)amountInput != null)
			{
				string text2 = amountInput.Text;
				int result;
				bool flag5 = int.TryParse(text2, out result);
				obj7 = typeof(DataRelation) + 1368;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj9 = !flag6;
				int num2 = result;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num2 = result;
				}
				decimal num3 = num2;
				d = num3 * 0m;
				object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
					object obj12 = (nint)0 & (nint)1;
					if (obj12 != null)
					{
						goto IL_03c3;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
					object obj13 = (nint)0 & (nint)1;
					bool flag7 = obj13 == null;
					object obj14 = !flag7;
					if (obj14 != null)
					{
						goto IL_03c3;
					}
				}
				_ = 1;
				obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v20+E4]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				if (obj16 != null)
				{
					goto IL_03f0;
				}
				goto IL_05fc;
			}
		}
		goto IL_060b;
		IL_03f0:
		decimal num4 = decimal.Ceiling(d);
		int num5 = (int)num4;
		TextMeshProUGUI textMeshProUGUI = transactionFee;
		int num6 = default(int);
		string text3 = num6.ToString();
		bool flag9 = (object)transactionFee == null;
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
		decimal num7 = 0m;
		object obj18 = 0;
		num = unchecked((nint)null);
		TextMeshProUGUI textMeshProUGUI2;
		string text4;
		object obj19;
		decimal num10;
		if (!flag9)
		{
			nint num8 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v25 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			obj18 = 0;
			transactionFee.text = text3;
			textMeshProUGUI2 = transactionTotal;
			int num9 = default(int);
			text4 = num9.ToString();
			bool flag10 = (object)transactionTotal == null;
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
			num10 = 0m;
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
			num7 = 0m;
			num = unchecked((nint)null);
			if (!flag10)
			{
				goto IL_0501;
			}
		}
		goto IL_060b;
		IL_0501:
		nint num11 = (nint)textMeshProUGUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v11 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		obj18 = 0;
		textMeshProUGUI2.text = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
		bool flag11 = obj20 != null;
		obj17 = obj19;
		num7 = num10;
		num = (nint)text4;
		if (!flag11)
		{
			return;
		}
		goto IL_0619;
		IL_03c3:
		obj15 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v20+E4]");
		if ((nint)0 != 0)
		{
			goto IL_03f0;
		}
		goto IL_05fc;
		IL_00bc:
		decimal num12 = 100m;
		object obj21 = typeof(DataRelation) + 1368;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v49+E4]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		decimal <AppliedFees>k__BackingField = transferFees.<AppliedFees>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
		decimal num13 = <AppliedFees>k__BackingField * 0m;
		object obj24 = "Material with texture name \"" + 3224;
		decimal num14 = default(decimal);
		string text5 = num14.ToString((string)obj24);
		bool flag13 = (object)transactionFee == null;
		obj17 = 0;
		num7 = 0m;
		obj18 = 0;
		num = (nint)obj24;
		if (!flag13)
		{
			transactionFee.text = text5;
			textMeshProUGUI2 = transactionTotal;
			decimal num15 = 100m;
			decimal num16 = 100m;
			decimal <AppliedFees>k__BackingField2 = transferFees.<AppliedFees>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
			decimal num17 = <AppliedFees>k__BackingField2 * 0m;
			decimal num18 = num15 + 0m;
			text4 = num14.ToString((string)obj24);
			bool flag14 = (object)transactionTotal == null;
			object obj25 = !flag14;
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
			num10 = 0m;
			if (obj25 != null)
			{
				goto IL_0501;
			}
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Kammelna.Server.WebRequests.TransferFeesModel)+20]");
			num7 = 0m;
			obj18 = 0;
			num = (nint)obj24;
		}
		goto IL_060b;
		IL_0619:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		return;
		IL_05fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_03f0;
		IL_060b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0619;
	}

	private unsafe void SubmitTransaction()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Ref, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0131: Expected O, but got I
		//IL_0142: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text = amountInput.Text;
		bool flag = int.TryParse(text, out *(int*)(obj2 + 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+18]");
		if (ValidateInput(0))
		{
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.SetLoading(loading: true);
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)4040;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj8);
			GiftInfo giftInfo = _giftInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+18]");
			KammelnaRequests.TransferCurrency(giftInfo, 0, action);
		}
	}

	private bool ValidateInput(int value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f3: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0443: Expected O, but got I
		//IL_045d: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_01b7: Expected O, but got I
		//IL_04cc: Expected I4, but got O
		//IL_049b: Expected O, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_041d: Expected O, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		//IL_02a7: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03e4: Expected O, but got I4
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected I8, but got Unknown
		object obj = typeof(DataRelation) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E692B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v42+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v42+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		decimal num = value;
		TransferFeesModel transferFees = _transferFees;
		bool flag2 = _transferFees == null;
		decimal num2 = 0m;
		if (!flag2)
		{
			goto IL_014f;
		}
		goto IL_04be;
		IL_01d4:
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0201;
		}
		goto IL_04a9;
		IL_04a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0201;
		IL_0201:
		decimal d;
		decimal num3 = decimal.Ceiling(d);
		int num4 = (int)num3;
		if (value > 99)
		{
			object obj6 = typeof(Queue<string>) + 848;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				object obj10 = num4 + value;
				User localUser = sessionModel.LocalUser;
				int aces = SFSKammelnaUserExtensions.GetAces(localUser);
				if ((nint)obj10 <= aces)
				{
					return true;
				}
				object obj11 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v26+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					User localUser2 = sessionModel2.LocalUser;
					int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
					object obj13 = typeof(MemberAchievementClanFeedData) + 2608;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v17+E4]");
					bool flag5 = (nint)0 == 0;
					object obj15 = !flag5;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					long remaining = obj10 - aces2;
					NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.CurrencyTransfer);
					return false;
				}
			}
			goto IL_04be;
		}
		object errorMsg = "Picking audio files is not supported on iOS" + 584;
		((CurrencyTransferUi)num4).ShowError((string)errorMsg);
		return false;
		IL_0074:
		num = value;
		transferFees = _transferFees;
		bool flag6 = _transferFees == null;
		object obj16 = !flag6;
		num2 = 0m;
		if (obj16 != null)
		{
			goto IL_014f;
		}
		goto IL_04be;
		IL_014f:
		object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		d = num * num2;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
			object obj19 = (nint)0 & (nint)1;
			if (obj19 != null)
			{
				goto IL_01d4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A7]");
			object obj20 = (nint)0 & (nint)1;
			bool flag7 = obj20 == null;
			object obj21 = !flag7;
			if (obj21 != null)
			{
				goto IL_01d4;
			}
		}
		_ = 1;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v6+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 != null)
		{
			goto IL_0201;
		}
		goto IL_04a9;
		IL_04be:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ShowError(string errorMsg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_0053: Expected I, but got O
		//IL_007d: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1512;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.SetError(errorMsg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	public CurrencyTransferUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TransferFeesModel transferFeesModel = default(TransferFeesModel);
		transferFeesModel..ctor();
		object obj2 = this + 128;
		obj2 = transferFeesModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <RefreshFeesInfo>b__21_0(KammelnaResponseModel<TransferFeesModel> request)
	{
		//IL_0076: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		if (((KammelnaResponseModel<object>)(object)request).Succeeded)
		{
			loadingIndicator.SetActive(value: false);
			object obj = this + 128;
			obj = request.<Model>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			RefreshFeesUi();
			return;
		}
		object obj2 = (nint)0 + (nint)1600;
		string errorMessage = ((KammelnaResponseModel<object>)(object)request).ErrorMessage;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.ShowError(errorMessage);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowError(errorMessage);
	}
}
