using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace UI.Popups.Chat;

public class SubBombPinnedAvatar : MonoBehaviour
{
	private sealed class <>c__DisplayClass13_0
	{
		public SubBombPinnedAvatar <>4__this;

		public DG.Tweening.Sequence seq;

		internal void <AnimateRemoveLikeButton>g__FinalizeAnimation|0()
		{
			SubBombPinnedAvatar subBombPinnedAvatar = <>4__this;
			GameObject gameObject = subBombPinnedAvatar.like.gameObject;
			gameObject.SetActive(value: false);
			TweenExtensions.Rewind(seq);
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public SubBombPinnedAvatar <>4__this;

		public DG.Tweening.Sequence seq;

		internal void <AnimateRemovePinnedAvatar>g__FinalizeAnimation|0()
		{
			SubBombPinnedAvatar subBombPinnedAvatar = <>4__this;
			GameObject gameObject = subBombPinnedAvatar.content.gameObject;
			gameObject.SetActive(value: false);
			TweenExtensions.Rewind(seq);
		}
	}

	private GameObject content;

	private AvatarInitializer userAvatar;

	private Button like;

	private ParticleSystem[] particleSystems;

	private GenericSoundAlbum soundAlbum;

	private GiftBombData CurrentGiftBomb
	{
		get
		{
			Room lobby = SFS.Lobby;
			return SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		}
	}

