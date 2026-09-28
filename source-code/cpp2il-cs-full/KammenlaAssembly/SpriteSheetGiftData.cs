using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[Serializable]
public class SpriteSheetGiftData : ScriptableObject
{
	public int animationSplineIndex;

	public Vector3[] splineLastPointPositions;

	public AnimationTransitionType transitionType;

	private float speed = 0f;

	private float duration;

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

	public Vector3 startScale;

	public bool useCanvasLayer;

	public CanvasLayer TargetCanvasLayer;

	public float playAudioPosition;

	public bool useSpriteRenderer;

	public Vector2Int sliceGridSize;

	public bool displayOnStart;

	public int startFrameIndex;

	public int endFrameIndex;

	public float spriteSheetDuration;

	public float spritePlayPosition;

	public bool useSpritePositionCurve;

	public AnimationCurve spritePositionCurve;

	public int spriteSheetLoop;

	public float spriteSheetDelay;

	public bool useTrail;

	public AnimationCurve trailWidthCurve;

	public float trailLifeTime;

	public Vector2 trailActiveRange;

	public Vector3 trailPlacement;

	public bool useOpacityFading;

	public float fadeDelay;

	public float fadeDuration;

	public float destroyDelay;

	public float ActualFadeDelay
	{
		get
		{
			//IL_0028: Expected F4, but got I4
			if (endFrameIndex > 0)
			{
				return 0f;
			}
			return fadeDelay + fadeDuration;
		}
	}

	public float ActualDestroyDelay
	{
		get
		{
			if (endFrameIndex > 0)
			{
				return destroyDelay;
			}
			float num = fadeDelay + fadeDuration;
			return destroyDelay + num;
		}
	}

	public bool hasFadingFrames
	{
		get
		{
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = endFrameIndex < 0;
			bool flag2 = endFrameIndex == 0;
			int num = endFrameIndex ^ endFrameIndex;
			int num2 = endFrameIndex & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public bool modifyLastPointPosition
	{
		get
		{
			//IL_0058: Expected I4, but got O
			Vector3[] array = splineLastPointPositions;
			if (splineLastPointPositions != null)
			{
				bool flag = array.Length == 0;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool ShowDurationOption()
	{
		return transitionType == AnimationTransitionType.Duration;
	}

	public void Apply(SpriteSheetAnimatedGift targetElement)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_013a: Expected O, but got I4
		object obj = targetElement + 56;
		obj = velocityMultiplier;
		_ = transitionType;
		_ = speed;
		_ = useVelocityMultiplierCurve;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = overrideTimelinePosition;
		_ = zPosition;
		_ = useRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+60]");
		_ = 0;
		_ = rotationParameter;
		object obj2 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = followPathOrientation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+94]");
		_ = 0;
		_ = offsetRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetGiftData)+B8]");
		_ = 0;
		_ = scaleParameter;
		object obj3 = obj + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (useScale)
		{
			Transform transform = targetElement.transform;
			transform.localScale = (Vector3)0;
		}
	}

	public SpriteSheetGiftData()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Expected O, but got I8
		object obj = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+14]");
		_ = 0;
		_ = 1065353216;
		_ = 1;
		_ = 1048576000;
		object obj3 = this + 308;
		obj3 = 4575657221408423936L;
		_ = 1065353216;
		base..ctor();
	}
}
