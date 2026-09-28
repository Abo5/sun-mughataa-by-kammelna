using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public static class TransitionExtension
{
	private sealed class <>c__DisplayClass2_0
	{
		public RectTransform target;

		public Action onFinish;

		public Vector2 start;

		internal void <DoTweenSlide>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f6: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_014f: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01de: Expected O, but got I
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7878]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				obj5 = target;
				obj6 = target;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = target;
				obj6 = target;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0166;
			IL_0166:
			Action action = onFinish;
			if (onFinish != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v94.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			GameObject gameObject = target.gameObject;
			object obj10 = typeof(UsageHint) + 744;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v9+B8]");
			object obj12 = 0;
			object obj13 = (object)start - obj12;
			object obj14 = obj13 * obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj15 = obj14 - 786163454;
			bool flag5 = (nint)obj15 < 0;
			bool active = !flag5;
			gameObject.SetActive(active);
			return;
			IL_0091:
			bool flag6 = obj5 == null;
			bool flag7 = !flag6;
			obj9 = 0;
			if (!flag7)
			{
				return;
			}
			goto IL_0166;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public Graphic graphic;

		public float originalAlpha;

		public Action onComplete;

		internal void <FadeOut>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f1: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7879]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				obj5 = graphic;
				obj6 = graphic;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = graphic;
				obj6 = graphic;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_0158;
			}
			return;
			IL_0158:
			GameObject gameObject = graphic.gameObject;
			gameObject.SetActive(value: false);
			UIExtensions.SetAlpha(graphic, originalAlpha);
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
			IL_0091:
			if (obj5 == null)
			{
				return;
			}
			goto IL_0158;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public Graphic target;

		public float duration;

		public Ease ease;

		public bool repeat;

		public float alpha;

		public TweenCallback <>9__1;

		internal void <FadeFlash>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f7: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_016c: Expected O, but got I
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_01c6: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			//IL_01fe: Expected O, but got I
			//IL_020c: Expected I, but got O
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E787A]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				obj5 = target;
				obj6 = target;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = target;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = target;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0154;
			IL_0154:
			object obj9 = (nint)0 + (nint)2816;
			object obj10 = (nint)0 + (nint)2456;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(target, 1f, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj11 = this + 40;
			TweenCallback tweenCallback = (TweenCallback)obj11;
			bool flag5 = obj11 == null;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)744;
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(this, (IntPtr)obj14);
				<>9__1 = tweenCallback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tweenCallback = tweenCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			return;
			IL_0091:
			if (obj5 == null)
			{
				return;
			}
			goto IL_0154;
		}

		internal void <FadeFlash>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f1: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E787B]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				obj5 = target;
				obj6 = target;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = target;
				obj6 = target;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_0158;
			}
			return;
			IL_0158:
			if (repeat)
			{
				FadeFlash(target, duration, alpha, repeat: true, ease);
			}
			return;
			IL_0091:
			if (obj5 == null)
			{
				return;
			}
			goto IL_0158;
		}
	}

	private sealed class <SlideCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public RectTransform target;

		public Vector2 start;

		public Vector2 end;

		public float speed;

		public Action onFinish;

		private float <timeToStart>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <SlideCoroutine>d__1(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ae: Expected I4, but got I8
			//IL_003b: Expected O, but got I4
			//IL_0402: Expected I4, but got O
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_0058: Expected I4, but got I8
			//IL_044b: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_0116: Expected O, but got I
			//IL_009a: Expected O, but got I4
			//IL_020d: Invalid comparison between F4 and I4
			//IL_021c: Invalid comparison between F4 and I4
			//IL_0234: Expected O, but got F8
			//IL_0241: Expected O, but got F4
			//IL_0276: Expected O, but got I4
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_0462: Invalid comparison between F4 and I4
			//IL_04bc: Expected O, but got I
			//IL_0519: Expected O, but got I4
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Expected O, but got Unknown
			//IL_052d: Expected O, but got I4
			//IL_02c2: Expected F4, but got I4
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_03e6;
				}
				<>1__state = -1;
				float time = Time.time;
				<timeToStart>5__2 = time;
				if ((object)target == null)
				{
					goto IL_03f4;
				}
				target.localPosition = (Vector3)0;
			}
			else
			{
				<>1__state = -1;
			}
			GameObject gameObject;
			bool active;
			if ((object)target != null)
			{
				Vector3 localPosition = target.localPosition;
				object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj5 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TransitionExtension+<SlideCoroutine>d__1)+34]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TransitionExtension+<SlideCoroutine>d__1)+2C]");
				object obj6 = num - 0;
				object obj7 = end - start;
				object obj8 = obj7 * obj7;
				object obj9 = obj6 * obj6;
				object obj10 = obj8 + obj9;
				object obj11 = obj5 * obj5;
				object obj12 = obj11 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				if ((nint)obj12 > 1028443341)
				{
					if ((object)target != null)
					{
						Vector3 localPosition2 = target.localPosition;
						float time2 = Time.time;
						float num2 = time2 - <timeToStart>5__2;
						float num3 = num2 * speed;
						float num4 = num3 - 1f;
						bool flag3 = num4 < 0f;
						bool flag4 = num4 == 0f;
						object obj13 = (double)num3 ^ 1.0;
						object obj14 = num3 ^ num4;
						object obj15 = obj13 & obj14;
						bool flag5 = (nint)obj15 < 0;
						bool flag6 = flag3 == flag5;
						object obj16 = !flag4;
						object obj17 = flag6 & obj16;
						object obj18 = ~obj17;
						float num5 = ((obj18 != null) ? num3 : 1f);
						float num6 = ((!(num3 < 0f)) ? num5 : 0f);
						object obj19 = (object)end - obj12;
						float num7 = (float)obj19 * num6;
						float num8 = (float)obj12 + num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TransitionExtension+<SlideCoroutine>d__1)+34]");
						object obj20 = -1028443341;
						float num9 = (float)obj20 * num6;
						float num10 = 1.0284433E+09f + num9;
						float num11 = 0f - (float)obj8;
						float num12 = num11 * num6;
						float num13 = (float)obj8 + num12;
						target.localPosition = (Vector3)0;
						object obj21 = this + 24;
						obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						return true;
					}
				}
				else
				{
					Action action = onFinish;
					if (onFinish != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					if ((object)start == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TransitionExtension+<SlideCoroutine>d__1)+2C]");
						if ((nint)0 == 0)
						{
							if ((object)target != null)
							{
								gameObject = target.gameObject;
								if ((object)gameObject != null)
								{
									active = false;
									goto IL_0572;
								}
							}
							goto IL_03f4;
						}
					}
					if ((object)target != null)
					{
						gameObject = target.gameObject;
						if ((object)gameObject != null)
						{
							active = true;
							goto IL_0572;
						}
					}
				}
			}
			goto IL_03f4;
			IL_0572:
			gameObject.SetActive(active);
			goto IL_03e6;
			IL_03f4:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_03e6:
			return false;
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
			object obj2 = (nint)0 + (nint)752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public static void Slide(RectTransform target, Vector2 start, Vector2 end, float speed, Action onFinish = null)
	{
		DoTweenSlide(target, start, end, speed, onFinish);
	}

	public static IEnumerator SlideCoroutine(RectTransform target, Vector2 start, Vector2 end, float speed, Action onFinish = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 64;
		obj4 = start;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static void DoTweenSlide(RectTransform target, Vector2 start, Vector2 end, float speed, Action onFinish = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_0109: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = start;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj6 = (nint)0 + (nint)720;
		object obj7 = (nint)0 + (nint)2488;
		((RectTransform)obj3).anchoredPosition = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+10]");
		int num = ShortcutExtensions.DOKill((Component)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+10]");
		float duration = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos((RectTransform)0, (Vector2)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public static void FadeIn(Graphic graphic, float alpha, float duration)
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		int num = ShortcutExtensions.DOKill(graphic);
		object obj = (nint)0 + (nint)2816;
		object obj2 = (nint)0 + (nint)2736;
		graphic.raycastTarget = true;
		UIExtensions.SetAlpha(graphic, 0f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(graphic, alpha, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	public static void FadeOut(Graphic graphic, float duration = 1.3f, Action onComplete = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_014e: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill((Component)obj3);
		object obj5 = obj3;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X8_v4+2C8] (should have been resolved before IL gen)");
		object obj7 = obj3;
		object obj8 = (nint)0 + (nint)2816;
		object obj9 = (nint)0 + (nint)2736;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj11 = (nint)0 + (nint)728;
		object obj12 = (nint)0 + (nint)2456;
		object obj13 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ X8_v5+298] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)0, 0f, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public static void FadeFlash(Graphic target, float duration, float alpha, bool repeat, Ease ease = Ease.OutQuart)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00bd: Expected F4, but got I
		//IL_00bd: Expected F4, but got I
		//IL_00eb: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2816;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)736;
		object obj6 = (nint)0 + (nint)2456;
		object obj7 = obj2 + 16;
		obj7 = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill((Component)obj7);
		object target2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+24]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+18]");
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)target2, num2, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public static void RectSlideFromRight(RectTransform target, float speed = 0.2f)
	{
		//IL_0049: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasWidth = ScreenUtility.CanvasWidth;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, canvasWidth, onFinish);
	}

	public static void RectSlideFromLeft(RectTransform target, float speed = 0.2f)
	{
		//IL_0052: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasWidth = ScreenUtility.CanvasWidth;
		float speed2 = 0f - canvasWidth;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, speed2, onFinish);
	}

	public static void RectSlideToRight(RectTransform target, float speed = 0.2f)
	{
		//IL_004a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasWidth = ScreenUtility.CanvasWidth;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public static void RectSlideToLeft(RectTransform target, float speed = 0.2f)
	{
		//IL_004a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasWidth = ScreenUtility.CanvasWidth;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public static void RectSlideFromTop(RectTransform target, float speed = 0.2f)
	{
		//IL_004a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasHeight = ScreenUtility.CanvasHeight;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public static void RectSlideFromBottom(RectTransform target, float speed = 0.2f)
	{
		//IL_004a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasHeight = ScreenUtility.CanvasHeight;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public static void RectSlideToTop(RectTransform target, float speed = 0.2f)
	{
		//IL_004a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasHeight = ScreenUtility.CanvasHeight;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public static void RectSlideToBottom(RectTransform target, float speed = 0.2f)
	{
		//IL_004a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		GameObject gameObject = target.gameObject;
		gameObject.SetActive(value: true);
		float canvasHeight = ScreenUtility.CanvasHeight;
		Action onFinish = default(Action);
		DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}
}
