using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;

public class AnimatedElement : MonoBehaviour
{
	private sealed class <>c__DisplayClass37_0
	{
		public float targetTimelinePosition;

		public float travelPosition;

		internal void <Update>b__0(AnimetedElementActivator activator)
		{
			activator.SetActivateState(targetTimelinePosition, travelPosition);
		}
	}

	public SplineHolder spline;

	public AnimationTransitionType transitionType;

	public float speed = 0f;

	public float duration;

	public bool useVelocityMultiplierCurve;

	public AnimationCurve velocityMultiplier;

	public bool overrideTimelinePosition;

	public bool overrideZPosition;

	public float zPosition;

	public bool useRotation;

	public bool useScale;

	public AnimationVectorParameter rotationParameter;

	public bool followPathOrientation;

	public Vector3 offsetRotation;

	public AnimationVectorParameter scaleParameter;

	public FakeDynamicShadowUI shadow;

	public AnimationCurve shadowHeightCurve;

	public bool useShadowTravelPosition;

	public float timelinePosition;

	public List<AnimetedElementActivator> activators;

	private bool disableImage;

	private bool disableShadow;

	private bool disableOnArrived;

	public UnityEvent<float> OnAnimationProgressChanged;

	public UnityEvent OnAnimationStarted;

	private bool isStarted;

	private Vector3 startRotation;

	private Vector3 startScale;

	private bool ShowRotationOptions()
	{
		return useRotation;
	}

	private bool ShowScaleOptions()
	{
		return useScale;
	}

	private bool ShowDurationOption()
	{
		return transitionType == AnimationTransitionType.Duration;
	}

	private bool ShowVelocityCurveOption()
	{
		return useVelocityMultiplierCurve;
	}

	private bool ShowZPositionOption()
	{
		return overrideZPosition;
	}

	private bool ValidateOffsetRotationState()
	{
		return followPathOrientation;
	}

