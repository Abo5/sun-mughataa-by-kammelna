using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class StealBurnCardAnimation : MonoBehaviour, ICustomPlayAnimation
{
	private sealed class <>c__DisplayClass30_0
	{
		public Transform playedCard;

		public Vector3 targetPosition2;

		public StealBurnCardAnimation <>4__this;

		public SpriteRenderer card;

		public Vector3 targetRotation;

		public TweenCallback <>9__2;

		public TweenCallback <>9__3;

		public TweenCallback <>9__4;

		internal void <StartAnimation>b__0()
		{
			//IL_0033: Expected O, but got I
			//IL_003f: Expected O, but got I
			//IL_004b: Expected O, but got I
			//IL_0057: Expected O, but got I
			//IL_008b: Expected F4, but got O
			//IL_008b: Expected O, but got I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00d5: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_0402: Expected F4, but got O
			//IL_0402: Expected O, but got I4
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_0116: Expected O, but got I
			//IL_0124: Expected I, but got O
			//IL_016e: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_01b1: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01e9: Expected O, but got I
			//IL_01f7: Expected I, but got O
			//IL_0219: Expected O, but got I4
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected O, but got Unknown
			//IL_0289: Expected O, but got I4
			//IL_02c8: Expected O, but got I
			//IL_02ec: Expected I4, but got O
			//IL_030b: Expected O, but got I
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Expected O, but got Unknown
			//IL_0342: Expected O, but got I4
			//IL_043a: Expected O, but got I
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_046e: Expected O, but got I
			//IL_0481: Expected I, but got O
			//IL_03c3: Expected O, but got I
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected O, but got Unknown
			//IL_037a: Expected O, but got I
			//IL_0388: Expected I, but got O
			//IL_03aa: Expected O, but got I4
			GameSoundManager instance = GameSoundManager.Instance;
			instance.PlaySound(GameSoundEffect.CARD, withDelay: false);
			StealBurnCardAnimation stealBurnCardAnimation = <>4__this;
			object obj = (nint)0 + (nint)2776;
			object obj2 = (nint)0 + (nint)2904;
			object obj3 = (nint)0 + (nint)2504;
			object obj4 = (nint)0 + (nint)2744;
			double num = (double)stealBurnCardAnimation.moveDuration * 0.5;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMove(playedCard, (Vector3)0, (float)targetPosition2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj5 = this + 72;
			TweenCallback tweenCallback = (TweenCallback)obj5;
			bool flag = obj5 == null;
			object obj6 = !flag;
			object obj7 = 0;
			if (obj6 == null)
			{
				object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)1232;
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(this, (IntPtr)obj9);
				<>9__2 = tweenCallback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj7 = 0;
				tweenCallback = tweenCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(playedCard, (Vector3)1, (float)targetRotation);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			StealBurnCardAnimation stealBurnCardAnimation2 = <>4__this;
			object obj10 = (nint)0 + (nint)2840;
			object obj11 = (nint)0 + (nint)2472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
			object obj12 = this + 80;
			TweenCallback tweenCallback3 = (TweenCallback)obj12;
			bool flag2 = obj12 == null;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = (nint)0 + (nint)1240;
				TweenCallback tweenCallback4 = default(TweenCallback);
				tweenCallback4..ctor(this, (IntPtr)obj15);
				<>9__3 = tweenCallback4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj7 = 0;
				tweenCallback3 = tweenCallback4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			StealBurnCardAnimation stealBurnCardAnimation3 = <>4__this;
			if (stealBurnCardAnimation3.burn)
			{
				object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1888;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj18 = !flag3;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					stealBurnCardAnimation3 = <>4__this;
				}
				object obj19 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X9_v6+B8]");
				object obj20 = 0;
				TweenerCore<float, float, FloatOptions> tweenerCore3 = ShortcutExtensions.DOFloat(stealBurnCardAnimation3._instanceMaterial, 1f, (int)obj20, stealBurnCardAnimation3.burnDuration);
				StealBurnCardAnimation stealBurnCardAnimation4 = <>4__this;
				object obj21 = (nint)0 + (nint)2752;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				object obj22 = this + 88;
				TweenCallback tweenCallback5 = (TweenCallback)obj22;
				bool flag4 = obj22 == null;
				object obj23 = !flag4;
				if (obj23 == null)
				{
					object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj25 = (nint)0 + (nint)1248;
					TweenCallback tweenCallback6 = default(TweenCallback);
					tweenCallback6..ctor(this, (IntPtr)obj25);
					<>9__4 = tweenCallback6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj7 = 0;
					tweenCallback5 = tweenCallback6;
				}
				object obj26 = (nint)0 + (nint)2592;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058770");
				object obj27 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj28 = (nint)0 + (nint)3928;
				TweenCallback tweenCallback7 = default(TweenCallback);
				tweenCallback7..ctor(<>4__this, (IntPtr)obj28);
				object obj29 = (nint)0 + (nint)2480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			}
		}

		internal void <StartAnimation>b__2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object sortingLayerName = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
			card.sortingLayerName = (string)sortingLayerName;
		}

		internal void <StartAnimation>b__3()
		{
			//IL_007f: Expected O, but got I4
			StealBurnCardAnimation stealBurnCardAnimation = <>4__this;
			if (stealBurnCardAnimation.burn)
			{
				Transform transform = stealBurnCardAnimation.smoke.transform;
				Transform transform2 = playedCard.transform;
				Vector3 position = transform2.position;
				transform.position = (Vector3)0;
				StealBurnCardAnimation stealBurnCardAnimation2 = <>4__this;
				stealBurnCardAnimation2.smoke.Play();
			}
		}

		internal void <StartAnimation>b__4()
		{
			StealBurnCardAnimation stealBurnCardAnimation = <>4__this;
			stealBurnCardAnimation.audioPlayer.PlayOneShot(stealBurnCardAnimation.burnClip);
		}

		internal void <StartAnimation>b__1()
		{
			//IL_0048: Expected O, but got I4
			StealBurnCardAnimation stealBurnCardAnimation = <>4__this;
			Transform transform = stealBurnCardAnimation.trail.transform;
			Vector3 position = playedCard.position;
			transform.position = (Vector3)0;
		}
	}

	private const string HandCardsLayer = "Hand cards";

	private const string GroundCardsLayer = "Ground cards";

	private GameAction _gameAction;

	private TrailRenderer trail;

	private ParticleSystem smoke;

	private float groundScale;

	private float targetHoldScale;

	private bool burn;

	private float burnDuration = (float)typeof(!!0);

	private float burnDelay;

	private float scaleDuration;

	private float moveDuration;

	private AnimationCurve scaleCurve;

	private AnimationCurve movementCurve;

	private AnimationCurve rotationCurve;

	private Color dimmColor;

	private Material burnCardMaterial;

	private Material _instanceMaterial;

	private AudioSource audioPlayer;

	private AudioClip burnClip;

	private SpriteRenderer _card;

	private GameAction <Action>k__BackingField;

	private readonly CardGamePlayer <TargetPlayer>k__BackingField;

	private static readonly int DissolveProperty;

	private static readonly int DimmColorProperty;

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

	public CardGamePlayer TargetPlayer => <TargetPlayer>k__BackingField;

	public void StartAnimation(SpriteRenderer card, Transform startPlacement, Userbox userbox, SpriteRenderer[] groundCards, Vector3 landingWorldPosition)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_029d: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_01fe: Expected O, but got I
		//IL_02f5: Expected O, but got I4
		//IL_0332: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0418: Expected O, but got I
		//IL_0449: Expected O, but got I4
		//IL_0a82: Expected O, but got I4
		//IL_0a9c: Expected O, but got I4
		//IL_0ab6: Expected O, but got I4
		//IL_0ae7: Expected O, but got I4
		//IL_047e: Expected O, but got I4
		//IL_0498: Expected O, but got I4
		//IL_04b9: Expected O, but got I4
		//IL_04ea: Expected O, but got I4
		//IL_0507: Expected O, but got I4
		//IL_053d: Expected O, but got I
		//IL_0555: Expected O, but got I4
		//IL_0b0d: Expected O, but got I
		//IL_0bb8: Expected O, but got I
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Expected O, but got Unknown
		//IL_0bf6: Expected O, but got I
		//IL_0c10: Expected O, but got I4
		//IL_09d8: Expected O, but got I
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected O, but got Unknown
		//IL_05a4: Expected O, but got I4
		//IL_0797: Expected O, but got I
		//IL_07a3: Expected O, but got I
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_07c3: Expected O, but got I
		//IL_07cf: Expected O, but got I
		//IL_07db: Expected O, but got I
		//IL_0803: Expected O, but got I
		//IL_084b: Expected O, but got I4
		//IL_084b: Expected O, but got I
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I4
		//IL_087e: Expected I, but got O
		//IL_0703: Expected O, but got I
		//IL_071d: Expected O, but got I4
		//IL_08a8: Expected I, but got O
		//IL_073a: Expected O, but got I
		//IL_074e: Expected I4, but got O
		//IL_08b9: Expected O, but got I
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0969: Expected O, but got I
		//IL_0992: Expected O, but got I4
		//IL_0910: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 48;
		obj4 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Transform transform = ((Component)obj4).transform;
		object obj6 = obj2 + 16;
		obj6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)startPlacement)
			{
				goto IL_00f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = startPlacement;
			bool flag2 = !flag;
			object obj8 = !flag2;
			if (obj8 != null)
			{
				goto IL_00f8;
			}
		}
		Transform transform2 = userbox.transform;
		Transform transform3 = transform2;
		goto IL_018b;
		IL_05f6:
		_ = 1;
		double num2;
		double num = num2;
		double num4;
		double num3 = num4;
		double num6;
		double num5 = num6;
		double num8;
		double num7 = num8;
		float num10;
		float num9 = num10;
		Vector3 vector2;
		Vector3 vector = vector2;
		object obj10;
		object obj9 = obj10;
		object obj12;
		object obj11 = obj12;
		goto IL_09c0;
		IL_0322:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v20+B8]");
		object obj13 = 0;
		Userbox nextPlayerUserbox = ((AnimatedItemController)obj13).GetNextPlayerUserbox((KPlayer)userbox.<player>k__BackingField);
		Transform transform4 = nextPlayerUserbox.transform;
		Vector3 position = transform4.position;
		object obj14 = this + 160;
		obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = ((Component)obj4).gameObject;
		gameObject.SetActive(value: true);
		object sortingLayerName = "HH:mm:ss.ffZ" + 656;
		((Renderer)obj4).sortingLayerName = (string)sortingLayerName;
		((Transform)obj6).position = (Vector3)0;
		object obj15 = typeof(UsageHint) + 816;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v12+B8]");
		object obj17 = 0;
		num2 = groundScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v13+14]");
		num4 = 0.0 * (double)groundScale;
		((Transform)obj6).localScale = (Vector3)0;
		object obj18;
		double num11 = default(double);
		double num12 = default(double);
		double num13 = default(double);
		if (userbox.direction != Userbox.UserBoxDirection.Bottom)
		{
			obj18 = userbox.direction - 1;
			bool flag3 = (nint)obj18 < 3;
			object obj19 = !flag3;
			num6 = num11;
			num8 = num12;
			num10 = (float)num13;
			vector2 = (Vector3)0;
			num = num2;
			num3 = num4;
			num5 = num11;
			num7 = num12;
			num9 = (float)num13;
			vector = (Vector3)0;
			if (obj19 == null)
			{
				goto IL_04f8;
			}
		}
		else
		{
			bool isMe = userbox.<player>k__BackingField.IsMe;
			bool flag4 = !isMe;
			num6 = num11;
			num8 = num12;
			double num14 = num13;
			if (!flag4)
			{
				object obj20 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v55+B8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v56+18]");
				double num15 = 0.0 * 10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v56+1C]");
				double num16 = 0.0 * 10.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v56+20]");
				num4 = 0.0 * 10.0;
				num14 = num13 + num15;
				num8 = num12 + num16;
				num6 = num11 + num4;
				num2 = 10.0;
			}
			obj18 = userbox.direction - 1;
			bool flag5 = (nint)obj18 < 3;
			object obj22 = !flag5;
			object obj23 = ~obj22;
			num10 = (float)num14;
			vector2 = (Vector3)0;
			num = num2;
			num3 = num4;
			num5 = num6;
			num7 = num8;
			num9 = (float)num14;
			vector = (Vector3)0;
			if (obj23 != null)
			{
				goto IL_04f8;
			}
		}
		object obj24 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v45+B8]");
		object obj25 = 0;
		obj12 = obj25;
		object obj26 = obj25 + 8;
		obj10 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CB]");
		object obj27 = (nint)0 & (nint)1;
		bool flag6 = obj27 == null;
		object obj28 = !flag6;
		num2 = num;
		num4 = num3;
		num6 = num5;
		num8 = num7;
		num10 = num9;
		vector2 = vector;
		obj9 = obj26;
		obj11 = obj25;
		if (obj28 == null)
		{
			goto IL_05f6;
		}
		goto IL_09c0;
		IL_0250:
		bool flag7 = (object)userbox == null;
		object obj29 = !flag7;
		if (obj29 != null)
		{
			goto IL_0322;
		}
		goto IL_09a1;
		IL_00f8:
		bool flag8 = (object)startPlacement == null;
		object obj30 = !flag8;
		transform3 = startPlacement;
		if (obj30 != null)
		{
			goto IL_018b;
		}
		goto IL_09a1;
		IL_018b:
		object obj31 = typeof(SqlSingle[]) + 3832;
		Vector3 position2 = transform3.position;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj33 = (nint)0 & (nint)1;
			if (obj33 != null)
			{
				goto IL_021b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj34 = (nint)0 & (nint)1;
			bool flag9 = obj34 == null;
			object obj35 = !flag9;
			if (obj35 != null)
			{
				goto IL_021b;
			}
		}
		_ = 1;
		object obj36 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj37 = !flag10;
		object obj38 = obj36;
		if (obj37 != null)
		{
			goto IL_0250;
		}
		goto IL_030b;
		IL_04f8:
		object obj39 = 119873536 + 4080;
		object obj40 = obj39 + obj18;
		obj10 = obj40;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CB]");
		object obj41 = (nint)0 & (nint)1;
		bool flag11 = obj41 == null;
		obj12 = 0;
		if (flag11)
		{
			goto IL_05f6;
		}
		num = num2;
		num3 = num4;
		num5 = num6;
		num7 = num8;
		num9 = num10;
		vector = vector2;
		obj9 = obj40;
		obj11 = 0;
		goto IL_09c0;
		IL_09a1:
		throw new NullReferenceException();
		IL_09c0:
		object obj42 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v16+B8]");
		object obj43 = 0;
		float num17 = UnityEngine.Random.Range(-12f, 12f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v17+48]");
		object obj45 = default(object);
		object obj44 = 0 * obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v17+50]");
		float num18 = 0f * num17;
		object obj46 = obj11 + obj44;
		float num19 = (float)obj9 + num18;
		bool flag12 = !burn;
		Userbox userbox2 = userbox;
		if (!flag12)
		{
			object obj47 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Material material = default(Material);
			material..ctor(burnCardMaterial);
			object obj48 = this + 136;
			obj48 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj49 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1888;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v64+E4]");
			bool flag13 = (nint)0 == 0;
			object obj51 = !flag13;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj52 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v34+B8]");
			object obj53 = 0;
			object obj54 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v35+4]");
			((Material)obj54).SetColor(0, (Color)0);
			object obj55 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v36+B8]");
			object obj56 = 0;
			_instanceMaterial.SetFloat((int)obj56, 0f);
			((Renderer)obj4).material = (Material)obj48;
			object materialProperty = "_InputUv1BufferOffset" + 3072;
			SpriteExensions.SetAtlasRectInfo((SpriteRenderer)obj4, isSharedMaterial: true, (string)materialProperty);
			userbox2 = null;
		}
		object obj57 = (nint)0 + (nint)2896;
		object obj58 = (nint)0 + (nint)2904;
		object obj59 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj60 = (nint)0 + (nint)1216;
		object obj61 = (nint)0 + (nint)2504;
		object obj62 = (nint)0 + (nint)1224;
		audioPlayer.Play();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Object)+10]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale((Transform)0, targetHoldScale, scaleDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		double num20 = (double)moveDuration * 0.25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Object)+10]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOMove((Transform)0, (Vector3)0, num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj60);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj62);
		object obj63 = (nint)0 + (nint)2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30587F0");
		object obj64 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj65 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v52+E4]");
		CardGameVisualControls cardGameVisualControls = default(CardGameVisualControls);
		if ((nint)0 != 0)
		{
			object obj66 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			if ((object)cardGameVisualControls == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj67 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			bool flag14 = (object)cardGameVisualControls == null;
			object obj68 = !flag14;
			if (obj68 == null)
			{
				return;
			}
		}
		cardGameVisualControls.CardCollisionAnim((SpriteRenderer)obj4, userbox.<player>k__BackingField, isEventFromServer: false);
		return;
		IL_021b:
		obj36 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v20+E4]");
		bool flag15 = (nint)0 == 0;
		obj38 = obj36;
		if (!flag15)
		{
			goto IL_0250;
		}
		goto IL_030b;
		IL_030b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj36 = obj31;
		goto IL_0322;
	}

	private void OnBurnEffectCompleted()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		_card.color = (Color)0;
		GameObject obj2 = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj2);
	}

	static StealBurnCardAnimation()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0064: Expected O, but got I4
		//IL_0089: Expected O, but got I
		object obj = "[{0}]:{1}" + 2888;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1888;
		object obj3 = "[{0}]:{1}" + 2856;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+B8]");
		object obj5 = 0;
		obj5 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+B8]");
		object obj7 = 0;
	}
}
