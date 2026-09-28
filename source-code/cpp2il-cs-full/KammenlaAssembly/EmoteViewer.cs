using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class EmoteViewer : MonoBehaviour
{
	private sealed class <PlayEmoteAnimation>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public EmoteViewer <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <PlayEmoteAnimation>d__38(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0102: Expected I4, but got I8
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected O, but got Unknown
			//IL_0140: Expected O, but got I4
			//IL_01c3: Expected O, but got I
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected O, but got Unknown
			//IL_01f6: Expected F4, but got I
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_017e: Expected I4, but got O
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					EmoteViewer emoteViewer = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this != null && (object)emoteViewer.emotePlayer != null)
					{
						GameObject gameObject = emoteViewer.emotePlayer.gameObject;
						if ((object)gameObject != null)
						{
							gameObject.SetActive(value: true);
							if ((object)emoteViewer.emotePlayer != null)
							{
								emoteViewer.emotePlayer.Play();
								goto IL_019d;
							}
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			else
			{
				<>1__state = -1;
				object obj = typeof(DataRelation) + 3032;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v5+B8]");
				object obj4 = 0;
				object obj5 = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v6+4]");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(0f);
				object obj6 = this + 24;
				obj6 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
			}
			goto IL_019d;
			IL_019d:
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private Userbox userbox;

	private GameObject avatarHolder;

	private Transform avatarShadow;

	private Image avatar;

	private RotatingLoadingIndicator emoteLoadingIndicator;

	private Image emoteImageRenderer;

	private SpriteSheetPlayer emotePlayer;

	private AudioSource audio;

	private bool <isEmotePlaying>k__BackingField;

	private bool <isEmotePreparing>k__BackingField;

	private int <userDbId>k__BackingField = -1;

	public float viewScale;

	private static float EMOTE_SCALE_DURATION;

	private static float EMOTE_PLAY_DELAY;

	private static readonly int BlurProperty;

	private static readonly int ShiftProperty;

	private float avatarStartScale;

	private float emoteStartScale;

	public bool isEmotePlaying
	{
		get
		{
			return <isEmotePlaying>k__BackingField;
		}
		private set
		{
			<isEmotePlaying>k__BackingField = value;
		}
	}

	public bool isEmotePreparing
	{
		get
		{
			return <isEmotePreparing>k__BackingField;
		}
		private set
		{
			<isEmotePreparing>k__BackingField = value;
		}
	}

	public int userDbId
	{
		get
		{
			return <userDbId>k__BackingField;
		}
		private set
		{
			<userDbId>k__BackingField = value;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0052: Expected I, but got O
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0388: Expected O, but got I4
		//IL_0391: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0167: Expected O, but got I
		//IL_0175: Expected I, but got O
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0237: Expected O, but got I
		//IL_0245: Expected I, but got O
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_02f9: Expected I, but got O
		//IL_032a: Expected I, but got O
		//IL_033a: Expected O, but got I
		//IL_034a: Expected O, but got I
		Image image = avatar;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		nint num = (nint)image;
		Material material = image.material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material2 = default(Material);
		material2..ctor(material);
		nint num2 = (nint)image;
		image.material = material2;
		Transform transform = avatarHolder.transform;
		Vector3 localScale = transform.localScale;
		float num3 = default(float);
		avatarStartScale = num3;
		Transform transform2 = emotePlayer.transform;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Vector3 localScale2 = transform2.localScale;
		emoteStartScale = num3;
		ClearAvatarBlur();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v17+E4]");
		object obj4;
		if ((nint)0 != 0)
		{
			bool flag = emotePlayer;
			bool flag2 = !flag;
			obj4 = 0;
			if (!flag2)
			{
				goto IL_013d;
			}
			return;
		}
		goto IL_0354;
		IL_0354:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = emotePlayer;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		obj4 = 0;
		if (obj5 == null)
		{
			return;
		}
		goto IL_013d;
		IL_013d:
		object obj6 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)360;
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)this, (IntPtr)obj7);
		object obj8 = emotePlayer + 112;
		Delegate obj9 = (Delegate)obj8;
		object obj12 = default(object);
		bool flag6;
		Delegate obj15 = default(Delegate);
		do
		{
			Delegate obj10 = Delegate.Combine(obj9, action);
			Delegate obj14;
			if ((object)obj10 == null)
			{
				object obj11 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = obj12 == null;
				object obj13 = !flag5;
				object obj11 = obj12;
				if (obj13 == null)
				{
					obj14 = null;
					obj11 = obj6;
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag6 = (object)obj15 == obj9;
			obj9 = obj15;
			obj14 = obj15;
		}
		while (!flag6);
		object obj16 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)352;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj17);
		object obj18 = emotePlayer + 120;
		Delegate obj19 = (Delegate)obj18;
		bool flag7;
		Delegate obj21 = default(Delegate);
		do
		{
			Delegate obj20 = Delegate.Combine(obj19, action2);
			Delegate obj22;
			if ((object)obj20 == null || obj20 == obj16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag7 = (object)obj21 == obj19;
				obj19 = obj21;
				obj22 = obj21;
				continue;
			}
			InvalidCastException ex = new InvalidCastException();
			obj22 = null;
			break;
		}
		while (!flag7);
		Image image2 = emoteImageRenderer;
		nint num4 = (nint)image2;
		Material material3 = image2.material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material4 = default(Material);
		material4..ctor(material3);
		nint num5 = (nint)image2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v18 (Il2CppClass<UnityEngine.UI.Image>)+348]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v18 (Il2CppClass<UnityEngine.UI.Image>)+350]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v188 @ X3_v4 (should have been resolved before IL gen)");
		goto IL_0354;
	}

	private void OnEnable()
	{
		EmoteViewer_OnCompleted();
	}

	private void EmoteViewer_OnFrameChanged(int index, Sprite sprite)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object materialProperty = "_InputUv1BufferOffset" + 3072;
		SpriteExensions.SetAtlasRectInfo(emoteImageRenderer, (string)materialProperty);
	}

	private void PerformScaleAnimation(float scale)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_017c: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_036a: Expected F4, but got O
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I
		//IL_01fe: Expected F4, but got O
		//IL_0279: Expected O, but got I4
		//IL_032d: Expected O, but got I
		//IL_02fc: Expected O, but got I4
		//IL_039e: Expected O, but got I
		//IL_03d0: Expected F4, but got O
		Transform target = emotePlayer.transform;
		int num = ShortcutExtensions.DOKill(target);
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Transform target2 = avatarHolder.transform;
		int num2 = ShortcutExtensions.DOKill(target2);
		bool flag = (object)avatarShadow == null;
		object obj2 = 0;
		bool flag2 = false;
		if (!flag)
		{
			Transform target3 = avatarShadow.transform;
			int num3 = ShortcutExtensions.DOKill(target3);
			obj2 = 0;
			flag2 = false;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		object obj5 = typeof(DataRelation) + 3032;
		object obj6 = (nint)0 + (nint)2904;
		Transform target4 = emotePlayer.transform;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v6+B8]");
		object obj9 = 0;
		float endValue = scale * emoteStartScale;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target4, endValue, (float)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s, t);
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		Transform target5 = avatarHolder.transform;
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+B8]");
		object obj12 = 0;
		float endValue2 = scale * avatarStartScale;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target5, endValue2, (float)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = avatarShadow;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			if (obj14 != null)
			{
				goto IL_02c3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)avatarShadow)
			{
				goto IL_02c3;
			}
		}
		goto IL_0321;
		IL_02c3:
		Transform target6 = avatarShadow.transform;
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+B8]");
		object obj17 = 0;
		float num4 = scale * avatarStartScale;
		float endValue3 = num4 * 1.0666115E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target6, endValue3, (float)obj17);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t3 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t3);
		goto IL_0321;
		IL_0321:
		object obj18 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	public void PrepareEmote()
	{
		<isEmotePreparing>k__BackingField = true;
	}

	public void UnprepareEmote()
	{
		<isEmotePreparing>k__BackingField = false;
	}

	private void ClearAvatarBlur()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		//IL_0088: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		int num = ShortcutExtensions.DOKill(avatar);
		Material material = avatar.material;
		int num2 = ShortcutExtensions.DOKill(material);
		Image image = avatar;
		object obj = typeof(DataRelation) + 3032;
		nint num3 = (nint)image;
		Material material2 = image.material;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8+8]");
		material2.SetFloat(0, 0f);
	}

	public void Reset()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003b: Expected I, but got O
		//IL_0072: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		emoteLoadingIndicator.FinishLoading();
		Image image = avatar;
		object obj = typeof(DataRelation) + 3032;
		nint num = (nint)image;
		Material material = image.material;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+8]");
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(material, 0f, 0, 0.3f);
		GameObject gameObject = emotePlayer.gameObject;
		gameObject.SetActive(value: false);
		audio.Stop();
		<isEmotePlaying>k__BackingField = false;
		PerformScaleAnimation(1f);
	}

	private void EmoteViewer_OnCompleted()
	{
		//IL_01ea: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_012d: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01a3: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_00be: Expected O, but got I
		Reset();
		object obj = <userDbId>k__BackingField + 1;
		if (obj == null)
		{
			return;
		}
		object obj2 = typeof(SqlSingle[]) + 3832;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				goto IL_0079;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_0079;
			}
		}
		_ = 1;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object obj9 = obj7;
		if (obj8 != null)
		{
			goto IL_00ae;
		}
		goto IL_0181;
		IL_0079:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		obj9 = obj7;
		if (!flag3)
		{
			goto IL_00ae;
		}
		goto IL_0181;
		IL_00e3:
		AnimatedItemController animatedItemController;
		animatedItemController.NotifyEmotePlaybackCompleted(<userDbId>k__BackingField);
		return;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v16+B8]");
		object obj10 = 0;
		animatedItemController = (AnimatedItemController)obj10;
		if (obj10 != null)
		{
			goto IL_00e3;
		}
		return;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v7+B8]");
		object obj12 = 0;
		animatedItemController = (AnimatedItemController)obj12;
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			return;
		}
		goto IL_00e3;
	}

	public void PlayLoadingEmote()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0058: Expected O, but got I4
		//IL_00ca: Expected O, but got I
		<isEmotePreparing>k__BackingField = true;
		ClearAvatarBlur();
		Image image = avatar;
		object obj = typeof(DataRelation) + 3032;
		nint num = (nint)image;
		Material material = image.material;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+8]");
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(material, 30f, 0, 0.8f);
		emoteLoadingIndicator.StartLoading();
		PerformScaleAnimation(viewScale);
	}

	public void PlayEmote(AudioClip clip, Texture2D image, Vector2Int gridSize, float duration, float audioDelay, float shiftMask)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0192: Expected I, but got O
		//IL_01c9: Expected O, but got I4
		//IL_01fe: Expected O, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		emoteLoadingIndicator.FinishLoading();
		<isEmotePlaying>k__BackingField = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag = this.userbox;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_00cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)this.userbox)
			{
				goto IL_00cb;
			}
		}
		goto IL_010d;
		IL_010d:
		GameObject gameObject = emotePlayer.gameObject;
		gameObject.SetActive(value: false);
		SpriteSheetPlayer spriteSheetPlayer = emotePlayer;
		spriteSheetPlayer.gridSize = gridSize;
		SpriteSheetPlayer spriteSheetPlayer2 = emotePlayer;
		spriteSheetPlayer2.duration = duration;
		Image image2 = emoteImageRenderer;
		object obj4 = typeof(DataRelation) + 3032;
		nint num = (nint)image2;
		Material material = image2.material;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v11+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+C]");
		material.SetFloat(0, shiftMask);
		SpriteSheetPlayer spriteSheetPlayer3 = emotePlayer;
		object obj9 = emotePlayer + 48;
		obj9 = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sprite[] array = SpriteExensions.CreateSprites((Texture2D)obj9, spriteSheetPlayer3.gridSize);
		object obj10 = emotePlayer + 96;
		obj10 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		audio.clip = clip;
		audio.PlayDelayed(audioDelay);
		object obj11 = typeof(DebugUI.BitField) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = default(object);
		obj12..ctor();
		_ = 0;
		object obj13 = obj12 + 32;
		obj13 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj12);
		return;
		IL_00cb:
		Userbox userbox = this.userbox;
		CardGamePlayer <player>k__BackingField = userbox.<player>k__BackingField;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(((KPlayer)<player>k__BackingField).<User>k__BackingField);
		<userDbId>k__BackingField = intDbId;
		goto IL_010d;
	}

	private IEnumerator PlayEmoteAnimation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	static EmoteViewer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_00ae: Expected O, but got I
		object obj = typeof(DataRelation) + 3032;
		object obj2 = "[{0}]:{1}" + 1608;
		object obj3 = "_InputUv1BufferOffset" + 2136;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F98]");
		obj5 = 0;
		int num = Shader.PropertyToID((string)obj2);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+B8]");
		object obj7 = 0;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+B8]");
		object obj9 = 0;
	}
}