	private bool HasShadow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ca: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BC7]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			obj4 = shadow;
			obj5 = shadow;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = shadow;
			obj5 = shadow;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return obj5;
		IL_0088:
		return obj4;
	}

	public virtual void Start()
	{
		Transform transform = base.transform;
		Vector3 eulerAngles = transform.eulerAngles;
		Vector3 vector = default(Vector3);
		startRotation = vector;
		Transform transform2 = base.transform;
		Vector3 localScale = transform2.localScale;
		startScale = vector;
	}

	public virtual void Awake()
	{
	}

	public unsafe virtual void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0031: Invalid comparison between O and F8
		//IL_0a80: Invalid comparison between F4 and I4
		//IL_0a8f: Invalid comparison between F4 and I4
		//IL_0aa7: Expected O, but got F8
		//IL_0ab4: Expected O, but got F4
		//IL_0ae9: Expected O, but got I4
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected O, but got Unknown
		//IL_0b16: Invalid comparison between F4 and I4
		//IL_00e0: Expected F4, but got I4
		//IL_0136: Invalid comparison between F4 and I4
		//IL_0145: Invalid comparison between F4 and I4
		//IL_015d: Expected O, but got F8
		//IL_016a: Expected O, but got F4
		//IL_019f: Expected O, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0b6f: Invalid comparison between F4 and I4
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected O, but got Unknown
		//IL_0b9c: Expected O, but got F4
		//IL_01eb: Expected F4, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected O, but got Unknown
		//IL_0bea: Expected F4, but got O
		//IL_0bf3: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0616: Expected O, but got I
		//IL_06ed: Expected O, but got I4
		//IL_0697: Expected O, but got I4
		//IL_0435: Expected O, but got I
		//IL_0445: Expected O, but got I
		//IL_0456: Expected F4, but got I
		//IL_0466: Expected F4, but got I
		//IL_048f: Expected F4, but got I
		//IL_048f: Expected O, but got Ref
		//IL_04f5: Expected O, but got I4
		//IL_0513: Expected O, but got I
		//IL_0524: Expected F4, but got I
		//IL_054d: Expected F4, but got I
		//IL_054d: Expected O, but got Ref
		//IL_030b: Expected F4, but got O
		//IL_0769: Expected O, but got I4
		//IL_04a6: Expected O, but got I4
		//IL_04b7: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_06ae: Expected O, but got I4
		//IL_0735: Expected O, but got I4
		//IL_05b3: Expected O, but got I4
		//IL_05cd: Expected O, but got I4
		//IL_05de: Expected O, but got I4
		//IL_0358: Expected O, but got I
		//IL_0368: Expected O, but got I
		//IL_03b5: Expected O, but got I4
		//IL_03be: Expected O, but got I4
		//IL_0c50: Expected F4, but got O
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected O, but got Unknown
		//IL_0c2b: Expected O, but got I
		//IL_0c3c: Expected I, but got O
		//IL_07b0: Expected O, but got I4
		//IL_07c1: Expected O, but got I
		//IL_07e5: Invalid comparison between O and F8
		//IL_0c63: Expected F4, but got O
		//IL_083a: Expected I4, but got O
		//IL_0854: Expected O, but got I
		//IL_08c0: Expected O, but got I
		//IL_087a: Expected O, but got I4
		//IL_0984: Expected O, but got I4
		//IL_0941: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (!isStarted)
		{
			return;
		}
		object obj3 = this + 228;
		if (obj3 >= (object)1.0)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		double num2;
		if (transitionType != AnimationTransitionType.Duration)
		{
			float splineScaleFactor = spline.splineScaleFactor;
			double num = 1.0 / (double)speed;
			num2 = num * (double)splineScaleFactor;
		}
		else
		{
			num2 = duration;
		}
		float num3 = deltaTime / (float)num2;
		float num4 = timelinePosition + num3;
		float num5 = num4 - 1f;
		bool flag = num5 < 0f;
		bool flag2 = num5 == 0f;
		object obj4 = (double)num4 ^ 1.0;
		object obj5 = num4 ^ num5;
		object obj6 = obj4 & obj5;
		bool flag3 = (nint)obj6 < 0;
		bool flag4 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag4 & obj7;
		object obj9 = ~obj8;
		float num6 = ((obj9 != null) ? num4 : 1f);
		float num7 = (timelinePosition = ((!(num4 < 0f)) ? num6 : 0f));
		bool flag5 = !useVelocityMultiplierCurve;
		float num8 = 1f;
		if (!flag5)
		{
			num8 = velocityMultiplier.Evaluate(num7);
		}
		float num9 = num7 * num8;
		float num10 = num9 - 1f;
		bool flag6 = num10 < 0f;
		bool flag7 = num10 == 0f;
		object obj10 = (double)num9 ^ 1.0;
		object obj11 = num9 ^ num10;
		object obj12 = obj10 & obj11;
		bool flag8 = (nint)obj12 < 0;
		bool flag9 = flag6 == flag8;
		object obj13 = !flag7;
		object obj14 = flag9 & obj13;
		object obj15 = ~obj14;
		float num11 = ((obj15 != null) ? num9 : 1f);
		float num12 = ((!(num9 < 0f)) ? num11 : 0f);
		object obj16 = obj2 + 20;
		obj16 = num12;
		Vector3 positionAt = spline.GetPositionAt(num12);
		float num13 = ((!overrideZPosition) ? num6 : zPosition);
		Transform transform = base.transform;
		transform.position = (Vector3)0;
		bool flag10 = !useVelocityMultiplierCurve;
		object obj17 = obj3;
		if (!flag10)
		{
			bool flag11 = !overrideTimelinePosition;
			object obj18 = !flag11;
			object obj19 = ~obj18;
			obj17 = ((obj19 != null) ? obj3 : obj16);
		}
		object obj20 = obj2 + 16;
		obj20 = obj17;
		bool flag12 = !useRotation;
		float num14 = num13;
		float num15 = (float)obj17;
		Vector3 vector = (Vector3)0;
		AnimationVectorParameter animationVectorParameter = default(AnimationVectorParameter);
		Vector3 start = default(Vector3);
		AnimationVectorParameter parameter = default(AnimationVectorParameter);
		Vector3 vector4;
		object obj23;
		object obj21;
		object obj22;
		float num17;
		Quaternion quaternion2;
		if (!flag12)
		{
			Transform transform2 = base.transform;
			if (!followPathOrientation)
			{
				Quaternion rotation = transform2.rotation;
				Quaternion rotation2 = default(Quaternion);
				Vector3 vector2 = Quaternion.Internal_ToEulerRad(ref rotation2);
				float num16 = num13 * 1.1139274E+09f;
				Vector3 vector3 = Quaternion.Internal_MakePositive((Vector3)0);
				vector4 = startRotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+114]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+60]");
				num11 = 0f;
				obj22 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+70]");
				Vector3 vectorPlacement = ((AnimatedElement)vector3).GetVectorPlacement((Vector3)(&animationVectorParameter), start, parameter, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num14 = num16 * 1.01600314E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+70]");
				num15 = 0f * (float)startRotation;
				Vector3 euler = default(Vector3);
				Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
				Transform transform3 = base.transform;
				transform3.rotation = (Quaternion)0;
				bool flag13 = useScale;
				obj23 = 1016003125;
				num17 = num14;
				quaternion2 = (Quaternion)0;
				if (flag13)
				{
					goto IL_03f5;
				}
				goto IL_05ec;
			}
			Vector3 directionAt = spline.GetDirectionAt((float)obj20);
			transform2.up = (Vector3)0;
			Transform transform4 = base.transform;
			Vector3 eulerAngles = transform4.eulerAngles;
			vector4 = offsetRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+90]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+94]");
			obj21 = 0;
			num15 = (float)obj20 + (float)offsetRotation;
			float num18 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+90]");
			num11 = num18 + 0f;
			float num19 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+94]");
			num14 = num19 + 0f;
			transform4.eulerAngles = (Vector3)0;
			vector = (Vector3)0;
		}
		bool flag14 = !useScale;
		num17 = num14;
		quaternion2 = (Quaternion)vector;
		if (!flag14)
		{
			goto IL_03f5;
		}
		goto IL_05ec;
		IL_05ec:
		object obj24 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BC7]");
		object obj25 = (nint)0 & (nint)1;
		UnityEngine.Object obj26;
		UnityEngine.Object obj28;
		if (obj25 != null)
		{
			obj26 = shadow;
			object obj27 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v42+E4]");
			bool flag15 = (nint)0 == 0;
			obj28 = shadow;
			if (!flag15)
			{
				goto IL_0674;
			}
		}
		else
		{
			_ = 1;
			obj26 = shadow;
			object obj27 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v42+E4]");
			bool flag16 = (nint)0 == 0;
			object obj29 = !flag16;
			obj28 = shadow;
			if (obj29 != null)
			{
				goto IL_0674;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj28;
		bool flag18 = !flag17;
		object obj30 = 0;
		if (!flag18)
		{
			goto IL_0743;
		}
		goto IL_0c01;
		IL_0743:
		FakeDynamicShadowUI fakeDynamicShadowUI = shadow;
		bool flag19 = !useShadowTravelPosition;
		object obj31 = !flag19;
		object obj32 = ~obj31;
		object obj33 = ((obj32 != null) ? obj20 : obj16);
		num15 = shadowHeightCurve.Evaluate((float)obj33);
		fakeDynamicShadowUI.height = num15;
		obj30 = 0;
		goto IL_0c01;
		IL_091e:
		UnityEngine.Object obj34;
		bool flag20 = obj34;
		bool flag21 = !flag20;
		object obj35 = !flag21;
		if (obj35 != null)
		{
			goto IL_09db;
		}
		goto IL_0a02;
		IL_0674:
		bool flag22 = obj26;
		bool flag23 = !flag22;
		object obj36 = !flag23;
		if (obj36 != null)
		{
			goto IL_0743;
		}
		obj30 = 0;
		goto IL_0c01;
		IL_0a02:
		OnAnimationCompleted();
		goto IL_0c59;
		IL_09db:
		GameObject gameObject = shadow.gameObject;
		gameObject.SetActive(value: false);
		goto IL_0a02;
		IL_0c01:
		object obj37 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)3328;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj38);
		object obj39 = (nint)0 + (nint)888;
		object obj40 = obj39;
		((List<object>)(object)activators).ForEach(action);
		if (obj3 == (object)1.0)
		{
			if (disableOnArrived)
			{
				bool flag24 = !disableImage;
				bool flag25 = (byte)(int)action != 0;
				if (!flag24)
				{
					object obj41 = (nint)0 + (nint)3872;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					Behaviour behaviour = default(Behaviour);
					behaviour.enabled = false;
					obj40 = 0;
					flag25 = false;
				}
				if (disableShadow)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BC7]");
					object obj42 = (nint)0 & (nint)1;
					UnityEngine.Object obj44;
					if (obj42 != null)
					{
						object obj43 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v27+E4]");
						bool flag26 = (nint)0 == 0;
						obj34 = shadow;
						obj44 = shadow;
						if (!flag26)
						{
							goto IL_091e;
						}
					}
					else
					{
						_ = 1;
						object obj43 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v27+E4]");
						bool flag27 = (nint)0 == 0;
						object obj45 = !flag27;
						obj34 = shadow;
						obj44 = shadow;
						if (obj45 != null)
						{
							goto IL_091e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if ((bool)obj44)
					{
						goto IL_09db;
					}
				}
			}
			goto IL_0a02;
		}
		goto IL_0c59;
		IL_0c59:
		OnAnimationChanged((float)obj20);
		return;
		IL_03f5:
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		Vector3 localScale = transform6.localScale;
		vector4 = startScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+11C]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+120]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+A8]");
		num11 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+B8]");
		num15 = 0f;
		obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimatedElement)+B8]");
		Vector3 vectorPlacement2 = ((AnimatedElement)localScale).GetVectorPlacement((Vector3)(&animationVectorParameter), start, parameter, 0f);
		transform5.localScale = (Vector3)0;
		num17 = num14;
		quaternion2 = (Quaternion)0;
		goto IL_05ec;
	}

	protected virtual void OnAnimationChanged(float position)
	{
		if (OnAnimationProgressChanged != null)
		{
			float arg = default(float);
			OnAnimationProgressChanged.Invoke(arg);
		}
	}

	private Vector3 GetVectorPlacement(Vector3 current, Vector3 start, AnimationVectorParameter parameter, float lerpPosition)
	{
		//IL_0016: Expected O, but got I
		//IL_0396: Invalid comparison between F8 and I4
		//IL_03a5: Invalid comparison between F8 and I4
		//IL_03bd: Expected O, but got F8
		//IL_03ca: Expected O, but got F8
		//IL_03ff: Expected O, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_006b: Expected O, but got I
		//IL_0090: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_0449: Invalid comparison between F4 and I4
		//IL_047d: Invalid comparison between F8 and I4
		//IL_048c: Invalid comparison between F8 and I4
		//IL_04a4: Expected O, but got F8
		//IL_04b1: Expected O, but got F8
		//IL_04e6: Expected O, but got I4
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0513: Invalid comparison between F4 and I4
		//IL_061b: Expected O, but got I4
		//IL_0631: Expected O, but got I
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_0547: Invalid comparison between F8 and I4
		//IL_0556: Invalid comparison between F8 and I4
		//IL_056e: Expected O, but got F8
		//IL_057b: Expected O, but got F8
		//IL_05b0: Expected O, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_05dd: Invalid comparison between F4 and I4
		//IL_013a: Expected O, but got I
		//IL_069d: Expected O, but got I4
		//IL_06b3: Expected O, but got I
		//IL_06cd: Expected O, but got I4
		//IL_0125: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_028d: Expected O, but got I
		//IL_0278: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+C]");
		object obj = (nint)0 & (nint)1;
		float num;
		float num2 = default(float);
		float num4;
		Vector3 result;
		float num6;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			bool flag = (nint)0 < (nint)7;
			object obj2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			object obj3 = -7;
			bool flag2 = obj3 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			object obj4 = 1 << 0;
			object obj5 = obj4 & 0xB3;
			object obj6 = ~obj2;
			object obj7 = obj6 | flag2;
			object obj8 = ~obj7;
			bool flag3 = obj8 != null || obj5 == null;
			num = num2;
			AnimationCurve animationCurve = (AnimationCurve)(object)this;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+18]");
					animationCurve = (AnimationCurve)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+20]");
					animationCurve = (AnimationCurve)0;
				}
				if (animationCurve == null)
				{
					goto IL_02f8;
				}
				float num3 = animationCurve.Evaluate(num2);
				num = num3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			bool flag4 = (nint)0 < (nint)7;
			object obj9 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			object obj10 = -7;
			bool flag5 = obj10 == null;
			object obj11 = obj4 & 0xD5;
			object obj12 = ~obj9;
			object obj13 = obj12 | flag5;
			object obj14 = ~obj13;
			bool flag6 = obj14 != null || obj11 == null;
			num4 = num2;
			result = (Vector3)animationCurve;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
				AnimationCurve animationCurve2;
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+18]");
					animationCurve2 = (AnimationCurve)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+28]");
					animationCurve2 = (AnimationCurve)0;
				}
				if (animationCurve2 == null)
				{
					goto IL_02f8;
				}
				float num5 = animationCurve2.Evaluate(num2);
				num4 = num5;
				result = (Vector3)animationCurve2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			bool flag7 = (nint)0 < (nint)7;
			object obj15 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
			object obj16 = -7;
			bool flag8 = obj16 == null;
			object obj17 = !flag8;
			object obj18 = obj15 & obj17;
			num6 = num2;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
				object obj19 = 1 << 0;
				object obj20 = obj19 & 0xE9;
				bool flag9 = obj20 == null;
				num6 = num2;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+10]");
					AnimationCurve animationCurve3;
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+18]");
						animationCurve3 = (AnimationCurve)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X1 (UnityEngine.Vector3)+30]");
						animationCurve3 = (AnimationCurve)0;
					}
					if (animationCurve3 == null)
					{
						goto IL_02f8;
					}
					float num7 = animationCurve3.Evaluate(num2);
					result = (Vector3)animationCurve3;
					num6 = num7;
				}
			}
		}
		else
		{
			num4 = num2;
			num = num2;
			result = (Vector3)this;
			num6 = num2;
		}
		double num8 = (double)num4 - 1.0;
		bool flag10 = num8 < 0.0;
		bool flag11 = num8 == 0.0;
		object obj21 = (double)num4 ^ 1.0;
		object obj22 = (double)num4 ^ num8;
		object obj23 = obj21 & obj22;
		bool flag12 = (nint)obj23 < 0;
		bool flag13 = flag10 == flag12;
		object obj24 = !flag11;
		object obj25 = flag13 & obj24;
		object obj26 = ~obj25;
		if (obj26 == null)
		{
		}
		if (num4 < 0f)
		{
		}
		double num9 = (double)num - 1.0;
		bool flag14 = num9 < 0.0;
		bool flag15 = num9 == 0.0;
		object obj27 = (double)num ^ 1.0;
		object obj28 = (double)num ^ num9;
		object obj29 = obj27 & obj28;
		bool flag16 = (nint)obj29 < 0;
		bool flag17 = flag14 == flag16;
		object obj30 = !flag15;
		object obj31 = flag17 & obj30;
		object obj32 = ~obj31;
		if (obj32 == null)
		{
		}
		if (num < 0f)
		{
		}
		double num10 = (double)num6 - 1.0;
		bool flag18 = num10 < 0.0;
		bool flag19 = num10 == 0.0;
		object obj33 = (double)num6 ^ 1.0;
		object obj34 = (double)num6 ^ num10;
		object obj35 = obj33 & obj34;
		bool flag20 = (nint)obj35 < 0;
		bool flag21 = flag18 == flag20;
		object obj36 = !flag19;
		object obj37 = flag21 & obj36;
		object obj38 = ~obj37;
		if (obj38 == null)
		{
		}
		if (num6 < 0f)
		{
		}
		return result;
		IL_02f8:
		return (Vector3)new NullReferenceException();
	}

	public virtual void Play(float position = 0f)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_003f: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_01f9: Expected I, but got O
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		timelinePosition = position;
		isStarted = true;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BC7]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj4 = shadow;
			obj5 = shadow;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = shadow;
			obj5 = shadow;
			if (obj6 != null)
			{
				goto IL_009d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj5)
		{
			goto IL_015a;
		}
		goto IL_0190;
		IL_0190:
		Transform transform = base.transform;
		Vector3 positionAt = spline.GetPositionAt(position);
		transform.position = (Vector3)0;
		if (OnAnimationStarted != null)
		{
			OnAnimationStarted.Invoke();
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4 (Il2CppClass<AnimatedElement>)+1D8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4 (Il2CppClass<AnimatedElement>)+1E0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v114 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_015a:
		Transform transform2 = base.transform;
		object obj9 = shadow + 48;
		obj9 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0190;
		IL_009d:
		bool flag3 = obj4;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_015a;
		}
		goto IL_0190;
	}

	public virtual void OnAnimationCompleted()
	{
	}

	public virtual void OnAnimationBegin()
	{
	}
}
