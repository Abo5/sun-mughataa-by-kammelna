using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class BurnCardAnimation : MonoBehaviour, ICustomPlayAnimation
{
	private sealed class <>c__DisplayClass27_0
	{
		public SpriteRenderer card;

		public BurnCardAnimation <>4__this;

		public Transform playedCardTransform;

		internal void <StartAnimation>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object sortingLayerName = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
			card.sortingLayerName = (string)sortingLayerName;
		}

		internal void <StartAnimation>b__1()
		{
			//IL_005a: Expected O, but got I4
			BurnCardAnimation burnCardAnimation = <>4__this;
			Transform transform = burnCardAnimation.smoke.transform;
			Transform transform2 = playedCardTransform.transform;
			Vector3 position = transform2.position;
			transform.position = (Vector3)0;
			BurnCardAnimation burnCardAnimation2 = <>4__this;
			burnCardAnimation2.smoke.Play();
		}
	}

	private const string RevealedCardsLayer = "Revealed cards";

	private const string GroundCardsLayer = "Ground cards";

	private float groundScale;

	private float targetHoldScale;

	private ParticleSystem smoke;

	private float scaleDuration;

	private float moveDuration;

	private float burnDuration = (float)typeof(!!0);

	private float burnDelay;

	private AnimationCurve scaleCurve;

	private AnimationCurve movementCurve;

	private AnimationCurve rotationCurve;

	private AudioSource audioPlayer;

	private Color dimmColor;

	private Material burnCardMaterial;

	private Material _instanceMaterial;

	private SpriteRenderer _card;

	private GameAction <Action>k__BackingField;

	private readonly CardGamePlayer <TargetPlayer>k__BackingField;

	private static readonly int DissolveProperty;

	private static readonly int DimmColorProperty;

	private static readonly int MainTexProperty;

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
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_020e: Expected O, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0267: Expected O, but got I
		//IL_02c0: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_035f: Expected O, but got I
		//IL_0379: Expected O, but got I4
		//IL_0396: Expected O, but got I
		//IL_03aa: Expected I4, but got O
		//IL_03c7: Expected O, but got I
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_044f: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_0922: Expected O, but got I
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_0956: Expected O, but got I
		//IL_0970: Expected O, but got I4
		//IL_0486: Expected O, but got I4
		//IL_04b1: Expected O, but got I
		//IL_04c9: Expected O, but got I4
		//IL_08e1: Expected O, but got I
		//IL_0519: Expected O, but got I
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_0539: Expected O, but got I
		//IL_0545: Expected O, but got I
		//IL_0551: Expected O, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I4
		//IL_04e8: Expected O, but got I4
		//IL_099e: Expected O, but got I
		//IL_09ba: Expected I4, but got O
		//IL_0610: Expected I, but got O
		//IL_063c: Expected O, but got I
		//IL_064c: Expected O, but got I
		//IL_067a: Expected O, but got I4
		//IL_067a: Expected O, but got I
		//IL_068a: Expected O, but got I
		//IL_06af: Expected O, but got I
		//IL_06c0: Expected I, but got O
		//IL_06d1: Expected O, but got I
		//IL_06fa: Expected O, but got I4
		//IL_06fa: Expected O, but got I
		//IL_071e: Expected O, but got I
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_0747: Expected I, but got O
		//IL_07d1: Expected O, but got I4
		//IL_09e3: Expected O, but got I
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected O, but got Unknown
		//IL_0a2b: Expected O, but got I4
		//IL_07f1: Expected O, but got I
		//IL_0884: Expected I, but got O
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Transform transform = ((Component)obj3).transform;
		object obj6 = obj2 + 32;
		obj6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v15+E4]");
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
		IL_08c9:
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v21+B8]");
		object obj11 = 0;
		float num = UnityEngine.Random.Range(-12f, 12f);
		GameSoundManager instance = GameSoundManager.Instance;
		object obj12 = (nint)0 + (nint)2752;
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj14 = (nint)0 + (nint)1688;
		object obj15 = (nint)0 + (nint)2592;
		object obj16 = (nint)0 + (nint)2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v22+48]");
		object obj18 = default(object);
		object obj17 = 0 * obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v22+50]");
		float num2 = 0f * num;
		object obj19;
		float duration = (float)obj19 + (float)obj17;
		object obj20;
		float num3 = (float)obj20 + num2;
		instance.PlaySound(GameSoundEffect.CARD, withDelay: false);
		object obj22;
		object obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v47+E4]");
		bool flag3 = (nint)0 == 0;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v47+B8]");
		object obj24 = 0;
		object obj25;
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat((Material)obj25, 1f, (int)obj24, burnDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(audioPlayer, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058770");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Object)+20]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale((Transform)0, targetHoldScale, scaleDuration);
		object obj26 = (nint)0 + (nint)2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Object)+20]");
		float duration2 = default(float);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOMove((Transform)0, (Vector3)0, duration2);
		object obj27 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)1984;
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj28);
		object obj29 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Object)+20]");
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore4 = ShortcutExtensions.DOLocalRotate((Transform)0, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		object obj30 = (nint)0 + (nint)1992;
		object obj31 = default(object);
		object a = obj31 + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback3 = default(TweenCallback);
		tweenCallback3..ctor(obj2, (IntPtr)obj30);
		Delegate obj32 = Delegate.Combine((Delegate)a, tweenCallback3);
		if ((object)obj32 != null)
		{
			if (obj32 == obj13)
			{
				a = obj32;
				if (obj32 == obj13)
				{
					goto IL_09d7;
				}
			}
			throw new InvalidCastException();
		}
		a = 0;
		goto IL_09d7;
		IL_04f2:
		_ = 1;
		object obj33;
		obj20 = obj33;
		object obj34;
		obj19 = obj34;
		goto IL_08c9;
		IL_09d7:
		object obj35 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj36 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v75+E4]");
		bool flag4 = (nint)0 == 0;
		object obj38 = !flag4;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj39 = (nint)0 + (nint)1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGameVisualControls cardGameVisualControls = default(CardGameVisualControls);
		bool flag5 = (object)cardGameVisualControls == null;
		bool flag6 = false;
		KPlayer kPlayer = null;
		SpriteRenderer spriteRenderer = (SpriteRenderer)(object)obj32;
		if (!flag5)
		{
			spriteRenderer = (SpriteRenderer)obj3;
			kPlayer = userbox.<player>k__BackingField;
			cardGameVisualControls.CardCollisionAnim((SpriteRenderer)obj3, userbox.<player>k__BackingField, isEventFromServer: false);
			flag6 = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback4 = default(TweenCallback);
		tweenCallback4..ctor(this, (IntPtr)obj39);
		object obj41 = default(object);
		object obj40 = obj41 + 128;
		obj40 = tweenCallback4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00f8:
		bool flag7 = (object)startPlacement == null;
		object obj42 = !flag7;
		transform3 = startPlacement;
		if (obj42 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_018b;
		IL_018b:
		Vector3 position = transform3.position;
		object obj43 = this + 128;
		obj43 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = ((Component)obj3).gameObject;
		gameObject.SetActive(value: true);
		object sortingLayerName = "Read object reference Id '{0}' for {1}." + 3096;
		((Renderer)obj3).sortingLayerName = (string)sortingLayerName;
		((Transform)obj6).position = (Vector3)0;
		object obj44 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		obj22 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3680;
		obj10 = typeof(UsageHint) + 816;
		object obj45 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v9+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v10+14]");
		float num4 = 0f * groundScale;
		float num5 = groundScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v10+10]");
		float num6 = num5 * 0f;
		float num7 = groundScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v10+C]");
		float num8 = num7 * 0f;
		((Transform)obj6).localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material = default(Material);
		material..ctor(burnCardMaterial);
		obj25 = this + 120;
		obj25 = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj47 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v32+E4]");
		bool flag8 = (nint)0 == 0;
		object obj48 = !flag8;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj49 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v12+B8]");
		object obj50 = 0;
		object obj51 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v13+4]");
		((Material)obj51).SetColor(0, (Color)0);
		object obj52 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v14+B8]");
		object obj53 = 0;
		_instanceMaterial.SetFloat((int)obj53, 0f);
		object obj54 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v16+B8]");
		object obj55 = 0;
		Sprite sprite = ((SpriteRenderer)obj3).sprite;
		Texture2D texture = sprite.texture;
		object obj56 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v17+8]");
		((Material)obj56).SetTexture(0, (Texture)texture);
		object materialProperty = "_InputUv1BufferOffset" + 3072;
		((Renderer)obj3).material = (Material)obj25;
		SpriteExensions.SetAtlasRectInfo((SpriteRenderer)obj3, isSharedMaterial: true, (string)materialProperty);
		object obj57 = userbox.direction - 1;
		bool flag9 = (nint)obj57 < 3;
		object obj58 = !flag9;
		if (obj58 == null)
		{
			object obj59 = 119873536 + 4080;
			object obj60 = obj59 + obj57;
			obj33 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CB]");
			object obj61 = (nint)0 & (nint)1;
			bool flag10 = obj61 == null;
			obj34 = 0;
			if (flag10)
			{
				goto IL_04f2;
			}
			obj20 = obj60;
			obj19 = 0;
		}
		else
		{
			object obj62 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v43+B8]");
			object obj63 = 0;
			obj34 = obj63;
			object obj64 = obj63 + 8;
			obj33 = obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CB]");
			object obj65 = (nint)0 & (nint)1;
			bool flag11 = obj65 == null;
			object obj66 = !flag11;
			obj20 = obj64;
			obj19 = obj63;
			if (obj66 == null)
			{
				goto IL_04f2;
			}
		}
		goto IL_08c9;
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

	static BurnCardAnimation()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0089: Expected O, but got I
		//IL_0091: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_005e: Expected O, but got I
		object obj = "[{0}]:{1}" + 2888;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3680;
		object obj3 = "[{0}]:{1}" + 2856;
		object obj4 = "_InputUv1BufferOffset" + 688;
		int num = Shader.PropertyToID((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+B8]");
		object obj6 = 0;
		obj6 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+B8]");
		object obj8 = 0;
		int num3 = Shader.PropertyToID((string)obj4);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+B8]");
		object obj10 = 0;
	}
}
