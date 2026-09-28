using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Maro.UILineDrawer;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class SwipeCaptcha : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	private sealed class <>c__DisplayClass34_0
	{
		public SwipeCaptcha <>4__this;

		public List<Vector2> result;

		internal void <CheckFinish>b__0()
		{
			SwipeCaptcha swipeCaptcha = <>4__this;
			if (swipeCaptcha.OnSwipeFinish != null)
			{
				((UnityEvent<object>)(object)swipeCaptcha.OnSwipeFinish).Invoke((object)result);
			}
		}
	}

	private float pointerPathThreshold;

	private float headGrabThreshold;

	private float edgeMinThreshold;

	private float edgeMaxThreshold;

	private float successDelay;

	private float splineToLocalScale;

	private float smoothing;

	private float targetOverhang;

	private UILineDrawer basePath;

	private UILineDrawer fillPath;

	private RectTransform fillPathHead;

	private RectTransform fillPathEnd;

	private RectTransform fillPathTarget;

	private GameObject blocker;

	public UnityEvent<List<Vector2>> OnSwipeFinish;

	private const int MAX_ADVANCES_PER_DRAG = 32;

	private bool _lockShape;

	private bool _isDrawing;

	private bool _pointsDirty;

	private bool _interactable;

	private Vector2 _pathEnd;

	private readonly List<Vector2> _drawPoints;

	private readonly List<BezierKnot2D> _knotBuffer;

	public bool Interactable
	{
		get
		{
			return _interactable;
		}
		set
		{
			_interactable = value;
			bool active = (byte)((value ? 1u : 0u) ^ 1u) != 0;
			blocker.SetActive(active);
			bool lockShape = (byte)((_interactable ? 1u : 0u) ^ 1u) != 0;
			_lockShape = lockShape;
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		//IL_0046: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_0170: Invalid comparison between F4 and I4
		List<Vector2> drawPoints = _drawPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		if ((nint)0 < (nint)2)
		{
			return;
		}
		bool flag = !_lockShape;
		object obj = !flag;
		if (obj == null)
		{
			float2 pointerOnPath = GetPointerOnPath(eventData);
			List<Vector2> drawPoints2 = _drawPoints;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			int index = (int)(-1);
			object obj2 = (nint)0 + (nint)3352;
			Vector2 vector = drawPoints2.get_Item(index);
			object obj3 = default(object);
			float num = (float)obj3 * splineToLocalScale;
			object obj4 = default(object);
			float num2 = (float)obj4 * splineToLocalScale;
			float2 @float = (Vector2)0;
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num3 = num2 - (float)obj4;
			float num4 = num - (float)obj3;
			float num5 = num4 * num4;
			float num6 = num3 * num3;
			float num7 = num5 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num8 = num7 - headGrabThreshold;
			bool isDrawing = num8 < 0f;
			_isDrawing = isDrawing;
		}
	}

	public unsafe void OnDrag(PointerEventData eventData)
	{
		//IL_003e: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_009d: Expected O, but got Ref
		//IL_00ab: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_021d: Expected O, but got I4
		//IL_0131: Invalid comparison between O and F4
		//IL_0161: Expected O, but got I4
		//IL_0247: Expected O, but got I4
		//IL_0170: Expected O, but got Ref
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		if (!_isDrawing)
		{
			return;
		}
		bool flag = !_lockShape;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		float2 pointerOnPath = GetPointerOnPath(eventData);
		UILineDrawer uILineDrawer = basePath;
		Vector2 vector = (float2)0;
		object obj2 = default(object);
		Vector2 closestPoint = uILineDrawer._spline.GetClosestPoint((Vector2)(&obj2), out *(float*)10, 5, 0);
		float2 @float = (Vector2)0;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default(object);
		object obj6 = obj7 - obj7;
		object obj9 = default(object);
		object obj8 = obj9 - obj9;
		object obj10 = obj8 * obj8;
		object obj11 = obj6 * obj6;
		object obj12 = obj10 + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (obj12 > (object)pointerPathThreshold)
		{
			_isDrawing = false;
			return;
		}
		object obj13 = 32;
		do
		{
			bool flag3 = !_lockShape;
			object obj14 = !flag3;
			if (obj14 != null || !TryAdvanceTowards((float2)(&obj2)))
			{
				break;
			}
			CheckFinish();
			obj13--;
		}
		while ((nint)obj13 != 1);
		if (_pointsDirty)
		{
			UpdateFillPath();
		}
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		_isDrawing = false;
	}

	public void InitPath(List<Vector2> points)
	{
		//IL_0085: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		int index = (int)(-1);
		Vector2 vector = points.get_Item(index);
		Vector2 pathEnd = default(Vector2);
		_pathEnd = pathEnd;
		SetSmoothedKnots(basePath, points);
		InitFillPath(points);
		UpdateFillPath();
		PositionEndMarkers(points);
		fillPathEnd.localScale = (Vector3)0;
		fillPathTarget.localScale = (Vector3)0;
		_interactable = true;
		blocker.SetActive(value: false);
		bool lockShape = (byte)((_interactable ? 1u : 0u) ^ 1u) != 0;
		_lockShape = lockShape;
	}

	public void ShowPathStart()
	{
		//IL_0037: Expected O, but got I4
		//IL_004c: Expected O, but got I
		//IL_005c: Expected O, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_00b8: Expected F4, but got I
		//IL_00b8: Expected O, but got I4
		List<Vector2> drawPoints = _drawPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		int num = (int)(-1);
		Vector2 vector = drawPoints.get_Item(num);
		Vector3 vector2 = PathToRootLocal((Vector2)num);
		object obj = (nint)0 + (nint)2904;
		fillPathHead.localPosition = (Vector3)0;
		object obj2 = typeof(UsageHint) + 816;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8+B8]");
		object obj4 = 0;
		RectTransform target = fillPathHead;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, (Vector3)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0087: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0165: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0229: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		object obj = typeof(List<Tween>) + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Vector2> list = default(List<Vector2>);
		list..ctor();
		object obj2 = (nint)0 + (nint)3304;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
		object obj4 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v4+18]");
		bool flag = num < 0;
		object obj6 = !flag;
		object obj7;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			obj7 = (nint)0 + (nint)1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj9 = obj8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253588]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
			object obj10 = (nint)0 + (nint)2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v5+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v21+C0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v22+70]");
			list.AddWithResize((Vector2)0);
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
			object obj13 = (nint)0 + (nint)1;
		}
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v4+18]");
		bool flag2 = (nint)obj14 < 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			object obj16 = obj7 + 1;
			object obj17 = obj5 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253590]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v5+20]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v17+C0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v18+70]");
			list.AddWithResize((Vector2)0);
		}
		InitPath(list);
		fillPathHead.localScale = (Vector3)0;
		fillPathEnd.localScale = (Vector3)0;
	}

	private unsafe bool TryAdvanceTowards(float2 target)
	{
		//IL_0722: Expected I4, but got O
		//IL_0011: Expected O, but got I
		//IL_0066: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_07d1: Invalid comparison between F4 and I4
		//IL_07e0: Expected F8, but got I4
		//IL_0889: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_033c: Expected O, but got I4
		//IL_0356: Invalid comparison between F4 and I4
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_020b: Invalid comparison between F8 and I4
		//IL_021a: Invalid comparison between F8 and I4
		//IL_0232: Expected O, but got F8
		//IL_023f: Expected O, but got F8
		//IL_0274: Expected O, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0554: Expected O, but got I
		//IL_056e: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_08c1: Expected O, but got I4
		//IL_0835: Invalid comparison between F8 and I4
		//IL_0844: Expected F4, but got I4
		//IL_06aa: Expected O, but got I4
		//IL_06c4: Invalid comparison between F4 and I4
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_0616: Expected O, but got I4
		//IL_043c: Expected O, but got I4
		//IL_0483: Expected O, but got Ref
		//IL_0491: Expected O, but got I4
		//IL_04b0: Expected O, but got I
		//IL_0529: Expected O, but got Ref
		List<Vector2> drawPoints = _drawPoints;
		float num;
		float num3;
		int num5;
		ref float reference;
		object obj2;
		double num16;
		float num29;
		float num31;
		float num32;
		float num33;
		float2 newPoint;
		float num41;
		float num42;
		int num34;
		int num36;
		float num38;
		float num39;
		double num40;
		ref float reference2;
		if (_drawPoints != null)
		{
			object obj = (nint)0 + (nint)3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			int index = (int)(-1);
			Vector2 vector = _drawPoints.get_Item(index);
			float num2 = default(float);
			num = num2 * splineToLocalScale;
			float num4 = default(float);
			num3 = num4 * splineToLocalScale;
			float2 @float = (Vector2)0;
			List<Vector2> drawPoints2 = _drawPoints;
			if (_drawPoints != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				num5 = (int)(-2);
				reference = ref *(float*)obj;
				Vector2 vector2 = _drawPoints.get_Item(num5);
				float num6 = num * splineToLocalScale;
				float num7 = num3 * splineToLocalScale;
				float2 float2 = (Vector2)0;
				float num8 = num2 - num;
				float num9 = num4 - num3;
				float num10 = num - num6;
				float num11 = num3 - num7;
				Vector2 vector3 = (float2)0;
				Vector2 vector4 = (float2)0;
				obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				float num12 = num10 * num10;
				float num13 = num11 * num11;
				float num14 = num12 + num13;
				float num15 = num8 * num8;
				num16 = (double)num9 * (double)num9;
				float num17 = num15 + (float)num16;
				float num18 = num14 * num17;
				bool flag = num18 < 228737630f;
				double num19 = 228737632.0;
				if (!flag)
				{
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v45+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num20 = num10 * num8;
					float num21 = num11 * num9;
					float num22 = num20 + num21;
					float num23 = num22 / 228737630f;
					double num24 = (double)num23 - 1.0;
					bool flag3 = num24 < 0.0;
					bool flag4 = num24 == 0.0;
					object obj5 = (double)num23 ^ 1.0;
					object obj6 = (double)num23 ^ num24;
					object obj7 = obj5 & obj6;
					bool flag5 = (nint)obj7 < 0;
					bool flag6 = flag3 == flag5;
					object obj8 = !flag4;
					object obj9 = flag6 & obj8;
					object obj10 = ~obj9;
					double num25 = ((obj10 != null) ? ((double)num23) : 1.0);
					double num26 = ((!((double)num23 < -1.0)) ? num25 : (-1.0));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0DB4");
					num19 = num26 * 1113927393.0;
					bool flag7 = num19 > 1119092736.0;
					num17 = 1.1190927E+09f;
					num16 = -1.0;
					if (flag7)
					{
						goto IL_0706;
					}
				}
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v22+E4]");
				bool flag8 = (nint)0 == 0;
				object obj12 = !flag8;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num27 = num8 * num8;
				float num28 = num9 * num9;
				num29 = num27 + num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				bool flag9 = num29 < edgeMinThreshold;
				object obj13 = !flag9;
				float num30 = num29 - edgeMinThreshold;
				bool flag10 = num30 == 0f;
				object obj14 = ~obj13;
				object obj15 = obj14 | flag10;
				if (obj15 != null)
				{
					goto IL_0706;
				}
				num31 = edgeMaxThreshold;
				if (!(num29 > edgeMaxThreshold))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FD]");
					object obj16 = (nint)0 & (nint)1;
					bool flag11 = obj16 == null;
					object obj17 = !flag11;
					num32 = num2;
					num33 = num4;
					int num35 = default(int);
					num34 = num35;
					int num37 = default(int);
					num36 = num37;
					num38 = edgeMaxThreshold;
					num39 = num29;
					num40 = num16;
					reference2 = ref reference;
					newPoint = (float2)num5;
					num41 = num2;
					num42 = num4;
					if (obj17 == null)
					{
						goto IL_05d6;
					}
					goto IL_0897;
				}
				UILineDrawer uILineDrawer = basePath;
				if ((object)basePath != null)
				{
					float num43 = num8 / num29;
					float num44 = num9 / num29;
					num16 = (double)num43 * (double)edgeMaxThreshold;
					float num45 = num44 * edgeMaxThreshold;
					num29 = num + (float)num16;
					num31 = num3 + num45;
					Vector2 vector5 = (float2)0;
					if (uILineDrawer._spline != null)
					{
						object obj18 = default(object);
						Vector2 closestPoint = uILineDrawer._spline.GetClosestPoint((Vector2)(&obj18), out *(float*)10, 5, 0);
						float2 float3 = (Vector2)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FD]");
						object obj19 = (nint)0 & (nint)1;
						bool flag12 = obj19 == null;
						reference = ref *(float*)10;
						num5 = (int)(&obj18);
						num32 = num29;
						num33 = num31;
						if (flag12)
						{
							goto IL_05d6;
						}
						num34 = 5;
						num36 = 0;
						num38 = num31;
						num39 = num29;
						num40 = num16;
						reference2 = ref *(float*)10;
						newPoint = (float2)(&obj18);
						num41 = num29;
						num42 = num31;
						goto IL_0897;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_05d6:
		_ = 1;
		num34 = 5;
		num36 = 0;
		num38 = num31;
		num39 = num29;
		num40 = num16;
		reference2 = ref reference;
		newPoint = (float2)num5;
		num41 = num32;
		num42 = num33;
		goto IL_0897;
		IL_0706:
		return false;
		IL_0897:
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v25+E4]");
		bool flag13 = (nint)0 == 0;
		object obj21 = !flag13;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num46 = num42 - num3;
		float num47 = num41 - num;
		float num48 = num47 * num47;
		float num49 = num46 * num46;
		float num50 = num48 + num49;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag14 = num50 < edgeMinThreshold;
		object obj22 = !flag14;
		float num51 = num50 - edgeMinThreshold;
		bool flag15 = num51 == 0f;
		object obj23 = ~obj22;
		object obj24 = obj23 | flag15;
		if (obj24 == null)
		{
			AddNewPoint(newPoint);
			return true;
		}
		goto IL_0706;
	}

	private void AddNewPoint(float2 newPoint)
	{
		//IL_013d: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00f8: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		List<Vector2> drawPoints = _drawPoints;
		Vector2 vector = (float2)0;
		object obj = (nint)0 + (nint)3304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
		object obj3 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
		object obj4 = 0;
		object obj5 = default(object);
		float num = (float)obj5 / splineToLocalScale;
		object obj6 = default(object);
		float num2 = (float)obj6 / splineToLocalScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v4+18]");
		bool flag = num3 < 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj9 = obj4 + 0;
			_pointsDirty = true;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v6+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v8+70]");
			drawPoints.AddWithResize((Vector2)0);
			_pointsDirty = true;
		}
	}

	private void CheckFinish()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_00a4: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_031d: Expected O, but got I4
		//IL_01b7: Expected O, but got I
		//IL_01df: Expected O, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_024b: Expected O, but got I
		//IL_025c: Expected I, but got O
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029f: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<Vector2> drawPoints = _drawPoints;
		object obj4 = (nint)0 + (nint)3352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		int index = (int)(-1);
		Vector2 vector = drawPoints.get_Item(index);
		object obj5 = default(object);
		float num = (float)obj5 * splineToLocalScale;
		object obj6 = default(object);
		float num2 = (float)obj6 * splineToLocalScale;
		float2 @float = (Vector2)0;
		float num3 = (float)_pathEnd * splineToLocalScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SwipeCaptcha)+80]");
		float num4 = 0f * splineToLocalScale;
		float2 float2 = (Vector2)0;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num5 = num4 - num2;
		float num6 = num3 - num;
		float num7 = num6 * num6;
		float num8 = num5 * num5;
		float num9 = num7 + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (!(num9 > edgeMinThreshold))
		{
			List<Vector2> drawPoints2 = _drawPoints;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			int index2 = (int)(-1);
			object value = (nint)0 + (nint)3360;
			drawPoints2.set_Item(index2, (Vector2)value);
			_lockShape = true;
			object obj10 = (nint)0 + (nint)3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9B7FC");
			IEnumerable<Vector2> source = default(IEnumerable<Vector2>);
			List<Vector2> list = Enumerable.ToList(source);
			object obj11 = obj2 + 24;
			obj11 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2328;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj13);
			object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj16 = !flag2;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(successDelay, action);
			AnimateHeadFinish();
		}
	}

	private void InitFillPath(List<Vector2> points)
	{
		//IL_001b: Expected O, but got I
		//IL_0037: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_02a0: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_02e3: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0206: Expected O, but got I4
		//IL_0340: Expected O, but got I
		//IL_0350: Expected O, but got I
		//IL_0365: Expected O, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0307: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		List<Vector2> drawPoints = _drawPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
		object obj = (nint)0 + (nint)1;
		_ = 0;
		object obj2 = (nint)0 + (nint)3352;
		object obj3 = (nint)0 + (nint)3304;
		Vector2 vector = points.get_Item(0);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
		object obj5 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v4+18]");
		bool flag = num < 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj9 = obj6 + 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v24+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v25+70]");
			drawPoints.AddWithResize((Vector2)0);
		}
		List<Vector2> drawPoints2 = _drawPoints;
		Vector2 vector2 = points.get_Item(0);
		Vector2 vector3 = points.get_Item(1);
		object obj13 = default(object);
		object obj12 = obj13 - obj13;
		object obj15 = default(object);
		object obj14 = obj15 - obj15;
		object obj16 = obj12 * obj12;
		object obj17 = obj14 * obj14;
		object obj18 = obj16 + obj17;
		bool flag2 = obj18 == null;
		object obj19 = !flag2;
		object obj20 = ~obj19;
		object obj21;
		bool flag4;
		if (obj20 == null)
		{
			bool flag3 = (nint)obj18 < 992204555;
			obj21 = !flag3;
			object obj22 = obj18 - 992204555;
			flag4 = obj22 == null;
		}
		else
		{
			flag4 = false;
			obj21 = 0;
		}
		object obj23 = ~obj21;
		object obj24 = obj23 | flag4;
		object obj25 = obj13;
		object obj26 = obj15;
		if (obj24 == null)
		{
			object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj29 = !flag5;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj30 = obj12 / obj15;
			object obj31 = obj30 * 1028443341;
			obj25 = obj13 + obj31;
			object obj32 = obj14 / obj15;
			object obj33 = obj32 * 1028443341;
			obj26 = obj15 + obj33;
		}
		object obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v4 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
		object obj35 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v4 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v4 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v7+18]");
		bool flag6 = num2 < 0;
		object obj37 = !flag6;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v4 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj38 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X20_v4 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj39 = obj36 + 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v12+20]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v15+C0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v16+70]");
			drawPoints2.AddWithResize((Vector2)0);
		}
		_lockShape = false;
		_pointsDirty = true;
	}

	private void UpdateFillPath()
	{
		//IL_0037: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		SetSmoothedKnots(fillPath, _drawPoints);
		List<Vector2> drawPoints = _drawPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		int num = (int)(-1);
		Vector2 vector = drawPoints.get_Item(num);
		Vector3 vector2 = PathToRootLocal((Vector2)num);
		fillPathHead.localPosition = (Vector3)0;
		_pointsDirty = false;
	}

	private unsafe void PositionEndMarkers(List<Vector2> points)
	{
		//IL_0825: Expected O, but got I4
		//IL_0836: Expected O, but got I4
		//IL_0021: Expected O, but got I
		//IL_0076: Expected I, but got O
		//IL_0099: Expected O, but got F4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0133: Expected O, but got F4
		//IL_0154: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_019c: Expected O, but got F4
		//IL_01bd: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0214: Expected O, but got F4
		//IL_0235: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0269: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_029d: Expected F4, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0314: Unsupported input type for neg.
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_0333: Expected F4, but got I4
		//IL_033c: Expected O, but got I4
		//IL_0788: Expected O, but got I4
		//IL_0361: Expected O, but got I
		//IL_03fc: Expected I, but got O
		//IL_0884: Expected I, but got O
		//IL_0894: Expected O, but got I
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_039c: Expected O, but got I
		//IL_0645: Expected O, but got I4
		//IL_064e: Expected O, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0963: Expected O, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I
		//IL_065b: Expected I, but got O
		//IL_066b: Expected O, but got I
		//IL_0466: Expected O, but got I
		//IL_06fe: Expected I, but got O
		//IL_09a5: Expected O, but got I
		//IL_06a6: Expected O, but got I
		//IL_08f5: Expected I, but got O
		//IL_0905: Expected O, but got I
		//IL_04a1: Expected O, but got I
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected I, but got Unknown
		//IL_0550: Expected I, but got O
		//IL_0560: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0599: Expected O, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04ca: Expected O, but got I
		//IL_05cd: Expected O, but got I
		//IL_0612: Expected O, but got I4
		//IL_0623: Expected O, but got I4
		//IL_062c: Expected F4, but got I4
		//IL_0635: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85A8]");
		nint num = 0;
		bool flag = points == null;
		object obj = 0;
		Vector2 vector = (Vector2)points;
		object obj2 = 152993792;
		List<Vector2> list = points;
		if (!flag)
		{
			obj2 = (nint)0 + (nint)3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			int index = (int)(-1);
			Vector2 vector2 = points.get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			int index2 = (int)(-2);
			nint num2 = (nint)obj2;
			Vector2 vector3 = points.get_Item(index2);
			float num3 = default(float);
			Vector2 vector4 = (Vector2)(num3 - num3);
			Vector2 vector5 = default(Vector2);
			float num4 = (float)vector5 - (float)vector5;
			Vector2 value = default(Vector2);
			Vector2 vector6 = Vector2.Normalize(ref value);
			float num5 = (float)vector4 * targetOverhang;
			float num6 = num4 * targetOverhang;
			float num7 = (float)_pathEnd + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SwipeCaptcha)+80]");
			Vector2 vector7 = (Vector2)(0 + num6);
			Vector3 vector8 = PathToRootLocal((Vector2)0);
			bool flag2 = (object)fillPathEnd == null;
			obj = 0;
			Vector2 vector9 = (Vector2)num6;
			vector5 = vector7;
			num3 = num7;
			Vector2 vector10 = vector4;
			vector = (Vector2)0;
			list = points;
			if (!flag2)
			{
				fillPathEnd.localPosition = (Vector3)0;
				bool flag3 = (object)fillPathTarget == null;
				obj = 0;
				vector9 = (Vector2)num6;
				vector5 = vector7;
				num3 = num7;
				vector10 = vector4;
				vector = (Vector2)0;
				list = points;
				if (!flag3)
				{
					fillPathTarget.localPosition = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0E2C");
					bool flag4 = (object)fillPathTarget == null;
					obj = 0;
					vector9 = (Vector2)num6;
					vector5 = vector4;
					num3 = num4;
					vector10 = vector4;
					vector = (Vector2)0;
					list = points;
					if (!flag4)
					{
						vector10 = (Vector2)(num4 * 1113927393);
						fillPathTarget.localEulerAngles = (Vector3)0;
						bool flag5 = (object)fillPathTarget == null;
						obj = 0;
						vector9 = vector10;
						vector5 = (Vector2)0;
						num3 = 0f;
						vector = (Vector2)0;
						num = 1113927393;
						list = points;
						if (!flag5)
						{
							obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
							object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
							list = (List<Vector2>)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344);
							IEnumerator enumerator = fillPathTarget.GetEnumerator();
							Vector2 vector11 = 0 - vector10;
							vector9 = vector10;
							vector5 = (Vector2)0;
							num3 = 0f;
							Vector3 vector12 = (Vector3)0;
							object obj4 = default(object);
							num = (nint)(&obj4);
							object obj10 = default(object);
							object obj12 = default(object);
							object obj16 = default(object);
							List<Vector2> list2 = default(List<Vector2>);
							object obj23 = default(object);
							IntPtr intPtr = default(IntPtr);
							Transform transform = default(Transform);
							object obj17;
							while (true)
							{
								if (obj != null)
								{
									object obj5 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v20+12E]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v20+12E]");
									if ((nint)0 == 0)
									{
										goto IL_03ed;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v20+B0]");
									object obj7 = (nint)0 + (nint)8;
									object obj8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X10_v24-8]");
										if (0 == (nint)obj2)
										{
											break;
										}
										obj8 = obj7 + 16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v20+12E]");
										obj6 = -1;
										bool flag6 = (nint)obj6 != 1;
										obj7 = obj8;
										if (flag6)
										{
											continue;
										}
										goto IL_03ed;
									}
									obj6 = obj7;
									object obj9 = obj5 + obj7;
									obj10 = obj9 + 312;
									obj8 = obj7;
									goto IL_087c;
								}
								NullReferenceException ex = new NullReferenceException();
								vector = vector12;
								break;
								IL_03ed:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								num2 = unchecked((nint)null);
								goto IL_087c;
								IL_087c:
								num = (nint)obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v39+8]");
								vector = (Vector2)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ X0_v39] (should have been resolved before IL gen)");
								object obj11 = obj12 & 1;
								if (obj11 != null)
								{
									if (obj != null)
									{
										object obj13 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v23+12E]");
										object obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v23+12E]");
										if ((nint)0 == 0)
										{
											goto IL_04f2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v23+B0]");
										object obj14 = (nint)0 + (nint)8;
										object obj8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X10_v19-8]");
											if (0 == (nint)obj2)
											{
												break;
											}
											obj8 = obj14 + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v23+12E]");
											obj6 = -1;
											bool flag7 = (nint)obj6 != 1;
											obj14 = obj8;
											if (flag7)
											{
												continue;
											}
											goto IL_04f2;
										}
										obj6 = obj14 + 1;
										object obj15 = obj13 + obj6;
										obj16 = obj15 + 312;
										obj8 = obj14;
										goto IL_08ed;
									}
									NullReferenceException ex2 = new NullReferenceException();
									break;
								}
								obj17 = 0;
								object obj18 = 0;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag8 = list2 == null;
									vector = (Vector2)list;
									if (flag8)
									{
										goto IL_0949;
									}
									nint num8 = (nint)list2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v5 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector2>>)+12E]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v5 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector2>>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_06ef;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v5 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector2>>)+B0]");
									object obj20 = (nint)0 + (nint)8;
									object obj8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X10_v7-8]");
										if (0 == (nint)list)
										{
											break;
										}
										obj8 = obj20 + 16;
										obj19--;
										bool flag9 = (nint)obj19 != 1;
										obj20 = obj8;
										if (flag9)
										{
											continue;
										}
										goto IL_06ef;
									}
									object obj21 = num8 + obj20;
									num = (nint)(obj21 + 312);
									obj8 = obj20;
									goto IL_0995;
									IL_0949:
									bool flag10 = obj18 == null;
									object obj22 = !flag10;
									if (obj22 == null)
									{
										return;
									}
									OutOfMemoryException ex3 = new OutOfMemoryException();
									if ((nint)vector != 1)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
									obj18 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
									obj17 = obj23;
									continue;
									IL_06ef:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
									num2 = unchecked((nint)null);
									num = intPtr;
									list = list2;
									goto IL_0995;
									IL_0995:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v4 (Il2CppClass<UnityEngine.Transform>)+8]");
									vector = (Vector2)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X8_v4 (Il2CppClass<UnityEngine.Transform>)] (should have been resolved before IL gen)");
									goto IL_0949;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
								return;
								IL_04f2:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								num2 = 1;
								goto IL_08ed;
								IL_08ed:
								num = (nint)obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v43+8]");
								vector = (Vector2)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v681 @ X0_v43] (should have been resolved before IL gen)");
								if ((object)transform != null)
								{
									vector = (Vector2)obj3;
									num = (nint)transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v4 (Il2CppClass<UnityEngine.Transform>)+130]");
									object obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X1_v7 (UnityEngine.Vector2)+130]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v4 (Il2CppClass<UnityEngine.Transform>)+130]");
									nint num9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X1_v7 (UnityEngine.Vector2)+130]");
									bool flag11 = num9 < 0;
									object obj24 = !flag11;
									object obj25 = ~obj24;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v4 (Il2CppClass<UnityEngine.Transform>)+C8]");
										nint num10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X1_v7 (UnityEngine.Vector2)+130]");
										object obj26 = num10 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v29-8]");
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v29-8]");
										if (0 == (nint)vector)
										{
											transform.localEulerAngles = (Vector3)0;
											vector9 = vector11;
											vector5 = (Vector2)0;
											num3 = 0f;
											vector12 = (Vector3)0;
											continue;
										}
									}
									InvalidCastException ex4 = new InvalidCastException();
								}
								else
								{
									NullReferenceException ex5 = new NullReferenceException();
								}
								break;
							}
							obj17 = 0;
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void AnimateHeadFinish()
	{
		//IL_0028: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0097: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00e8: Expected F4, but got I
		//IL_00e8: Expected O, but got I4
		Vector3 localPosition = fillPathTarget.localPosition;
		float duration = default(float);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(fillPathHead, (Vector3)0, duration);
		object obj = typeof(UsageHint) + 744;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+8]");
		float duration2 = 0f * 63f;
		float elasticity = default(float);
		Tweener tweener = ShortcutExtensions.DOPunchScale(fillPathHead, (Vector3)1, duration2, 0, elasticity);
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+B8]");
		object obj6 = 0;
		RectTransform target = fillPathEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target, (Vector3)0, 0f);
	}

	private unsafe void SetSmoothedKnots(UILineDrawer line, List<Vector2> points)
	{
		//IL_001b: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected I4, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_056f: Expected O, but got I4
		//IL_05da: Expected O, but got I4
		//IL_06b0: Invalid comparison between F4 and I4
		//IL_06bf: Invalid comparison between F4 and I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06e0: Expected O, but got F4
		//IL_0715: Expected O, but got I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_022b: Expected F8, but got I4
		//IL_0752: Expected O, but got I4
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I
		//IL_07a5: Expected O, but got I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0340: Expected O, but got I4
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_07be: Expected O, but got I4
		//IL_03a2: Invalid comparison between F4 and I4
		//IL_0831: Expected O, but got F8
		//IL_084b: Expected O, but got I
		//IL_084b: Expected O, but got I4
		//IL_03e5: Expected O, but got I
		//IL_03fa: Expected O, but got I
		//IL_0428: Expected O, but got I4
		//IL_00a3: Expected O, but got Ref
		//IL_00c2: Expected O, but got I4
		//IL_044c: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_04a0: Expected O, but got I4
		List<BezierKnot2D> knotBuffer = _knotBuffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3 (System.Collections.Generic.List`1<Maro.UILineDrawer.BezierKnot2D>)+1C]");
		object obj = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		int num = (int)(-1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		if ((nint)0 >= (nint)1)
		{
			object tangentIn = (nint)0 + (nint)3352;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			int num2 = 0;
			object obj3 = default(object);
			float num4 = default(float);
			IntPtr intPtr = default(IntPtr);
			BezierKnot2D bezierKnot2D2 = default(BezierKnot2D);
			object obj34 = default(object);
			while (true)
			{
				Vector2 vector = points.get_Item(num2);
				float num3 = (float)obj3 * splineToLocalScale;
				num4 *= splineToLocalScale;
				float2 @float = (Vector2)0;
				object obj4 = num2 - 1;
				bool flag = (nint)obj4 < 0;
				bool flag2 = obj4 == null;
				int num5 = num2 ^ 1;
				int num6 = num2 ^ obj4;
				int num7 = num5 & num6;
				bool flag3 = num7 < 0;
				bool flag4 = flag == flag3;
				object obj5 = !flag2;
				object obj6 = flag4 & obj5;
				object obj7 = ~obj6;
				int num8 = ((obj7 != null) ? 1 : num2);
				int index = num8 - 1;
				Vector2 vector2 = points.get_Item(index);
				float num9 = num3 * splineToLocalScale;
				float num10 = num4 * splineToLocalScale;
				float2 float2 = (Vector2)0;
				int num11 = num2 + 1;
				int index2 = ((num11 < num) ? (num2 + 1) : num);
				Vector2 vector3 = points.get_Item(index2);
				float num12 = num9 * splineToLocalScale;
				float num13 = num10 * splineToLocalScale;
				float2 float3 = (Vector2)0;
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v20+E4]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num14 = num12 - num9;
				float num15 = num13 - num10;
				float num16 = num14 * num14;
				float num17 = num15 * num15;
				float num18 = num16 + num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				double num19 = 1.0 / (double)num17;
				double num20 = (double)num14 * num19;
				double num21 = (double)num15 * num19;
				float num22 = num18 - 8388608f;
				bool flag5 = num22 < 0f;
				bool flag6 = num22 == 0f;
				object obj9 = num18 ^ 0x800000;
				object obj10 = num18 ^ num22;
				object obj11 = obj9 & obj10;
				bool flag7 = (nint)obj11 < 0;
				bool flag8 = flag5 == flag7;
				object obj12 = !flag6;
				object obj13 = flag8 & obj12;
				object obj14 = ~obj13;
				double num23 = ((obj14 != null) ? 0.0 : num21);
				bool flag9 = flag5 == flag7;
				object obj15 = !flag6;
				object obj16 = flag9 & obj15;
				object obj17 = ~obj16;
				double num24 = ((obj17 != null) ? 1.0 : num20);
				object obj18 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v23+E4]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FD]");
					object obj19 = (nint)0 & (nint)1;
					if (obj19 == null)
					{
						_ = 1;
					}
				}
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v25+E4]");
				bool flag10 = (nint)0 == 0;
				object obj21 = !flag10;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num25 = num10 - num4;
				float num26 = num9 - num3;
				float num27 = num26 * num26;
				float num28 = num25 * num25;
				float num29 = num27 + num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float num30 = num13 - num4;
				float num31 = num12 - num3;
				float num32 = num31 * num31;
				float num33 = num30 * num30;
				float num34 = num32 + num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				object obj22 = num34 & 0x7FFFFFFF;
				bool flag11 = (nint)obj22 < 2139095040;
				object obj23 = !flag11;
				object obj24 = obj22 - 2139095040;
				bool flag12 = obj24 == null;
				object obj25 = ~obj23;
				object obj26 = obj25 | flag12;
				object obj27 = ~obj26;
				bool flag13;
				if (obj27 == null)
				{
					float num35 = num29 - num34;
					flag13 = num35 < 0f;
				}
				else
				{
					flag13 = true;
				}
				object obj28 = !flag13;
				if (obj28 != null)
				{
					num29 = num34;
				}
				double num36 = (double)smoothing / 3.0;
				double num37 = (double)num29 * num36;
				double num38 = num24 * num37;
				double num39 = num23 * num37;
				List<BezierKnot2D> knotBuffer2 = _knotBuffer;
				double num40 = num23 * num37;
				object obj29 = 0.0 - num40;
				BezierKnot2D bezierKnot2D = new BezierKnot2D((float2)0, (float2)tangentIn, (float2)(nint)intPtr, num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v6 (System.Collections.Generic.List`1<Maro.UILineDrawer.BezierKnot2D>)+1C]");
				object obj30 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v6 (System.Collections.Generic.List`1<Maro.UILineDrawer.BezierKnot2D>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v6 (System.Collections.Generic.List`1<Maro.UILineDrawer.BezierKnot2D>)+18]");
				nint num41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X9_v9+18]");
				bool flag14 = num41 < 0;
				object obj32 = !flag14;
				object obj33;
				if (obj32 != null)
				{
					knotBuffer2.AddWithResize((BezierKnot2D)(&bezierKnot2D2));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
					bool flag15 = (nint)0 == num11;
					obj33 = 0;
					obj3 = obj34;
					num2 = num11;
					if (flag15)
					{
						break;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v6 (System.Collections.Generic.List`1<Maro.UILineDrawer.BezierKnot2D>)+18]");
				object obj35 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X23_v6 (System.Collections.Generic.List`1<Maro.UILineDrawer.BezierKnot2D>)+18]");
				object obj36 = (nint)0 * (nint)28;
				object obj37 = obj31 + obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [points @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				bool flag16 = (nint)0 != num11;
				obj33 = 0;
				obj3 = obj34;
				num2 = num11;
				if (!flag16)
				{
					break;
				}
			}
		}
		line.UpdatePoints(_knotBuffer);
	}

	private unsafe float2 GetPointerOnPath(PointerEventData eventData)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_00ab: Expected O, but got Ref
		//IL_00b9: Expected O, but got I4
		if ((object)basePath != null)
		{
			RectTransform rectTransform = basePath.rectTransform;
			if (eventData != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3608;
				Camera pressEventCamera = eventData.pressEventCamera;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = default(object);
				bool flag2 = RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, (Vector2)pressEventCamera, (Camera)(&obj4), out *(Vector2*)null);
				return (Vector2)0;
			}
		}
		return (float2)new NullReferenceException();
	}

	private float2 PathLocal(Vector2 splinePoint)
	{
		//IL_000a: Expected O, but got I4
		return (Vector2)0;
	}

	private Vector3 PathToRootLocal(Vector2 splinePoint)
	{
		//IL_0062: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		if ((object)basePath != null)
		{
			RectTransform rectTransform = basePath.rectTransform;
			if ((object)rectTransform != null)
			{
				Vector3 localPosition = rectTransform.localPosition;
				float2 @float = (Vector2)0;
				return (Vector2)(float2)0;
			}
		}
		return (Vector3)new NullReferenceException();
	}

	public SwipeCaptcha()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0082: Expected F4, but got I
		//IL_0094: Expected F4, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 264;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535A0]");
		pointerPathThreshold = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535B0]");
		successDelay = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Vector2> list = default(List<Vector2>);
		list..ctor();
		object obj3 = this + 136;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<BezierKnot2D> list2 = default(List<BezierKnot2D>);
		list2..ctor();
		object obj4 = this + 144;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
