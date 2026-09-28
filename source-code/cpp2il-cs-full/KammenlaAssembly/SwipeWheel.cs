using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SwipeWheel : MonoBehaviour
{
	private Transform wheel;

	private float actuationDist;

	private const float MIN_HOLD_TIME = 0.15f;

	private List<SwipeWheelChoice> _choices;

	private Camera _uiCam;

	private SwipeWheelChoice _lastNearestChoice;

	private float _lastOpenTime;

	private bool _isDragging;

	private static SwipeWheel _currentOpenWheel;

	private bool IsOpen
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_0091: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3184;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (UnityEngine.Object)obj4 == this;
		}
	}

	private SwipeWheelChoice NearestChoice
	{
		get
		{
			//IL_0015: Expected O, but got I4
			//IL_003f: Expected I, but got O
			//IL_0048: Expected O, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_0352: Expected O, but got I
			//IL_035a: Expected I, but got O
			//IL_0418: Expected O, but got I4
			//IL_0132: Expected I, but got O
			//IL_013b: Expected O, but got I4
			//IL_016a: Expected O, but got I
			//IL_0178: Expected F4, but got I4
			//IL_020e: Expected I, but got O
			//IL_02e7: Expected O, but got I4
			//IL_02f8: Expected O, but got I4
			Vector2 pointerPosition = InputUtil.PointerPosition;
			bool flag = (object)_uiCam == null;
			float num2 = default(float);
			float num = num2;
			float num4 = default(float);
			float num3 = num4;
			SwipeWheel result = this;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			nint num5 = default(nint);
			if (!flag)
			{
				Vector3 vector = _uiCam.ScreenToWorldPoint((Vector3)0);
				bool flag2 = (object)wheel == null;
				num = num2;
				num3 = num4;
				num5 = unchecked((nint)null);
				object obj = 0;
				result = this;
				if (!flag2)
				{
					Vector3 position = wheel.position;
					object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v25+E4]");
					bool flag3 = (nint)0 == 0;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num6 = num2 - num2;
					float num7 = num4 - num4;
					float num8 = num7 * num7;
					float num9 = num6 * num6;
					num3 = num8 + num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					num = actuationDist;
					if (num3 < actuationDist)
					{
						result = null;
					}
					else
					{
						bool flag4 = _choices == null;
						num5 = unchecked((nint)null);
						obj = 0;
						result = this;
						if (flag4)
						{
							goto IL_03e0;
						}
						List<object>.Enumerator enumerator = ((List<object>)(object)_choices).GetEnumerator();
						object obj5 = (nint)0 + (nint)2064;
						SwipeWheel swipeWheel = null;
						float num10 = 2.139095E+09f;
						List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
						SwipeWheel swipeWheel2 = default(SwipeWheel);
						List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
						while (true)
						{
							IL_0426:
							float num11 = num;
							num3 = num10;
							while (true)
							{
								num5 = (nint)obj5;
								if (!enumerator2.MoveNext())
								{
									break;
								}
								if ((object)swipeWheel2 != null)
								{
									if ((object)swipeWheel2._lastNearestChoice != null)
									{
										Vector3 position2 = ((Transform)(object)swipeWheel2._lastNearestChoice).position;
										object obj6 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v40+E4]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num12 = num2 - num11;
										float num13 = num4 - num3;
										num11 = num13 * num13;
										float num14 = num12 * num12;
										num3 = num11 + num14;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										bool flag5 = num3 < num10;
										swipeWheel = swipeWheel2;
										num = num11;
										num10 = num3;
										if (!flag5)
										{
											continue;
										}
										goto IL_0426;
									}
									NullReferenceException ex = new NullReferenceException();
								}
								else
								{
									NullReferenceException ex2 = new NullReferenceException();
								}
								enumerator3 = enumerator4;
								enumerator4 = (List<object>.Enumerator)0;
								num = num11;
								obj = 0;
								result = swipeWheel;
								goto IL_03e0;
							}
							break;
						}
						enumerator2.Dispose();
						result = swipeWheel;
					}
					goto IL_02b4;
				}
			}
			goto IL_03e0;
			IL_02b4:
			return (SwipeWheelChoice)(object)result;
			IL_03e0:
			NullReferenceException ex3 = new NullReferenceException();
			bool flag6 = num5 != 1;
			NullReferenceException ex4 = ex3;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj7 = (nint)0 + (nint)2056;
				num5 = (nint)obj7;
				enumerator3.Dispose();
				object obj8 = default(object);
				if (obj8 == null)
				{
					goto IL_02b4;
				}
				OutOfMemoryException ex5 = new OutOfMemoryException();
				List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj8;
				ex4 = (NullReferenceException)(object)ex5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223AED4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			SwipeWheelChoice result2 = default(SwipeWheelChoice);
			return result2;
		}
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0148: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_0182: Expected O, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01d8: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AD7]");
		object obj2 = (nint)0 & (nint)1;
		Transform transform;
		Transform transform2;
		if (obj2 != null)
		{
			transform = wheel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			transform2 = wheel;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			transform = wheel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			transform2 = wheel;
			if (obj5 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		transform = transform2;
		goto IL_011b;
		IL_011b:
		object obj6 = (nint)0 + (nint)744;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3608;
		object obj8 = (nint)0 + (nint)3056;
		object obj9 = typeof(UsageHint) + 816;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+B8]");
		object obj11 = 0;
		transform.localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> list = Enumerable.ToList(source);
		object obj12 = this + 48;
		obj12 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		object obj13 = (nint)0 + (nint)4008;
		object obj14 = "ThisIsFakeReceiptData" + 3648;
		((List<object>)obj12).ForEach(action);
		GameObject gameObject = GameObject.Find((string)obj14);
		object obj15 = (nint)0 + (nint)1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj16 = this + 56;
		object obj17 = default(object);
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0083:
		bool flag3 = (object)transform == null;
		object obj18 = !flag3;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011b;
	}

	private void Update()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_007c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3184;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B72]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v11+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj9 == this)
		{
			goto IL_0190;
		}
		goto IL_01ba;
		IL_01ba:
		if (_isDragging)
		{
			OnDrag();
		}
		return;
		IL_0190:
		if (InputUtil.PointerReleasedThisFrame)
		{
			OnPointerUp();
			return;
		}
		goto IL_01ba;
		IL_00b9:
		bool flag3 = obj7 == this;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_0190;
		}
		goto IL_01ba;
	}

	private void OpenWheel()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_022d: Expected O, but got I
		//IL_0249: Expected F4, but got I
		//IL_0249: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3184;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AD8]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v20+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v16+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 != null;
		bool flag4 = !flag3;
		object obj13 = 0;
		object obj14 = 0;
		if (!flag4)
		{
			goto IL_01b2;
		}
		goto IL_01e5;
		IL_01e5:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = typeof(UsageHint) + 816;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+B8]");
		object obj18 = 0;
		Transform target = wheel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, (Vector3)0, 0f);
		float time = Time.time;
		_lastOpenTime = time;
		return;
		IL_01b2:
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+B8]");
		object obj20 = 0;
		((SwipeWheel)obj20).CloseWheel();
		obj14 = obj13;
		goto IL_01e5;
		IL_00b9:
		bool flag5 = obj7 != null;
		bool flag6 = !flag5;
		object obj21 = !flag6;
		obj13 = 0;
		if (obj21 != null)
		{
			goto IL_01b2;
		}
		obj14 = 0;
		goto IL_01e5;
	}

	private void CloseWheel()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f3: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_001d: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_013c: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_01e4: Expected F4, but got O
		//IL_01e4: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3184;
		object obj2 = 152989696;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B72]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v20+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_005a;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_005a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 == this;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		object obj14 = 0;
		if (obj13 == null)
		{
			return;
		}
		goto IL_008a;
		IL_008a:
		object obj15 = typeof(UsageHint) + 816;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v13+B8]");
		object obj17 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(wheel, (Vector3)0, (float)obj17);
		object obj18 = obj;
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_005a:
		bool flag5 = obj7 == this;
		bool flag6 = !flag5;
		obj14 = 0;
		if (!flag6)
		{
			goto IL_008a;
		}
	}

	public void OnDrag()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_009d: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_003d: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_0517: Expected O, but got I4
		//IL_0525: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_053c: Expected O, but got I4
		//IL_0552: Expected O, but got I
		//IL_064f: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01ce: Expected O, but got I
		//IL_013a: Expected O, but got I4
		//IL_05da: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		//IL_0352: Expected O, but got I
		//IL_037c: Expected O, but got I4
		//IL_038c: Expected O, but got I
		//IL_06ef: Expected O, but got I
		//IL_0705: Expected F8, but got I4
		//IL_071b: Expected F8, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_01fb: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_061a: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_06d1: Expected O, but got I4
		//IL_03f7: Expected O, but got I
		//IL_0414: Expected O, but got I
		//IL_0448: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		SwipeWheelChoice nearestChoice = NearestChoice;
		object obj2 = this + 64;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		UnityEngine.Object obj8;
		object obj7;
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj2 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj4 != null)
			{
				goto IL_00be;
			}
			obj7 = 0;
			obj8 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj2 != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			obj7 = 0;
			obj8 = null;
			if (!flag4)
			{
				goto IL_00be;
			}
		}
		goto IL_0281;
		IL_0281:
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		double num2 = default(double);
		double num = num2;
		double num4 = default(double);
		double num3 = num4;
		double num6 = default(double);
		double num5 = num6;
		double num8 = default(double);
		double num7 = num8;
		if (!flag5)
		{
			goto IL_02ce;
		}
		goto IL_04c6;
		IL_0533:
		object obj10 = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B75]");
		object obj11 = (nint)0 & (nint)1;
		UnityEngine.Object graphic;
		UnityEngine.Object graphic2;
		if (obj11 != null)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			graphic = nearestChoice.graphic;
			graphic2 = nearestChoice.graphic;
			if (!flag6)
			{
				goto IL_05b6;
			}
		}
		else
		{
			_ = 1;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			graphic = nearestChoice.graphic;
			graphic2 = nearestChoice.graphic;
			if (obj13 != null)
			{
				goto IL_05b6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = graphic2 != null;
		bool flag9 = !flag8;
		object obj14 = 0;
		num = num2;
		num3 = num4;
		num5 = num6;
		num7 = num8;
		object obj15 = 0;
		if (!flag9)
		{
			goto IL_06df;
		}
		goto IL_076a;
		IL_00be:
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v36+E4]");
		if ((nint)0 != 0)
		{
			bool flag10 = (UnityEngine.Object)obj2 != nearestChoice;
			bool flag11 = !flag10;
			object obj17 = !flag11;
			object obj18 = 0;
			UnityEngine.Object obj19 = nearestChoice;
			if (obj17 != null)
			{
				goto IL_01a2;
			}
			obj7 = 0;
			obj8 = nearestChoice;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag12 = (UnityEngine.Object)obj2 != nearestChoice;
			bool flag13 = !flag12;
			object obj18 = 0;
			UnityEngine.Object obj19 = nearestChoice;
			obj7 = 0;
			obj8 = nearestChoice;
			if (!flag13)
			{
				goto IL_01a2;
			}
		}
		goto IL_0281;
		IL_02ce:
		bool flag14 = nearestChoice != null;
		bool flag15 = !flag14;
		object obj20 = !flag15;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (obj20 != null)
		{
			goto IL_0533;
		}
		num = num2;
		num3 = num4;
		num5 = num6;
		num7 = num8;
		obj15 = 0;
		goto IL_076a;
		IL_04c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = nearestChoice != null;
		bool flag17 = !flag16;
		num2 = num;
		num4 = num3;
		num6 = num5;
		num8 = num7;
		obj21 = 0;
		obj22 = null;
		obj15 = 0;
		if (!flag17)
		{
			goto IL_0533;
		}
		goto IL_076a;
		IL_01a2:
		object obj23 = obj2;
		object obj24 = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B76]");
		object obj25 = (nint)0 & (nint)1;
		UnityEngine.Object obj26;
		UnityEngine.Object obj28;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X23_v8+38]");
			obj26 = (UnityEngine.Object)0;
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v42+E4]");
			bool flag18 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X23_v8+38]");
			obj28 = (UnityEngine.Object)0;
			if (!flag18)
			{
				goto IL_0238;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X23_v8+38]");
			obj26 = (UnityEngine.Object)0;
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v42+E4]");
			bool flag19 = (nint)0 == 0;
			object obj29 = !flag19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X23_v8+38]");
			obj28 = (UnityEngine.Object)0;
			if (obj29 != null)
			{
				goto IL_0238;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag20 = obj28 != null;
		bool flag21 = !flag20;
		obj7 = 0;
		obj8 = null;
		object obj30 = 0;
		if (flag21)
		{
			goto IL_0281;
		}
		goto IL_03e7;
		IL_06df:
		nearestChoice.graphic.color = (Color)0;
		num = 1.0;
		num3 = 0.0;
		num5 = 1.0;
		num7 = 0.0;
		obj15 = obj14;
		goto IL_076a;
		IL_076a:
		obj2 = nearestChoice;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_05b6:
		bool flag22 = graphic != null;
		bool flag23 = !flag22;
		object obj31 = !flag23;
		obj14 = 0;
		if (obj31 != null)
		{
			goto IL_06df;
		}
		num = num2;
		num3 = num4;
		num5 = num6;
		num7 = num8;
		obj15 = 0;
		goto IL_076a;
		IL_0238:
		bool flag24 = obj26 != null;
		bool flag25 = !flag24;
		object obj32 = !flag25;
		obj7 = 0;
		obj8 = null;
		obj30 = 0;
		if (obj32 == null)
		{
			goto IL_0281;
		}
		goto IL_03e7;
		IL_03e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X23_v8+38]");
		object obj33 = 0;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v22+2B0]");
		obj8 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ X8_v22+2A8] (should have been resolved before IL gen)");
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v26+E4]");
		bool flag26 = (nint)0 == 0;
		object obj35 = !flag26;
		num2 = 1.0;
		num4 = 1.0;
		num6 = 1.0;
		num8 = 1.0;
		num = 1.0;
		num3 = 1.0;
		num5 = 1.0;
		num7 = 1.0;
		obj7 = obj30;
		if (obj35 != null)
		{
			goto IL_02ce;
		}
		goto IL_04c6;
	}

	public void OnPointerDown()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_018e: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3184;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B72]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v12+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 == this;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_00e5;
		}
		goto IL_019d;
		IL_00e5:
		_isDragging = true;
		return;
		IL_019d:
		OpenWheel();
		_isDragging = true;
		return;
		IL_00b9:
		if (obj7 == this)
		{
			goto IL_00e5;
		}
		goto IL_019d;
	}

	private void OnPointerUp()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0184: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_011d: Invalid comparison between F4 and I4
		//IL_01d5: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AD9]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 64;
			obj5 = (UnityEngine.Object)obj4;
			_ = 0;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a6;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 64;
			obj5 = (UnityEngine.Object)obj4;
			_ = 0;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 != null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		obj4 = obj8;
		if (obj10 != null)
		{
			goto IL_00d7;
		}
		goto IL_00fa;
		IL_00fa:
		float time = Time.time;
		float num = time - _lastOpenTime;
		if (num > 1.0418651E+09f)
		{
			CloseWheel();
		}
		return;
		IL_00d7:
		ActivateChoiceAndClose(_lastNearestChoice);
		_lastNearestChoice = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_00fa;
		IL_00a6:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		obj11 = 0;
		if (!flag6)
		{
			goto IL_00d7;
		}
		goto IL_00fa;
	}

	public void ActivateChoiceAndClose(SwipeWheelChoice choice)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ADA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = choice == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			goto IL_0127;
		}
		return;
		IL_0127:
		if (((List<object>)(object)_choices).Contains((object)choice))
		{
			choice.OnDrop();
			CloseWheel();
		}
		return;
		IL_0074:
		if (choice == null)
		{
			return;
		}
		goto IL_0127;
	}

	private void <Start>b__13_0(SwipeWheelChoice c)
	{
		c.Init(this);
	}
}
