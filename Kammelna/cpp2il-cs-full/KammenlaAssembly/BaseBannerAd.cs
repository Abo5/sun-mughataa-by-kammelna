using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public abstract class BaseBannerAd : MonoBehaviour
{
	private const string SubscriptionAdvertisementMessage = "Enjoy an ad free experience when subscribing";

	protected Image bannerAdPlaceholder;

	protected AdsController adsController;

	private List<Sprite> ads;

	private KGame _game;

	private void Start()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01de: Expected O, but got I
		//IL_01ec: Expected I, but got O
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022f: Expected O, but got I
		//IL_023d: Expected I, but got O
		//IL_026b: Expected I, but got O
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02c4: Expected O, but got I4
		GameObject gameObject = bannerAdPlaceholder.gameObject;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(Queue<string>) + 848;
		gameObject.SetActive(value: false);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 56;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag3 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
		bool flag4 = !flag3;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			return;
		}
		Room room = ((KGame)obj7).Room;
		if (SFSKammelnaRoomExtensions.IsOffline(room))
		{
			object obj12 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2664;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj13);
			adsController.OnAdStart += action;
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)2656;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj15);
			adsController.OnAdFailedToLoad3Times += action2;
			ShowRandomLocalOfflineAd();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v12 (Il2CppClass<BaseBannerAd>)+180]");
			Action action3 = default(Action);
			action3..ctor(this, (IntPtr)0);
			object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v31+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(5f, action3);
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)2656;
		adsController.OnAdStart -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		adsController.OnAdFailedToLoad3Times -= action2;
	}

	protected virtual void ShowBannerAd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0032: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<BaseBannerAd>)+190]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy.WaitForEndOfFrame(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForEndOfFrame(action);
	}

	protected abstract void SendShowBannerRequest();

	private void OnAdStarted()
	{
		//IL_003b: Expected I, but got O
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0086: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		GameObject gameObject = bannerAdPlaceholder.gameObject;
		gameObject.SetActive(value: false);
		float bannerHeight = adsController.GetBannerHeight();
		nint num = (nint)this;
		PrepareAd(bannerHeight, isLocalAd: false);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "Drop Menu Toggle" + 3064;
		nint num2 = (nint)this;
		Vector2 toastPlacement = GetToastPlacement();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, bannerHeight);
	}

	protected abstract void PrepareAd(float adHeight, bool isLocalAd);

	private void ShowRandomLocalOfflineAd()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_0103: Expected I, but got O
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		object obj4 = default(object);
		while (true)
		{
			object sprite = ArraysExtensions.Random((IList<object>)ads);
			bannerAdPlaceholder.sprite = (Sprite)sprite;
			bannerAdPlaceholder.preserveAspect = true;
			UIExtensions.SetAlpha(bannerAdPlaceholder, 1f);
			GameObject gameObject = bannerAdPlaceholder.gameObject;
			gameObject.SetActive(value: true);
			RectTransform rectTransform = bannerAdPlaceholder.rectTransform;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Rect rect = rectTransform.rect;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float scaleFactor = ScreenUtility.ScaleFactor;
			float num = (float)obj4 / scaleFactor;
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4 (Il2CppClass<BaseBannerAd>)+198]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4 (Il2CppClass<BaseBannerAd>)+1A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void HideRandomLocalOfflineAd()
	{
		GameObject gameObject = bannerAdPlaceholder.gameObject;
		gameObject.SetActive(value: false);
	}

	private void OnAdFailedToLoad3Times(string _)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0076: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		ShowRandomLocalOfflineAd();
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "Drop Menu Toggle" + 3064;
		nint num = (nint)this;
		Vector2 toastPlacement = GetToastPlacement();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float duration = default(float);
		Toast.Show((string)message, (Vector2)0, duration);
	}

	private void ShowSubscriptionAdvertisement()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003c: Expected I, but got O
		//IL_0070: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "Drop Menu Toggle" + 3064;
		nint num = (nint)this;
		Vector2 toastPlacement = GetToastPlacement();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float duration = default(float);
		Toast.Show((string)message, (Vector2)0, duration);
	}

	protected virtual Vector2 GetToastPlacement()
	{
		//IL_0009: Expected O, but got I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		Vector2 vector = (Vector2)ScreenUtility.IsTablet;
		object obj = vector & 1;
		if (obj != null)
		{
			return vector;
		}
		float canvasHeight = ScreenUtility.CanvasHeight;
		float topCutoutSize = ScreenUtility.TopCutoutSize;
		return (Vector2)0;
	}
}
