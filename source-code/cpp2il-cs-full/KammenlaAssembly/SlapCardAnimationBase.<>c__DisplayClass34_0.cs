using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public abstract class SlapCardAnimationBase : MonoBehaviour, ICustomPlayAnimation
{
	private sealed class <>c__DisplayClass34_0
	{
		public SpriteRenderer card;

		public SlapCardAnimationBase <>4__this;

		public Transform playedCard;

		internal bool <StartAnimation>b__0(SpriteRenderer c)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0144: Expected O, but got I4
			//IL_019c: Expected O, but got I4
			//IL_01bd: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78E7]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				obj5 = card;
				obj6 = card;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = card;
				obj6 = card;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = c != obj6;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				goto IL_00bb;
			}
			goto IL_01aa;
			IL_00bb:
			if ((object)c != null)
			{
				GameObject gameObject = c.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_01aa:
			return flag3;
			IL_0091:
			flag3 = c != obj5;
			if (flag3)
			{
				goto IL_00bb;
			}
			goto IL_01aa;
		}

		internal void <StartAnimation>b__1()
		{
			//IL_002b: Expected I, but got O
			//IL_003b: Expected O, but got I
			//IL_004b: Expected O, but got I
			SlapCardAnimationBase slapCardAnimationBase = <>4__this;
			Transform transform = playedCard;
			SpriteRenderer spriteRenderer = card;
			nint num = (nint)slapCardAnimationBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v2 (Il2CppClass<SlapCardAnimationBase>)+1B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v2 (Il2CppClass<SlapCardAnimationBase>)+1C0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	protected float distanceFromCenter;

	protected float impactRadius;

	protected float impactRadiusTablet;

	protected float targetHoldScale;

	protected float groundScale;

	protected Vector2 bounceScaleRange;

	protected Vector2 bounceAngleRange;

	protected Vector2 tiltCardAngleRange;

	public Userbox targetUserBox;

	public Vector3 targetHoldAngles;

	protected AnimationCurve scaleCurve;

	protected AnimationCurve rotationCurve;

	protected AnimationCurve movementCurve;

	protected AnimationCurve bounceScaleCurve;

	protected float mainDuration;

	protected float moveDuration;

	protected float slideDuration;

	protected float bounceDuration;

	protected float destroyDelay;

	protected FakeDynamicShadowUI shadow;

	protected Vector2 shadowScaleRange;

	protected Vector2 shadowScaleTabletRange;

	protected AudioSource audioSource;

	private GameAction <Action>k__BackingField;

	protected SpriteRenderer[] _groundCards;

	protected Transform _playGround;

	private Vector3 _cardRestWorldPosition;

	private const string GROUND_CARDS_LAYER = "Ground cards";

	private const string UI_ELEMENTS_LAYER = "UI Elements";

	public CardGamePlayer TargetPlayer
	{
		get
		{
			Userbox userbox = targetUserBox;
			if ((object)targetUserBox != null)
			{
				return userbox.<player>k__BackingField;
			}
			return (CardGamePlayer)(object)new NullReferenceException();
		}
	}

	public GameAction Action
	{
		get
		{
			return <Action>k__BackingField;
		}
		set
		{
			<Action>k__BackingField = value;
		}
	}

	public void StartAnimation(SpriteRenderer card, Transform startPlacement, Userbox userbox, SpriteRenderer[] groundCards, Vector3 landingWorldPosition)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00b1: Expected I, but got O
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0258: Expected O, but got I
		//IL_0272: Expected O, but got I4
		//IL_01a1: Expected O, but got I
		//IL_02e8: Expected O, but got I
		//IL_02b0: Expected O, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_0225: Expected O, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0381: Expected O, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_096e: Expected O, but got I
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_09b1: Expected O, but got I
		//IL_09ce: Expected O, but got I
		//IL_09f8: Expected O, but got I
		//IL_0a7a: Expected O, but got I4
		//IL_0471: Invalid comparison between F4 and I4
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_0513: Invalid comparison between F8 and I4
		//IL_0522: Invalid comparison between F8 and I4
		//IL_053a: Expected O, but got F8
		//IL_0547: Expected O, but got F8
		//IL_057c: Expected O, but got I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		//IL_0630: Expected O, but got I4
		//IL_064d: Expected O, but got I
		//IL_065b: Expected O, but got I4
		//IL_0675: Expected O, but got I4
		//IL_06a5: Expected O, but got I
		//IL_06c3: Expected O, but got I4
		//IL_068f: Expected O, but got I
		//IL_0adb: Expected O, but got I4
		//IL_0b02: Expected O, but got I
		//IL_0b0e: Expected O, but got I
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0b2e: Expected O, but got I
		//IL_0b4f: Expected F4, but got O
		//IL_0b4f: Expected O, but got I4
		//IL_0b4f: Expected O, but got I
		//IL_0b7a: Expected O, but got I
		//IL_071a: Expected I, but got O
		//IL_0b9a: Expected F4, but got I
		//IL_0b9a: Expected F4, but got O
		//IL_0bcb: Expected O, but got I4
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_07b6: Expected O, but got I4
		//IL_0bf0: Expected O, but got I4
		//IL_07dd: Expected I, but got O
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_0894: Expected O, but got I4
		//IL_0c12: Expected O, but got I
		//IL_0886: Expected O, but got I4
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3376;
		object obj4 = (nint)0 + (nint)3832;
		object obj5 = (nint)0 + (nint)3752;
		object obj6 = obj2 + 16;
		obj6 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isTablet = ScreenUtility.IsTablet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		IEnumerable<object> source = Enumerable.Where(groundCards, func);
		object[] array = Enumerable.ToArray(source);
		object obj8 = this + 200;
		obj8 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = this + 80;
		obj9 = userbox;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = typeof(SqlSingle[]) + 3832;
		Transform transform = ((Component)obj6).transform;
		object obj11 = obj2 + 32;
		obj11 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_01be;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj14 = (nint)0 & (nint)1;
			bool flag = obj14 == null;
			object obj15 = !flag;
			if (obj15 != null)
			{
				goto IL_01be;
			}
		}
		_ = 1;
		object obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v156+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_01f3;
		}
		goto IL_02c6;
		IL_02f5:
		AnimatedItemController animatedItemController;
		Transform playGround = animatedItemController.PlayGround;
		object obj19 = this + 208;
		obj19 = playGround;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Vector3 position = ((Transform)obj19).position;
		object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
		Vector3 userBoxDirection = userbox.GetUserBoxDirection();
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj22 = !flag3;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = startPlacement;
		object obj23 = typeof(UsageHint) + 816;
		object obj24;
		object obj25 = default(object);
		Vector3 vector;
		Vector3 vector2 = default(Vector3);
		if (flag4)
		{
			Vector3 position2 = startPlacement.position;
			Quaternion rotation = startPlacement.rotation;
			obj24 = obj25;
			vector = vector2;
			Vector3 vector3 = vector2;
			object obj26 = obj25;
		}
		else
		{
			Transform transform2 = userbox.transform;
			Vector3 position3 = transform2.position;
			object obj27 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v40+B8]");
			object obj28 = 0;
			Vector3 userBoxDirection2 = userbox.GetUserBoxDirection();
			object obj29 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+18]");
			object obj30 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+1C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+1C]");
			object obj31 = num2 * 0;
			object obj32 = obj30 + obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+20]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+20]");
			object obj33 = num3 * 0;
			object obj34 = obj33 + obj32;
			float num4 = distanceFromCenter * distanceFromCenter;
			object obj35 = (object)vector2 * (object)vector2;
			float num5 = num4 + (float)obj35;
			object obj36 = obj25 * obj25;
			float num6 = (float)obj36 + num5;
			object obj37 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v121+E4]");
			bool flag5 = (nint)0 == 0;
			object obj38 = !flag5;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num7 = (float)obj34 * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (!(num7 < 646978940f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+18]");
				float num8 = 0f * distanceFromCenter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+1C]");
				object obj39 = 0 * vector2;
				float num9 = num8 + (float)obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v41+20]");
				object obj40 = 0 * obj25;
				float num10 = (float)obj40 + num9;
				float num11 = num10 / num7;
				double num12 = (double)num11 - 1.0;
				bool flag6 = num12 < 0.0;
				bool flag7 = num12 == 0.0;
				object obj41 = (double)num11 ^ 1.0;
				object obj42 = (double)num11 ^ num12;
				object obj43 = obj41 & obj42;
				bool flag8 = (nint)obj43 < 0;
				bool flag9 = flag6 == flag8;
				object obj44 = !flag7;
				object obj45 = flag9 & obj44;
				object obj46 = ~obj45;
				double num13 = ((obj46 != null) ? ((double)num11) : 1.0);
				if ((double)num11 < -1.0)
				{
					double num14 = -1.0;
				}
				else
				{
					double num14 = num13;
				}
				object obj47 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v131+E4]");
				bool flag10 = (nint)0 == 0;
				object obj48 = !flag10;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0DB4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Vector3 euler = default(Vector3);
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			obj24 = obj25;
			vector = vector2;
			Vector3 vector3 = vector2;
			object obj26 = obj25;
		}
		Vector3 vector4 = default(Vector3);
		_cardRestWorldPosition = vector4;
		GameObject gameObject = ((Component)obj6).gameObject;
		gameObject.SetActive(value: true);
		((Transform)obj11).position = (Vector3)0;
		object obj49 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v11+B8]");
		object obj50 = 0;
		((Transform)obj11).localScale = (Vector3)0;
		bool flag11 = !isTablet;
		object obj51 = !flag11;
		if (obj51 == null)
		{
			ApplyStartRotation((Transform)obj11, (Quaternion)0);
		}
		object obj52 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v15+198]");
		bool isMe = ((KPlayer)0).IsMe;
		bool flag12 = !isMe;
		object obj53 = !flag12;
		Vector3 vector5 = vector4;
		if (obj53 == null)
		{
			Vector3 eulerAngles = ((Transform)obj11).eulerAngles;
			Vector2 vector6 = tiltCardAngleRange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlapCardAnimationBase)+48]");
			float num15 = UnityEngine.Random.Range((float)vector6, 0f);
			int num16 = UnityEngine.Random.Range(0, 2);
			bool flag13 = num16 == 0;
			object obj54 = !flag13;
			object obj55 = ~obj54;
			if (obj55 == null)
			{
			}
			((Transform)obj11).eulerAngles = (Vector3)0;
			vector5 = vector4;
		}
		object obj56 = (nint)0 + (nint)2840;
		object obj57 = (nint)0 + (nint)2896;
		object obj58 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj59 = (nint)0 + (nint)3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3 (System.Object)+20]");
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate((Transform)0, (Vector3)3, (float)targetHoldAngles);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3 (System.Object)+20]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale((Transform)0, targetHoldScale, mainDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj59);
		float num17 = (float)vector4 * distanceFromCenter;
		float num18 = (float)vector2 * distanceFromCenter;
		float num19 = (float)obj25 * distanceFromCenter;
		float duration = (float)vector5 + num17;
		float num20 = (float)vector + num18;
		float num21 = (float)obj24 + num19;
		object obj61 = default(object);
		object obj60 = obj61 + 128;
		obj60 = tweenCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOMove((Transform)obj11, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num22 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17 (Il2CppClass<SlapCardAnimationBase>)+1E0]");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)0);
		object obj63 = default(object);
		object obj62 = obj63 + 88;
		obj62 = tweenCallback2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj64 = shadow + 48;
		obj64 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		FakeDynamicShadowUI fakeDynamicShadowUI = shadow;
		if (isTablet)
		{
			float maxShadowDistance = 0f - fakeDynamicShadowUI.maxShadowDistance;
			fakeDynamicShadowUI.maxShadowDistance = maxShadowDistance;
			object obj65 = 176;
		}
		else
		{
			object obj65 = 168;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlapCardAnimationBase)+v954 @ X9_v5]");
		fakeDynamicShadowUI.shadowScaleRange = (Vector2)0;
		OnBeforeAudioPlay((SpriteRenderer)obj6);
		int sortingOrder = ((Renderer)obj6).sortingOrder;
		object obj66 = "ThisIsFakeReceiptData" + 3656;
		int sortingLayerID = SortingLayer.NameToID((string)obj66);
		((Renderer)obj6).sortingLayerID = sortingLayerID;
		((Renderer)obj6).sortingOrder = sortingOrder;
		FakeDynamicShadowUI fakeDynamicShadowUI2 = shadow;
		int sortingOrder2 = ((Renderer)obj6).sortingOrder;
		int sortingLayerID2 = SortingLayer.NameToID((string)obj66);
		int sortingOrder3 = sortingOrder2 - 1;
		fakeDynamicShadowUI2.spriteShadow.sortingLayerID = sortingLayerID2;
		fakeDynamicShadowUI2.spriteShadow.sortingOrder = sortingOrder3;
		audioSource.Play();
		return;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v156+B8]");
		object obj67 = 0;
		animatedItemController = (AnimatedItemController)obj67;
		bool flag14 = obj67 == null;
		object obj68 = !flag14;
		if (obj68 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02f5;
		IL_02c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj69 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v148+B8]");
		object obj70 = 0;
		animatedItemController = (AnimatedItemController)obj70;
		goto IL_02f5;
		IL_01be:
		obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v156+E4]");
		bool flag15 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag15)
		{
			goto IL_01f3;
		}
		goto IL_02c6;
	}

	protected abstract void ApplyStartRotation(Transform playedCard, Quaternion startRotation);

	protected abstract void OnScaleComplete(SpriteRenderer card, Transform playedCard);

	protected virtual void OnBeforeAudioPlay(SpriteRenderer card)
	{
	}

	protected virtual void OnAnimationStarted()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0064: Expected I, but got O
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		GameObject gameObject = shadow.gameObject;
		object obj = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2808;
		object obj2 = (nint)0 + (nint)880;
		gameObject.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<float> func = default(Func<float>);
		func..ctor((object)this, (IntPtr)obj2);
		object obj3 = shadow + 120;
		obj3 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected virtual void OnGrounded(Transform card)
	{
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0077: Expected F4, but got O
		//IL_0077: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		GameObject gameObject = shadow.gameObject;
		object obj = (nint)0 + (nint)2904;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		gameObject.SetActive(value: false);
		int num = ShortcutExtensions.DOKill(card, complete: true);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMove(card, (Vector3)0, (float)_cardRestWorldPosition);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		BounceGroundedCards();
		GameObject gameObject2 = base.gameObject;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		UnityEngine.Object obj5 = gameObject2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = gameObject2;
		}
		UnityEngine.Object.Destroy(obj5, destroyDelay);
	}

	protected virtual int GetCardOrder()
	{
		//IL_0140: Expected I4, but got O
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		SpriteRenderer[] groundCards = _groundCards;
		if (_groundCards != null)
		{
			if (groundCards.Length < 1)
			{
				return 1;
			}
			object obj = _groundCards + 32;
			int num = 0;
			object obj2 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X23_v3+v45 @ X22_v4*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X23_v3+v45 @ X22_v4*8]");
				int sortingOrder = ((Renderer)0).sortingOrder;
				if (sortingOrder > num)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X23_v3+v45 @ X22_v4*8]");
					int sortingOrder2 = ((Renderer)0).sortingOrder;
					num = sortingOrder2;
				}
				obj2++;
				if ((nint)obj2 < groundCards.Length)
				{
					continue;
				}
				return num + 1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void BounceGroundedCards()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_02ec: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_030a: Expected F4, but got I
		//IL_031a: Invalid comparison between F8 and I
		//IL_01e0: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_020a: Expected F4, but got I
		//IL_020a: Expected F4, but got O
		//IL_0225: Expected F4, but got I
		//IL_0225: Expected F4, but got O
		//IL_0291: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		SpriteRenderer[] groundCards = _groundCards;
		if (groundCards.Length < 1)
		{
			return;
		}
		object obj = groundCards + 32;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = 0;
		double num2 = default(double);
		object obj14 = default(object);
		object obj15 = default(object);
		double num11 = default(double);
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X27_v4+v136 @ X24_v5*8]");
			Transform transform = ((Component)0).transform;
			Transform transform2 = transform.transform;
			Vector3 position = transform2.position;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num = num2 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			bool isTablet = ScreenUtility.IsTablet;
			bool flag2 = !isTablet;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				object obj9 = 40;
			}
			else
			{
				object obj9 = 36;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlapCardAnimationBase)+v343 @ X8_v10]");
			float num3 = 0f;
			double num4 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlapCardAnimationBase)+v343 @ X8_v10]");
			if (!(num4 > 0.0))
			{
				Vector2 vector = bounceScaleRange;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlapCardAnimationBase)+38]");
				float endValue = UnityEngine.Random.Range((float)vector, 0f);
				Vector2 vector2 = bounceAngleRange;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlapCardAnimationBase)+40]");
				float num5 = UnityEngine.Random.Range((float)vector2, 0f);
				int num6 = UnityEngine.Random.Range(1, 3);
				double num7 = ((num6 != 1) ? (-1.0) : 1.0);
				int num8 = ShortcutExtensions.DOKill(transform);
				Transform target = transform.transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, endValue, bounceDuration);
				object obj10 = (nint)0 + (nint)2896;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				Transform target2 = transform.transform;
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v17+B8]");
				object obj12 = 0;
				float num9 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18+50]");
				float num10 = num9 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18+48]");
				object obj13 = 0 * obj14;
				num3 = (float)obj13 * (float)obj15;
				num2 = num7 * (double)num10;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(target2, (Vector3)3, num3);
				object obj16 = (nint)0 + (nint)2848;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				num = num11;
			}
			obj4++;
		}
		while ((nint)obj4 < groundCards.Length);
	}

	private static int GetRandomSign()
	{
		//IL_002d: Expected O, but got I4
		int num = UnityEngine.Random.Range(0, 2);
		bool flag = num == 0;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return -1;
		}
		return 1;
	}

	protected static void ModifySortLayer(SpriteRenderer sprite, int orderId, bool aboveUI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = "ThisIsFakeReceiptData" + 3656;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
		bool flag = !aboveUI;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = ((obj4 != null) ? obj2 : obj);
		int sortingLayerID = SortingLayer.NameToID((string)obj5);
		sprite.sortingLayerID = sortingLayerID;
		sprite.sortingOrder = orderId;
	}

	private void OnDrawGizmos()
	{
		//IL_000a: Expected O, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0049: Expected F4, but got O
		//IL_0049: Expected O, but got I4
		Gizmos.color = (Color)0;
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		Gizmos.DrawWireSphere((Vector3)0, (float)obj3);
	}

	protected SlapCardAnimationBase()
	{
		//IL_0012: Expected F4, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FD0]");
		distanceFromCenter = 0f;
		groundScale = 1f;
		object obj = typeof(UsageHint) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+8]");
		object obj4 = default(object);
		object obj3 = 0 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+8]");
		object obj5 = (nint)0 * (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FA0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F98]");
		_ = 0;
		_ = 1061997773;
		base..ctor();
	}

	private float <OnAnimationStarted>b__38_0()
	{
		//IL_0167: Expected F4, but got I4
		//IL_009a: Invalid comparison between F8 and I4
		//IL_00a9: Invalid comparison between F8 and I4
		//IL_00c1: Expected O, but got F8
		//IL_00ce: Expected O, but got F8
		//IL_0103: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0170: Invalid comparison between F8 and I4
		//IL_014f: Expected F4, but got I4
		FakeDynamicShadowUI fakeDynamicShadowUI = shadow;
		Vector3 localScale = fakeDynamicShadowUI.target.localScale;
		if ((double)targetHoldScale != 1.0)
		{
			object obj = default(object);
			double num = (double)obj + -1.0;
			double num2 = (double)targetHoldScale + -1.0;
			double num3 = num / num2;
			double num4 = num3 - 1.0;
			bool flag = num4 < 0.0;
			bool flag2 = num4 == 0.0;
			object obj2 = num3 ^ 1.0;
			object obj3 = num3 ^ num4;
			object obj4 = obj2 & obj3;
			bool flag3 = (nint)obj4 < 0;
			bool flag4 = flag == flag3;
			object obj5 = !flag2;
			object obj6 = flag4 & obj5;
			object obj7 = ~obj6;
			double num5 = ((obj7 != null) ? num3 : 1.0);
			if (num3 < 0.0)
			{
				return 0f;
			}
			return (float)num5;
		}
		return 0f;
	}
}
