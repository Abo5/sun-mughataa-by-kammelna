using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public abstract class AnimatedRoomElement : MonoBehaviour
{
	private sealed class <DelayedPlay>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public AnimatedRoomElement <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <DelayedPlay>d__18(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0074: Expected I4, but got I8
			//IL_00fe: Expected I4, but got O
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			AnimatedRoomElement animatedRoomElement = <>4__this;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					if ((object)<>4__this == null)
					{
						goto IL_00f0;
					}
					<>4__this.Play();
				}
			}
			else
			{
				<>1__state = -1;
				if ((object)<>4__this == null)
				{
					goto IL_00f0;
				}
				object obj = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(animatedRoomElement._delay);
				object obj2 = this + 24;
				obj2 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
			}
			return <>1__state == 0;
			IL_00f0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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
			object obj2 = (nint)0 + (nint)3512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public const float MIN_X_TAB_POSITION = 0.45f;

	public const float MAX_X_TAB_POSITION = 0.872f;

	private RectTransform rectTransform;

	protected AudioSource audioSource;

	private float _delay;

	private string <ElementName>k__BackingField;

	protected float duration;

	protected Vector2Int spriteGridSize;

	protected int loopCount;

	public bool IsInfiniteLoop
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = loopCount + 1;
			return obj == null;
		}
	}

	public string ElementName
	{
		get
		{
			return <ElementName>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Start()
	{
		//IL_0005: Expected I, but got O
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0037: Expected I, but got O
		//IL_0047: Expected O, but got I
		//IL_0057: Expected O, but got I
		nint num = (nint)this;
		Prepare();
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1176;
		object obj2 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<AnimatedRoomElement>)+1A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<AnimatedRoomElement>)+1B0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v60 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnDestroy()
	{
	}

	public abstract void Prepare();

	public abstract void Play();

	public virtual void OnStart()
	{
	}

	public void SetAudioClip(AudioClip audioClip)
	{
		audioSource.clip = audioClip;
	}

	public virtual void ApplyRoomSetup(AnimatedRoomElementInfo info)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_015e: Expected F4, but got O
		//IL_0166: Expected F4, but got O
		//IL_01d1: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c1: Expected F4, but got O
		//IL_00c9: Expected F4, but got O
		//IL_00f2: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_033b: Expected O, but got I
		//IL_0229: Invalid comparison between F8 and I4
		//IL_0238: Invalid comparison between F8 and I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		loopCount = info.loopCount;
		_delay = info.delay;
		duration = info.duration;
		spriteGridSize = info.spriteGridSize;
		object obj = this + 56;
		obj = info.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = info + 52;
		object obj3 = typeof(UsageHint) + 744;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+B8]");
		object obj5 = 0;
		object obj6 = obj2 - obj5;
		object obj7 = obj6 * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float size;
		float size2;
		Component component;
		RectTransform rectTransform;
		if ((nint)obj7 >= 786163454 && ScreenUtility.IsTablet)
		{
			object obj8 = obj2 + 4;
			size = (float)obj2;
			size2 = (float)obj8;
			component = this.rectTransform;
			bool flag = !info.useWidthHeightAsScale;
			object obj9 = !flag;
			rectTransform = this.rectTransform;
			if (obj9 == null)
			{
				goto IL_010a;
			}
		}
		else
		{
			object obj10 = info + 44;
			object obj11 = info + 48;
			size = (float)obj10;
			size2 = (float)obj11;
			component = this.rectTransform;
			bool flag2 = !info.useWidthHeightAsScale;
			rectTransform = this.rectTransform;
			if (flag2)
			{
				goto IL_010a;
			}
		}
		Transform transform = component.transform;
		transform.localScale = (Vector3)0;
		goto IL_01c1;
		IL_010a:
		rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size2);
		this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size);
		goto IL_01c1;
		IL_01c1:
		this.rectTransform.eulerAngles = (Vector3)0;
		if (ScreenUtility.IsTablet)
		{
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v15+B8]");
			object obj13 = 0;
			object obj14 = obj2 - obj13;
			object obj15 = obj14 * obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			if ((nint)obj15 < 786163454)
			{
				double num = (double)info.pivotPosition - 1.0;
				bool flag3 = num < 0.0;
				bool flag4 = num == 0.0;
				object obj16 = info.pivotPosition ^ 1.0;
				object obj17 = info.pivotPosition ^ num;
				object obj18 = obj16 & obj17;
				bool flag5 = (nint)obj18 < 0;
				bool flag6 = flag3 == flag5;
				object obj19 = !flag4;
				object obj20 = flag6 & obj19;
				object obj21 = ~obj20;
				if (obj21 == null)
				{
				}
				if ((nint)info.pivotPosition >= 0)
				{
				}
			}
		}
		UIExtensions.SetPivot(this.rectTransform, (Vector2)0);
	}

	private IEnumerator DelayedPlay()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private Vector2 MapToTabletPosition(Vector2 pivot)
	{
		//IL_001d: Invalid comparison between F8 and I4
		//IL_002c: Invalid comparison between F8 and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		object obj = default(object);
		double num = (double)obj - 1.0;
		bool flag = num < 0.0;
		bool flag2 = num == 0.0;
		object obj2 = obj ^ 1.0;
		object obj3 = obj ^ num;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		if ((nint)obj < 0)
		{
		}
		return (Vector2)this;
	}
}
