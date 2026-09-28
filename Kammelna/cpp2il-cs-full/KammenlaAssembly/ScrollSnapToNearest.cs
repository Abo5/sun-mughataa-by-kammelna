using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class ScrollSnapToNearest : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	private sealed class <>c__DisplayClass35_0
	{
		public ScrollSnapToNearest <>4__this;

		public Vector2 target;

		internal void <SnapTo>b__0()
		{
			//IL_0027: Expected O, but got I4
			ScrollRect scrollRect = <>4__this.ScrollRect;
			scrollRect.m_Content.anchoredPosition = (Vector2)0;
		}
	}

	private float snapDuration;

	private Ease snapEase;

	private float proximityMaxDistance;

	private int selectedIndex;

	private List<ScrollSnapProximityBehavior> behaviors;

	public UnityEvent<RectTransform> OnNearestChangedWhileDragging;

	public UnityEvent<RectTransform> OnSnappedAfterDrag;

	public UnityEvent<int> OnIndexChanged;

	private RectTransform <NearestItem>k__BackingField;

	private bool _isDragging;

	private RectTransform _lastReportedNearest;

	private int _lastReportedIndex;

	private readonly List<ScrollSnapItemProximity> _itemProximities;

	private ScrollRect _scrollRect;

	public int SelectedIndex
	{
		get
		{
			return selectedIndex;
		}
		set
		{
			selectedIndex = value;
		}
	}

	public RectTransform NearestItem
	{
		get
		{
			return <NearestItem>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe int CurrentIndex
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_016a: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_0109: Expected I4, but got I8
			//IL_01c9: Expected O, but got I4
			//IL_01d2: Expected O, but got I4
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Expected O, but got Unknown
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
			//IL_0741: Expected O, but got I4
			//IL_02a3: Expected O, but got I
			//IL_0342: Expected O, but got I4
			//IL_0802: Expected I, but got O
			//IL_0812: Expected O, but got I
			//IL_0825: Unknown result type (might be due to invalid IL or missing references)
			//IL_082a: Expected O, but got Unknown
			//IL_02de: Expected O, but got I
			//IL_05d1: Expected O, but got I4
			//IL_05da: Expected O, but got I4
			//IL_0983: Expected I4, but got I8
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Expected O, but got Unknown
			//IL_0942: Unknown result type (might be due to invalid IL or missing references)
			//IL_0947: Expected O, but got Unknown
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Expected O, but got Unknown
			//IL_0307: Expected O, but got I
			//IL_08e2: Expected O, but got I4
			//IL_03ac: Expected O, but got I
			//IL_05f7: Expected O, but got I
			//IL_044b: Expected O, but got I4
			//IL_068e: Expected O, but got I4
			//IL_0874: Expected I, but got O
			//IL_0884: Expected O, but got I
			//IL_03e7: Expected O, but got I
			//IL_0924: Expected O, but got I
			//IL_0632: Expected O, but got I
			//IL_0496: Expected I, but got O
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Expected O, but got Unknown
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Expected O, but got Unknown
			//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b6: Expected I, but got Unknown
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fa: Expected O, but got Unknown
			//IL_0410: Expected O, but got I
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Expected O, but got Unknown
			//IL_064e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0653: Expected O, but got Unknown
			//IL_0548: Expected O, but got I4
			//IL_0592: Expected O, but got I4
			//IL_06d3: Expected O, but got I4
			//IL_06dc: Expected O, but got I4
			//IL_06e5: Expected O, but got I4
			//IL_05b7: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79EB]");
			object obj3 = (nint)0 & (nint)1;
			object obj5;
			UnityEngine.Object obj6;
			nint num2;
			UnityEngine.Object obj7;
			nint num;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v57+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v57+E4]");
				bool flag = (nint)0 == 0;
				obj5 = 0;
				obj6 = <NearestItem>k__BackingField;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v57+E4]");
				num2 = 0;
				obj7 = <NearestItem>k__BackingField;
				if (!flag)
				{
					goto IL_00c3;
				}
			}
			else
			{
				_ = 1;
				obj6 = <NearestItem>k__BackingField;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v57+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v57+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj5 = 0;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v57+E4]");
				num2 = 0;
				obj7 = <NearestItem>k__BackingField;
				if (obj8 != null)
				{
					goto IL_00c3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			num = num2;
			if (obj9 != null)
			{
				goto IL_00fc;
			}
			goto IL_01ed;
			IL_00fc:
			int num3 = -1;
			goto IL_06c3;
			IL_06c3:
			return num3;
			IL_07ca:
			throw new NullReferenceException();
			IL_00c3:
			bool flag5 = obj6 == null;
			bool flag6 = !flag5;
			obj10 = 0;
			obj11 = null;
			if (!flag6)
			{
				goto IL_00fc;
			}
			goto IL_01ed;
			IL_01ed:
			ScrollRect scrollRect = ScrollRect;
			if ((object)scrollRect != null && (object)scrollRect.m_Content != null)
			{
				IEnumerator enumerator = scrollRect.m_Content.GetEnumerator();
				object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				obj11 = null;
				num = (nint)(&obj5);
				num3 = 0;
				object obj14 = default(object);
				object obj20 = default(object);
				object obj22 = default(object);
				object obj27 = default(object);
				Component component = default(Component);
				object obj34 = default(object);
				int result = default(int);
				object obj36 = default(object);
				IntPtr intPtr = default(IntPtr);
				while (true)
				{
					object obj18;
					if (obj14 != null)
					{
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v18+12E]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v18+12E]");
						if ((nint)0 == 0)
						{
							goto IL_032f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v18+B0]");
						object obj17 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v25-8]");
							if (0 == (nint)obj12)
							{
								break;
							}
							obj18 = obj17 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v18+12E]");
							obj16 = -1;
							bool flag7 = (nint)obj16 != 1;
							obj17 = obj18;
							if (flag7)
							{
								continue;
							}
							goto IL_032f;
						}
						obj16 = obj17;
						object obj19 = obj15 + obj17;
						obj20 = obj19 + 312;
						obj18 = obj17;
						goto IL_07fa;
					}
					NullReferenceException ex = new NullReferenceException();
					goto IL_0735;
					IL_0933:
					object obj21 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					obj11 = (UnityEngine.Object)obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj22 == null)
					{
						goto IL_08c8;
					}
					object obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+12E]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+12E]");
					if ((nint)0 == 0)
					{
						goto IL_067b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v7+B0]");
					object obj25 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X10_v9-8]");
						if (0 == (nint)obj21)
						{
							break;
						}
						obj18 = obj25 + 16;
						obj24--;
						bool flag8 = (nint)obj24 != 1;
						obj25 = obj18;
						if (flag8)
						{
							continue;
						}
						goto IL_067b;
					}
					object obj26 = obj23 + obj25;
					num = (nint)(obj26 + 312);
					obj18 = obj25;
					goto IL_0914;
					IL_086c:
					num = (nint)obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v36+8]");
					obj11 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v652 @ X0_v36] (should have been resolved before IL gen)");
					object obj32;
					object obj31;
					if ((object)component != null)
					{
						obj11 = (UnityEngine.Object)obj13;
						num = (nint)component;
						if (component == obj13)
						{
							GameObject gameObject = component.gameObject;
							if ((object)gameObject != null)
							{
								bool activeInHierarchy = gameObject.activeInHierarchy;
								bool flag9 = !activeInHierarchy;
								obj11 = null;
								if (flag9)
								{
									continue;
								}
								object obj28 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v46+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v46+E4]");
								bool flag10 = (nint)0 == 0;
								object obj29 = !flag10;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag11 = component == <NearestItem>k__BackingField;
								bool flag12 = !flag11;
								object obj30 = !flag12;
								if (obj30 == null)
								{
									num3++;
									obj10 = 0;
									obj11 = <NearestItem>k__BackingField;
									continue;
								}
								obj31 = 0;
								obj10 = 0;
								obj32 = 0;
								goto IL_0933;
							}
							NullReferenceException ex2 = new NullReferenceException();
							obj11 = null;
						}
						else
						{
							InvalidCastException ex3 = new InvalidCastException();
						}
					}
					else
					{
						NullReferenceException ex4 = new NullReferenceException();
					}
					goto IL_0735;
					IL_0914:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6 (Il2CppClass<UnityEngine.Component>)+8]");
					obj11 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X8_v6 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
					goto IL_08c8;
					IL_08c8:
					bool flag13 = obj32 == null;
					object obj33 = !flag13;
					if (obj33 != null)
					{
						OutOfMemoryException ex5 = new OutOfMemoryException();
						if ((nint)obj11 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj32 = obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							obj31 = obj34;
							goto IL_0976;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return result;
					}
					break;
					IL_032f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj10 = 0;
					goto IL_07fa;
					IL_07fa:
					num = (nint)obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v32+8]");
					obj11 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ X0_v32] (should have been resolved before IL gen)");
					object obj35 = obj36 & 1;
					if (obj35 != null)
					{
						if (obj14 != null)
						{
							object obj37 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v21+12E]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v21+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0438;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v21+B0]");
							object obj38 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v20-8]");
								if (0 == (nint)obj12)
								{
									break;
								}
								obj18 = obj38 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v21+12E]");
								obj16 = -1;
								bool flag14 = (nint)obj16 != 1;
								obj38 = obj18;
								if (flag14)
								{
									continue;
								}
								goto IL_0438;
							}
							obj16 = obj38 + 1;
							object obj39 = obj37 + obj16;
							obj27 = obj39 + 312;
							obj18 = obj38;
							goto IL_086c;
						}
						NullReferenceException ex6 = new NullReferenceException();
						goto IL_0735;
					}
					obj31 = 0;
					obj32 = 0;
					goto IL_0976;
					IL_0976:
					num3 = -1;
					goto IL_0933;
					IL_0735:
					obj31 = 0;
					goto IL_07ca;
					IL_0438:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj10 = 1;
					goto IL_086c;
					IL_067b:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj10 = 0;
					num = intPtr;
					goto IL_0914;
				}
				goto IL_06c3;
			}
			goto IL_07ca;
		}
	}

	public float NearestItemProximity
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0117: Expected O, but got I4
			//IL_00b7: Expected F4, but got I4
			//IL_00c0: Expected F4, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_0166: Expected O, but got I4
			//IL_016f: Expected F4, but got I4
			//IL_0178: Expected F4, but got I4
			//IL_0181: Expected O, but got I4
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected O, but got Unknown
			//IL_0250: Expected O, but got I4
			//IL_02c6: Expected O, but got I4
			//IL_0357: Expected O, but got I4
			//IL_03dc: Expected O, but got I4
			//IL_0401: Expected F4, but got I4
			//IL_04ba: Expected O, but got I4
			//IL_041c: Expected F8, but got I4
			//IL_0536: Invalid comparison between F4 and I4
			//IL_0545: Invalid comparison between F4 and I4
			//IL_055d: Expected O, but got F8
			//IL_056a: Expected O, but got F4
			//IL_059f: Expected O, but got I4
			//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ac: Expected O, but got Unknown
			//IL_05e0: Invalid comparison between F4 and I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79EC]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v23+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <NearestItem>k__BackingField;
				obj6 = <NearestItem>k__BackingField;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <NearestItem>k__BackingField;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v23+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <NearestItem>k__BackingField;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			float result = 0f;
			float num = 0f;
			object obj9 = 0;
			if (obj8 != null)
			{
				goto IL_00d8;
			}
			goto IL_0190;
			IL_00d8:
			return result;
			IL_0190:
			ScrollRect scrollRect = ScrollRect;
			if ((object)scrollRect != null)
			{
				ScrollRect scrollRect2 = ScrollRect;
				if ((object)scrollRect2 != null && (object)scrollRect2.m_Viewport != null)
				{
					Rect rect = scrollRect2.m_Viewport.rect;
					object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v10+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)scrollRect.m_Viewport != null)
					{
						object obj13 = default(object);
						double num2 = (double)obj13 * 0.5;
						object obj14 = default(object);
						double num3 = (double)obj14 + num2;
						object obj15 = default(object);
						double num4 = (double)obj15 * 0.5;
						float num5 = num + (float)num4;
						Vector3 vector = scrollRect.m_Viewport.TransformPoint((Vector3)0);
						bool flag6 = (object)<NearestItem>k__BackingField == null;
						num = num5;
						if (!flag6)
						{
							Rect rect2 = <NearestItem>k__BackingField.rect;
							double num6 = 0.0 * 0.5;
							num = num5 + (float)num6;
							double num7 = num2 * 0.5;
							double num8 = num3 + num7;
							Vector3 vector2 = <NearestItem>k__BackingField.TransformPoint((Vector3)0);
							ScrollRect scrollRect3 = ScrollRect;
							if ((object)scrollRect3 != null)
							{
								ScrollRect scrollRect4 = ScrollRect;
								if ((object)scrollRect4 != null)
								{
									float num9 = num - num5;
									bool flag7 = !scrollRect3.m_Horizontal;
									object obj16 = !flag7;
									object obj17 = ~obj16;
									if (obj17 != null)
									{
										num9 = 0f;
									}
									double num10 = num8 - num3;
									bool flag8 = !scrollRect4.m_Vertical;
									object obj18 = !flag8;
									object obj19 = ~obj18;
									double num11 = ((obj19 != null) ? 0.0 : num10);
									float num12 = num9 * num9;
									double num13 = num11 * num11;
									float num14 = num12 + (float)num13;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									float num15 = num14 / proximityMaxDistance;
									float num16 = num15 - 1f;
									bool flag9 = num16 < 0f;
									bool flag10 = num16 == 0f;
									object obj20 = (double)num15 ^ 1.0;
									object obj21 = num15 ^ num16;
									object obj22 = obj20 & obj21;
									bool flag11 = (nint)obj22 < 0;
									bool flag12 = flag9 == flag11;
									object obj23 = !flag10;
									object obj24 = flag12 & obj23;
									object obj25 = ~obj24;
									float num17 = ((obj25 != null) ? num15 : 1f);
									double num18 = 1.0 - (double)num17;
									if (num15 < 0f)
									{
										return 1f;
									}
									return (float)num18;
								}
							}
						}
					}
				}
			}
			throw new NullReferenceException();
			IL_0091:
			bool flag13 = obj5 == null;
			bool flag14 = !flag13;
			result = 0f;
			num = 0f;
			obj9 = 0;
			if (!flag14)
			{
				goto IL_00d8;
			}
			goto IL_0190;
		}
	}

	private ScrollRect ScrollRect
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_019e: Expected O, but got I
			//IL_0179: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79ED]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 120;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 120;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 != null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			obj4 = obj8;
			object obj11 = 0;
			if (obj10 != null)
			{
				goto IL_00dc;
			}
			goto IL_0198;
			IL_00dc:
			return (ScrollRect)obj4;
			IL_0198:
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			ScrollRect scrollRect = default(ScrollRect);
			_scrollRect = scrollRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return scrollRect;
			IL_00a0:
			bool flag5 = obj5 != null;
			bool flag6 = !flag5;
			obj11 = 0;
			obj8 = obj4;
			if (!flag6)
			{
				goto IL_00dc;
			}
			goto IL_0198;
		}
	}

	private RectTransform Content
	{
		get
		{
			ScrollRect scrollRect = ScrollRect;
			if ((object)scrollRect != null)
			{
				return scrollRect.m_Content;
			}
			return (RectTransform)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_0014: Expected I4, but got I8
		//IL_002e: Expected O, but got I4
		int num = (int)(selectedIndex & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			SnapToIndex(selectedIndex);
			return;
		}
		RefreshNearestItem();
		SnapTo(<NearestItem>k__BackingField);
	}

	private void Update()
	{
		//IL_0356: Expected O, but got I
		//IL_035f: Expected O, but got I4
		//IL_0195: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_023c: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0080: Expected O, but got I4
		//IL_0383: Expected I4, but got O
		//IL_01e0: Expected O, but got I
		//IL_02ef: Expected I4, but got O
		//IL_0259: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		RefreshNearestItem();
		bool flag = !_isDragging;
		IntPtr intPtr = default(IntPtr);
		object obj = (nint)intPtr;
		object obj2 = 152989696;
		RectTransform rectTransform;
		RectTransform rectTransform2;
		if (!flag)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			obj2 = this + 96;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v3-10]");
				bool flag2 = (UnityEngine.Object)0 != (UnityEngine.Object)obj2;
				bool flag3 = !flag2;
				object obj5 = !flag3;
				rectTransform = null;
				if (obj5 != null)
				{
					goto IL_00f8;
				}
				rectTransform2 = null;
				obj = obj2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v3-10]");
				bool flag4 = (UnityEngine.Object)0 != (UnityEngine.Object)obj2;
				bool flag5 = !flag4;
				rectTransform = null;
				rectTransform2 = null;
				obj = obj2;
				if (!flag5)
				{
					goto IL_00f8;
				}
			}
		}
		goto IL_0173;
		IL_00f8:
		obj = <NearestItem>k__BackingField;
		_lastReportedNearest = <NearestItem>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag6 = OnNearestChangedWhileDragging == null;
		rectTransform2 = rectTransform;
		if (!flag6)
		{
			obj = <NearestItem>k__BackingField;
			object obj6 = (nint)0 + (nint)1072;
			rectTransform2 = (RectTransform)obj6;
			((UnityEvent<object>)(object)OnNearestChangedWhileDragging).Invoke((object)<NearestItem>k__BackingField);
		}
		goto IL_0173;
		IL_0173:
		int currentIndex = CurrentIndex;
		bool flag7 = currentIndex == _lastReportedIndex;
		int num = (int)obj;
		if (!flag7)
		{
			_lastReportedIndex = currentIndex;
			bool flag8 = OnIndexChanged == null;
			num = currentIndex;
			if (!flag8)
			{
				object obj7 = (nint)0 + (nint)976;
				rectTransform2 = (RectTransform)obj7;
				OnIndexChanged.Invoke(currentIndex);
				num = currentIndex;
			}
		}
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (behaviors != null)
		{
			object obj8 = (nint)0 + (nint)1056;
			obj2 = (nint)0 + (nint)1048;
			List<object>.Enumerator enumerator = ((List<object>)(object)behaviors).GetEnumerator();
			num = (int)obj8;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj9 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj10 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag9 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj2;
			enumerator2.Dispose();
			object obj11 = default(object);
			if (obj11 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj10 = obj11;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223AD84");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 96;
		obj = <NearestItem>k__BackingField;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		_isDragging = false;
		ScrollRect scrollRect = ScrollRect;
		scrollRect.StopMovement();
		RefreshNearestItem();
		SnapTo(<NearestItem>k__BackingField);
		if (OnSnappedAfterDrag != null)
		{
			((UnityEvent<object>)(object)OnSnappedAfterDrag).Invoke((object)<NearestItem>k__BackingField);
		}
	}

	private void RefreshNearestItem()
	{
		//IL_0d6a: Expected O, but got I
		//IL_0d73: Expected O, but got I4
		//IL_0055: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_008e: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_02b4: Expected F8, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_02f8: Expected F8, but got I4
		//IL_0311: Expected O, but got I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0353: Expected O, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0387: Expected F8, but got I4
		//IL_03a8: Expected F8, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03ba: Expected F8, but got I4
		//IL_0e05: Expected O, but got F8
		//IL_0c81: Expected O, but got I4
		//IL_0e56: Expected O, but got I
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected O, but got Unknown
		//IL_050f: Expected O, but got I
		//IL_0a77: Expected O, but got I4
		//IL_0a80: Expected O, but got I4
		//IL_0e1a: Expected O, but got I
		//IL_0580: Expected I, but got O
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_1072: Expected O, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0ab6: Expected I, but got O
		//IL_0ac6: Expected O, but got I
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected O, but got Unknown
		//IL_10b4: Expected O, but got I
		//IL_0b01: Expected O, but got I
		//IL_0ed7: Expected O, but got I
		//IL_0618: Expected O, but got I
		//IL_0e9b: Expected O, but got I
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got Unknown
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected I, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_0bd0: Expected O, but got I4
		//IL_0735: Expected O, but got I4
		//IL_0768: Expected O, but got I
		//IL_078a: Expected O, but got I4
		//IL_07fb: Expected O, but got I4
		//IL_0c5d: Expected F8, but got I4
		//IL_0c66: Expected O, but got I4
		//IL_0859: Expected O, but got I4
		//IL_0862: Expected I4, but got O
		//IL_0886: Expected F8, but got I4
		//IL_0c30: Expected F8, but got I4
		//IL_0c39: Expected O, but got I4
		//IL_0c46: Expected O, but got I4
		//IL_08c6: Expected O, but got I4
		//IL_08f3: Expected F8, but got I4
		//IL_0f72: Invalid comparison between F8 and I4
		//IL_0f81: Invalid comparison between F8 and I4
		//IL_0f99: Expected O, but got F8
		//IL_0fa6: Expected O, but got F8
		//IL_0fdb: Expected O, but got I4
		//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected O, but got Unknown
		//IL_101c: Invalid comparison between F8 and I4
		//IL_0c11: Expected F8, but got I4
		//IL_0c19: Expected O, but got I4
		//IL_093e: Expected I4, but got O
		//IL_0954: Expected O, but got I
		//IL_0990: Expected I4, but got F8
		//IL_09ae: Expected O, but got I
		//IL_09be: Expected O, but got I
		//IL_09e7: Expected O, but got I4
		//IL_03cf: Expected O, but got I
		//IL_03df: Expected F8, but got I
		//IL_03ef: Expected O, but got I
		//IL_0420: Expected F8, but got I4
		//IL_0430: Expected I4, but got F8
		//IL_0438: Expected O, but got F8
		//IL_0459: Expected F8, but got I4
		//IL_0491: Expected I4, but got F8
		//IL_0a2f: Expected O, but got I
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected O, but got Unknown
		//IL_0a5d: Expected O, but got I4
		List<ScrollSnapItemProximity> itemProximities = _itemProximities;
		bool flag = _itemProximities == null;
		double num2 = default(double);
		double num = num2;
		double num4 = default(double);
		double num3 = num4;
		double num6 = default(double);
		double num5 = num6;
		IntPtr intPtr = default(IntPtr);
		Vector3 vector = (Vector3)(nint)intPtr;
		RectTransform rectTransform = (RectTransform)152989696;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
			int num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+1C]");
			nint num8 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
			bool flag2 = (nint)0 < (nint)1;
			vector = (Vector3)(nint)intPtr;
			object obj = default(object);
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+10]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
				Array.Clear((Array)num9, 0, 0);
				obj = 0;
				vector = (Vector3)0;
			}
			ScrollRect scrollRect = ScrollRect;
			bool flag3 = (object)scrollRect == null;
			num = num2;
			num3 = num4;
			num5 = num6;
			rectTransform = (RectTransform)152989696;
			if (!flag3)
			{
				rectTransform = scrollRect.m_Viewport;
				ScrollRect scrollRect2 = ScrollRect;
				bool flag4 = (object)scrollRect2 == null;
				num = num2;
				num3 = num4;
				num5 = num6;
				if (!flag4)
				{
					bool flag5 = (object)scrollRect2.m_Viewport == null;
					num = num2;
					num3 = num4;
					num5 = num6;
					if (!flag5)
					{
						object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
						Rect rect = scrollRect2.m_Viewport.rect;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v31+E4]");
						itemProximities = (List<ScrollSnapItemProximity>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v31+E4]");
						bool flag6 = (nint)0 == 0;
						object obj4 = !flag6;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = (object)rectTransform == null;
						num = num2;
						num3 = num4;
						num5 = num6;
						double num11 = default(double);
						double num10 = num11;
						double num12 = num2;
						vector = (Vector3)0;
						if (!flag7)
						{
							double num13 = num11 * 0.5;
							num3 = num4 + num13;
							double num14 = num2 * 0.5;
							num5 = num6 + num14;
							Vector3 vector2 = rectTransform.TransformPoint((Vector3)0);
							ScrollRect scrollRect3 = ScrollRect;
							bool flag8 = (object)scrollRect3 == null;
							num = 0.0;
							num10 = num11;
							num12 = num2;
							vector = (Vector3)0;
							if (!flag8)
							{
								bool flag9 = (object)scrollRect3.m_Content == null;
								num = 0.0;
								num10 = num11;
								num12 = num2;
								vector = (Vector3)0;
								if (!flag9)
								{
									object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
									object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
									object obj7 = (nint)0 + (nint)848;
									object obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
									IEnumerator enumerator = scrollRect3.m_Content.GetEnumerator();
									Component component = null;
									double num15 = 0.0;
									double num16 = num3;
									double num17 = num5;
									double num18 = num11;
									double num19 = 2139095039.0;
									ScrollSnapItemProximity scrollSnapItemProximity = (ScrollSnapItemProximity)0;
									double num20 = 2139095039.0;
									List<ScrollSnapItemProximity> list = default(List<ScrollSnapItemProximity>);
									object obj10 = default(object);
									object obj11 = default(object);
									bool flag10 = default(bool);
									object obj15 = default(object);
									object obj19 = default(object);
									object obj21 = default(object);
									object obj25 = default(object);
									Component component2 = default(Component);
									ScrollSnapItemProximity scrollSnapItemProximity2 = default(ScrollSnapItemProximity);
									List<ScrollSnapItemProximity> list2 = default(List<ScrollSnapItemProximity>);
									object obj13 = default(object);
									object obj48 = default(object);
									List<ScrollSnapItemProximity> list3 = default(List<ScrollSnapItemProximity>);
									while (true)
									{
										IL_0d8c:
										list = list;
										object obj9 = obj10;
										obj11 = obj11;
										flag10 = flag10;
										object obj12 = obj13;
										num = num15;
										double num21 = num16;
										double num22 = num17;
										num10 = num18;
										num12 = num19;
										object obj14 = obj;
										vector = (Vector3)scrollSnapItemProximity;
										nint num23 = num8;
										int num24 = num7;
										itemProximities = (List<ScrollSnapItemProximity>)num20;
										object obj26;
										while (true)
										{
											if (obj15 != null)
											{
												object obj16 = obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v20+12E]");
												num8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v20+12E]");
												if ((nint)0 == 0)
												{
													goto IL_0560;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v20+B0]");
												object obj17 = (nint)0 + (nint)8;
												while (true)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X10_v25-8]");
													obj9 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X10_v25-8]");
													if (0 == (nint)obj5)
													{
														break;
													}
													obj12 = obj17 + 16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v20+12E]");
													num8 = -1;
													bool flag11 = num8 != 1;
													obj17 = obj12;
													if (flag11)
													{
														continue;
													}
													goto IL_0560;
												}
												num8 = (nint)obj17;
												object obj18 = obj16 + obj17;
												obj19 = obj18 + 312;
												obj12 = obj17;
												goto IL_0e3e;
											}
											NullReferenceException ex = new NullReferenceException();
											goto IL_0c6b;
											IL_0e3e:
											itemProximities = (List<ScrollSnapItemProximity>)obj19;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v43+8]");
											vector = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v820 @ X0_v43] (should have been resolved before IL gen)");
											object obj20 = obj21 & 1;
											if (obj20 == null)
											{
												break;
											}
											if (obj15 != null)
											{
												object obj22 = obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v23+12E]");
												num23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v23+12E]");
												if ((nint)0 == 0)
												{
													goto IL_0669;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v23+B0]");
												object obj23 = (nint)0 + (nint)8;
												while (true)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X10_v20-8]");
													obj9 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X10_v20-8]");
													if (0 == (nint)obj5)
													{
														break;
													}
													obj12 = obj23 + 16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v23+12E]");
													num23 = -1;
													bool flag12 = num23 != 1;
													obj23 = obj12;
													if (flag12)
													{
														continue;
													}
													goto IL_0669;
												}
												num23 = (nint)(obj23 + 1);
												object obj24 = obj22 + num23;
												obj25 = obj24 + 312;
												obj12 = obj23;
												goto IL_0ebf;
											}
											NullReferenceException ex2 = new NullReferenceException();
											goto IL_0c6b;
											IL_0669:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											num24 = 1;
											goto IL_0ebf;
											IL_0c6b:
											obj13 = obj12;
											obj26 = 0;
											num3 = num21;
											num5 = num22;
											obj = obj14;
											num7 = num24;
											rectTransform = (RectTransform)component;
											goto end_IL_0d8c;
											IL_0ebf:
											itemProximities = (List<ScrollSnapItemProximity>)obj25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X0_v47+8]");
											vector = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v883 @ X0_v47] (should have been resolved before IL gen)");
											if ((object)component2 != null)
											{
												vector = (Vector3)obj6;
												itemProximities = (List<ScrollSnapItemProximity>)(object)component2;
												if (component2 == obj6)
												{
													GameObject gameObject = component2.gameObject;
													if ((object)gameObject != null)
													{
														bool activeInHierarchy = gameObject.activeInHierarchy;
														bool flag13 = !activeInHierarchy;
														vector = (Vector3)0;
														if (flag13)
														{
															continue;
														}
														Rect rect2 = ((RectTransform)component2).rect;
														object obj27 = obj2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v59+E4]");
														itemProximities = (List<ScrollSnapItemProximity>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v59+E4]");
														bool flag14 = (nint)0 == 0;
														object obj28 = !flag14;
														if (obj28 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														double num25 = num * 0.5;
														num22 += num25;
														double num26 = num11 * 0.5;
														num21 += num26;
														Vector3 vector3 = ((Transform)component2).TransformPoint((Vector3)0);
														ScrollRect scrollRect4 = ScrollRect;
														if ((object)scrollRect4 != null)
														{
															num22 -= num5;
															bool flag15 = !scrollRect4.m_Horizontal;
															object obj29 = !flag15;
															num10 = (((int)(~obj29) != 0) ? 0.0 : num22);
															ScrollRect scrollRect5 = ScrollRect;
															if ((object)scrollRect5 != null)
															{
																bool flag16 = scrollRect5.m_Vertical;
																double num27 = num21 - num3;
																bool flag17 = !scrollRect5.m_Vertical;
																object obj30 = !flag17;
																object obj31 = ~obj30;
																num12 = ((obj31 != null) ? 0.0 : num27);
																list = _itemProximities;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																double num28 = num12 / (double)proximityMaxDistance;
																double num29 = num28 - 1.0;
																bool flag18 = num29 < 0.0;
																bool flag19 = num29 == 0.0;
																object obj32 = num28 ^ 1.0;
																object obj33 = num28 ^ num29;
																object obj34 = obj32 & obj33;
																bool flag20 = (nint)obj34 < 0;
																bool flag21 = flag18 == flag20;
																obj11 = !flag19;
																object obj35 = flag21 & obj11;
																object obj36 = ~obj35;
																double num30 = ((obj36 != null) ? num28 : 1.0);
																num21 = 1.0 - num30;
																flag10 = !(num28 < 0.0);
																num22 = (flag10 ? num21 : 1.0);
																bool flag22 = list == null;
																vector = (Vector3)component2;
																if (!flag22)
																{
																	flag16 = (byte)(int)obj7 != 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+1C]");
																	object obj37 = (nint)0 + (nint)1;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+10]");
																	num23 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+10]");
																	bool flag23 = (nint)0 == 0;
																	vector = (Vector3)scrollSnapItemProximity2;
																	num24 = (int)num22;
																	if (!flag23)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
																		obj12 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X9_v21 (Il2CppClass<System.Collections.Generic.List`1<ScrollSnapItemProximity>>)+18]");
																		obj9 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
																		nint num31 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X9_v21 (Il2CppClass<System.Collections.Generic.List`1<ScrollSnapItemProximity>>)+18]");
																		bool flag24 = num31 < 0;
																		object obj38 = !flag24;
																		if (obj38 != null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v30 (System.Boolean)+20]");
																			object obj39 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v34+C0]");
																			num20 = 0.0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v17 (System.Double)+70]");
																			obj14 = 0;
																			list.AddWithResize(scrollSnapItemProximity2);
																			scrollSnapItemProximity = scrollSnapItemProximity2;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
																			num20 = 0.0 + 1.0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+10]");
																			nint num32 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v10 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+18]");
																			object obj40 = num32 + 0;
																			object obj41 = obj40 + 32;
																			obj41 = scrollSnapItemProximity2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			scrollSnapItemProximity = (ScrollSnapItemProximity)0;
																		}
																		bool flag25 = num12 < num19;
																		num = 0.0;
																		vector = (Vector3)scrollSnapItemProximity;
																		num24 = (int)num22;
																		itemProximities = (List<ScrollSnapItemProximity>)num20;
																		obj10 = obj9;
																		obj13 = obj12;
																		component = component2;
																		num15 = 0.0;
																		num16 = num21;
																		num17 = num22;
																		num18 = num10;
																		num19 = num12;
																		obj = obj14;
																		num8 = num23;
																		num7 = (int)num22;
																		if (!flag25)
																		{
																			continue;
																		}
																		goto IL_0d8c;
																	}
																}
																NullReferenceException ex3 = new NullReferenceException();
																num = 0.0;
																itemProximities = (List<ScrollSnapItemProximity>)flag16;
															}
															else
															{
																NullReferenceException ex4 = new NullReferenceException();
																num = 0.0;
																vector = (Vector3)0;
																itemProximities = (List<ScrollSnapItemProximity>)scrollRect4.m_Horizontal;
															}
														}
														else
														{
															NullReferenceException ex5 = new NullReferenceException();
															num = 0.0;
															vector = (Vector3)0;
														}
													}
													else
													{
														NullReferenceException ex6 = new NullReferenceException();
														vector = (Vector3)0;
													}
												}
												else
												{
													InvalidCastException ex7 = new InvalidCastException();
												}
											}
											else
											{
												NullReferenceException ex8 = new NullReferenceException();
											}
											goto IL_0c6b;
											IL_0560:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											num24 = 0;
											goto IL_0e3e;
										}
										obj13 = obj12;
										obj26 = 0;
										object obj42 = 0;
										num3 = num21;
										num5 = num22;
										obj = obj14;
										num7 = num24;
										rectTransform = (RectTransform)component;
										while (true)
										{
											vector = (Vector3)obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											if (list2 == null)
											{
												goto IL_1058;
											}
											nint num33 = (nint)list2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v6 (Il2CppClass<System.Collections.Generic.List`1<ScrollSnapItemProximity>>)+12E]");
											object obj43 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v6 (Il2CppClass<System.Collections.Generic.List`1<ScrollSnapItemProximity>>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_0b4a;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v6 (Il2CppClass<System.Collections.Generic.List`1<ScrollSnapItemProximity>>)+B0]");
											object obj44 = (nint)0 + (nint)8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v7-8]");
												if (0 == (nint)obj8)
												{
													break;
												}
												obj13 = obj44 + 16;
												obj43--;
												bool flag26 = (nint)obj43 != 1;
												obj44 = obj13;
												if (flag26)
												{
													continue;
												}
												goto IL_0b4a;
											}
											object obj45 = num33 + obj44;
											itemProximities = (List<ScrollSnapItemProximity>)(obj45 + 312);
											obj13 = obj44;
											goto IL_10a4;
											IL_1058:
											bool flag27 = obj42 == null;
											object obj46 = !flag27;
											if (obj46 == null)
											{
												object obj47 = this + 80;
												obj47 = rectTransform;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												return;
											}
											OutOfMemoryException ex9 = new OutOfMemoryException();
											if ((nint)vector != 1)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
											obj42 = obj48;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
											obj26 = obj48;
											continue;
											IL_0b4a:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											num7 = 0;
											itemProximities = list3;
											goto IL_10a4;
											IL_10a4:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)+8]");
											vector = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X8_v5 (System.Collections.Generic.List`1<ScrollSnapItemProximity>)] (should have been resolved before IL gen)");
											goto IL_1058;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
										return;
										continue;
										end_IL_0d8c:
										break;
									}
								}
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void SnapToNearest()
	{
		RefreshNearestItem();
		SnapTo(<NearestItem>k__BackingField);
	}

	public unsafe void SnapToIndex(int index)
	{
		//IL_0581: Expected I4, but got I8
		//IL_059b: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_04ea: Expected O, but got I4
		//IL_00dc: Expected I, but got O
		//IL_00ec: Expected O, but got I
		//IL_0187: Expected I, but got O
		//IL_05e1: Expected I, but got O
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_039b: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_0719: Expected I4, but got O
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_06c0: Expected O, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_03c6: Expected O, but got I
		//IL_01e1: Expected I, but got O
		//IL_01f1: Expected O, but got I
		//IL_0459: Expected I, but got O
		//IL_0401: Expected O, but got I
		//IL_0652: Expected I, but got O
		//IL_022c: Expected O, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected I, but got Unknown
		//IL_02d3: Expected I4, but got O
		//IL_02db: Expected I, but got O
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79F1]");
		nint num = 0;
		int num2 = (int)(index & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		ScrollRect scrollRect = ScrollRect;
		bool flag2 = (object)scrollRect == null;
		int num3 = index;
		if (!flag2)
		{
			bool flag3 = (object)scrollRect.m_Content == null;
			num3 = index;
			if (!flag3)
			{
				object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				IEnumerator enumerator = scrollRect.m_Content.GetEnumerator();
				num3 = 0;
				object obj5 = default(object);
				num = (nint)(&obj5);
				Component component = default(Component);
				object obj10 = default(object);
				object obj12 = default(object);
				object obj15 = default(object);
				int num7 = default(int);
				object obj22 = default(object);
				IntPtr intPtr = default(IntPtr);
				Component component2 = default(Component);
				object obj16;
				while (true)
				{
					if ((object)component != null)
					{
						nint num4 = (nint)component;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v17 (Il2CppClass<UnityEngine.Component>)+12E]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v17 (Il2CppClass<UnityEngine.Component>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0178;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v17 (Il2CppClass<UnityEngine.Component>)+B0]");
						object obj7 = (nint)0 + (nint)8;
						object obj8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v25-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj8 = obj7 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v17 (Il2CppClass<UnityEngine.Component>)+12E]");
							obj6 = -1;
							bool flag4 = (nint)obj6 != 1;
							obj7 = obj8;
							if (flag4)
							{
								continue;
							}
							goto IL_0178;
						}
						obj6 = obj7;
						object obj9 = num4 + obj7;
						obj10 = obj9 + 312;
						obj8 = obj7;
						goto IL_05d9;
					}
					NullReferenceException ex = new NullReferenceException();
					break;
					IL_05d9:
					num = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v30+8]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ X0_v30] (should have been resolved before IL gen)");
					object obj11 = obj12 & 1;
					if (obj11 == null)
					{
						goto IL_0390;
					}
					if ((object)component != null)
					{
						nint num5 = (nint)component;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v21 (Il2CppClass<UnityEngine.Component>)+12E]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v21 (Il2CppClass<UnityEngine.Component>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_027d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v21 (Il2CppClass<UnityEngine.Component>)+B0]");
						object obj13 = (nint)0 + (nint)8;
						object obj8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v20-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj8 = obj13 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v21 (Il2CppClass<UnityEngine.Component>)+12E]");
							obj6 = -1;
							bool flag5 = (nint)obj6 != 1;
							obj13 = obj8;
							if (flag5)
							{
								continue;
							}
							goto IL_027d;
						}
						obj6 = obj13 + 1;
						object obj14 = num5 + obj6;
						obj15 = obj14 + 312;
						obj8 = obj13;
						goto IL_064a;
					}
					NullReferenceException ex2 = new NullReferenceException();
					break;
					IL_027d:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					nint num6 = 1;
					goto IL_064a;
					IL_0390:
					obj16 = 0;
					object obj17 = 0;
					while (true)
					{
						num3 = (int)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						if (num7 == 0)
						{
							goto IL_06a6;
						}
						int value = ((int*)num7)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v6 (System.Int32)+12E]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v6 (System.Int32)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_044a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v6 (System.Int32)+B0]");
						object obj19 = (nint)0 + (nint)8;
						object obj8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X10_v8-8]");
							if (0 == (nint)obj4)
							{
								break;
							}
							obj8 = obj19 + 16;
							obj18--;
							bool flag6 = (nint)obj18 != 1;
							obj19 = obj8;
							if (flag6)
							{
								continue;
							}
							goto IL_044a;
						}
						object obj20 = value + obj19;
						num = (nint)(obj20 + 312);
						obj8 = obj19;
						goto IL_06f2;
						IL_06a6:
						bool flag7 = obj17 == null;
						object obj21 = !flag7;
						if (obj21 == null)
						{
							return;
						}
						OutOfMemoryException ex3 = new OutOfMemoryException();
						if (num3 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj17 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						obj16 = obj22;
						continue;
						IL_044a:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						num6 = unchecked((nint)null);
						num = intPtr;
						goto IL_06f2;
						IL_06f2:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v5 (Il2CppClass<UnityEngine.Component>)+8]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ X8_v5 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
						goto IL_06a6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
					IL_064a:
					num = (nint)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v35+8]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v623 @ X0_v35] (should have been resolved before IL gen)");
					if ((object)component2 != null)
					{
						num3 = (int)obj3;
						num = (nint)component2;
						if (component2 == obj3)
						{
							GameObject gameObject = component2.gameObject;
							if ((object)gameObject != null)
							{
								bool activeInHierarchy = gameObject.activeInHierarchy;
								bool flag8 = !activeInHierarchy;
								num3 = 0;
								if (flag8)
								{
									continue;
								}
								bool flag9 = 0 != index;
								num3 = 0;
								if (flag9)
								{
									continue;
								}
								SnapTo((RectTransform)component2);
								goto IL_0390;
							}
							NullReferenceException ex4 = new NullReferenceException();
							num3 = 0;
							break;
						}
						InvalidCastException ex5 = new InvalidCastException();
						break;
					}
					NullReferenceException ex6 = new NullReferenceException();
					break;
					IL_0178:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num6 = unchecked((nint)null);
					goto IL_05d9;
				}
				obj16 = 0;
			}
		}
		throw new NullReferenceException();
	}

	public void SnapTo(RectTransform targetRect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_0314: Expected O, but got I4
		//IL_0441: Expected F4, but got I
		//IL_0441: Expected O, but got I4
		//IL_0451: Expected O, but got I
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_048a: Expected O, but got I
		//IL_049b: Expected I, but got O
		//IL_04ac: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag = targetRect == null;
			bool flag2 = !flag;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = targetRect == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj8 != null)
			{
				return;
			}
		}
		ScrollRect scrollRect = ScrollRect;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(scrollRect.m_Content);
		ScrollRect scrollRect2 = ScrollRect;
		ScrollRect scrollRect3 = ScrollRect;
		Rect rect = scrollRect3.m_Viewport.rect;
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = default(object);
		double num = (double)obj15 * 0.5;
		object obj16 = default(object);
		double num2 = (double)obj16 + num;
		object obj17 = default(object);
		double num3 = (double)obj17 * 0.5;
		object obj18 = default(object);
		double num4 = (double)obj18 + num3;
		Vector3 vector = scrollRect2.m_Viewport.TransformPoint((Vector3)0);
		Rect rect2 = targetRect.rect;
		double num5 = 0.0 * 0.5;
		double num6 = num4 + num5;
		double num7 = num * 0.5;
		double num8 = num2 + num7;
		Vector3 vector2 = targetRect.TransformPoint((Vector3)0);
		ScrollRect scrollRect4 = ScrollRect;
		double num9 = num4 - num6;
		double num10 = num2 - num8;
		Vector3 vector3 = scrollRect4.m_Viewport.InverseTransformVector((Vector3)0);
		ScrollRect scrollRect5 = ScrollRect;
		Vector2 anchoredPosition = scrollRect5.m_Content.anchoredPosition;
		ScrollRect scrollRect6 = ScrollRect;
		if (scrollRect6.m_Horizontal)
		{
			double num11 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+18]");
			double num12 = num11 + 0.0;
		}
		ScrollRect scrollRect7 = ScrollRect;
		if (scrollRect7.m_Vertical)
		{
			double num13 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+1C]");
			double num14 = num13 + 0.0;
		}
		ScrollRect scrollRect8 = ScrollRect;
		scrollRect8.StopMovement();
		ScrollRect scrollRect9 = ScrollRect;
		int num15 = ShortcutExtensions.DOKill(scrollRect9.m_Content);
		ScrollRect scrollRect10 = ScrollRect;
		RectTransform content = scrollRect10.m_Content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+18]");
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(content, (Vector2)0, 0f);
		object obj19 = (nint)0 + (nint)2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)1736;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj21);
		object obj22 = (nint)0 + (nint)2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public ScrollSnapToNearest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_003e: Expected I4, but got I8
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3208;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3200;
		snapDuration = 0.2f;
		proximityMaxDistance = 0f / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 48;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_lastReportedIndex = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<ScrollSnapItemProximity> list2 = default(List<ScrollSnapItemProximity>);
		list2..ctor();
		object obj4 = this + 112;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
