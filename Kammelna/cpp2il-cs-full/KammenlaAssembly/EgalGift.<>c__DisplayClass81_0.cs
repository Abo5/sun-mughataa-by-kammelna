using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UI.Popups;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class EgalGift : MonoBehaviour, IAnimatedGift
{
	private sealed class <>c__DisplayClass73_0
	{
		public FakeDynamicShadowUI shadow;

		internal float <DoShadow>b__0()
		{
			FakeDynamicShadowUI fakeDynamicShadowUI = shadow;
			return fakeDynamicShadowUI.height;
		}

		internal void <DoShadow>b__1(float h)
		{
			FakeDynamicShadowUI fakeDynamicShadowUI = shadow;
			fakeDynamicShadowUI.height = h;
		}
	}

	private sealed class <>c__DisplayClass74_0
	{
		public EgalGift <>4__this;

		public AudioClip clip;

		public float volume;

		internal void <PlayAudio>b__0()
		{
			EgalGift egalGift = <>4__this;
			egalGift.audioSource.PlayOneShot(clip, volume);
		}
	}

	private sealed class <>c__DisplayClass80_0
	{
		public bool visible;

		internal void <SetBackCardVisibility>b__0(SpriteRenderer c)
		{
			GameObject gameObject = c.gameObject;
			gameObject.SetActive(visible);
		}
	}

	private sealed class <>c__DisplayClass81_0
	{
		public float bottomHeight;

		public EgalGift <>4__this;

		internal float <OnAnimationEventCallback>b__3()
		{
			//IL_0071: Invalid comparison between F8 and I4
			//IL_0080: Invalid comparison between F8 and I4
			//IL_0098: Expected O, but got F8
			//IL_00a5: Expected O, but got F8
			//IL_00da: Expected O, but got I4
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0141: Invalid comparison between F4 and I4
			//IL_0126: Expected F4, but got I4
			EgalGift egalGift = <>4__this;
			Transform transform = egalGift.egal.transform;
			Vector3 position = transform.position;
			object obj = default(object);
			float num = (float)obj - bottomHeight;
			float num2 = num / 1.1204035E+09f;
			double num3 = (double)num2 - 1.0;
			bool flag = num3 < 0.0;
			bool flag2 = num3 == 0.0;
			object obj2 = (double)num2 ^ 1.0;
			object obj3 = (double)num2 ^ num3;
			object obj4 = obj2 & obj3;
			bool flag3 = (nint)obj4 < 0;
			bool flag4 = flag == flag3;
			object obj5 = !flag2;
			object obj6 = flag4 & obj5;
			object obj7 = ~obj6;
			double num4 = ((obj7 != null) ? ((double)num2) : 1.0);
			if (num2 < 0f)
			{
				return 0f;
			}
			return (float)num4;
		}
	}

	private Userbox senderUserBox;

	private Userbox receiverUserBox;

	private Animator shemagAnimator;

	private Animator egalAnimator;

	private Animator egalShadowAnimator;

	private Transform egal;

	private SpriteRenderer shemagRenderer;

	private SpriteRenderer singleShemagRenderer;

	private SpriteRenderer shemagShadowRenderer;

	private FakeDynamicShadowUI egalShadow;

	private FakeDynamicShadowUI shemagShadow;

	private TrailRenderer trail;

	private ParticleSystem hitEffect;

	private ParticleSystem dizzyFlowEffect;

	private Transform dizzyStars;

	private ParticleSystem vanishFlowEffect;

	private float maxLifeTime;

	private float travelDuration;

	private float egalStartDuration;

	private float shemagPullDelay;

	private float shemagStartScale;

	private AnimationCurve egalMotionCurve;

	private AnimationCurve egalShadowCurve;

	private AnimationCurve hitCurve;

	private AnimationCurve finalHitCurve;

	private AudioSource audioSource;

	private AudioClip shemagDropClip;

	private AudioClip egalMoveClip;

	private AudioClip egalHitClip;

	private AudioClip shemagPullClip;

	private Material defaultMaterial;

	private Material wigglyMaterial;

	private readonly Vector3 <startPosition>k__BackingField;

	private readonly Vector3 <targetPosition>k__BackingField;

	private bool <allowClearing>k__BackingField;

	private bool <affectCards>k__BackingField;

	private bool _isCleared;

	private Vector3 egalHoldPosition;

	private Vector3 cardHolderScale;

	private Transform targetCardHolder;

	private TextMeshProUGUI targetPlayerName;

	private Material wigglyMaterialShared;

	private int egalHitCount;

	private Vector3 dizzyScale;

	private List<SpriteRenderer> frontCards;

	public Vector3 startPosition => (Vector3)this;

	public Vector3 targetPosition => (Vector3)this;

	public Userbox fromUserBox => senderUserBox;

	public Userbox toUserbox => receiverUserBox;

	public float canvasScale
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_013f: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01c5: Expected O, but got I4
			//IL_016d: Expected O, but got I
			//IL_0187: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_010f: Expected F4, but got I
			//IL_01fd: Expected O, but got I
			//IL_021f: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(SqlSingle[]) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7937]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0195;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			goto IL_0102;
			IL_0102:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+38]");
			return 0f;
			IL_01db:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj11 = 0;
			obj9 = obj11;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0102;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00b0;
			}
			goto IL_0195;
			IL_0195:
			_ = 1;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj14;
			if (obj15 != null)
			{
				goto IL_00e5;
			}
			goto IL_01db;
			IL_00b0:
			obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			obj16 = obj14;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_01db;
		}
	}

	public bool allowClearing
	{
		get
		{
			return <allowClearing>k__BackingField;
		}
		set
		{
			<allowClearing>k__BackingField = value;
		}
	}

	public bool isCleared => _isCleared;

	public bool affectCards
	{
		get
		{
			return <affectCards>k__BackingField;
		}
		set
		{
			<affectCards>k__BackingField = value;
		}
	}

	private bool isTargetMainPlayer
	{
		get
		{
			//IL_0070: Expected I4, but got O
			Userbox userbox = receiverUserBox;
			if ((object)receiverUserBox != null && userbox.<player>k__BackingField != null)
			{
				return userbox.<player>k__BackingField.IsMe;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool isSenderMainPlayer
	{
		get
		{
			//IL_0070: Expected I4, but got O
			Userbox userbox = senderUserBox;
			if ((object)senderUserBox != null && userbox.<player>k__BackingField != null)
			{
				return userbox.<player>k__BackingField.IsMe;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		ActivateElements(state: false);
	}

	public unsafe void StartAnimation()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_118c: Expected I, but got O
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0169: Expected O, but got I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0191: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_0299: Expected O, but got I
		//IL_02a7: Expected O, but got I4
		//IL_02cb: Expected O, but got F4
		//IL_02cf: Unsupported input type for neg.
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02d8: Unsupported input type for neg.
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_0373: Expected O, but got I4
		//IL_11f1: Expected O, but got I
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_1205: Expected O, but got Unknown
		//IL_121b: Expected O, but got I
		//IL_04bd: Expected O, but got I4
		//IL_03f6: Expected O, but got I
		//IL_0543: Expected O, but got I4
		//IL_04eb: Expected O, but got I
		//IL_0505: Expected O, but got I4
		//IL_0458: Expected O, but got I
		//IL_047a: Expected O, but got I4
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05bd: Expected O, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_057b: Expected O, but got I
		//IL_067a: Expected O, but got I
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_069d: Expected O, but got I4
		//IL_06b3: Expected O, but got I
		//IL_07b2: Expected O, but got I
		//IL_07c2: Expected O, but got I
		//IL_07d2: Expected O, but got I
		//IL_07e8: Expected O, but got I
		//IL_0802: Expected O, but got I4
		//IL_0812: Expected O, but got I
		//IL_0822: Expected O, but got I
		//IL_0781: Expected O, but got I4
		//IL_06e8: Expected O, but got I
		//IL_06f8: Expected O, but got I
		//IL_0708: Expected O, but got I
		//IL_071e: Expected O, but got I
		//IL_073d: Expected O, but got I
		//IL_074d: Expected O, but got I
		//IL_08b6: Expected O, but got I
		//IL_08d3: Expected O, but got I
		//IL_084e: Expected O, but got I
		//IL_1257: Expected O, but got I4
		//IL_0991: Expected O, but got I
		//IL_0976: Expected O, but got I4
		//IL_0ab8: Expected O, but got I4
		//IL_0c33: Expected O, but got I4
		//IL_09f1: Expected O, but got I
		//IL_0b3e: Expected O, but got I4
		//IL_0ae6: Expected O, but got I
		//IL_0b00: Expected O, but got I4
		//IL_0c63: Expected O, but got F8
		//IL_0a53: Expected O, but got I
		//IL_0a75: Expected O, but got I4
		//IL_0b76: Expected O, but got I
		//IL_1285: Expected O, but got I
		//IL_12de: Expected O, but got Ref
		//IL_12eb: Expected O, but got Ref
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected O, but got Unknown
		//IL_0d3b: Expected O, but got I4
		//IL_0d69: Expected F4, but got I4
		//IL_0d5b: Expected F4, but got I4
		//IL_0da5: Expected O, but got I
		//IL_0ea4: Expected O, but got I
		//IL_0eb4: Expected O, but got I
		//IL_0ec4: Expected O, but got I
		//IL_0eda: Expected O, but got I
		//IL_0ef4: Expected O, but got I4
		//IL_0f04: Expected O, but got I
		//IL_0f14: Expected O, but got I
		//IL_0e73: Expected O, but got I4
		//IL_0dda: Expected O, but got I
		//IL_0dea: Expected O, but got I
		//IL_0dfa: Expected O, but got I
		//IL_0e10: Expected O, but got I
		//IL_0e2f: Expected O, but got I
		//IL_0e3f: Expected O, but got I
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Expected O, but got Unknown
		//IL_0f7a: Expected O, but got I
		//IL_0f86: Expected O, but got I
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected O, but got Unknown
		//IL_0fc2: Expected O, but got I
		//IL_0fd8: Expected O, but got I
		//IL_1036: Expected O, but got I4
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Expected O, but got Unknown
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected O, but got Unknown
		//IL_1103: Expected O, but got I
		//IL_1149: Expected I, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v3 (Il2CppClass<EgalGift>)+250]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		Coroutine coroutine = UIExtensions.WaitForSeconds(this, maxLifeTime, action);
		Userbox userbox = receiverUserBox;
		targetCardHolder = userbox.<handRoot>k__BackingField;
		object obj4 = this + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Userbox userbox2 = receiverUserBox;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v6 (Userbox)+1A8]");
		_ = 0;
		cardHolderScale = userbox2.originalHandRootScale;
		EgalGift egalGift = default(EgalGift);
		Vector3 userBoxDirection = egalGift.GetUserBoxDirection(senderUserBox);
		object obj5 = default(object);
		bool flag = (nint)obj5 < 0;
		bool flag2 = obj5 == null;
		object obj6 = obj5 ^ obj5;
		object obj7 = obj5 & obj6;
		bool flag3 = (nint)obj7 < 0;
		object obj10;
		if (!flag)
		{
			bool flag4 = flag == flag3;
			object obj8 = !flag2;
			object obj9 = flag4 & obj8;
			if (obj9 == null)
			{
				obj10 = 146599936 + 201;
				object obj11 = obj10 & 1;
				if (obj11 == null)
				{
					goto IL_019f;
				}
				goto IL_11bb;
			}
		}
		obj10 = 146599936 + 220;
		object obj12 = obj10 & 1;
		bool flag5 = obj12 == null;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			goto IL_019f;
		}
		goto IL_11bb;
		IL_0b83:
		double num2 = 1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v73+38]");
		double num3 = num2 / 0.0;
		double num5;
		double num4 = num5 * num3;
		double num6 = 1.0;
		goto IL_0bc0;
		IL_086d:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj14;
		num6 = (double)obj14 * 1129316352.0;
		object obj15;
		object obj16;
		num3 = (double)obj15 * (double)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+30]");
		object obj17 = (nint)0 * (nint)1121058816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+34]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v32+3C]");
		object obj18 = num7 * 0;
		double num8 = num6 + (double)obj17;
		num5 = num3 + (double)obj18;
		Userbox userbox3;
		if (userbox3.direction == Userbox.UserBoxDirection.Left)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+3C]");
			num3 = 0.0 * 30.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+40]");
			num6 = 0.0 * 0.0;
			num8 += num3;
			num5 += num6;
			obj17 = 0;
		}
		bool flag6 = userbox3.direction == Userbox.UserBoxDirection.Bottom;
		object obj19 = !flag6;
		num4 = num5;
		object obj22;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7937]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				object obj21 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v121+E4]");
				if ((nint)0 != 0)
				{
					goto IL_09db;
				}
			}
			else
			{
				_ = 1;
				object obj21 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v121+E4]");
				bool flag7 = (nint)0 == 0;
				object obj23 = !flag7;
				if (obj23 != null)
				{
					goto IL_09db;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj24 = (nint)0 & (nint)1;
			bool flag8 = obj24 == null;
			object obj25 = !flag8;
			if (obj25 != null)
			{
				goto IL_0a0e;
			}
			goto IL_0b0e;
		}
		goto IL_0bc0;
		IL_0a43:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v127+B8]");
		object obj26 = 0;
		object obj27 = obj26;
		bool flag9 = obj26 == null;
		object obj28 = !flag9;
		if (obj28 != null)
		{
			goto IL_0b83;
		}
		goto IL_1170;
		IL_019f:
		obj10 = 1;
		goto IL_11bb;
		IL_11bb:
		Userbox userbox4 = senderUserBox;
		object obj29 = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		if (userbox4.<player>k__BackingField.IsMe)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		Transform transform = shemagAnimator.transform;
		Transform transform2 = senderUserBox.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num9 = maxLifeTime * 0f;
		transform.position = (Vector3)0;
		Transform transform3 = shemagAnimator.transform;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v16+B8]");
		object obj31 = 0;
		transform3.localScale = (Vector3)0;
		Transform transform4 = shemagAnimator.transform;
		object obj32 = 0f - maxLifeTime;
		object obj33 = 0 - obj5;
		object obj35 = default(object);
		object obj34 = 0 - obj35;
		transform4.up = (Vector3)0;
		object obj36 = (nint)0 + (nint)2904;
		Transform target = shemagAnimator.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 55f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		shemagRenderer.enabled = true;
		_ = 1065353216;
		Transform transform5 = shemagShadow.transform;
		transform5.up = (Vector3)0;
		singleShemagRenderer.enabled = false;
		Transform transform6 = receiverUserBox.transform;
		Vector3 position2 = transform6.position;
		object obj37 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v24+B8]");
		object obj38 = 0;
		obj22 = typeof(SqlSingle[]) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7937]");
		object obj39 = (nint)0 & (nint)1;
		if (obj39 != null)
		{
			object obj40 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v153+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03e0;
			}
		}
		else
		{
			_ = 1;
			object obj40 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v153+E4]");
			bool flag10 = (nint)0 == 0;
			object obj41 = !flag10;
			if (obj41 != null)
			{
				goto IL_03e0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj42 = (nint)0 & (nint)1;
		bool flag11 = obj42 == null;
		object obj43 = !flag11;
		if (obj43 != null)
		{
			goto IL_0413;
		}
		goto IL_0513;
		IL_1170:
		throw new NullReferenceException();
		IL_0bc0:
		Transform transform7 = dizzyFlowEffect.transform;
		Transform transform8 = receiverUserBox.transform;
		Vector3 position3 = transform8.position;
		object obj45 = default(object);
		object obj44 = obj45 + obj17;
		double num10 = num4 + num6;
		double num11 = num8 + num3;
		transform7.position = (Vector3)0;
		Transform transform9 = dizzyFlowEffect.transform;
		Vector3 localScale = transform9.localScale;
		dizzyScale = (Vector3)num11;
		ParticleSystem.MainModule main = vanishFlowEffect.main;
		object obj46 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X8_v40+B8]");
		object obj47 = 0;
		Vector3 userBoxDirection2 = ((EgalGift)main).GetUserBoxDirection(senderUserBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @513A294");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v41+24]");
		float constant = 0f * 3.1634867E+09f;
		ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(constant);
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
		ParticleSystem.MinMaxCurve minMaxCurve2 = default(ParticleSystem.MinMaxCurve);
		((ParticleSystem.MainModule*)mainModule)->startRotation = (ParticleSystem.MinMaxCurve)(&minMaxCurve2);
		trail.emitting = false;
		Userbox userbox5 = receiverUserBox;
		object obj48 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		bool isMe = userbox5.<player>k__BackingField.IsMe;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material = default(Material);
		material..ctor(wigglyMaterial);
		wigglyMaterialShared = material;
		object obj49 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj50 = "_InputUv1BufferOffset" + 960;
		bool flag12 = !isMe;
		object obj51 = !flag12;
		object obj52 = ~obj51;
		float num12 = ((obj52 != null) ? 0f : 1.06199776E+09f);
		wigglyMaterialShared.SetFloat((string)obj50, num12);
		Transform transform10 = egalAnimator.transform;
		Vector3 position4 = transform10.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C9]");
		object obj53 = (nint)0 & (nint)1;
		object obj56;
		object obj57;
		object obj59;
		object obj60;
		if (obj53 != null)
		{
			object obj54 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X8_v67+B8]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v68+20]");
			obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v68+18]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D7]");
			object obj58 = (nint)0 & (nint)1;
			bool flag13 = obj58 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v68+18]");
			obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v68+20]");
			obj60 = 0;
			if (!flag13)
			{
				goto IL_0e4d;
			}
		}
		else
		{
			_ = 1;
			object obj61 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X8_v63+B8]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v64+20]");
			obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v64+18]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D7]");
			object obj63 = (nint)0 & (nint)1;
			bool flag14 = obj63 == null;
			object obj64 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v64+18]");
			obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v64+20]");
			obj60 = 0;
			if (obj64 != null)
			{
				goto IL_0e4d;
			}
		}
		_ = 1;
		Component component = egalAnimator;
		obj57 = obj59;
		obj56 = obj60;
		goto IL_0f47;
		IL_09db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj65 = (nint)0 & (nint)1;
		if (obj65 != null)
		{
			goto IL_0a0e;
		}
		goto IL_0b0e;
		IL_0e4d:
		component = egalAnimator;
		bool flag15 = (object)egalAnimator == null;
		object obj66 = !flag15;
		if (obj66 != null)
		{
			goto IL_0f47;
		}
		goto IL_1170;
		IL_0f47:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num13 = (float)obj57 * num12;
		object obj67 = obj56 * 1108082688;
		object obj68 = (nint)0 + (nint)2896;
		object obj69 = (nint)0 + (nint)2856;
		float num14 = num12 + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v41+2C]");
		object obj70 = 0 + obj67;
		object obj71 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v54+B8]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ X8_v55+3C]");
		object obj73 = (nint)0 * (nint)0;
		float duration = num14 + (float)obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ X8_v55+44]");
		double num15 = 0.0 * 15.0;
		double num16 = (double)obj70 + num15;
		Transform target2 = component.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOMove(target2, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		EgalGift egalGift2 = default(EgalGift);
		TweenerCore<float, float, FloatOptions> tweenerCore3 = egalGift2.DoShadow(egalShadow, 1f, egalStartDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		EgalGift egalGift3 = default(EgalGift);
		TweenerCore<float, float, FloatOptions> tweenerCore4 = egalGift3.DoShadow(shemagShadow, 0f, 0.2f);
		ActivateElements(state: true);
		object trigger = "AvailableVoices" + 1480;
		egalAnimator.SetTrigger((string)trigger);
		egalShadowAnimator.SetTrigger((string)trigger);
		object obj74 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj75 = (nint)0 + (nint)304;
		egalShadowAnimator.SetTrigger((string)trigger);
		PlayAudio(shemagDropClip);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj75);
		BlurLayersManager.OnPopupVisibilityChanged += action2;
		bool isBlurActive = BlurLayersManager.IsBlurActive;
		OnPopupVisibilityChanged(isBlurActive);
		return;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj76 = (nint)0 & (nint)1;
		if (obj76 != null)
		{
			goto IL_0413;
		}
		goto IL_0513;
		IL_0513:
		_ = 1;
		object obj77 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v159+E4]");
		bool flag16 = (nint)0 == 0;
		object obj78 = !flag16;
		object obj79 = obj77;
		if (obj78 != null)
		{
			goto IL_0448;
		}
		goto IL_0559;
		IL_0413:
		obj77 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v159+E4]");
		bool flag17 = (nint)0 == 0;
		obj79 = obj77;
		if (!flag17)
		{
			goto IL_0448;
		}
		goto IL_0559;
		IL_0559:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj80 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v147+B8]");
		object obj81 = 0;
		object obj82 = obj81;
		goto IL_0588;
		IL_0448:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v159+B8]");
		object obj83 = 0;
		obj82 = obj83;
		bool flag18 = obj83 == null;
		object obj84 = !flag18;
		if (obj84 != null)
		{
			goto IL_0588;
		}
		goto IL_1170;
		IL_0588:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v25+18]");
		object obj85 = 0 * obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v25+20]");
		object obj86 = (nint)0 * (nint)1130758144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v27+38]");
		object obj87 = obj86 / 0;
		object obj88 = obj34 + obj87;
		object obj89 = this + 300;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v27+38]");
		object obj90 = obj85 / 0;
		object obj91 = obj32 + obj90;
		obj89 = obj91;
		Transform transform11 = egalAnimator.transform;
		Transform transform12 = shemagAnimator.transform;
		Vector3 position5 = transform12.position;
		object obj92 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v31+B8]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v32+3C]");
		obj16 = obj91 + 0;
		transform11.position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C9]");
		object obj94 = (nint)0 & (nint)1;
		object obj98;
		object obj99;
		object obj96;
		if (obj94 != null)
		{
			object obj95 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v105+B8]");
			obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+18]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+1C]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0DC]");
			object obj97 = (nint)0 & (nint)1;
			bool flag19 = obj97 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+1C]");
			obj98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+18]");
			obj99 = 0;
			if (!flag19)
			{
				goto IL_075b;
			}
		}
		else
		{
			_ = 1;
			object obj100 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X8_v101+B8]");
			obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+18]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+1C]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0DC]");
			object obj101 = (nint)0 & (nint)1;
			bool flag20 = obj101 == null;
			object obj102 = !flag20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+1C]");
			obj98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+18]");
			obj99 = 0;
			if (obj102 != null)
			{
				goto IL_075b;
			}
		}
		_ = 1;
		object obj103 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v98+B8]");
		obj96 = 0;
		userbox3 = receiverUserBox;
		obj15 = obj98;
		obj14 = obj99;
		goto IL_086d;
		IL_0b54:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj104 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v115+B8]");
		object obj105 = 0;
		obj27 = obj105;
		goto IL_0b83;
		IL_0a0e:
		object obj106 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v127+E4]");
		bool flag21 = (nint)0 == 0;
		object obj107 = obj106;
		if (!flag21)
		{
			goto IL_0a43;
		}
		goto IL_0b54;
		IL_0b0e:
		_ = 1;
		obj106 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v127+E4]");
		bool flag22 = (nint)0 == 0;
		object obj108 = !flag22;
		obj107 = obj106;
		if (obj108 != null)
		{
			goto IL_0a43;
		}
		goto IL_0b54;
		IL_075b:
		userbox3 = receiverUserBox;
		bool flag23 = (object)receiverUserBox == null;
		object obj109 = !flag23;
		if (obj109 != null)
		{
			goto IL_086d;
		}
		goto IL_1170;
	}

	private void OnPopupVisibilityChanged(bool visible)
	{
		//IL_0071: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		Transform transform2;
		if (visible)
		{
			Transform transform = dizzyFlowEffect.transform;
			transform.localScale = (Vector3)0;
			transform2 = dizzyStars;
		}
		else
		{
			Transform transform3 = dizzyFlowEffect.transform;
			transform3.localScale = (Vector3)0;
			transform2 = dizzyStars;
		}
		transform2.localScale = (Vector3)0;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		BlurLayersManager.OnPopupVisibilityChanged -= action;
	}

	private Vector3 GetUserBoxDirection(Userbox userbox)
	{
		//IL_006a: Expected O, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_028f: Expected O, but got I
		//IL_02a9: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I
		//IL_02ef: Expected O, but got I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0338: Expected O, but got I
		//IL_0348: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_03ac: Expected O, but got I
		//IL_03bc: Expected O, but got I
		//IL_01f9: Invalid comparison between O and F8
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0424: Expected O, but got I4
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_0897: Expected O, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0575: Invalid comparison between F8 and I4
		//IL_0586: Expected O, but got I4
		//IL_0506: Invalid comparison between F8 and I4
		//IL_0517: Expected O, but got I4
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I4
		//IL_0622: Invalid comparison between F8 and I4
		//IL_0633: Expected O, but got I4
		//IL_069b: Expected O, but got I4
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		//IL_06ee: Expected O, but got I4
		//IL_0719: Invalid comparison between F8 and I4
		//IL_072a: Expected O, but got I4
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_0773: Expected O, but got I4
		//IL_079e: Invalid comparison between F8 and I4
		//IL_07af: Expected O, but got I4
		//IL_0817: Expected O, but got I4
		object obj2;
		object obj7;
		if ((object)userbox != null)
		{
			Transform transform = userbox.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
				object obj = (nint)0 & (nint)1;
				object obj4;
				if (obj != null)
				{
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj3 = (nint)0 & (nint)1;
					bool flag = obj3 == null;
					obj4 = obj2;
					if (!flag)
					{
						goto IL_00d6;
					}
				}
				else
				{
					_ = 1;
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj5 = (nint)0 & (nint)1;
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					obj4 = obj2;
					if (obj6 != null)
					{
						goto IL_00d6;
					}
				}
				_ = 1;
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 != null)
				{
					goto IL_0103;
				}
				goto IL_02fd;
			}
		}
		return (Vector3)new NullReferenceException();
		IL_00d6:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0103;
		}
		goto IL_02fd;
		IL_0103:
		object obj10 = default(object);
		object obj9 = obj10 * obj10;
		object obj12 = default(object);
		object obj11 = obj12 * obj12;
		object obj13 = obj9 + obj11;
		object obj15 = default(object);
		object obj14 = obj15 * obj15;
		object obj16 = obj14 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj17;
		object obj18;
		object obj19;
		double num2 = default(double);
		object obj20;
		double num3;
		object obj21;
		object obj22;
		object obj23;
		double num;
		if ((nint)obj16 > 925353388)
		{
			obj17 = obj10 / obj16;
			obj18 = obj12 / obj16;
			obj19 = obj15 / obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			bool flag4 = (nint)obj17 < 0;
			num = num2;
			obj20 = obj17;
			num3 = num2;
			obj21 = obj17;
			obj22 = obj19;
			obj23 = obj18;
			if (!flag4)
			{
				goto IL_01ec;
			}
		}
		else
		{
			object obj24 = typeof(UsageHint) + 816;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v18+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+4]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+8]");
			obj19 = 0;
			obj17 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			bool flag5 = (nint)obj26 >= 0;
			num = num2;
			obj20 = obj26;
			num3 = num2;
			obj21 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+4]");
			obj23 = 0;
			if (flag5)
			{
				goto IL_01ec;
			}
		}
		double num4 = (double)obj17 + -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num5 = num3 + -1.0;
		object obj27 = num3 & 1;
		bool flag6 = obj27 == null;
		object obj28 = !flag6;
		if (obj28 != null)
		{
			num3 = num5;
		}
		double num6 = (double)obj21 - -0.5;
		bool flag7 = num6 == 0.0;
		object obj29 = !flag7;
		object obj30 = ~obj29;
		if (obj30 == null)
		{
		}
		double num7 = -0.5;
		num = num3;
		obj19 = obj22;
		obj18 = obj23;
		goto IL_0833;
		IL_02fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0103;
		IL_01ec:
		if (obj20 == (object)0.5)
		{
			double num8 = num + 1.0;
			object obj31 = num & 1;
			bool flag8 = obj31 == null;
			object obj32 = !flag8;
			if (obj32 == null)
			{
			}
			num7 = 0.5;
			num = num8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num7 = 0.5;
		}
		goto IL_0833;
		IL_0833:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
		double num9 = (double)obj18 + -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num11 = default(double);
		double num10 = num11 + -1.0;
		object obj33 = num11 & 1;
		bool flag9 = obj33 == null;
		object obj34 = !flag9;
		if (obj34 == null)
		{
			num10 = num11;
		}
		double num12 = (double)obj18 - -0.5;
		bool flag10 = num12 == 0.0;
		object obj35 = !flag10;
		object obj36 = ~obj35;
		if (obj36 != null)
		{
			num9 = num10;
		}
		double num13 = (double)obj18 + 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num14 = num11 + 1.0;
		object obj37 = num11 & 1;
		bool flag11 = obj37 == null;
		object obj38 = !flag11;
		if (obj38 == null)
		{
			double num15 = num11;
		}
		else
		{
			double num15 = num14;
		}
		double num16 = (double)obj18 - 0.5;
		bool flag12 = num16 == 0.0;
		object obj39 = !flag12;
		object obj40 = ~obj39;
		if (obj40 == null)
		{
		}
		bool flag13 = (nint)obj18 < 0;
		object obj41 = obj18 ^ obj18;
		object obj42 = obj18 & obj41;
		bool flag14 = (nint)obj42 < 0;
		bool flag15 = flag13 == flag14;
		object obj43 = !flag15;
		object obj44 = ~obj43;
		if (obj44 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj46 = default(object);
		object obj45 = obj46 & 1;
		bool flag16 = obj45 == null;
		object obj47 = !flag16;
		if (obj47 == null)
		{
		}
		double num17 = (double)obj19 - -0.5;
		bool flag17 = num17 == 0.0;
		object obj48 = !flag17;
		object obj49 = ~obj48;
		if (obj49 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj50 = obj46 & 1;
		bool flag18 = obj50 == null;
		object obj51 = !flag18;
		if (obj51 == null)
		{
		}
		double num18 = (double)obj19 - 0.5;
		bool flag19 = num18 == 0.0;
		object obj52 = !flag19;
		object obj53 = ~obj52;
		if (obj53 == null)
		{
		}
		bool flag20 = (nint)obj19 < 0;
		object obj54 = obj19 ^ obj19;
		object obj55 = obj19 & obj54;
		bool flag21 = (nint)obj55 < 0;
		bool flag22 = flag20 == flag21;
		object obj56 = !flag22;
		object obj57 = ~obj56;
		if (obj57 == null)
		{
		}
		Vector3 result = default(Vector3);
		return result;
	}

	private void ActivateElements(bool state)
	{
		GameObject gameObject = shemagAnimator.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = egalAnimator.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = shemagAnimator.gameObject;
		gameObject3.SetActive(state);
		GameObject gameObject4 = egalAnimator.gameObject;
		gameObject4.SetActive(state);
		GameObject gameObject5 = egalShadow.gameObject;
		gameObject5.SetActive(state);
		GameObject gameObject6 = shemagShadow.gameObject;
		gameObject6.SetActive(state);
	}

	private TweenerCore<float, float, FloatOptions> DoShadow(FakeDynamicShadowUI shadow, float targetHeight, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00cd: Expected I, but got O
		//IL_00f7: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
			object obj4 = (nint)0 + (nint)2792;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
			object obj6 = (nint)0 + (nint)2800;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = obj2 + 16;
			obj8 = shadow;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<float> dOGetter = default(DOGetter<float>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<float> dOSetter = default(DOSetter<float>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return DOTween.To(dOGetter, dOSetter, targetHeight, duration);
		}
		return (TweenerCore<float, float, FloatOptions>)(object)new NullReferenceException();
	}

	private void PlayAudio(AudioClip clip, float delay = 0f, float volume = 1f)
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
		//IL_00af: Expected I, but got O
		//IL_00de: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2808;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = clip;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(delay, action);
	}

	private void SetEgalTrigger(string name, bool withShadow = true)
	{
		egalAnimator.SetTrigger(name);
		if (withShadow)
		{
			egalShadowAnimator.SetTrigger(name);
		}
		egalShadowAnimator.SetTrigger(name);
	}

	public void Setup()
	{
		Userbox userbox = receiverUserBox;
		if (userbox.<player>k__BackingField.IsMe)
		{
			<affectCards>k__BackingField = false;
		}
	}

	public void SetUserboxes(Userbox sender, Userbox receiver)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = this + 32;
		obj = sender;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 40;
		obj2 = receiver;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Clear()
	{
		//IL_01f0: Expected O, but got I
		//IL_01f8: Expected I, but got O
		//IL_00ba: Expected I, but got O
		//IL_0095: Expected I, but got O
		//IL_00d4: Expected O, but got I
		//IL_00dc: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_0275: Expected I, but got O
		//IL_0159: Expected O, but got I
		//IL_0161: Expected I, but got O
		//IL_019e: Expected O, but got I4
		if (!<affectCards>k__BackingField)
		{
			return;
		}
		Userbox userbox = receiverUserBox;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if ((object)receiverUserBox != null && userbox.<player>k__BackingField != null)
		{
			List<object> list;
			if (userbox.<player>k__BackingField.IsMe)
			{
				SetBackCardVisibility(visible: false);
				list = (List<object>)(object)frontCards;
				num = unchecked((nint)null);
			}
			else
			{
				Userbox userbox2 = receiverUserBox;
				bool flag = (object)receiverUserBox == null;
				num = unchecked((nint)null);
				if (flag)
				{
					goto IL_025f;
				}
				object obj = (nint)0 + (nint)2688;
				num = (nint)obj;
				List<object> list2 = Enumerable.ToList((IEnumerable<object>)userbox2.cardBacks);
				list = list2;
			}
			if (list != null)
			{
				List<object>.Enumerator enumerator = list.GetEnumerator();
				object obj2 = (nint)0 + (nint)1632;
				num = (nint)obj2;
				if (!enumerator2.MoveNext())
				{
					object obj3 = (nint)0 + (nint)1624;
					num = (nint)obj3;
					enumerator2.Dispose();
					goto IL_016f;
				}
				NullReferenceException ex = new NullReferenceException();
				object obj4 = 0;
			}
		}
		goto IL_025f;
		IL_016f:
		_isCleared = true;
		DestroyGift(0f);
		return;
		IL_025f:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj5 = (nint)0 + (nint)1624;
			num = (nint)obj5;
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				goto IL_016f;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A3CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void WiggleCards()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_024f: Expected O, but got I
		//IL_0269: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		if (!<affectCards>k__BackingField)
		{
			return;
		}
		Userbox userbox = receiverUserBox;
		SpriteRenderer[] cardBacks = userbox.cardBacks;
		if (cardBacks.Length < 1)
		{
			return;
		}
		object obj = cardBacks + 32;
		object obj2 = (nint)0 + (nint)72;
		object materialProperty = "_InputUv1BufferOffset" + 3072;
		object obj3 = 0;
		Renderer renderer = default(Renderer);
		do
		{
			Userbox userbox2 = receiverUserBox;
			if (userbox2.<player>k__BackingField.IsMe)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X24_v4+v179 @ X23_v5*8]");
				Transform transform = ((Component)0).transform;
				Transform parent = transform.parent;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				renderer.material = wigglyMaterialShared;
				SpriteExensions.SetAtlasRectInfo((SpriteRenderer)renderer, isSharedMaterial: false, (string)materialProperty);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X24_v4+v179 @ X23_v5*8]");
				((Renderer)0).enabled = false;
				List<object> list = (List<object>)(object)frontCards;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag = list._size < items.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					list.AddWithResize((object)renderer);
				}
				else
				{
					int size = list._size + 1;
					list._size = size;
					object obj5 = items + list._size;
					object obj6 = obj5 + 32;
					obj6 = renderer;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X24_v4+v179 @ X23_v5*8]");
				((Renderer)0).material = wigglyMaterialShared;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X24_v4+v179 @ X23_v5*8]");
				SpriteExensions.SetAtlasRectInfo((SpriteRenderer)0, isSharedMaterial: true, (string)materialProperty);
			}
			obj3++;
		}
		while ((nint)obj3 < cardBacks.Length);
	}

	private void SetBackCardVisibility(bool visible)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Userbox userbox = receiverUserBox;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		object obj4 = (nint)0 + (nint)2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(userbox.cardBacks, action);
	}

	public void OnAnimationEventCallback(string id)
	{
		//IL_097d: Expected O, but got I4
		//IL_098f: Expected O, but got I8
		//IL_09a9: Expected O, but got I4
		//IL_02db: Expected O, but got I4
		//IL_02ed: Expected O, but got I8
		//IL_0307: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0682: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Expected O, but got Unknown
		//IL_0a61: Expected O, but got I
		//IL_0a98: Expected O, but got I
		//IL_0ab1: Expected O, but got I4
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected O, but got Unknown
		//IL_0adf: Expected O, but got I
		//IL_0aed: Expected I, but got O
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_09da: Expected O, but got I4
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_08a3: Expected O, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_06b5: Expected O, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03bd: Expected O, but got I4
		//IL_06a7: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0104: Expected F4, but got O
		//IL_0104: Expected O, but got I4
		//IL_0433: Expected O, but got I
		//IL_08f8: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_06d6: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0160: Expected I, but got O
		//IL_06c8: Expected O, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_01f9: Expected I, but got O
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0741: Expected O, but got I
		//IL_077b: Expected O, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_023c: Expected O, but got I4
		//IL_02a8: Expected O, but got I
		//IL_07eb: Expected O, but got I4
		//IL_0800: Expected O, but got I
		//IL_0818: Expected O, but got I
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(id);
		bool flag = (int)num < 2435462312L;
		object obj = !flag;
		object obj2 = (int)num - 2435462312L;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			bool flag3 = (int)num < 1580379970;
			object obj5 = !flag3;
			object obj6 = num - 1580379970;
			bool flag4 = obj6 == null;
			object obj7 = !flag4;
			object obj8 = obj5 & obj7;
			if (obj8 != null)
			{
				if ((int)num != 2435462312L)
				{
					if (num == 1926693936)
					{
						object obj9 = "setMimeType" + 2088;
						if (id == (string)obj9)
						{
							SetShemagSortlayer(isAboveUI: false);
						}
					}
					return;
				}
				object obj10 = "destinationTimeZone" + 1696;
				if (id == (string)obj10)
				{
					WiggleCards();
					object obj11 = typeof(UsageHint) + 816;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v66+B8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v67+48]");
					object obj14 = default(object);
					float duration = 0f * (float)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v67+50]");
					object obj15 = (nint)0 * (nint)1142292480;
					TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(dizzyStars, (Vector3)1, duration);
					object obj16 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj17 = (nint)0 + (nint)296;
					Action action = default(Action);
					action..ctor(this, (IntPtr)obj17);
					object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v53+E4]");
					bool flag5 = (nint)0 == 0;
					object obj20 = !flag5;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Coroutine coroutine = CoroutineDummy.WaitForSeconds(shemagPullDelay, action);
					dizzyFlowEffect.Play();
					targetCardHolder.localScale = (Vector3)0;
				}
				return;
			}
			switch (num)
			{
			case 1580379970u:
				break;
			case 1103634318u:
			{
				object obj21 = "setMimeType" + 2096;
				if (id == (string)obj21)
				{
					GameObject gameObject = shemagShadow.gameObject;
					gameObject.SetActive(value: false);
					shemagRenderer.enabled = false;
					singleShemagRenderer.enabled = true;
				}
				return;
			}
			default:
				return;
			}
			object obj22 = "destinationTimeZone" + 1672;
			if (!(id == (string)obj22))
			{
				return;
			}
			Transform target = egalAnimator.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOMove(target, (Vector3)0, (float)egalHoldPosition);
			object obj23 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)280;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj25);
			object obj27 = default(object);
			object obj26 = obj27 + 128;
			obj26 = tweenCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			PlayAudio(egalMoveClip);
			FakeDynamicShadowUI fakeDynamicShadowUI = egalShadow;
			fakeDynamicShadowUI.height = 0f;
			object obj28 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj29 = (nint)0 + (nint)288;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj29);
			object obj30 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v85+E4]");
			bool flag6 = (nint)0 == 0;
			object obj32 = !flag6;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(0.2f, action2);
			TweenerCore<float, float, FloatOptions> tweenerCore3 = ((EgalGift)(object)coroutine2).DoShadow(egalShadow, 1f, travelDuration);
			AnimationCurve animationCurve = egalShadowCurve;
			object obj33 = (nint)0 + (nint)2856;
			object obj34 = obj33;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)tweenerCore3;
		}
		else
		{
			bool flag7 = (int)num < 3258101531L;
			object obj35 = !flag7;
			object obj36 = (int)num - 3258101531L;
			bool flag8 = obj36 == null;
			object obj37 = !flag8;
			object obj38 = obj35 & obj37;
			if (obj38 != null)
			{
				if ((int)num != 3899631940L)
				{
					if ((int)num == 4294905038L)
					{
						object obj39 = "setMimeType" + 2104;
						if (id == (string)obj39)
						{
							vanishFlowEffect.Play();
							ClearMaterials();
						}
					}
				}
				else
				{
					object obj40 = "setMimeType" + 2112;
					if (id == (string)obj40)
					{
						PlayAudio(shemagPullClip);
					}
				}
				return;
			}
			if ((int)num != 3173729122L)
			{
				if ((int)num == 3258101531L)
				{
					object obj41 = "destinationTimeZone" + 1680;
					if (id == (string)obj41)
					{
						object obj42 = egalShadow + 120;
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						FakeDynamicShadowUI fakeDynamicShadowUI2 = egalShadow;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F90]");
						fakeDynamicShadowUI2.shadowOpacityRange = (Vector2)0;
						FakeDynamicShadowUI fakeDynamicShadowUI3 = egalShadow;
						fakeDynamicShadowUI3.maxShadowDistance = 320f;
						EgalGift egalGift = default(EgalGift);
						TweenerCore<float, float, FloatOptions> tweenerCore5 = egalGift.DoShadow(fakeDynamicShadowUI3, 1f, 0.8f);
						object obj43 = (nint)0 + (nint)2864;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					}
				}
				return;
			}
			object obj44 = "destinationTimeZone" + 1688;
			if (!(id == (string)obj44))
			{
				return;
			}
			int num2 = egalHitCount + 1;
			egalHitCount = num2;
			Userbox userbox = receiverUserBox;
			bool isMe = userbox.<player>k__BackingField.IsMe;
			bool flag9 = !isMe;
			object obj45 = !flag9;
			object obj46 = ~obj45;
			if (obj46 == null)
			{
			}
			object obj47 = !flag9;
			object obj48 = ~obj47;
			object obj49 = ((obj48 != null) ? ((object)1062836634) : ((object)1065101558));
			if (egalHitCount == 3)
			{
			}
			if (egalHitCount == 3)
			{
				object obj50 = 208;
			}
			else
			{
				object obj50 = 200;
			}
			Transform transform = hitEffect.transform;
			Transform transform2 = egal.transform;
			Vector3 position = transform2.position;
			object obj51 = typeof(UsageHint) + 816;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v39+B8]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v40+24]");
			double num3 = 0.0 * 30.0;
			double num4 = 1060320051.0 + num3;
			transform.position = (Vector3)0;
			trail.emitting = false;
			hitEffect.Play();
			int num5 = ShortcutExtensions.DOKill(targetCardHolder);
			Vector3 localScale = targetCardHolder.localScale;
			float duration2 = (float)obj49 * (float)num4;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(targetCardHolder, (Vector3)0, duration2);
			object obj54 = (nint)0 + (nint)2896;
			object obj34 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (EgalGift)+v612 @ X8_v34]");
			AnimationCurve animationCurve = (AnimationCurve)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
	}

	private void ClearMaterials()
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02dd: Expected I, but got O
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0313: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0175: Expected I, but got O
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_039b: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		bool flag = !<allowClearing>k__BackingField;
		EgalGift egalGift = this;
		if (!flag)
		{
			bool flag2 = !<affectCards>k__BackingField;
			egalGift = this;
			if (!flag2)
			{
				Userbox userbox = receiverUserBox;
				bool flag3 = (object)receiverUserBox == null;
				egalGift = this;
				if (!flag3)
				{
					bool flag4 = userbox.<player>k__BackingField == null;
					egalGift = this;
					if (!flag4)
					{
						if (userbox.<player>k__BackingField.IsMe)
						{
							List<object> list = (List<object>)(object)frontCards;
							bool flag5 = frontCards == null;
							egalGift = this;
							if (!flag5)
							{
								if (list._size < 1)
								{
									return;
								}
								object obj = (nint)0 + (nint)2504;
								object obj2 = ((List<object>)(object)frontCards).get_Item(0);
								bool flag6 = obj2 == null;
								egalGift = this;
								if (!flag6)
								{
									Material material = ((Renderer)obj2).material;
									object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									nint num = (nint)this;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v20 (Il2CppClass<EgalGift>)+250]");
									TweenCallback tweenCallback = default(TweenCallback);
									tweenCallback..ctor(this, (IntPtr)0);
									object property = "_InputUv1BufferOffset" + 960;
									TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(material, 1f, (string)property, 0.3f);
									object obj4 = (nint)0 + (nint)2752;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
									object obj5 = default(object);
									bool flag7 = obj5 == null;
									egalGift = this;
									if (!flag7)
									{
										object obj6 = obj5 + 128;
										obj6 = tweenCallback;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										List<object> list2 = (List<object>)(object)frontCards;
										bool flag8 = frontCards == null;
										egalGift = this;
										if (!flag8)
										{
											int num2 = 1;
											object obj8 = default(object);
											object obj10;
											do
											{
												if (num2 < list2._size)
												{
													object obj7 = list2.get_Item(num2);
													bool flag9 = obj7 == null;
													egalGift = this;
													if (flag9)
													{
														break;
													}
													Material material2 = ((Renderer)obj7).material;
													TweenerCore<float, float, FloatOptions> tweenerCore2 = ShortcutExtensions.DOFloat(material2, 1f, (string)property, 0.3f);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
													bool flag10 = obj8 == null;
													egalGift = this;
													if (flag10)
													{
														break;
													}
													object obj9 = obj8 + 128;
													obj9 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													list2 = (List<object>)(object)frontCards;
													num2++;
													bool flag11 = frontCards == null;
													obj10 = !flag11;
													egalGift = this;
													continue;
												}
												return;
											}
											while (obj10 != null);
										}
									}
								}
							}
						}
						else
						{
							object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							nint num3 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v10 (Il2CppClass<EgalGift>)+250]");
							TweenCallback tweenCallback2 = default(TweenCallback);
							tweenCallback2..ctor(this, (IntPtr)0);
							object property2 = "_InputUv1BufferOffset" + 960;
							egalGift = (EgalGift)((nint)0 + (nint)2752);
							TweenerCore<float, float, FloatOptions> tweenerCore3 = ShortcutExtensions.DOFloat(wigglyMaterialShared, 1f, (string)property2, 0.3f);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
							object obj12 = default(object);
							if (obj12 != null)
							{
								object obj13 = obj12 + 128;
								obj13 = tweenCallback2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return;
							}
						}
					}
				}
				throw new NullReferenceException();
			}
		}
		egalGift.DestroyGift(1f);
	}

	private void DestroyGift(float delay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0072: Expected I, but got O
		//IL_009c: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)272;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(delay, action);
	}

	private void ResetWiggleMaterial(Material material, TweenCallback callback = null, float duration = 0.3f, float delay = 8f)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		object property = "_InputUv1BufferOffset" + 960;
		object obj = (nint)0 + (nint)2752;
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(material, 1f, (string)property, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj3 = default(object);
		object obj2 = obj3 + 128;
		obj2 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private TweenerCore<Vector3, Vector3, VectorOptions> MoveEgal(Vector3 position, float duration)
	{
		//IL_0045: Expected O, but got I4
		if ((object)egalAnimator != null)
		{
			Transform target = egalAnimator.transform;
			return ShortcutExtensions.DOMove(target, (Vector3)0, duration);
		}
		return (TweenerCore<Vector3, Vector3, VectorOptions>)(object)new NullReferenceException();
	}

	private void SetShemagSortlayer(bool isAboveUI)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		object obj = "Unsupported map type" + 856;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
		bool flag = !isAboveUI;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = ((obj4 != null) ? obj2 : obj);
		int sortingLayerID = SortingLayer.NameToID((string)obj5);
		shemagRenderer.sortingLayerID = sortingLayerID;
		singleShemagRenderer.sortingLayerID = sortingLayerID;
		shemagShadowRenderer.sortingLayerID = sortingLayerID;
	}

	public EgalGift()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3504;
		maxLifeTime = 18f;
		egalStartDuration = 0.3f;
		shemagStartScale = 88f;
		<allowClearing>k__BackingField = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		frontCards = (List<SpriteRenderer>)(object)list;
		object obj2 = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <OnAnimationEventCallback>b__81_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I
		//IL_00ec: Expected I, but got O
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object trigger = "HH:mm:ss.ffZ" + 1544;
		egalAnimator.SetTrigger((string)trigger);
		egalShadowAnimator.SetTrigger((string)trigger);
		egalShadowAnimator.SetTrigger((string)trigger);
		Transform transform = egal.transform;
		object obj4 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2808;
		object obj5 = (nint)0 + (nint)2824;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<float> func = default(Func<float>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj6 = egalShadow + 120;
		obj6 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayAudio(egalHitClip);
	}

	private void <OnAnimationEventCallback>b__81_1()
	{
		trail.emitting = true;
	}

	private void <OnAnimationEventCallback>b__81_2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object trigger = "Picking audio files is not supported on iOS" + 2792;
		shemagAnimator.SetTrigger((string)trigger);
	}

	private void <DestroyGift>b__83_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0296: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78CB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a7;
		IL_021c:
		AnimatedItemController animatedItemController;
		bool flag3 = animatedItemController.UnregisterGift(this);
		Transform transform = base.transform;
		Transform parent = transform.parent;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		GameObject gameObject = parent.gameObject;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		UnityEngine.Object obj10 = gameObject;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = gameObject;
		}
		UnityEngine.Object.Destroy(obj10, 0.2f);
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v31+B8]");
		object obj11 = 0;
		animatedItemController = (AnimatedItemController)obj11;
		bool flag5 = obj11 == null;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_021c;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v15+B8]");
		object obj14 = 0;
		animatedItemController = (AnimatedItemController)obj14;
		goto IL_021c;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a7;
		IL_01a7:
		_ = 1;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
		IL_00a7:
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v31+E4]");
		bool flag7 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag7)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
	}
}
