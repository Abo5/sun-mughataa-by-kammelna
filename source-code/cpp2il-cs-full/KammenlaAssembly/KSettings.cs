using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Purchasing.Telemetry;

public class KSettings : MonoBehaviour
{
	private sealed class <>c__DisplayClass14_0
	{
		public KSettings <>4__this;

		public RectTransform rect;

		public TweenCallback <>9__1;

		internal void <ScrollAndShake>b__0()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_006b: Expected O, but got I4
			//IL_0094: Expected O, but got I
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0111: Expected O, but got I4
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_0149: Expected O, but got I
			//IL_0157: Expected I, but got O
			KSettings kSettings = <>4__this;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Vector3 localPosition = this.rect.localPosition;
			Rect rect = this.rect.rect;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2488;
			object obj5 = default(object);
			double num = (double)obj5 * 0.5;
			object obj6 = default(object);
			double num2 = (double)obj6 + num;
			float endValue = (float)(0.0 - num2);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(kSettings.scrollTransform, endValue, 0.5f);
			object obj7 = this + 32;
			TweenCallback tweenCallback = (TweenCallback)obj7;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)3192;
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(this, (IntPtr)obj10);
				<>9__1 = tweenCallback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tweenCallback = tweenCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}

		internal void <ScrollAndShake>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0070: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect);
		}
	}

	private RoutingEventsChannel _routingEventsChannel;

	private RectTransform avatarSection;

	private RectTransform cardsSection;

	private RectTransform roomThemeSection;

	private RectTransform gamePlaySettingsSection;

	private RectTransform soundsSettingsSection;

	private RectTransform accountSection;

	private RectTransform gameReplaytSection;

	private RectTransform scrollTransform;

	private AssetReferenceGameObject editProfilePopupRef;

	private AssetReferenceGameObject gameReplayListPopupRef;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)3392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute += (Action<RoutingCommand, string>)(object)action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)3392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
	}

	private void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		AssetReferenceGameObject reference;
		if (command > RoutingCommand.EditRoomThemes)
		{
			switch (command)
			{
			case RoutingCommand.SoundSettings:
				ScrollAndShake(soundsSettingsSection);
				return;
			case RoutingCommand.GameReplay:
				break;
			default:
				return;
			case RoutingCommand.GameplaySettings:
				ScrollAndShake(gamePlaySettingsSection);
				return;
			case RoutingCommand.AccountSettings:
				ScrollAndShake(accountSection);
				return;
			}
			RectTransform rectTransform = gameReplaytSection;
			ScrollAndShake(gameReplaytSection);
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v18+E4]");
			if ((nint)0 != 0)
			{
				PrefabInitializer.InitializePrefab(gameReplayListPopupRef);
				return;
			}
			object obj3 = obj2;
			reference = gameReplayListPopupRef;
		}
		else
		{
			if (command == RoutingCommand.EditCards)
			{
				ScrollAndShake(cardsSection);
				return;
			}
			if (command != RoutingCommand.EditAvatar)
			{
				if (command == RoutingCommand.EditRoomThemes)
				{
					ScrollAndShake(roomThemeSection);
				}
				return;
			}
			reference = editProfilePopupRef;
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_021a;
			}
			RectTransform rectTransform = (RectTransform)command;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_021a;
		IL_021a:
		PrefabInitializer.InitializePrefab(reference);
	}

	private void ScrollAndShake(RectTransform rect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		//IL_00d9: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3184;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action);
	}

	private float GetScrollOffset(RectTransform rect)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Vector3 localPosition = rect.localPosition;
		Rect rect2 = rect.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default(object);
		double num = (double)obj4 * 0.5;
		object obj5 = default(object);
		double num2 = (double)obj5 + num;
		return (float)(0.0 - num2);
	}
}
