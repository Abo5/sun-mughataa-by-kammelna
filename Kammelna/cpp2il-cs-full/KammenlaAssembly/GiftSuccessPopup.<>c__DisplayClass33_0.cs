using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using GoogleMobileAds.Ump.Api;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models.Products;
using TMPro;
using UI.Popups;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GiftSuccessPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass32_0
	{
		public GiftNotificationData gift;

		public string recipientId;

		internal void <PopupSent>b__0(GiftSuccessPopup instance)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object message = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2632;
			instance.Show(gift, recipientId, (string)message, showActions: false);
		}
	}

	private sealed class <>c__DisplayClass33_0
	{
		public GiftNotificationData gift;

		internal void <PopupReceived>b__0(GiftSuccessPopup instance)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0078: Expected O, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_009d: Expected O, but got I
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00c2: Expected O, but got I
			//IL_00e6: Expected I, but got O
			//IL_0110: Expected O, but got I4
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 16;
			obj4 = instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4+20]");
			object obj6 = 0;
			object obj7 = typeof(SqlSingle[]) + 2376;
			object obj8 = (nint)0 + (nint)2216;
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v5+28]");
			GameObject gameObject = ((UnityEngine.Component)0).gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj8);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupStack.Push(gameObject, action);
		}
	}

	private sealed class <>c__DisplayClass33_1
	{
		public GiftSuccessPopup instance;

		public <>c__DisplayClass33_0 CS$<>8__locals1;

		internal void <PopupReceived>b__1()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			<>c__DisplayClass33_0 cS$<>8__locals = CS$<>8__locals1;
			GiftNotificationData gift = cS$<>8__locals.gift;
			object message = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3088;
			instance.Show(cS$<>8__locals.gift, gift.<SenderId>k__BackingField, (string)message, showActions: true);
		}
	}

	private static readonly AddressReference<GiftSuccessPopup> Address;

	private PopupUI popup;

	private Image itemImage;

	private TextMeshProUGUI sentMessage;

	private TextMeshProUGUI giftMessage;

	private GameObject giftMessageContainer;

	private AvatarInitializer userAvatar;

	private GameObject buttonsContainer;

	private Button addFriendButton;

	private Button likeButton;

	private Button giftButton;

	private Sprite subscriptionIcon;

	private Sprite coinsIcon;

	private Image giftBottom;

	private Image giftTop;

	private Image giftInside;

	private Image glow;

	private Image shine;

	private Image itemImage2;

	private Image displayitem;

	private ParticleSystem glowParticle;

	private long _recipientId;

	private Sequence _sequence;

	private Vector3 giftbottominitialPos;

	private Vector3 gifttopinitialPos;

	private Vector3 giftinsideinitialPos;

	private Vector3 glowinitialPos;

	private Vector3 shineinitialPos;

	private Vector3 glowinitialscale;

	private Vector3 shineinitialscale;

	private Quaternion giftTopinitialRot;

	private float giftbottominitialAlpha;

	public static void PopupSent(GiftNotificationData gift, string recipientId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_0188: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2904;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2144;
		object obj5 = (nint)0 + (nint)2200;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = gift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = recipientId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		object obj11 = (nint)0 + (nint)2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	public static void PopupReceived(GiftNotificationData gift)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2904;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2144;
		object obj5 = (nint)0 + (nint)2208;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = gift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		Button button = addFriendButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = likeButton;
		object obj3 = (nint)0 + (nint)3248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = giftButton;
		object obj4 = (nint)0 + (nint)3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		button3.m_OnClick.AddListener(unityAction3);
		RectTransform rectTransform = giftBottom.rectTransform;
		Vector3 localPosition = rectTransform.localPosition;
		Vector3 vector = default(Vector3);
		giftbottominitialPos = vector;
		RectTransform rectTransform2 = giftTop.rectTransform;
		Vector3 localPosition2 = rectTransform2.localPosition;
		gifttopinitialPos = vector;
		RectTransform rectTransform3 = giftInside.rectTransform;
		Vector3 localPosition3 = rectTransform3.localPosition;
		giftinsideinitialPos = vector;
		RectTransform rectTransform4 = giftTop.rectTransform;
		Quaternion rotation = rectTransform4.rotation;
		giftTopinitialRot = (Quaternion)vector;
		Color color = giftBottom.color;
		float num = default(float);
		giftbottominitialAlpha = num;
		RectTransform rectTransform5 = glow.rectTransform;
		Vector3 localScale = rectTransform5.localScale;
		glowinitialscale = vector;
		RectTransform rectTransform6 = shine.rectTransform;
		Vector3 localScale2 = rectTransform6.localScale;
		shineinitialscale = vector;
		RectTransform rectTransform7 = glow.rectTransform;
		Vector3 localPosition4 = rectTransform7.localPosition;
		glowinitialPos = vector;
		RectTransform rectTransform8 = shine.rectTransform;
		Vector3 localPosition5 = rectTransform8.localPosition;
		shineinitialPos = vector;
	}

	private unsafe void Show(GiftNotificationData gift, string recipientId, string message, bool showActions)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I8, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0122: Expected I, but got O
		//IL_014c: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long value = Convert.ToInt64(recipientId);
		long num = this + 192;
		((long*)num)->m_value = value;
		PopulateGiftInfo(gift, message);
		string dbId = ((long*)num)->ToString();
		userAvatar.InitializeFriendWithDbId(dbId);
		AddCustomMessage(gift);
		PopulateAction(showActions);
		AnimateGiftReceived();
		popup.SlideFromBottom();
		PopupUI popupUI = popup;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)3232;
		object obj6 = typeof(RegisteredWaitHandle) + 3136;
		GameObject gameObject = popupUI.content.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(gameObject, action);
	}

	private void PopulateGiftInfo(GiftNotificationData gift, string message)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0071: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_03e3: Expected O, but got I
		//IL_0409: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_01af: Expected O, but got I4
		//IL_042e: Expected O, but got I
		//IL_0454: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_04b1: Expected O, but got I4
		//IL_04be: Expected I8, but got I4
		//IL_0504: Expected O, but got I4
		//IL_0289: Expected I8, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_0479: Expected O, but got I
		//IL_01e2: Expected O, but got I4
		//IL_02bc: Expected I, but got O
		//IL_02cc: Expected O, but got I
		//IL_02fa: Expected O, but got I
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		bool flag = gift == null;
		string text = message;
		GiftNotificationData giftNotificationData = gift;
		if (!flag)
		{
			if (gift.<ProductDbId>k__BackingField >= 1)
			{
				object obj = typeof(Queue<string>) + 752;
				object obj2 = (nint)0 + (nint)2024;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				IAPController iAPController = default(IAPController);
				bool flag3 = (object)iAPController == null;
				text = message;
				giftNotificationData = gift;
				if (!flag3)
				{
					ProductViewModel product = iAPController.GetProduct(gift.<ProductDbId>k__BackingField);
					UIExtensions.LoadProductImage(itemImage, product);
					bool flag4 = false;
					goto IL_01f5;
				}
			}
			else
			{
				bool flag5 = (object)itemImage == null;
				text = message;
				giftNotificationData = gift;
				if (!flag5)
				{
					if (gift.<ItemType>k__BackingField == GiftsHandler.GiftType.Coins)
					{
						object obj5 = 120;
					}
					else
					{
						object obj5 = 112;
					}
					Image image = itemImage;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftSuccessPopup)+v151 @ X8_v19]");
					image.sprite = (Sprite)0;
					bool flag6 = (object)itemImage2 == null;
					text = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftSuccessPopup)+v151 @ X8_v19]");
					giftNotificationData = (GiftNotificationData)0;
					if (!flag6)
					{
						if (gift.<ItemType>k__BackingField == GiftsHandler.GiftType.Coins)
						{
							object obj6 = 120;
						}
						else
						{
							object obj6 = 112;
						}
						Image image2 = itemImage2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftSuccessPopup)+v152 @ X8_v22]");
						image2.sprite = (Sprite)0;
						bool flag7 = (object)displayitem == null;
						text = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftSuccessPopup)+v152 @ X8_v22]");
						giftNotificationData = (GiftNotificationData)0;
						if (!flag7)
						{
							if (gift.<ItemType>k__BackingField == GiftsHandler.GiftType.Coins)
							{
								object obj7 = 120;
							}
							else
							{
								object obj7 = 112;
							}
							Image image3 = displayitem;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftSuccessPopup)+v326 @ X8_v25]");
							image3.sprite = (Sprite)0;
							bool flag4 = false;
							goto IL_01f5;
						}
					}
				}
			}
		}
		goto IL_036d;
		IL_037b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0389;
		IL_0389:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_01f5:
		object input = "AvailableVoices" + 3920;
		object obj8 = "SERVICE_DISABLED" + 1344;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
		if (gift.<ItemType>k__BackingField != GiftsHandler.GiftType.Coins)
		{
			input = obj8;
		}
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v11+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		long quantity = gift.<Amount>k__BackingField;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			quantity = gift.<Amount>k__BackingField;
		}
		string text2 = LocalizationUtil.Localize((string)input, quantity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag9 = array == null;
		text = null;
		giftNotificationData = (GiftNotificationData)1;
		if (flag9)
		{
			goto IL_036d;
		}
		bool flag10 = text2 == null;
		GiftNotificationData giftNotificationData2 = (GiftNotificationData)1;
		if (!flag10)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
			giftNotificationData2 = (GiftNotificationData)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag11 = ex == null;
			text = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
			giftNotificationData = (GiftNotificationData)0;
			if (flag11)
			{
				goto IL_0389;
			}
		}
		bool flag12 = array.Length == 0;
		text = null;
		giftNotificationData = giftNotificationData2;
		if (!flag12)
		{
			object obj13 = array + 32;
			obj13 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(sentMessage, message, array);
			return;
		}
		goto IL_037b;
		IL_036d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_037b;
	}

	private unsafe void PopulateUserInfo()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I8, but got Unknown
		long num = this + 192;
		string dbId = ((long*)num)->ToString();
		userAvatar.InitializeFriendWithDbId(dbId);
	}

	private void AddCustomMessage(GiftNotificationData data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = StringsExtensions.IsNullOrEmpty(data.<Message>k__BackingField);
		bool active = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		giftMessageContainer.SetActive(active);
		TextMeshProExtensions.FixArabic(giftMessage, data.<Message>k__BackingField);
	}

	private unsafe void PopulateAction(bool showActions)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I8, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_012d: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected I4, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I
		//IL_01f5: Expected I, but got O
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0238: Expected O, but got I4
		GameObject gameObject = buttonsContainer.gameObject;
		gameObject.SetActive(showActions);
		if (showActions)
		{
			long num = this + 192;
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = FriendsManager.IsFriend(((long*)num)->m_value);
			bool flag3 = FriendsManager.IsBlocked(_recipientId);
			bool flag4 = FriendsManager.IsRequestedFriendship(_recipientId);
			object obj4 = (nint)0 + (nint)288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
			object text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1408;
			object obj5 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3968;
			bool flag5 = !flag2;
			object obj6 = !flag5;
			object obj7 = ~obj6;
			if (obj7 != null)
			{
				text = obj5;
			}
			TextMeshProUGUI textMesh = default(TextMeshProUGUI);
			TextMeshProExtensions.Localize(textMesh, (string)text);
			object obj8 = flag2 || flag3;
			object obj9 = obj8 | flag4;
			object obj10 = ~obj9;
			bool interactable = (byte)(1 & obj10) != 0;
			addFriendButton.interactable = interactable;
			likeButton.interactable = false;
			string userId = ((long*)num)->ToString();
			object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3216;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj12);
			object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestUserProfile(userId, action);
		}
	}

	private void AnimateGiftReceived()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0665: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_067f: Expected O, but got I
		//IL_068b: Expected O, but got I
		//IL_0697: Expected O, but got I
		//IL_06be: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_00ec: Expected I, but got O
		//IL_0217: Expected O, but got I4
		//IL_0386: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_02bb: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_06e8: Expected O, but got I4
		//IL_0503: Expected O, but got I4
		//IL_05c2: Expected O, but got I4
		//IL_0557: Expected O, but got I4
		//IL_0611: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		object obj4 = this + 200;
		obj4 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X20_v3-98]");
		object obj5 = 0;
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ X8_v5+548] (should have been resolved before IL gen)");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2904;
		object obj11 = (nint)0 + (nint)2912;
		object obj12 = (nint)0 + (nint)2848;
		string value = default(string);
		bool flag3 = StringsExtensions.IsNullOrEmpty(value);
		bool flag4 = !flag3;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_014c;
		}
		TextMeshProUGUI textMeshProUGUI = giftMessage;
		nint num = (nint)textMeshProUGUI;
		string text = textMeshProUGUI.text;
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v24+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				goto IL_014c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringsExtensions.IsNullOrEmpty(text);
			bool flag6 = !flag5;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_014c;
			}
		}
		TweenerCore<Color, Color, ColorOptions> t = DOTweenModuleUI.DOFade(giftBottom, 1f, 1f);
		Sequence s = TweenSettingsExtensions.Join(_sequence, t);
		Transform target = giftBottom.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOMove(target, (Vector3)0, -20f);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Sequence s3 = default(Sequence);
		Sequence s2 = TweenSettingsExtensions.PrependInterval(s3, 1.2f);
		Transform target2 = giftTop.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMove(target2, (Vector3)0, -75f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t3 = default(Tween);
		Sequence s4 = TweenSettingsExtensions.Append(s2, t3);
		RectTransform rectTransform = giftTop.rectTransform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DORotate(rectTransform, (Vector3)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t4 = default(Tween);
		Sequence s5 = TweenSettingsExtensions.Join(s4, t4);
		Transform target3 = giftInside.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOMove(target3, (Vector3)0, 30f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t5 = default(Tween);
		Sequence s6 = TweenSettingsExtensions.Join(s5, t5);
		Transform target4 = glow.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOMove(target4, (Vector3)0, -10f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t6 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(s6, t6);
		Transform target5 = shine.transform;
		Sequence s7 = sequence3;
		goto IL_06cc;
		IL_014c:
		TweenerCore<Color, Color, ColorOptions> t7 = DOTweenModuleUI.DOFade(giftBottom, 1f, 1.5f);
		Sequence s8 = TweenSettingsExtensions.Join(_sequence, t7);
		Transform target6 = giftBottom.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> t8 = ShortcutExtensions.DOMove(target6, (Vector3)0, -20f);
		Sequence sequence4 = TweenSettingsExtensions.Join(s8, t8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Sequence s10 = default(Sequence);
		Sequence s9 = TweenSettingsExtensions.PrependInterval(s10, 0.7f);
		Transform target7 = giftTop.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore5 = ShortcutExtensions.DOMove(target7, (Vector3)0, -75f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t9 = default(Tween);
		Sequence s11 = TweenSettingsExtensions.Append(s9, t9);
		RectTransform rectTransform2 = giftTop.rectTransform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore6 = ShortcutExtensions.DORotate(rectTransform2, (Vector3)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t10 = default(Tween);
		Sequence s12 = TweenSettingsExtensions.Join(s11, t10);
		Transform target8 = giftInside.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore7 = ShortcutExtensions.DOMove(target8, (Vector3)0, 30f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t11 = default(Tween);
		Sequence s13 = TweenSettingsExtensions.Join(s12, t11);
		Transform target9 = glow.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore8 = ShortcutExtensions.DOMove(target9, (Vector3)0, -10f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t12 = default(Tween);
		Sequence sequence5 = TweenSettingsExtensions.Join(s13, t12);
		target5 = shine.transform;
		s7 = sequence5;
		goto IL_06cc;
		IL_06cc:
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore9 = ShortcutExtensions.DOMove(target5, (Vector3)0, -10f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t13 = default(Tween);
		Sequence s14 = TweenSettingsExtensions.Join(s7, t13);
		RectTransform rectTransform3 = glow.rectTransform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore10 = ShortcutExtensions.DOScale(rectTransform3, (Vector3)0, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t14 = default(Tween);
		Sequence s15 = TweenSettingsExtensions.Join(s14, t14);
		RectTransform rectTransform4 = shine.rectTransform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore11 = ShortcutExtensions.DOScale(rectTransform4, (Vector3)0, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t15 = default(Tween);
		Sequence sequence6 = TweenSettingsExtensions.Join(s15, t15);
	}

	private void AddFriend()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0066: Expected I, but got O
		//IL_0090: Expected O, but got I4
		//IL_00bc: Expected I4, but got I8
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)3208;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		addFriendButton.interactable = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.AddFriend((int)_recipientId, action);
	}

	private void Like()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0052: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1864;
		likeButton.interactable = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		KammelnaRequests.LikeUser(_recipientId, action);
	}

	private unsafe void Gift()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I8, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I8, but got Unknown
		//IL_0088: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6940]");
		object obj2 = (nint)0 & (nint)1;
		string text;
		string dbId;
		if (obj2 != null)
		{
			long num = this + 192;
			text = ((long*)num)->ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			dbId = text;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			long num2 = this + 192;
			text = ((long*)num2)->ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			dbId = text;
			if (obj5 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.ShowFor(dbId);
		return;
		IL_009e:
		BuyForFriendPopup.ShowFor(text);
	}

	public void Close()
	{
		//IL_0042: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_01d1: Expected I, but got O
		popup.SlideToTop();
		TweenExtensions.Kill(_sequence, complete: true);
		RectTransform rectTransform = giftBottom.rectTransform;
		rectTransform.localPosition = (Vector3)0;
		RectTransform rectTransform2 = giftTop.rectTransform;
		rectTransform2.localPosition = (Vector3)0;
		RectTransform rectTransform3 = giftInside.rectTransform;
		rectTransform3.localPosition = (Vector3)0;
		RectTransform rectTransform4 = giftTop.rectTransform;
		rectTransform4.rotation = (Quaternion)0;
		RectTransform rectTransform5 = glow.rectTransform;
		rectTransform5.localScale = (Vector3)0;
		RectTransform rectTransform6 = shine.rectTransform;
		rectTransform6.localScale = (Vector3)0;
		RectTransform rectTransform7 = glow.rectTransform;
		rectTransform7.localPosition = (Vector3)0;
		RectTransform rectTransform8 = shine.rectTransform;
		rectTransform8.localPosition = (Vector3)0;
		glowParticle.Stop();
		glowParticle.Clear();
		glowParticle.Play();
		Image image = giftBottom;
		Color color = giftBottom.color;
		Color color2 = giftBottom.color;
		Color color3 = giftBottom.color;
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v156 @ X8_v5 (Il2CppClass<UnityEngine.UI.Image>)+2A8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	static GiftSuccessPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3080;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3048;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <PopulateAction>b__39_0(PlayerProfileModel profile)
	{
		//IL_0011: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object text = "LAK" + 1648;
		object obj2 = "LAK" + 1640;
		bool flag = !profile.<isLiked>k__BackingField;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			text = obj2;
		}
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text);
		object obj5 = ~(profile.<isLiked>k__BackingField ? 1 : 0);
		bool interactable = (byte)(1 & obj5) != 0;
		likeButton.interactable = interactable;
	}

	private void <AddFriend>b__41_0(KammelnaResponseModel<bool> response)
	{
		//IL_0050: Expected O, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected I4, but got Unknown
		//IL_0042: Expected O, but got I
		object obj;
		if (response.Succeeded)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
			obj = (nint)0 ^ (nint)1;
		}
		else
		{
			obj = 1;
		}
		bool interactable = (byte)(obj & 1) != 0;
		addFriendButton.interactable = interactable;
	}
}