	private void Awake()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_005c: Expected I, but got O
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I
		//IL_0108: Expected I, but got O
		//IL_0133: Expected I, but got O
		//IL_016b: Expected O, but got I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I
		//IL_020d: Expected I, but got O
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		content.SetActive(value: false);
		Button button = like;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		AvatarInitializer avatarInitializer = userAvatar;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)2856;
		object obj5 = typeof(DataRelation) + 3728;
		object obj6 = (nint)0 + (nint)2864;
		object obj7 = typeof(Queue<string>) + 848;
		object obj8 = (nint)0 + (nint)2200;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.ChatTopBombers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj6);
		SFS.OnExtensionResponse += eventListenerDelegate;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if (sessionModel.IsInLobby)
		{
			GameObject go = base.gameObject;
			Room lobby = SFS.Lobby;
			object obj11 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)2848;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj12);
			object varName = "___# Content push apply failed [{0}]: {1}" + 2736;
			VariableBinderExtensions.Bind(go, lobby, (string)varName, action2);
		}
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00b1: Expected I, but got O
		//IL_00d7: Expected I, but got O
		Button button = like;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)2856;
		object obj5 = typeof(DataRelation) + 3728;
		object obj6 = (nint)0 + (nint)2864;
		button.m_OnClick.RemoveListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj6);
		SFS.OnExtensionResponse -= eventListenerDelegate;
	}

	private void OnJoinRoom(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005b: Expected I, but got O
		if (SFSKammelnaRoomExtensions.IsLobby(room))
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2848;
			object varName = "___# Content push apply failed [{0}]: {1}" + 2736;
			GameObject go = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			VariableBinderExtensions.Bind(go, room, (string)varName, action);
		}
	}

	private void OnBombCreated()
	{
		Room lobby = SFS.Lobby;
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		if (activeBombInfo != null && activeBombInfo.<Category>k__BackingField == GiftBombType.Subscription)
		{
			AnimateAddPinnedAvatar();
		}
		else
		{
			AnimateRemovePinnedAvatar();
		}
	}

	private void AnimateAddPinnedAvatar()
	{
		//IL_0074: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		GameObject gameObject = content.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = like.gameObject;
		gameObject2.SetActive(value: true);
		like.interactable = true;
		object obj = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		Room lobby = SFS.Lobby;
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		AvatarData data = activeBombInfo.<Creator>k__BackingField;
		userAvatar.Initialize(data);
		object obj2 = (nint)0 + (nint)1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Component component = default(Component);
		int num = ShortcutExtensions.DOKill(component);
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Vector3 localScale = ((Transform)component).localScale;
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = (nint)0 + (nint)2408;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+B8]");
		object obj7 = 0;
		((Transform)component).localScale = (Vector3)0;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v24+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence s = DOTween.Sequence();
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.AppendInterval(s, 0.5f);
		float duration = default(float);
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale((Transform)component, (Vector3)0, duration);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void Like()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		//IL_0095: Expected I8, but got I4
		Room lobby = SFS.Lobby;
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		if (activeBombInfo != null)
		{
			Room lobby2 = SFS.Lobby;
			GiftBombData activeBombInfo2 = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby2);
			PlayerInfo <Creator>k__BackingField = activeBombInfo2.<Creator>k__BackingField;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj2 = (nint)0 + (nint)1864;
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj2);
			KammelnaRequests.LikeUser(<Creator>k__BackingField.<DBID>k__BackingField, action);
			AnimateRemoveLikeButton();
			SFS.SendChatPinnedAvatarParticle(ChatPinnedAvatarParticle.Heart);
			ITrackEvent trackEvent = TrackerLibrary.ChatSubBombPinkedAvatarClickedLike();
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	private void AnimateRemoveLikeButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0141: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01f1: Expected F4, but got O
		//IL_01f1: Expected O, but got I4
		//IL_0181: Expected I, but got O
		//IL_0196: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		like.interactable = false;
		object obj4 = (nint)0 + (nint)3912;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Component target = default(Component);
		int num = ShortcutExtensions.DOKill(target);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		object obj8 = obj2 + 24;
		obj8 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.AppendInterval((DG.Tweening.Sequence)obj8, 0.5f);
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2216;
		object obj11 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj12 = typeof(UsageHint) + 744;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7+B8]");
		object obj14 = 0;
		LayoutElement target2 = default(LayoutElement);
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPreferredSize(target2, (Vector2)0, (float)obj14);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Append((DG.Tweening.Sequence)obj8, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+18]");
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.AppendCallback((DG.Tweening.Sequence)0, tweenCallback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void AnimateRemovePinnedAvatar()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01d7: Expected F4, but got O
		//IL_01d7: Expected O, but got I4
		//IL_016c: Expected I, but got O
		//IL_0181: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)1488;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Component target = default(Component);
		int num = ShortcutExtensions.DOKill(target);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		object obj8 = obj2 + 24;
		obj8 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.AppendInterval((DG.Tweening.Sequence)obj8, 0.5f);
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2224;
		object obj11 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj12 = typeof(UsageHint) + 816;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v7+B8]");
		object obj14 = 0;
		Transform target2 = default(Transform);
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(target2, (Vector3)0, (float)obj14);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Append((DG.Tweening.Sequence)obj8, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+18]");
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.AppendCallback((DG.Tweening.Sequence)0, tweenCallback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void OnOnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		object obj = "com.unity.services.authentication.profile" + 1736;
		string command = SFSExtensions.GetCommand(evt);
		if (!(command != (string)obj))
		{
			object obj2 = "com.unity.services.authentication.profile" + 1744;
			object obj3 = (nint)0 + (nint)64;
			ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
			ChatPinnedAvatarParticle particle = default(ChatPinnedAvatarParticle);
			ShootParticle(particle);
		}
	}

	private void ShootParticle(ChatPinnedAvatarParticle particle)
	{
		//IL_0233: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		ParticleSystem particleSystem;
		if (particle <= ChatPinnedAvatarParticle.Thanks1)
		{
			if (particle != ChatPinnedAvatarParticle.Heart)
			{
				if (particle != ChatPinnedAvatarParticle.Thanks1)
				{
					return;
				}
				ParticleSystem[] array = particleSystems;
				if (particleSystems != null)
				{
					particleSystem = array[1];
					bool flag = (object)array[1] == null;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_02af;
					}
				}
			}
			else
			{
				ParticleSystem[] array2 = particleSystems;
				if (particleSystems != null)
				{
					particleSystem = array2[0];
					bool flag2 = (object)array2[0] == null;
					object obj2 = !flag2;
					if (obj2 != null)
					{
						goto IL_02af;
					}
				}
			}
		}
		else if (particle != ChatPinnedAvatarParticle.Thanks2)
		{
			if (particle != ChatPinnedAvatarParticle.Thanks3)
			{
				return;
			}
			ParticleSystem[] array3 = particleSystems;
			if (particleSystems != null)
			{
				particleSystem = array3[3];
				bool flag3 = (object)array3[3] == null;
				object obj3 = !flag3;
				if (obj3 != null)
				{
					goto IL_02af;
				}
			}
		}
		else
		{
			ParticleSystem[] array4 = particleSystems;
			if (particleSystems != null)
			{
				bool flag4 = array4.Length < 2;
				object obj4 = !flag4;
				object obj5 = array4.Length - 2;
				bool flag5 = obj5 == null;
				object obj6 = ~obj4;
				object obj7 = obj6 | flag5;
				if (obj7 != null)
				{
					goto IL_02c7;
				}
				particleSystem = array4[2];
				if ((object)array4[2] != null)
				{
					goto IL_02af;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02c7;
		IL_02af:
		particleSystem.Play();
		return;
		IL_02c7:
		throw new IndexOutOfRangeException();
	}
}
