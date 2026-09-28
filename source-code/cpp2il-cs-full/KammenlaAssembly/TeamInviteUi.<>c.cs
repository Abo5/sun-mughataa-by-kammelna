using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TeamInviteUi : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Button, bool> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 2552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_Actionable>b__11_0(Button button)
		{
			//IL_0067: Expected I4, but got O
			if ((object)button != null)
			{
				GameObject gameObject = button.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private RectTransform container;

	private RectTransform panel;

	private AvatarInitializer avatar;

	private TextMeshProUGUI messageText;

	private Button[] buttons;

	private TournamentSceneEventsChannel tournamentEventsChannel;

	private QueuePlayer _player;

	private Vector2 _finalPos;

	public int PlayerId
	{
		get
		{
			//IL_00ab: Expected I4, but got I8
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			QueuePlayer player = _player;
			if (_player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					int? num = <info>k__BackingField.<DBID>k__BackingField;
					object obj = (??)num & 1;
					bool flag = obj == null;
					object obj2 = !flag;
					object obj3 = ~obj2;
					int result = default(int);
					if (obj3 == null)
					{
						return result;
					}
					return -1;
				}
			}
			return -1;
		}
	}

	public bool Actionable
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D90]");
			object obj3 = (nint)0 & (nint)1;
			Button[] array;
			Button[] array2;
			object obj4;
			if (obj3 != null)
			{
				array = buttons;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				array2 = buttons;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				array = buttons;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				array2 = buttons;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = array2;
			object obj10 = obj7;
			IEnumerable<object> source = array2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2784;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return Enumerable.Any(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = array;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = array;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_006a: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		tournamentEventsChannel.OnDismissAllInvites += action;
		AvatarInitializer avatarInitializer = avatar;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.TournamentTeams;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		tournamentEventsChannel.OnDismissAllInvites -= action;
	}

	public void Populate(QueuePlayer invitePlayer, string message)
	{
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_016e: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		//IL_0206: Expected F4, but got O
		//IL_0206: Expected O, but got I4
		object obj = this + 80;
		obj = invitePlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = default(int);
		string userDbId = num.ToString();
		User onlineUser = SFS.GetOnlineUser(userDbId);
		RectTransform rectTransform;
		if (onlineUser != null)
		{
			avatar.Initialize(onlineUser);
			TextMeshProExtensions.Localize(messageText, message);
			rectTransform = panel;
			bool flag = (object)panel == null;
			object obj2 = !flag;
			object obj3 = 0;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			AvatarData data = invitePlayer.<info>k__BackingField;
			avatar.Initialize(data);
			TextMeshProExtensions.Localize(messageText, message);
			rectTransform = panel;
			object obj3 = 0;
		}
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		Vector2 finalPos = default(Vector2);
		_finalPos = finalPos;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = panel.rect;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		float num2 = default(float);
		float value = num2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = num2;
		}
		UIExtensions.MoveTo(x: value, gObject: panel, isWorldPositions: false, y: (float?)(object)0);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(panel, (Vector2)0, (float)_finalPos);
	}

	public void Close()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c4: Unsupported input type for neg.
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected F4, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019d: Expected O, but got I
		//IL_01ee: Expected O, but got I
		//IL_0236: Expected O, but got I4
		//IL_01bf: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = panel.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 offsetMax = panel.offsetMax;
		object obj4 = typeof(UsageHint) + 744;
		panel.anchorMin = (Vector2)0;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj6 = default(object);
		float inset = 0 - obj6;
		float size = default(float);
		panel.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, inset, size);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence s = DOTween.Sequence();
		Rect rect2 = panel.rect;
		float num = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOAnchorPosX(panel, num, 0.3f);
		DG.Tweening.Sequence s2 = TweenSettingsExtensions.Append(s, t);
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)1272;
		Vector2 sizeDelta = container.sizeDelta;
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v14+B8]");
		object obj12 = 0;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v15+28]");
		float duration = num2 * 0f;
		float num3 = 1.0502537E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v15+2C]");
		float num4 = num3 * 0f;
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOSizeDelta(container, (Vector2)0, duration);
		DG.Tweening.Sequence s3 = TweenSettingsExtensions.Join(s2, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.AppendCallback(s3, tweenCallback);
	}

	public void Accept()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00cb: Expected I, but got O
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_005e: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		Button[] array = buttons;
		bool flag = array.Length < 1;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		if (!flag)
		{
			object obj = array + 32;
			object obj2 = 0;
			bool flag3;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X22_v5+v77 @ X21_v6*8]");
				((Selectable)0).interactable = false;
				obj2++;
				flag3 = (nint)obj2 < array.Length;
				flag2 = false;
			}
			while (flag3);
		}
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		tournamentEventsChannel.TriggerAcceptInvite(_player, action);
	}

	public void Reject()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00cb: Expected I, but got O
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_005e: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		Button[] array = buttons;
		bool flag = array.Length < 1;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		if (!flag)
		{
			object obj = array + 32;
			object obj2 = 0;
			bool flag3;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X22_v5+v77 @ X21_v6*8]");
				((Selectable)0).interactable = false;
				obj2++;
				flag3 = (nint)obj2 < array.Length;
				flag2 = false;
			}
			while (flag3);
		}
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		tournamentEventsChannel.TriggerRejectInvite(_player, action);
	}

	private void DisableButtons()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		Button[] array = buttons;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((Selectable)0).interactable = false;
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void CloseIfActionable()
	{
		if (Actionable)
		{
			Close();
		}
	}

	private void <Close>b__15_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D97]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object obj5;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = gameObject;
			object obj6 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = gameObject;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.Destroy(obj5);
	}
}
