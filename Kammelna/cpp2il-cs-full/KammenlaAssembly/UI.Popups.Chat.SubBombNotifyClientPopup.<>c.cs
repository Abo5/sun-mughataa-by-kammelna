using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace UI.Popups.Chat;

public class SubBombNotifyClientPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static UnityAction <>9__27_0;

		public static UnityAction <>9__27_1;

		public static UnityAction <>9__27_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ActivateSendThanksArea>b__27_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00af: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E6F]");
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
			SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Thanks1);
			return;
			IL_0074:
			SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Thanks1);
		}

		internal void <ActivateSendThanksArea>b__27_1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00af: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E70]");
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
			SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Thanks2);
			return;
			IL_0074:
			SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Thanks2);
		}

		internal void <ActivateSendThanksArea>b__27_2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00af: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E71]");
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
			SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Thanks3);
			return;
			IL_0074:
			SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Thanks3);
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public BombClaimedFeedData giftBomb;

		internal void <InitializePopup>b__0(SubBombNotifyClientPopup instance)
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
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1848;
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
			object obj8 = (nint)0 + (nint)2208;
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v5+28]");
			GameObject gameObject = ((Component)0).gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj8);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupStack.Push(gameObject, action);
		}
	}

	private sealed class <>c__DisplayClass15_1
	{
		public SubBombNotifyClientPopup instance;

		public <>c__DisplayClass15_0 CS$<>8__locals1;

		internal void <InitializePopup>b__1()
		{
			<>c__DisplayClass15_0 cS$<>8__locals = CS$<>8__locals1;
			instance.Setup(cS$<>8__locals.giftBomb);
		}
	}

	private static readonly AddressReference<SubBombNotifyClientPopup> Address;

	private PopupUI popup;

	private TextMeshProUGUI sentMessage;

	private TextMeshProUGUI giftMessage;

	private AvatarInitializer userAvatar;

	private Button like;

	private Button dismiss;

	private GameObject messageArea;

	private RectTransform sendThanksArea;

	private Button thanksButton1;

	private Button thanksButton2;

	private Button thanksButton3;

	private BombClaimedFeedData _giftBombData;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = like;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = dismiss;
		object obj3 = (nint)0 + (nint)2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = like;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = dismiss;
		object obj3 = (nint)0 + (nint)2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.RemoveListener(unityAction2);
	}

	public static void InitializePopup(BombClaimedFeedData giftBomb)
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
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2976;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3592;
		object obj5 = (nint)0 + (nint)2200;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = giftBomb;
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
		object obj10 = (nint)0 + (nint)2368;
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

	private void Setup(BombClaimedFeedData giftBomb)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		object obj = this + 120;
		obj = giftBomb;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ResetComponents();
		object obj2 = obj;
		long num = default(long);
		string userId = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v1+3C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v1+40]");
		Populate((int)num2, (string)0, userId);
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.PopFromCenter();
		ITrackEvent trackEvent = TrackerLibrary.ChatSubBombClaimViewed();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		SlowRevealDismissButton();
	}

	private void ResetComponents()
	{
		like.interactable = true;
		GameObject gameObject = dismiss.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = sendThanksArea.gameObject;
		gameObject2.SetActive(value: false);
	}

	public void Populate(int subDays, string bombMessage, string userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0068: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		object message = "HH:mm:ss.ffZ" + 864;
		int days = default(int);
		PopulateGiftInfo(days, (string)message);
		object text = "Cannot populate JSON object onto type '{0}'." + 2824;
		userAvatar.InitializeFriendWithDbId(userId);
		object obj = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text);
		object obj2 = 152989696;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ECE]");
		object obj4 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject gameObject2;
		if (obj4 != null)
		{
			gameObject = messageArea;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			gameObject2 = messageArea;
			if (!flag)
			{
				goto IL_00f0;
			}
		}
		else
		{
			_ = 1;
			gameObject = messageArea;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			gameObject2 = messageArea;
			if (obj6 != null)
			{
				goto IL_00f0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(bombMessage);
		bool flag4 = (object)gameObject2 == null;
		object obj7 = !flag4;
		gameObject = gameObject2;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0102;
		IL_00f0:
		flag3 = StringsExtensions.IsNullOrEmpty(bombMessage);
		goto IL_0102;
		IL_0102:
		bool active = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		TextMeshProExtensions.FixArabic(giftMessage, bombMessage);
	}

	private void PopulateGiftInfo(int days, string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_0035: Expected I8, but got I4
		//IL_0144: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		//IL_0093: Expected I, but got O
		//IL_00a3: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "DNQUALIFIER" + 1456;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize((string)input, days);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj5;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj6;
		if (array != null)
		{
			bool flag2 = text == null;
			obj5 = 1;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag3)
				{
					goto IL_015f;
				}
			}
			if (array.Length != 0)
			{
				object obj7 = array + 32;
				obj7 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(sentMessage, message, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj5 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj6 = obj5;
		goto IL_015f;
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void PopulateUserInfo(string dbId)
	{
		userAvatar.InitializeFriendWithDbId(dbId);
	}

	private void PopulateLikeButton(string likeButtonText)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, likeButtonText);
	}

	private void AddCustomMessage(string bombMessage)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ECE]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject gameObject2;
		if (obj3 != null)
		{
			gameObject = messageArea;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			gameObject2 = messageArea;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			gameObject = messageArea;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			gameObject2 = messageArea;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(bombMessage);
		bool flag4 = (object)gameObject2 == null;
		object obj6 = !flag4;
		gameObject = gameObject2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a3;
		IL_0091:
		flag3 = StringsExtensions.IsNullOrEmpty(bombMessage);
		goto IL_00a3;
		IL_00a3:
		bool active = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		TextMeshProExtensions.FixArabic(giftMessage, bombMessage);
	}

	private void Show()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.PopFromCenter();
		ITrackEvent trackEvent = TrackerLibrary.ChatSubBombClaimViewed();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void Like()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00ac: Expected I, but got O
		object text = "HH:mm:ss.ffZ" + 880;
		like.interactable = false;
		object obj = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text);
		BombClaimedFeedData giftBombData = _giftBombData;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj3 = (nint)0 + (nint)1864;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj3);
		KammelnaRequests.LikeUser(giftBombData.<SenderId>k__BackingField, action);
		ActivateSendThanksArea();
		ITrackEvent trackEvent = TrackerLibrary.ChatSubBombClaimClickedLike();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void Dismiss()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_019e: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E69]");
		object obj3 = (nint)0 & (nint)1;
		object obj7;
		object obj6;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
			obj7 = 0;
			object obj8 = obj4;
			if (!flag)
			{
				goto IL_00b1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
			obj7 = 0;
			object obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00b1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		bool flag3 = (object)screenManager == null;
		object obj10 = !flag3;
		obj6 = obj7;
		if (obj10 != null)
		{
			goto IL_00d8;
		}
		goto IL_01fd;
		IL_020b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException trackEvent;
		Tracker.DesignEvent((ITrackEvent)trackEvent);
		return;
		IL_00d8:
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		screenManager.Back();
		ITrackEvent trackEvent2 = TrackerLibrary.ChatSubBombClaimDismissed();
		obj6 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		trackEvent = (NullReferenceException)trackEvent2;
		if (!flag4)
		{
			Tracker.DesignEvent(trackEvent2);
			return;
		}
		goto IL_020b;
		IL_01fd:
		trackEvent = new NullReferenceException();
		goto IL_020b;
		IL_00b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)screenManager != null)
		{
			goto IL_00d8;
		}
		goto IL_01fd;
	}

	private void SlowRevealDismissButton()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		Image image = dismiss.image;
		UIExtensions.SetAlpha(image, 0f);
		GameObject gameObject = dismiss.gameObject;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		gameObject.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence s = DOTween.Sequence();
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.AppendInterval(s, 5f);
		object obj4 = (nint)0 + (nint)2408;
		Image image2 = dismiss.image;
		TweenerCore<Color, Color, ColorOptions> t = DOTweenModuleUI.DOFade(image2, 1f, 3f);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void ActivateSendThanksArea()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ef: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0564: Expected O, but got I
		//IL_0575: Expected I, but got O
		//IL_0593: Expected O, but got I
		//IL_0273: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_02d5: Expected O, but got I4
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05d4: Expected O, but got I
		//IL_05e5: Expected I, but got O
		//IL_0603: Expected O, but got I
		//IL_0407: Expected O, but got I
		//IL_0417: Expected O, but got I
		//IL_0439: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_0305: Expected O, but got I
		//IL_03d2: Expected O, but got I4
		//IL_037e: Expected O, but got I
		//IL_038e: Expected O, but got I
		//IL_0469: Expected O, but got I4
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_0644: Expected O, but got I
		//IL_0655: Expected I, but got O
		//IL_0673: Expected O, but got I
		//IL_04a7: Expected O, but got I4
		//IL_0499: Expected O, but got I
		//IL_051a: Expected O, but got I4
		Button button = thanksButton1;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1832;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v41+E4]");
		object obj3;
		UnityAction call;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v41+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v41+8]");
			call = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v41+8]");
			if ((nint)0 != 0)
			{
				goto IL_008b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v41+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v41+8]");
			call = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v41+8]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_008b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v41+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v47+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2176;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v46+B8]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = 0;
		call = unityAction;
		goto IL_018c;
		IL_021f:
		Button button2;
		bool flag3 = button2.m_OnClick == null;
		object obj12 = !flag3;
		if (obj12 != null)
		{
			goto IL_0320;
		}
		goto IL_0524;
		IL_0320:
		UnityAction call2;
		button2.m_OnClick.AddListener(call2);
		Button button3 = thanksButton3;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v19+E4]");
		object obj14;
		UnityAction call3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v19+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v17+18]");
			call3 = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v17+18]");
			if ((nint)0 != 0)
			{
				goto IL_03b3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v19+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v17+18]");
			call3 = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v17+18]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 != null)
			{
				goto IL_03b3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v23+B8]");
			obj14 = 0;
		}
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)2192;
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(obj14, (IntPtr)obj19);
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v22+B8]");
		object obj21 = (nint)0 + (nint)24;
		obj21 = unityAction2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = 0;
		call3 = unityAction2;
		goto IL_04b4;
		IL_03b3:
		bool flag6 = button3.m_OnClick == null;
		object obj22 = !flag6;
		if (obj22 != null)
		{
			goto IL_04b4;
		}
		goto IL_0524;
		IL_04b4:
		button3.m_OnClick.AddListener(call3);
		GameObject gameObject = sendThanksArea.gameObject;
		gameObject.SetActive(value: true);
		Vector2 sizeDelta = sendThanksArea.sizeDelta;
		float duration = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(sendThanksArea, (Vector2)0, duration);
		return;
		IL_0524:
		throw new NullReferenceException();
		IL_008b:
		bool flag7 = button.m_OnClick == null;
		object obj23 = !flag7;
		if (obj23 != null)
		{
			goto IL_018c;
		}
		goto IL_0524;
		IL_018c:
		button.m_OnClick.AddListener(call);
		button2 = thanksButton2;
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v30+E4]");
		object obj25;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v30+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v29+10]");
			call2 = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v29+10]");
			if ((nint)0 != 0)
			{
				goto IL_021f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v30+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v29+10]");
			call2 = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v29+10]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 != null)
			{
				goto IL_021f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v30+E4]");
		bool flag9 = (nint)0 == 0;
		object obj27 = !flag9;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v35+B8]");
			obj25 = 0;
		}
		object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)2184;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(obj25, (IntPtr)obj30);
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v34+B8]");
		object obj32 = (nint)0 + (nint)16;
		obj32 = unityAction3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = 0;
		call2 = unityAction3;
		goto IL_0320;
	}

	private static void SendSfsChatPinnedAvatarParticle(ChatPinnedAvatarParticle particle)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0068: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		SFS.SendChatPinnedAvatarParticle(particle);
		ITrackEvent trackEvent = TrackerLibrary.ChatSubBombClaimSentParticle(particle);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			if (!flag)
			{
				goto IL_0058;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0058;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0058;
		IL_0058:
		RoutingManager.Route(RoutingCommand.Chat, null, (Games?)(object)0);
	}

	static SubBombNotifyClientPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "SetRoomVariables request error" + 3952;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3192;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
