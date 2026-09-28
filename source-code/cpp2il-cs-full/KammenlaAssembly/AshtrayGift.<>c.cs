using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UI.Popups;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;

public class AshtrayGift : BaseAnimatedGift
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Transform, Vector3> <>9__33_0;

		public static Func<SpriteRenderer, int> <>9__36_0;

		public static Func<SpriteRenderer, Material> <>9__36_1;

		public static Action<SpriteRenderer> <>9__37_0;

		public static Action<Material> <>9__45_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Vector3 <RegisterElementScales>b__33_0(Transform i)
		{
			return (Vector3)(((object?)i?.localScale) ?? ((object)new NullReferenceException()));
		}

		internal int <AssignCardMaterials>b__36_0(SpriteRenderer s)
		{
			//IL_003d: Expected I4, but got O
			if ((object)s != null)
			{
				return s.sortingOrder;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal Material <AssignCardMaterials>b__36_1(SpriteRenderer c)
		{
			if ((object)c != null)
			{
				return c.material;
			}
			return (Material)(object)new NullReferenceException();
		}

		internal void <HideBackCards>b__37_0(SpriteRenderer b)
		{
			b.enabled = false;
		}

		internal void <ClearDustEffect>b__45_0(Material m)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object name = "[{0}]:{1}" + 3224;
			m.SetInt((string)name, 1);
		}
	}

	private sealed class <>c__DisplayClass45_0
	{
		public float x;

		public float y;

		public AshtrayGift <>4__this;

		internal void <ClearDustEffect>b__1(Material m)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_003a: Expected O, but got I4
			float canvasScale = <>4__this.canvasScale;
			object name = "[{0}]:{1}" + 3232;
			m.SetVector((string)name, (Vector4)0);
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public string property;

		public float startImpact;

		public float target;

		public float interval;

		internal void <ApplyDustEffect>b__0(Material m)
		{
			//IL_0032: Invalid comparison between F4 and I4
			//IL_0041: Invalid comparison between F4 and I4
			//IL_005b: Expected O, but got F8
			//IL_006a: Expected O, but got F4
			//IL_009f: Expected O, but got I4
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_010a: Invalid comparison between F4 and I4
			//IL_00ed: Expected F4, but got I4
			float num = target - startImpact;
			float num2 = interval - 1f;
			bool flag = num2 < 0f;
			bool flag2 = num2 == 0f;
			object obj = (double)interval ^ 1.0;
			object obj2 = interval ^ num2;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			float num3 = ((obj6 != null) ? interval : 1f);
			float num4 = ((!(interval < 0f)) ? num3 : 0f);
			float num5 = num * num4;
			float value = startImpact + num5;
			m.SetFloat(property, value);
		}
	}

	private sealed class <ApplyDustEffect>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public string property;

		public float target;

		public float delay;

		private <>c__DisplayClass46_0 <>8__1;

		public AshtrayGift <>4__this;

		public float duration;

		public Action onComplete;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <ApplyDustEffect>d__46(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_026a: Expected I4, but got I8
			//IL_040d: Expected I4, but got O
			//IL_01a9: Expected I4, but got I8
			//IL_0040: Expected O, but got I4
			//IL_005d: Expected I4, but got I8
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Expected O, but got Unknown
			//IL_0340: Expected O, but got I
			//IL_0353: Expected I, but got O
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_0386: Expected O, but got I
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected O, but got Unknown
			//IL_03ac: Expected O, but got I4
			//IL_0128: Invalid comparison between F4 and I4
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected O, but got Unknown
			AshtrayGift ashtrayGift = <>4__this;
			<>c__DisplayClass46_0 <>c__DisplayClass46_;
			<>c__DisplayClass46_0 <>c__DisplayClass46_2;
			if (<>1__state != 2)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					<>c__DisplayClass46_ = <>8__1;
					goto IL_043c;
				}
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0436;
				}
				<>1__state = -1;
				object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1984;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = default(object);
				obj3..ctor();
				object obj4 = this + 48;
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj4 != null)
				{
					object obj5 = obj4 + 16;
					obj5 = property;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					<>c__DisplayClass46_ = <>8__1;
					if (<>8__1 != null)
					{
						<>c__DisplayClass46_.target = target;
						if (delay > 0f)
						{
							object obj6 = typeof(UsageHint) + 1640;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							WaitForSeconds waitForSeconds = default(WaitForSeconds);
							waitForSeconds..ctor(delay);
							object obj7 = this + 24;
							obj7 = waitForSeconds;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 1;
							return true;
						}
						goto IL_043c;
					}
				}
			}
			else
			{
				<>1__state = -1;
				<>c__DisplayClass46_2 = <>8__1;
				if (<>8__1 != null)
				{
					goto IL_0293;
				}
			}
			goto IL_03ff;
			IL_03ff:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0293:
			if ((double)<>c__DisplayClass46_2.interval < 1.0)
			{
				float deltaTime = Time.deltaTime;
				float num = deltaTime / duration;
				float interval = <>c__DisplayClass46_2.interval + num;
				<>c__DisplayClass46_2.interval = interval;
				if ((object)<>4__this != null)
				{
					object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2688;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj9 = (nint)0 + (nint)3840;
					Action<object> action = default(Action<object>);
					action..ctor((object)<>8__1, (IntPtr)obj9);
					if (ashtrayGift.cardMaterials != null)
					{
						object obj10 = (nint)0 + (nint)4008;
						((List<object>)(object)ashtrayGift.cardMaterials).ForEach(action);
						object obj11 = this + 24;
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 2;
						return true;
					}
				}
				goto IL_03ff;
			}
			Action action2 = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v211.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			goto IL_0436;
			IL_043c:
			if ((object)<>4__this != null && <>c__DisplayClass46_ != null && (object)ashtrayGift.dirtyCardMaterial != null)
			{
				float startImpact = ashtrayGift.dirtyCardMaterial.GetFloat(<>c__DisplayClass46_.property);
				<>c__DisplayClass46_.startImpact = startImpact;
				<>c__DisplayClass46_2 = <>8__1;
				if (<>8__1 != null)
				{
					<>c__DisplayClass46_2.interval = 0f;
					goto IL_0293;
				}
			}
			goto IL_03ff;
			IL_0436:
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
			object obj2 = (nint)0 + (nint)3848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <ClearDustEffect>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public AshtrayGift <>4__this;

		private float <duration>5__2;

		private Vector2 <tinyDustAngleRange>5__3;

		private float <angle>5__4;

		private float <targetAngle>5__5;

		private float <currentFadeRadius>5__6;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <ClearDustEffect>d__45(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01f7: Expected I4, but got I8
			//IL_0f5b: Expected I4, but got O
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected O, but got Unknown
			//IL_00d3: Expected I4, but got I8
			//IL_0040: Expected O, but got I4
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			//IL_005d: Expected I4, but got I8
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_035c: Expected O, but got I4
			//IL_036e: Expected F4, but got I
			//IL_037e: Expected O, but got I
			//IL_03a5: Expected O, but got I
			//IL_016f: Expected O, but got I4
			//IL_02f3: Expected O, but got I
			//IL_019d: Expected O, but got I4
			//IL_0fa9: Expected F4, but got I
			//IL_0fb9: Expected O, but got I
			//IL_0fe3: Expected O, but got I
			//IL_018f: Expected O, but got I4
			//IL_106e: Expected O, but got F4
			//IL_034e: Expected O, but got I8
			//IL_0ffd: Expected O, but got I
			//IL_0953: Unknown result type (might be due to invalid IL or missing references)
			//IL_0958: Expected O, but got Unknown
			//IL_096e: Expected O, but got I
			//IL_097f: Expected I, but got O
			//IL_09b5: Expected O, but got I
			//IL_09ca: Expected O, but got I
			//IL_0462: Expected O, but got I
			//IL_0e15: Expected F8, but got I4
			//IL_0a47: Expected O, but got I4
			//IL_0a84: Expected O, but got F4
			//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aaa: Expected O, but got Unknown
			//IL_0ad6: Invalid comparison between F8 and I4
			//IL_0ae5: Invalid comparison between F8 and I4
			//IL_0afd: Expected O, but got F8
			//IL_0b0a: Expected O, but got F8
			//IL_0b3f: Expected O, but got I4
			//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4c: Expected O, but got Unknown
			//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed8: Expected O, but got Unknown
			//IL_0ee1: Expected O, but got I4
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected O, but got Unknown
			//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04de: Expected O, but got Unknown
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f9: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Expected O, but got Unknown
			//IL_052b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Expected O, but got Unknown
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Expected O, but got Unknown
			//IL_059e: Expected O, but got I4
			//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Expected O, but got Unknown
			//IL_0e2b: Expected O, but got I
			//IL_1274: Invalid comparison between F8 and I4
			//IL_05cb: Expected O, but got I4
			//IL_0e51: Invalid comparison between F8 and I4
			//IL_1294: Invalid comparison between F8 and I4
			//IL_12a3: Invalid comparison between F8 and I4
			//IL_12b6: Expected O, but got F8
			//IL_12be: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c3: Expected O, but got Unknown
			//IL_12eb: Expected O, but got I4
			//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f8: Expected O, but got Unknown
			//IL_0b8b: Expected F8, but got I4
			//IL_10c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c8: Expected O, but got Unknown
			//IL_10e1: Invalid comparison between F8 and I4
			//IL_10f0: Invalid comparison between F8 and I4
			//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1104: Expected O, but got Unknown
			//IL_110c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1111: Expected O, but got Unknown
			//IL_1146: Expected O, but got I4
			//IL_114e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1153: Expected O, but got Unknown
			//IL_05e6: Expected O, but got I4
			//IL_131a: Expected O, but got I4
			//IL_0bba: Invalid comparison between F8 and I4
			//IL_0ebf: Expected O, but got I
			//IL_068f: Expected O, but got I4
			//IL_0698: Expected O, but got I4
			//IL_0c09: Expected O, but got I
			//IL_0c27: Expected O, but got I4
			//IL_146c: Expected F4, but got I
			//IL_147b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1480: Expected O, but got Unknown
			//IL_0653: Expected O, but got I4
			//IL_0739: Expected O, but got I
			//IL_0749: Expected O, but got I
			//IL_076b: Expected O, but got I4
			//IL_0681: Expected O, but got I4
			//IL_0704: Expected O, but got I4
			//IL_06ad: Expected O, but got I
			//IL_06bd: Expected O, but got I
			//IL_11f6: Expected O, but got I4
			//IL_0673: Expected O, but got I4
			//IL_0ca6: Expected O, but got I
			//IL_0809: Expected O, but got I
			//IL_081e: Expected O, but got I
			//IL_079b: Expected O, but got I4
			//IL_0c6b: Expected O, but got I
			//IL_120a: Unknown result type (might be due to invalid IL or missing references)
			//IL_120f: Expected O, but got Unknown
			//IL_1225: Expected O, but got I
			//IL_1236: Expected I, but got O
			//IL_1254: Expected O, but got I
			//IL_0854: Expected O, but got I
			//IL_07cb: Expected O, but got I
			//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Expected O, but got Unknown
			//IL_0cdb: Expected O, but got I
			//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf2: Expected O, but got Unknown
			//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d00: Expected O, but got Unknown
			//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1c: Expected O, but got Unknown
			//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d37: Expected O, but got Unknown
			//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d63: Expected O, but got Unknown
			//IL_0da5: Expected O, but got I4
			//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db2: Expected O, but got Unknown
			//IL_0dd2: Expected O, but got I4
			//IL_0897: Expected O, but got I4
			//IL_08ca: Expected O, but got I8
			//IL_08d3: Expected F8, but got I4
			//IL_1372: Unknown result type (might be due to invalid IL or missing references)
			//IL_1377: Expected O, but got Unknown
			//IL_1380: Unknown result type (might be due to invalid IL or missing references)
			//IL_1385: Expected O, but got Unknown
			//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b1: Expected O, but got Unknown
			//IL_13f3: Expected O, but got I4
			//IL_13fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1400: Expected O, but got Unknown
			//IL_0ded: Expected O, but got I4
			//IL_1447: Expected O, but got I
			//IL_1455: Expected O, but got I4
			BaseAnimatedGift baseAnimatedGift = <>4__this;
			List<object> list;
			List<object> list2;
			int index;
			int index2;
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj == null)
					{
						<>1__state = -1;
						object obj2 = typeof(UsageHint) + 1640;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						WaitForSeconds waitForSeconds = default(WaitForSeconds);
						waitForSeconds..ctor(2.7f);
						object obj3 = this + 24;
						obj3 = waitForSeconds;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						<>1__state = 1;
						return true;
					}
					goto IL_0f84;
				}
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					Userbox receiverUserBox = baseAnimatedGift.receiverUserBox;
					if ((object)baseAnimatedGift.receiverUserBox != null)
					{
						if (receiverUserBox.<player>k__BackingField != null)
						{
							bool isMe = receiverUserBox.<player>k__BackingField.IsMe;
							bool flag2 = !isMe;
							object obj4 = !flag2;
							object obj5 = ~obj4;
							if (obj5 == null)
							{
								object obj6 = 448;
							}
							else
							{
								object obj6 = 396;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+v694 @ X8_v77]");
							<duration>5__2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1D8]");
							list = (List<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E8]");
							bool flag3 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1D8]");
							list2 = (List<object>)0;
							if (!flag3)
							{
								goto IL_01a2;
							}
						}
						else
						{
							object obj7 = 396;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+v637 @ X8_v72]");
							<duration>5__2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1D8]");
							list = (List<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E8]");
							bool flag4 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1D8]");
							list2 = (List<object>)0;
							if (flag4)
							{
								goto IL_01a2;
							}
						}
						if (list2 != null)
						{
							index = list2._size - 1;
							index2 = 0;
							goto IL_0ff1;
						}
					}
				}
				goto IL_0f4d;
			}
			<>1__state = -1;
			float num = <angle>5__4;
			float num2 = <targetAngle>5__5;
			if (<angle>5__4 < <targetAngle>5__5)
			{
				goto IL_022e;
			}
			goto IL_08e1;
			IL_01a2:
			if (list == null)
			{
				goto IL_0f4d;
			}
			index2 = list._size - 1;
			index = 0;
			list2 = list;
			goto IL_0ff1;
			IL_0f84:
			return false;
			IL_0900:
			((BaseAnimatedGift)<>4__this).Clear();
			goto IL_0f84;
			IL_08e1:
			if ((object)<>4__this != null)
			{
				goto IL_0900;
			}
			goto IL_0f4d;
			IL_0ff1:
			object obj8 = (nint)0 + (nint)2504;
			object obj9 = list2.get_Item(index2);
			Action<object> action;
			if (obj9 != null)
			{
				Transform transform = ((Component)obj9).transform;
				if ((object)transform != null)
				{
					Vector3 eulerAngles = transform.eulerAngles;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1D8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1D8]");
						object obj10 = ((List<object>)0).get_Item(index);
						if (obj10 != null)
						{
							Transform transform2 = ((Component)obj10).transform;
							if ((object)transform2 != null)
							{
								Vector3 eulerAngles2 = transform2.eulerAngles;
								object obj12 = default(object);
								object obj11 = obj12 + 3268935680L;
								Vector2 vector = (Vector2)(obj12 + 3265265664L);
								object obj13 = (object)vector - obj11;
								object obj14 = obj13 / 1135869952;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
								object obj15 = obj14 * 3283353600L;
								object obj16 = obj13 + obj15;
								object obj17 = obj16 - 1135869952;
								bool flag5 = (nint)obj17 < 0;
								bool flag6 = obj17 == null;
								object obj18 = obj16 ^ 0x43B40000;
								object obj19 = obj16 ^ obj17;
								object obj20 = obj18 & obj19;
								bool flag7 = (nint)obj20 < 0;
								bool flag8 = flag5 == flag7;
								object obj21 = !flag6;
								object obj22 = flag8 & obj21;
								object obj23 = ~obj22;
								object obj24 = ((obj23 != null) ? obj16 : ((object)1135869952));
								object obj25 = (((nint)obj16 >= 0) ? obj24 : ((object)0));
								obj12 = obj25 + 3283353600L;
								double num3 = (double)obj25 - 1127481344.0;
								bool flag9 = num3 < 0.0;
								bool flag10 = num3 == 0.0;
								object obj26 = obj25 ^ 0x43340000;
								object obj27 = obj25 ^ num3;
								object obj28 = obj26 & obj27;
								bool flag11 = (nint)obj28 < 0;
								bool flag12 = flag9 == flag11;
								object obj29 = !flag10;
								object obj30 = flag12 & obj29;
								object obj31 = ~obj30;
								if (obj31 == null)
								{
									obj25 = obj12;
								}
								object obj32 = (object)vector - obj25;
								<tinyDustAngleRange>5__3 = vector;
								object obj33 = (object)vector + obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								float num4 = (float)obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F88]");
								float num5 = num4 + 0f;
								<angle>5__4 = num5;
								Userbox receiverUserBox2 = baseAnimatedGift.receiverUserBox;
								if ((object)baseAnimatedGift.receiverUserBox != null)
								{
									if (receiverUserBox2.<player>k__BackingField != null)
									{
										bool isMe2 = receiverUserBox2.<player>k__BackingField.IsMe;
										bool flag13 = !isMe2;
										object obj34 = !flag13;
										object obj35 = ~obj34;
										if (obj35 == null)
										{
											object obj36 = 444;
										}
										else
										{
											object obj36 = 392;
										}
										object obj37 = 0;
									}
									else
									{
										object obj37 = 0;
										object obj36 = 392;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+v940 @ X8_v48]");
									<currentFadeRadius>5__6 = 0f;
									object obj38 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1968;
									object obj39 = obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v63+E4]");
									object obj40;
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v63+B8]");
										obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v54+28]");
										action = (Action<object>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v54+28]");
										if ((nint)0 != 0)
										{
											goto IL_06e2;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj39 = obj38;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v63+B8]");
										obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v54+28]");
										action = (Action<object>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v54+28]");
										bool flag14 = (nint)0 == 0;
										object obj41 = !flag14;
										if (obj41 != null)
										{
											goto IL_06e2;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v63+E4]");
									bool flag15 = (nint)0 == 0;
									object obj42 = !flag15;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj43 = obj38;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v60+B8]");
										obj40 = 0;
									}
									object obj44 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2688;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj45 = (nint)0 + (nint)3808;
									Action<object> action2 = default(Action<object>);
									action2..ctor(obj40, (IntPtr)obj45);
									object obj46 = obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v59+B8]");
									object obj47 = (nint)0 + (nint)40;
									obj47 = action2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E0]");
									bool flag16 = (nint)0 == 0;
									action = action2;
									if (!flag16)
									{
										goto IL_07fd;
									}
								}
							}
						}
					}
				}
			}
			goto IL_0f4d;
			IL_07fd:
			object obj48 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E0]");
			((List<object>)0).ForEach(action);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
				Transform transform3 = ((Component)0).transform;
				Vector3 targetPosition = <>4__this.targetPosition;
				if ((object)transform3 != null)
				{
					transform3.position = (Vector3)0;
					num = <angle>5__4;
					num2 = <targetAngle>5__5;
					bool flag17 = <angle>5__4 < <targetAngle>5__5;
					object obj49 = 3283353600L;
					double num6 = 1127481344.0;
					if (flag17)
					{
						goto IL_022e;
					}
					goto IL_08e1;
				}
			}
			goto IL_0f4d;
			IL_0ec4:
			float deltaTime = Time.deltaTime;
			object obj50 = this + 24;
			obj50 = 0;
			float num7 = deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X20_v8+20]");
			float num8 = num7 * 0f;
			float num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X20_v8+10]");
			float num10 = num9 / 0f;
			float num11 = <angle>5__4 + num10;
			<angle>5__4 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 2;
			return true;
			IL_06e2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E0]");
			bool flag18 = (nint)0 == 0;
			object obj51 = !flag18;
			if (obj51 != null)
			{
				goto IL_07fd;
			}
			goto IL_0f4d;
			IL_022e:
			object obj52 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj53 = default(object);
			obj53..ctor();
			if (obj53 != null)
			{
				object obj54 = obj53 + 24;
				obj54 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)<>4__this != null)
				{
					if (!baseAnimatedGift.<allowClearing>k__BackingField)
					{
						goto IL_0900;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E8]");
					object obj55 = (nint)0 & (nint)1;
					float num13;
					if (obj55 != null)
					{
						num2 = <angle>5__4;
						float num12 = <targetAngle>5__5 + 3.256877E+09f;
						num13 = num12 - <angle>5__4;
						object obj12 = 3256877056L;
					}
					else
					{
						num13 = <angle>5__4;
					}
					float num14 = num13 * 1.01600314E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C88");
					float canvasScale = <>4__this.canvasScale;
					float num15 = num2 * <currentFadeRadius>5__6;
					object obj56 = 0f - num15;
					float num16 = canvasScale * (float)obj56;
					float canvasScale2 = <>4__this.canvasScale;
					float num17 = num14 * <currentFadeRadius>5__6;
					float num18 = num17 * canvasScale2;
					object obj57 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2688;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj58 = (nint)0 + (nint)3832;
					Action<object> action3 = default(Action<object>);
					action3..ctor(obj53, (IntPtr)obj58);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E0]");
					if ((nint)0 != 0)
					{
						object obj59 = (nint)0 + (nint)4008;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+1E0]");
						((List<object>)0).ForEach(action3);
						Userbox receiverUserBox3 = baseAnimatedGift.receiverUserBox;
						if ((object)baseAnimatedGift.receiverUserBox != null)
						{
							if (receiverUserBox3.<player>k__BackingField != null)
							{
								bool isMe3 = receiverUserBox3.<player>k__BackingField.IsMe;
								bool flag19 = !isMe3;
								object obj60 = !flag19;
								if (obj60 != null)
								{
									goto IL_0ec4;
								}
							}
							Vector2 vector2 = <tinyDustAngleRange>5__3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AshtrayGift+<ClearDustEffect>d__45)+30]");
							double num22;
							if ((object)vector2 != null)
							{
								object obj61 = 0f - num13;
								object obj62 = obj61 - (object)<tinyDustAngleRange>5__3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AshtrayGift+<ClearDustEffect>d__45)+30]");
								object obj63 = 0 - <tinyDustAngleRange>5__3;
								double num19 = (double)obj62 / (double)obj63;
								double num20 = num19 - 1.0;
								bool flag20 = num20 < 0.0;
								bool flag21 = num20 == 0.0;
								object obj64 = num19 ^ 1.0;
								object obj65 = num19 ^ num20;
								object obj66 = obj64 & obj65;
								bool flag22 = (nint)obj66 < 0;
								bool flag23 = flag20 == flag22;
								object obj67 = !flag21;
								object obj68 = flag23 & obj67;
								object obj69 = ~obj68;
								double num21 = ((obj69 != null) ? num19 : 1.0);
								num22 = ((!(num19 < 0.0)) ? num21 : 0.0);
								bool flag24 = num22 < 0.0;
								bool flag25 = num22 == 0.0;
								object obj70 = num22 ^ num22;
								object obj71 = num22 & obj70;
								bool flag26 = (nint)obj71 < 0;
								bool flag27 = flag24 == flag26;
								object obj72 = !flag25;
								object obj73 = flag27 & obj72;
								object obj74 = ~obj73;
								bool flag28;
								if (obj74 == null)
								{
									double num23 = num22 - 1.0;
									flag28 = num23 < 0.0;
								}
								else
								{
									flag28 = false;
								}
								object obj75 = !flag28;
								if (obj75 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
										bool isPlaying = ((ParticleSystem)0).isPlaying;
										bool flag29 = !isPlaying;
										object obj76 = !flag29;
										if (obj76 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
											if ((nint)0 == 0)
											{
												goto IL_0f4d;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
											((ParticleSystem)0).Play();
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v2 (BaseAnimatedGift)+170]");
											Transform transform4 = ((Component)0).transform;
											if ((object)transform4 != null)
											{
												object obj77 = typeof(UsageHint) + 816;
												object obj78 = obj77;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X8_v31+B8]");
												object obj79 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AshtrayGift+<ClearDustEffect>d__45)+30]");
												object obj80 = 0 - <tinyDustAngleRange>5__3;
												object obj81 = obj80 / 1135869952;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
												object obj82 = obj81 * 3283353600L;
												object obj83 = obj80 + obj82;
												object obj84 = obj83 - 1135869952;
												bool flag30 = (nint)obj84 < 0;
												bool flag31 = obj84 == null;
												object obj85 = obj83 ^ 0x43B40000;
												object obj86 = obj83 ^ obj84;
												object obj87 = obj85 & obj86;
												bool flag32 = (nint)obj87 < 0;
												bool flag33 = flag30 == flag32;
												object obj88 = !flag31;
												object obj89 = flag33 & obj88;
												object obj90 = ~obj89;
												object obj91 = ((obj90 != null) ? obj83 : ((object)1135869952));
												object obj92 = (((nint)obj83 >= 0) ? obj91 : ((object)0));
												object obj93 = obj92 + 3283353600L;
												object obj94 = obj92 - 1127481344;
												bool flag34 = (nint)obj94 < 0;
												bool flag35 = obj94 == null;
												object obj95 = obj92 ^ 0x43340000;
												object obj96 = obj92 ^ obj94;
												object obj97 = obj95 & obj96;
												bool flag36 = (nint)obj97 < 0;
												bool flag37 = flag34 == flag36;
												object obj98 = !flag35;
												object obj99 = flag37 & obj98;
												object obj100 = ~obj99;
												if (obj100 == null)
												{
													obj92 = obj93;
												}
												double num24 = num22 * (double)obj92;
												double num6 = (double)<tinyDustAngleRange>5__3 + num24;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v32+48]");
												object obj49 = 0;
												transform4.eulerAngles = (Vector3)0;
												goto IL_0ec4;
											}
										}
									}
									goto IL_0f4d;
								}
							}
							else
							{
								num22 = 0.0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF170]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF170]");
								if (((ParticleSystem)0).isPlaying && (num22 == 0.0 || num22 == 1.0))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF170]");
									if ((nint)0 == 0)
									{
										goto IL_0f4d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF170]");
									((ParticleSystem)0).Stop();
								}
								goto IL_0ec4;
							}
						}
					}
				}
			}
			goto IL_0f4d;
			IL_0f4d:
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
			object obj2 = (nint)0 + (nint)3856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private ParticleSystem rootEffect;

	private ParticleSystem dustEffect;

	private ParticleSystem ashtrayMiddlePart;

	private ParticleSystem[] ashtrayParts;

	private ParticleSystem tinyDustEffect;

	private Material dirtyCardMaterial;

	private Material defaultCardMaterial;

	private float fadeRadius;

	private float fadeDuration;

	private int wipeAudioActivatorIndex;

	private List<CustomUserBoxParticleOptions> customParticleOptions;

	private float maxLifeTime;

	private Vector3 mainShiftPosition;

	private float mainDustOpacity;

	private Vector2 mainShadowStrengthRange;

	private float mainFadeRadius;

	private float mainFadeDuration;

	private List<Transform> scaleableElements;

	private Vector3[] elementScales;

	private List<SpriteRenderer> cards;

	private List<Material> cardMaterials;

	private bool isInverted;

	private Vector3 impactPosition;

	private Vector3 fadePosition;

	private Material cardMaterial;

	private List<string> affectedCardNames;

	private bool isDustMaterialApplied;

	public bool isTargetMainPlayer
	{
		get
		{
			//IL_0074: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			//IL_0066: Expected I4, but got O
			Userbox userbox = receiverUserBox;
			if ((object)receiverUserBox != null)
			{
				if ((int)(~userbox.<player>k__BackingField) == 0)
				{
					return userbox.<player>k__BackingField.IsMe;
				}
				return (byte)(int)userbox.<player>k__BackingField != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override void OnSplinePrepared()
	{
		//IL_0042: Expected I, but got O
		//IL_0073: Expected O, but got I
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I
		//IL_025d: Expected O, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0184: Invalid comparison between F4 and I4
		//IL_02a2: Expected O, but got I
		//IL_02b2: Expected F4, but got I
		//IL_02c2: Expected F8, but got I
		//IL_02ca: Expected F4, but got O
		//IL_0878: Expected O, but got I4
		//IL_0885: Expected I, but got O
		//IL_02f6: Expected O, but got I4
		//IL_0303: Expected I, but got O
		//IL_0338: Expected O, but got I4
		//IL_0345: Expected I, but got O
		//IL_037a: Expected O, but got I4
		//IL_0387: Expected I, but got O
		//IL_03b8: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_0555: Expected O, but got I4
		//IL_0426: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0587: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_04d6: Invalid comparison between F8 and I4
		//IL_0625: Expected O, but got I
		//IL_0635: Expected F8, but got I
		//IL_0645: Expected F8, but got I
		//IL_064d: Expected F4, but got O
		//IL_08a5: Expected O, but got F4
		//IL_08ae: Expected O, but got F8
		//IL_0b01: Invalid comparison between O and F8
		//IL_0679: Expected I, but got O
		object obj2;
		object obj4;
		nint num;
		object obj7;
		if ((object)senderUserBox != null)
		{
			Transform transform = senderUserBox.transform;
			bool flag = (object)transform == null;
			num = unchecked((nint)null);
			if (!flag)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
				object obj = (nint)0 & (nint)1;
				if (obj != null)
				{
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj3 = (nint)0 & (nint)1;
					bool flag2 = obj3 == null;
					obj4 = obj2;
					if (!flag2)
					{
						goto IL_00df;
					}
				}
				else
				{
					_ = 1;
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj5 = (nint)0 & (nint)1;
					bool flag3 = obj5 == null;
					object obj6 = !flag3;
					obj4 = obj2;
					if (obj6 != null)
					{
						goto IL_00df;
					}
				}
				_ = 1;
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v18+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				obj2 = obj4;
				if (obj8 != null)
				{
					goto IL_0114;
				}
				goto IL_0273;
			}
		}
		goto IL_0697;
		IL_0114:
		object obj9 = typeof(UsageHint) + 816;
		float num3 = default(float);
		float num2 = num3 * num3;
		object obj11 = default(object);
		object obj10 = obj11 * obj11;
		float num4 = num2 + (float)obj10;
		double num6 = default(double);
		double num5 = num6 * num6;
		float num7 = (float)num5 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num8;
		float num9;
		double num10;
		if (num7 > 925353400f)
		{
			num8 = num3 / num7;
			num9 = (float)obj11 / num7;
			num10 = num6 / (double)num7;
		}
		else
		{
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v44+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v45+4]");
			num9 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v45+8]");
			num10 = 0.0;
			num8 = (float)obj13;
		}
		bool flag5 = (object)receiverUserBox == null;
		obj11 = 925353388;
		num3 = num7;
		num = unchecked((nint)null);
		float num11;
		object obj18;
		double num12;
		double num13;
		object obj21;
		float num14;
		object obj19;
		if (!flag5)
		{
			Transform transform2 = receiverUserBox.transform;
			bool flag6 = (object)transform2 == null;
			obj11 = 925353388;
			num3 = num7;
			num = unchecked((nint)null);
			if (!flag6)
			{
				Vector3 position2 = transform2.position;
				bool flag7 = (object)senderUserBox == null;
				obj11 = 925353388;
				num3 = num7;
				num = unchecked((nint)null);
				if (!flag7)
				{
					Transform transform3 = senderUserBox.transform;
					bool flag8 = (object)transform3 == null;
					obj11 = 925353388;
					num3 = num7;
					num = unchecked((nint)null);
					if (!flag8)
					{
						Vector3 position3 = transform3.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
						object obj14 = (nint)0 & (nint)1;
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
							object obj15 = (nint)0 & (nint)1;
							if (obj15 != null)
							{
								goto IL_0408;
							}
						}
						else
						{
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
							object obj16 = (nint)0 & (nint)1;
							bool flag9 = obj16 == null;
							object obj17 = !flag9;
							if (obj17 != null)
							{
								goto IL_0408;
							}
						}
						_ = 1;
						num11 = num7 - num7;
						obj18 = 925353388 - 925353388;
						num12 = num6 - num6;
						obj19 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v35+E4]");
						bool flag10 = (nint)0 == 0;
						object obj20 = !flag10;
						num13 = num12;
						obj21 = obj18;
						num14 = num11;
						if (obj20 != null)
						{
							goto IL_047a;
						}
						goto IL_05e6;
					}
				}
			}
		}
		goto IL_0697;
		IL_0408:
		num11 = num7 - num7;
		obj18 = 925353388 - 925353388;
		num12 = num6 - num6;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v35+E4]");
		bool flag11 = (nint)0 == 0;
		num13 = num12;
		obj21 = obj18;
		num14 = num11;
		if (!flag11)
		{
			goto IL_047a;
		}
		goto IL_05e6;
		IL_0697:
		throw new NullReferenceException();
		IL_047a:
		float num15 = num11 * num11;
		object obj22 = obj18 * obj18;
		float num16 = num15 + (float)obj22;
		double num17 = num12 * num12;
		double num18 = num17 + (double)num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num18 > 925353388.0)
		{
			float num19 = num11 / (float)num18;
			double num20 = (double)obj18 / num18;
			double num21 = num12 / num18;
		}
		else
		{
			object obj23 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v39+B8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v40+4]");
			double num20 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v40+8]");
			double num21 = 0.0;
			float num19 = (float)obj24;
		}
		float num22 = 0f - num8;
		object obj25 = 0f - num9;
		object obj26 = 0.0 - num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @513A294");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		if (obj25 < (object)2.0)
		{
			return;
		}
		bool flag12 = spline == null;
		obj11 = obj25;
		num3 = num22;
		num = unchecked((nint)null);
		if (!flag12)
		{
			spline.SetScaleXSign(num22);
			return;
		}
		goto IL_0697;
		IL_05e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num12 = num13;
		obj18 = obj21;
		num11 = num14;
		goto IL_047a;
		IL_00df:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v18+E4]");
		bool flag13 = (nint)0 == 0;
		obj4 = obj2;
		if (!flag13)
		{
			goto IL_0114;
		}
		goto IL_0273;
		IL_0273:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj2 = obj4;
		goto IL_0114;
	}

	private void SetAshtrayPartBurstMode()
	{
		//IL_0018: Expected O, but got I4
		//IL_0040: Expected O, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		ParticleSystem[] array = ashtrayParts;
		object obj = 0;
		ParticleSystem.ShapeModule shapeModule = default(ParticleSystem.ShapeModule);
		while ((nint)obj < array.Length)
		{
			object obj2 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+20]");
			ParticleSystem.ShapeModule shape = ((ParticleSystem)0).shape;
			shapeModule.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
			array = ashtrayParts;
			obj++;
			bool flag = ashtrayParts == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	public override void Setup()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)896;
		object obj2 = ((List<object>)(object)activators).get_Item(wipeAudioActivatorIndex);
		Userbox userbox = receiverUserBox;
		if (userbox.<player>k__BackingField != null && userbox.<player>k__BackingField.IsMe)
		{
			Vector3 vector = base.targetPosition;
			spline.Prepare(this, (Vector3)obj);
			_ = 1082130432;
		}
		else
		{
			_ = 1080872141;
			base.Setup();
		}
	}

	public void TriggerAnimationStarted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_030f: Expected I, but got O
		//IL_0051: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_006a: Expected I, but got O
		//IL_0266: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_021f: Expected I, but got O
		//IL_028e: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I4
		//IL_02e2: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_017d: Expected I, but got O
		//IL_018b: Expected I, but got O
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1768;
		object obj3 = (nint)0 + (nint)3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<AshtrayGift>)+2F0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		Coroutine coroutine = UIExtensions.WaitForSeconds(this, maxLifeTime, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<CustomUserBoxParticleOptions> action2 = default(Action<CustomUserBoxParticleOptions>);
		action2..ctor((object)this, (IntPtr)obj3);
		object obj4 = (nint)0 + (nint)304;
		nint num2 = (nint)obj4;
		customParticleOptions.ForEach(action2);
		Userbox userbox = receiverUserBox;
		bool flag = userbox.direction != Userbox.UserBoxDirection.Top;
		Action<CustomUserBoxParticleOptions> action3 = action2;
		if (flag)
		{
			ParticleSystem[] array = ashtrayParts;
			action3 = action2;
			object obj5 = 0;
			ParticleSystem.ShapeModule shapeModule = default(ParticleSystem.ShapeModule);
			while ((nint)obj5 < array.Length)
			{
				object obj6 = (object)array + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11+20]");
				ParticleSystem.ShapeModule shape = ((ParticleSystem)0).shape;
				shapeModule.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
				obj5++;
				array = ashtrayParts;
				bool flag2 = ashtrayParts == null;
				object obj7 = !flag2;
				action3 = (Action<CustomUserBoxParticleOptions>)3;
				num2 = 0;
				if (obj7 == null)
				{
					throw new NullReferenceException();
				}
			}
		}
		SetupParticlesPlacement();
		CreateCardMaterial();
		RegisterElementScales();
		Userbox userbox2 = receiverUserBox;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj9 = (nint)0 + (nint)3112;
		bool flag3 = userbox2.<player>k__BackingField == null;
		object obj10 = 0;
		if (!flag3)
		{
			bool isMe = userbox2.<player>k__BackingField.IsMe;
			bool flag4 = !isMe;
			obj10 = 0;
			action3 = null;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)3104;
				num2 = (nint)obj11;
				Action action4 = default(Action);
				action4..ctor(this, (IntPtr)obj11);
				object obj12 = typeof(SqlSingle[]) + 3832;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v30+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AnimatedItemController.OnMainPlayerCardChanged += action4;
				obj10 = 0;
				action3 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action5 = default(Action<bool>);
		action5..ctor((object)this, (IntPtr)obj9);
		BlurLayersManager.OnPopupVisibilityChanged += action5;
		bool isBlurActive = BlurLayersManager.IsBlurActive;
		OnPopupVisibilityChanged(isBlurActive);
	}

	private void RegisterElementScales()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_0188: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_013f: Expected I, but got O
		//IL_015d: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v6+8]");
		Func<object, Vector3> selector = (Func<object, Vector3>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3824;
			Func<object, Vector3> func = default(Func<object, Vector3>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v11+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<Vector3> source = Enumerable.Select(scaleableElements, selector);
		Vector3[] array = Enumerable.ToArray(source);
		elementScales = array;
		object obj13 = this + 464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnPopupVisibilityChanged(bool visible)
	{
		//IL_00e6: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		List<object> list = (List<object>)(object)scaleableElements;
		if (visible)
		{
			int num = 0;
			object obj2;
			do
			{
				if (num < list._size)
				{
					object obj = list.get_Item(num);
					((Transform)obj).localScale = (Vector3)0;
					num++;
					list = (List<object>)(object)scaleableElements;
					bool flag = scaleableElements == null;
					obj2 = !flag;
					continue;
				}
				return;
			}
			while (obj2 != null);
		}
		else
		{
			int num2 = 0;
			object obj5;
			do
			{
				if (num2 < list._size)
				{
					object obj3 = list.get_Item(num2);
					Vector3[] array = elementScales;
					bool flag2 = num2 < array.Length;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						num2++;
						((Transform)obj3).localScale = (Vector3)0;
						list = (List<object>)(object)scaleableElements;
						bool flag3 = scaleableElements == null;
						obj5 = !flag3;
						continue;
					}
					throw new IndexOutOfRangeException();
				}
				return;
			}
			while (obj5 != null);
		}
		throw new NullReferenceException();
	}

	private void ShiftLastCardPosition()
	{
		//IL_0090: Expected O, but got I4
		List<object> list = (List<object>)(object)cards;
		if (list._size != 0)
		{
			int index = list._size - 1;
			object obj = list.get_Item(index);
			Transform transform = ((Component)obj).transform;
			Vector3 position = transform.position;
			Transform transform2 = ((Component)obj).transform;
			transform2.position = (Vector3)0;
		}
	}

	private void AssignCardMaterials()
	{
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ef: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0087: Expected I, but got O
		//IL_0a00: Expected O, but got I
		//IL_0a11: Expected O, but got I
		//IL_0a21: Expected O, but got I
		//IL_0a43: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0117: Expected O, but got I4
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_0536: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected O, but got Unknown
		//IL_0a7b: Expected O, but got I
		//IL_0a8c: Expected I, but got O
		//IL_0aaa: Expected O, but got I
		//IL_0ac5: Expected O, but got I4
		//IL_0566: Expected O, but got I
		//IL_0376: Expected I, but got O
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_06f6: Expected O, but got I4
		//IL_0223: Expected O, but got I
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_07b8: Expected O, but got I
		//IL_07c8: Expected O, but got I
		//IL_07ea: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_085b: Expected O, but got I
		//IL_064e: Expected O, but got I
		//IL_065e: Expected O, but got I
		//IL_0680: Expected O, but got I4
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_081a: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		//IL_08b1: Expected O, but got I
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected O, but got Unknown
		//IL_0afd: Expected O, but got I
		//IL_0b0e: Expected I, but got O
		//IL_0b2c: Expected O, but got I
		//IL_0b47: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_016a: Expected I, but got O
		//IL_084a: Expected O, but got I
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04a4: Expected O, but got I4
		//IL_04ac: Expected I, but got O
		//IL_02da: Expected O, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected O, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0bb7: Expected O, but got I4
		Userbox userbox = receiverUserBox;
		bool isSharedMaterial;
		SpriteRenderer[] cardBacks;
		if (userbox.<player>k__BackingField != null)
		{
			bool isMe = userbox.<player>k__BackingField.IsMe;
			Userbox userbox2 = receiverUserBox;
			isSharedMaterial = (byte)((isMe ? 1u : 0u) ^ 1u) != 0;
			bool flag = userbox2.cardBacks == null;
			object obj = !flag;
			cardBacks = userbox2.cardBacks;
			nint num = unchecked((nint)null);
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			cardBacks = userbox.cardBacks;
			isSharedMaterial = true;
		}
		object obj6 = default(object);
		if (cardBacks.Length >= 1)
		{
			object obj2 = "_InputUv1BufferOffset" + 3072;
			object obj3 = (nint)0 + (nint)2472;
			object obj4 = cardBacks + 32;
			object obj5 = obj6;
			string text2 = default(string);
			string text = text2;
			object obj7 = 0;
			SpriteRenderer spriteRenderer = default(SpriteRenderer);
			bool flag5;
			do
			{
				Userbox userbox3 = receiverUserBox;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X28_v4+v131 @ X24_v7*8]");
				Component component = (Component)0;
				if (userbox3.<player>k__BackingField != null && userbox3.<player>k__BackingField.IsMe)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X28_v4+v131 @ X24_v7*8]");
					Transform transform = ((Component)0).transform;
					Transform parent = transform.parent;
					object obj8 = (nint)0 + (nint)72;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					List<object> list = (List<object>)(object)affectedCardNames;
					Sprite sprite = spriteRenderer.sprite;
					string text3 = sprite.name;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					bool flag2 = list._size < items.Length;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj10 = items + list._size;
						object obj11 = obj10 + 32;
						obj11 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						component = spriteRenderer;
					}
					else
					{
						list.AddWithResize((object)text3);
						component = spriteRenderer;
					}
				}
				else
				{
					GameObject gameObject = component.gameObject;
					bool activeSelf = gameObject.activeSelf;
					bool flag3 = !activeSelf;
					nint num = unchecked((nint)null);
					if (flag3)
					{
						goto IL_016f;
					}
				}
				((Renderer)component).material = cardMaterial;
				text = (string)obj2;
				SpriteExensions.SetAtlasRectInfo((SpriteRenderer)component, isSharedMaterial, (string)obj2);
				List<object> list2 = (List<object>)(object)cards;
				object obj12 = obj3;
				int version2 = list2._version + 1;
				list2._version = version2;
				object[] items2 = list2._items;
				bool flag4 = list2._size < items2.Length;
				object obj13 = !flag4;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v53+20]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v55+C0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v56+70]");
					text = (string)0;
					list2.AddWithResize((object)component);
					obj5 = 0;
					nint num = (nint)component;
				}
				else
				{
					int size2 = list2._size + 1;
					list2._size = size2;
					object obj16 = items2 + list2._size;
					object obj17 = obj16 + 32;
					obj17 = component;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj5 = 0;
					nint num = (nint)component;
				}
				goto IL_016f;
				IL_016f:
				obj7++;
				flag5 = (nint)obj7 >= cardBacks.Length;
				obj6 = obj5;
			}
			while (!flag5);
		}
		object obj18 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1968;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj18;
		}
		object obj21 = (nint)0 + (nint)2224;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v8+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v42+10]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v42+10]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v8+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v48+B8]");
				obj22 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)3792;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj22, (IntPtr)obj27);
			object obj28 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v47+B8]");
			object obj29 = (nint)0 + (nint)16;
			obj29 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj6 = 0;
			keySelector = func;
		}
		IOrderedEnumerable<object> source = Enumerable.OrderBy(cards, keySelector);
		List<object> list3 = Enumerable.ToList(source);
		cards = (List<SpriteRenderer>)(object)list3;
		object obj30 = this + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Userbox userbox4 = receiverUserBox;
		object obj32;
		Func<object, object> selector;
		if (userbox4.<player>k__BackingField != null && userbox4.<player>k__BackingField.IsMe)
		{
			HideBackCards();
			object obj31 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v50+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v50+B8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v32+18]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v32+18]");
				bool flag9 = (nint)0 == 0;
				object obj33 = !flag9;
				if (obj33 == null)
				{
					goto IL_07f8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj31 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v50+B8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v32+18]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v32+18]");
				bool flag10 = (nint)0 == 0;
				object obj34 = !flag10;
				if (obj34 == null)
				{
					goto IL_07f8;
				}
			}
			goto IL_084f;
		}
		List<object> list4 = (List<object>)(object)cardMaterials;
		int version3 = list4._version + 1;
		list4._version = version3;
		object[] items3 = list4._items;
		bool flag11 = list4._size < items3.Length;
		object obj35 = !flag11;
		if (obj35 == null)
		{
			int size3 = list4._size + 1;
			list4._size = size3;
			object obj36 = items3 + list4._size;
			object obj37 = obj36 + 32;
			obj37 = cardMaterial;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list4.AddWithResize((object)cardMaterial);
		}
		Vector3 vector = base.targetPosition;
		Vector3 vector2 = default(Vector3);
		fadePosition = vector2;
		return;
		IL_084f:
		object obj38 = (nint)0 + (nint)4048;
		IEnumerable<object> source2 = Enumerable.Select(cards, selector);
		List<object> list5 = Enumerable.ToList(source2);
		cardMaterials = (List<Material>)(object)list5;
		object obj39 = this + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj40 = (nint)0 + (nint)2504;
		object obj41 = ((List<object>)(object)cards).get_Item(0);
		Transform transform2 = ((Component)obj41).transform;
		Transform parent2 = transform2.parent;
		Vector3 position = parent2.position;
		fadePosition = vector2;
		object obj42 = ((List<object>)(object)cards).get_Item(0);
		Transform transform3 = ((Component)obj42).transform;
		Vector3 position2 = transform3.position;
		object obj43 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj44 = vector2 - fadePosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AshtrayGift)+1FC]");
		object obj46 = default(object);
		object obj45 = obj46 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AshtrayGift)+200]");
		object obj48 = default(object);
		object obj47 = obj48 - 0;
		object obj49 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v44+E4]");
		bool flag12 = (nint)0 == 0;
		object obj50 = !flag12;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj51 = obj44 * obj44;
		object obj52 = obj45 * obj45;
		object obj53 = obj51 + obj52;
		object obj54 = obj47 * obj47;
		object obj55 = obj53 + obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num2 = (float)obj55 + 1.1120148E+09f;
		mainFadeRadius = num2;
		return;
		IL_07f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v50+E4]");
		bool flag13 = (nint)0 == 0;
		object obj56 = !flag13;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj57 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v38+B8]");
			obj32 = 0;
		}
		object obj58 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj59 = (nint)0 + (nint)3800;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj32, (IntPtr)obj59);
		object obj60 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v37+B8]");
		object obj61 = (nint)0 + (nint)24;
		obj61 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj6 = 0;
		selector = func2;
		goto IL_084f;
	}

	private void HideBackCards()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I
		//IL_01d9: Expected I, but got O
		//IL_01f7: Expected O, but got I
		//IL_0177: Expected O, but got I
		Userbox userbox = receiverUserBox;
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6+E4]");
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0125;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0125;
			}
		}
		goto IL_017c;
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3816;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v12+B8]");
		object obj13 = (nint)0 + (nint)32;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		action = action2;
		goto IL_017c;
		IL_017c:
		ArraysExtensions.ForEach(userbox.cardBacks, action);
	}

	private void SetupParticlesPlacement()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_023f: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_0252: Expected O, but got I4
		Vector3 vector = base.targetPosition;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = default(object);
		object obj4 = obj5 * obj5;
		object obj7 = default(object);
		object obj6 = obj7 * obj7;
		Quaternion quaternion = (Quaternion)(obj4 + obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag2 = (nint)quaternion <= 925353388;
		object obj8 = 0;
		object obj9 = 0;
		object obj10 = 0;
		if (!flag2)
		{
			obj10 = obj5 / (object)quaternion;
			obj9 = obj7 / (object)quaternion;
			obj8 = 0 / quaternion;
		}
		Transform transform = rootEffect.transform;
		Quaternion localRotation = transform.localRotation;
		Quaternion rotation = default(Quaternion);
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(ref rotation);
		Vector3 vector3 = Quaternion.Internal_MakePositive((Vector3)0);
		object obj11 = typeof(UsageHint) + 816;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v11+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @513A294");
		Transform transform2 = rootEffect.transform;
		transform2.localEulerAngles = (Vector3)0;
		Transform transform3 = dustEffect.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		transform3.eulerAngles = (Vector3)0;
		Transform transform4 = ashtrayMiddlePart.transform;
		Vector3 localScale = transform4.localScale;
		int num = UnityEngine.Random.Range(1, 3);
		Transform transform5 = ashtrayMiddlePart.transform;
		if (num == 1)
		{
		}
		transform5.localScale = (Vector3)0;
	}

	private void CreateCardMaterial()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material = default(Material);
		material..ctor(dirtyCardMaterial);
		object obj2 = this + 520;
		cardMaterial = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Userbox userbox = receiverUserBox;
		object obj3 = userbox.direction - 3;
		bool flag = obj3 == null;
		isInverted = flag;
		Vector3 vector3 = default(Vector3);
		int value;
		if (userbox.<player>k__BackingField != null && userbox.<player>k__BackingField.IsMe)
		{
			Vector3 vector = base.targetPosition;
			Vector3 vector2 = vector3 + mainShiftPosition;
			impactPosition = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AshtrayGift)+1A8]");
			object obj5 = default(object);
			object obj4 = obj5 + 0;
			object obj6 = "[{0}]:{1}" + 3016;
			cardMaterial.SetFloat((string)obj6, mainDustOpacity);
			value = 0;
		}
		else
		{
			Vector3 vector4 = base.targetPosition;
			impactPosition = vector3;
			value = 1;
		}
		object obj7 = "[{0}]:{1}" + 3840;
		((Material)obj2).SetFloat((string)obj7, 0f);
		float value2 = UnityEngine.Random.Range(0f, 360f);
		object obj8 = "[{0}]:{1}" + 3024;
		((Material)obj2).SetFloat((string)obj8, value2);
		object obj9 = "_InputUv1BufferOffset" + 120;
		((Material)obj2).SetInt((string)obj9, value);
		object obj10 = "[{0}]:{1}" + 3848;
		((Material)obj2).SetVector((string)obj10, (Vector4)0);
		object obj11 = "_InputUv1BufferOffset" + 2112;
		cardMaterial.SetVector((string)obj11, (Vector4)0);
		float value3 = base.canvasScale;
		object obj12 = "_InputUv1BufferOffset" + 2424;
		cardMaterial.SetFloat((string)obj12, value3);
		object obj13 = "_InputUv1BufferOffset" + 104;
		((Material)obj2).SetInt((string)obj13, isInverted ? 1 : 0);
	}

	public override void OnAnimationCompleted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		if (base.<affectCards>k__BackingField)
		{
			object obj = "[{0}]:{1}" + 3840;
			AssignCardMaterials();
			ShiftLastCardPosition();
			isDustMaterialApplied = true;
			object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			_ = 0;
			object obj4 = obj3 + 56;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1065353216;
			_ = 1056964608;
			object obj5 = obj3 + 32;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			object obj6 = obj3 + 72;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj3);
			object obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = default(object);
			obj8..ctor();
			_ = 0;
			object obj9 = obj8 + 32;
			obj9 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine2 = StartCoroutine((IEnumerator)obj8);
		}
	}

	private void OnMainPlayerCardChanged()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0073: Expected O, but got I
		//IL_0081: Expected I, but got O
		if (isDustMaterialApplied && base.<allowClearing>k__BackingField && base.<affectCards>k__BackingField)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)3088;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			((List<object>)(object)cards).ForEach(action);
		}
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_013a: Expected I, but got O
		//IL_0069: Expected I, but got O
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I
		//IL_00af: Expected I, but got O
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_011d: Expected I, but got O
		Userbox userbox = receiverUserBox;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3112;
		if (userbox.<player>k__BackingField != null)
		{
			bool isMe = userbox.<player>k__BackingField.IsMe;
			bool flag = !isMe;
			nint num = unchecked((nint)null);
			if (!flag)
			{
				object obj3 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)3104;
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj4);
				object obj5 = typeof(SqlSingle[]) + 3832;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AnimatedItemController.OnMainPlayerCardChanged -= action;
				num = unchecked((nint)null);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj2);
		BlurLayersManager.OnPopupVisibilityChanged -= action2;
	}

	public override void Clear()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_0058: Expected I, but got O
		//IL_0071: Expected I, but got O
		if (base.<allowClearing>k__BackingField)
		{
			Userbox userbox = receiverUserBox;
			if (userbox.<player>k__BackingField != null)
			{
				bool isMe = userbox.<player>k__BackingField.IsMe;
				bool flag = !isMe;
				nint num = unchecked((nint)null);
				if (!flag)
				{
					HideBackCards();
					num = unchecked((nint)null);
				}
			}
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)3072;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			((List<object>)(object)cards).ForEach(action);
		}
		DestroyGift();
	}

	private void DestroyGift()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3080;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private IEnumerator ClearDustEffect()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private IEnumerator ApplyDustEffect(float target, float duration, string property, float delay = 0f, Action onComplete = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 56;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = property;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 72;
		obj5 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public AshtrayGift()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00ce: Expected F4, but got O
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3504;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2272;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		fadeRadius = (float)typeof(!!0);
		maxLifeTime = 15f;
		mainDustOpacity = 0.7f;
		mainFadeDuration = 4f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		cards = (List<SpriteRenderer>)(object)list;
		object obj4 = this + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		cardMaterials = (List<Material>)(object)list2;
		object obj5 = this + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		affectedCardNames = (List<string>)(object)list3;
		object obj6 = this + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private unsafe void <TriggerAnimationStarted>b__32_0(CustomUserBoxParticleOptions paritcleInfo)
	{
		float multiplier = base.canvasScale;
		((CustomUserBoxParticleOptions*)paritcleInfo)->SetParticleOptions(receiverUserBox, multiplier);
	}

	private void <OnMainPlayerCardChanged>b__41_0(SpriteRenderer c)
	{
		//IL_004b: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		Sprite sprite = c.sprite;
		string item = sprite.name;
		int num = ((List<object>)(object)affectedCardNames).IndexOf((object)item);
		object obj = num + 1;
		if (obj == null)
		{
			Material material = c.material;
			object obj2 = "[{0}]:{1}" + 3840;
			material.SetFloat((string)obj2, 0f);
		}
	}

	private void <Clear>b__43_0(SpriteRenderer c)
	{
		c.material = defaultCardMaterial;
	}

	private void <DestroyGift>b__44_0()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78B9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v23+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v23+E4]");
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
		StopAllCoroutines();
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v32+B8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v16+B8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v32+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v32+E4]");
		bool flag7 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag7)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
	}
}
