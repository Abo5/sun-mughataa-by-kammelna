using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class ClanLogoPreviewer : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<LogoLayerConfig, bool> <>9__14_0;

		public static Func<LogoLayerConfig, bool> <>9__14_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Initialize>b__14_0(LogoLayerConfig c)
		{
			//IL_0044: Expected I4, but got O
			if ((object)c != null)
			{
				return c.Layer == ClanLogoLayer.Rim;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <Initialize>b__14_1(LogoLayerConfig c)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if ((object)c != null)
			{
				object obj = c.Layer - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public ClanLogoLayer layer;

		internal bool <FirstItemId>b__0(ClanLogoElementViewModel e)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (e != null)
			{
				object obj = (int)e.Type - (int)layer;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public Image displayer;

		internal void <ApplyLayer>b__0(bool ok)
		{
			displayer.enabled = ok;
		}
	}

	private const string SHINE_PROPERTY = "_Shine";

	private Image layerPreviewerPrefab;

	private Transform logoAnchor;

	private LogoLayerConfig[] layerConfigs;

	private int defaultTier;

	private bool useShine;

	private readonly Dictionary<IconLayer, Image> _displayers;

	private IReadOnlyList<IconLayer> _layers;

	private int _tier;

	private Material _shineMaterial;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_004e: Expected I, but got O
		//IL_007d: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0120: Expected I, but got O
		//IL_0132: Expected O, but got I4
		object obj = (nint)0 + (nint)2608;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1304;
		object obj4 = typeof(RegisteredWaitHandle) + 56;
		object obj5 = obj;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)_layers))
		{
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 320;
			object obj7 = (nint)0 + (nint)1296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj7);
			KammelnaRequests.GetClanLogoElements(action);
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0186: Expected I, but got O
		//IL_01b0: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1304;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = _shineMaterial != null;
			bool flag3 = !flag2;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = _shineMaterial != null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (obj10 == null)
			{
				return;
			}
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(_shineMaterial);
	}

	private void OnConfigChanged()
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0078: Expected I, but got O
		object obj = (nint)0 + (nint)2608;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)_layers))
		{
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 320;
			object obj3 = (nint)0 + (nint)1296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			KammelnaRequests.GetClanLogoElements(action);
		}
	}

	public float GetRimHalfExtent()
	{
		//IL_03a9: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		//IL_03d0: Expected F4, but got O
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_04d1: Expected I, but got O
		//IL_0285: Expected F4, but got I4
		//IL_035a: Expected F4, but got O
		//IL_0363: Expected O, but got I4
		//IL_0461: Expected I, but got O
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02c1: Expected F4, but got I4
		//IL_0073: Expected O, but got I
		//IL_0389: Expected F4, but got O
		//IL_0392: Expected O, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_031c: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_0181: Expected I, but got O
		//IL_03e7: Expected O, but got I4
		//IL_03ff: Expected F4, but got O
		//IL_0408: Expected O, but got I4
		//IL_040d: Expected I, but got O
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0204: Expected O, but got I4
		object obj3 = default(object);
		object obj4 = default(object);
		UnityEngine.Object obj9 = default(UnityEngine.Object);
		Dictionary<object, object>.Enumerator enumerator2 = default(Dictionary<object, object>.Enumerator);
		object obj10;
		nint num = default(nint);
		object obj11;
		if (_displayers != null)
		{
			object obj = (nint)0 + (nint)1184;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			obj3 = (nint)0 + (nint)1176;
			Dictionary<object, object>.Enumerator enumerator = ((Dictionary<object, object>)(object)_displayers).GetEnumerator();
			while (true)
			{
				num = (nint)obj;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				if (obj4 == null)
				{
					goto IL_0339;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ stack_-98+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ stack_-98+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v20+18]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 != null)
					{
						continue;
					}
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v33+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = obj9 != null;
					bool flag4 = !flag3;
					obj10 = 0;
					if (flag4)
					{
						continue;
					}
					goto IL_0143;
				}
				goto IL_0368;
			}
			enumerator2.Dispose();
			obj11 = obj4;
			goto IL_0261;
		}
		NullReferenceException ex = new NullReferenceException();
		enumerator2 = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator3 = (Dictionary<object, object>.Enumerator)0;
		goto IL_03b7;
		IL_03b7:
		NullReferenceException ex2 = new NullReferenceException();
		Dictionary<object, object>.Enumerator enumerator4 = enumerator2;
		float result = (float)enumerator3;
		goto IL_0418;
		IL_0368:
		ex2 = new NullReferenceException();
		Dictionary<object, object>.Enumerator enumerator5 = default(Dictionary<object, object>.Enumerator);
		enumerator4 = enumerator5;
		obj11 = obj4;
		result = (float)enumerator5;
		enumerator5 = (Dictionary<object, object>.Enumerator)0;
		goto IL_0418;
		IL_0143:
		bool flag5 = (object)obj9 == null;
		obj10 = 0;
		enumerator2 = enumerator5;
		obj11 = obj4;
		enumerator3 = enumerator5;
		enumerator5 = (Dictionary<object, object>.Enumerator)0;
		num = unchecked((nint)null);
		if (flag5)
		{
			goto IL_03b7;
		}
		RectTransform rectTransform = ((Graphic)obj9).rectTransform;
		object obj15 = default(object);
		float result2;
		if ((object)rectTransform != null)
		{
			Rect rect = rectTransform.rect;
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v41+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num2 = (double)obj15 * 0.5;
			enumerator2.Dispose();
			result2 = (float)num2;
			goto IL_04fb;
		}
		ex2 = new NullReferenceException();
		obj10 = 0;
		enumerator4 = enumerator5;
		obj11 = obj4;
		result = (float)enumerator5;
		enumerator5 = (Dictionary<object, object>.Enumerator)0;
		num = unchecked((nint)null);
		goto IL_0418;
		IL_0418:
		bool flag7 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj3;
			enumerator4.Dispose();
			object obj16 = default(object);
			if (obj16 == null)
			{
				goto IL_0261;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator5 = (Dictionary<object, object>.Enumerator)obj16;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E380");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return result;
		IL_04fb:
		return result2;
		IL_0339:
		ex2 = new NullReferenceException();
		enumerator4 = enumerator5;
		obj11 = obj4;
		result = (float)enumerator5;
		enumerator5 = (Dictionary<object, object>.Enumerator)0;
		goto IL_0418;
		IL_0261:
		RectTransform rectTransform2 = (RectTransform)logoAnchor;
		bool flag8 = (object)logoAnchor == null;
		result2 = 0f;
		if (!flag8)
		{
			object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			bool flag9 = rectTransform2 != obj17;
			result2 = 0f;
			if (!flag9)
			{
				Rect rect2 = ((RectTransform)logoAnchor).rect;
				object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v23+E4]");
				bool flag10 = (nint)0 == 0;
				object obj20 = !flag10;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				result2 = (float)obj15 * 0.5f;
			}
		}
		goto IL_04fb;
	}

	public void Initialize(ClanLogoModel model, int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0139: Expected O, but got I4
		//IL_0548: Expected O, but got I
		//IL_0558: Expected O, but got I
		//IL_057a: Expected O, but got I4
		//IL_058a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_0dab: Expected O, but got I
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected O, but got Unknown
		//IL_04d1: Expected O, but got I
		//IL_04e1: Expected O, but got I
		//IL_0503: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_05ba: Expected O, but got I4
		//IL_0222: Expected O, but got I4
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0cab: Expected O, but got I
		//IL_0cbc: Expected I, but got O
		//IL_0cda: Expected O, but got I
		//IL_0cf1: Expected I, but got O
		//IL_0625: Expected O, but got I4
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected O, but got Unknown
		//IL_0e29: Expected O, but got I
		//IL_0e3a: Expected I, but got O
		//IL_0e58: Expected O, but got I
		//IL_0521: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_06b7: Expected O, but got I4
		//IL_05f4: Expected I, but got O
		//IL_05ea: Expected O, but got I
		//IL_0d16: Expected O, but got I
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected O, but got Unknown
		//IL_0d7b: Expected O, but got I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_0708: Expected O, but got I
		//IL_0711: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_076d: Expected O, but got I
		//IL_0357: Expected O, but got I
		//IL_03a9: Expected O, but got I4
		//IL_0bfc: Expected O, but got I
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected O, but got Unknown
		//IL_0e87: Expected O, but got I
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_03dc: Expected O, but got I4
		//IL_0ad3: Expected O, but got I
		//IL_0ae3: Expected O, but got I
		//IL_0b1f: Expected O, but got I4
		//IL_0ba2: Expected O, but got I4
		//IL_081c: Expected O, but got I
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0b86: Expected O, but got I4
		//IL_09ae: Expected F8, but got I4
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Expected O, but got Unknown
		//IL_0895: Expected O, but got I
		//IL_08b2: Expected O, but got I
		//IL_08de: Invalid comparison between F8 and I4
		//IL_08ed: Invalid comparison between F8 and I4
		//IL_0905: Expected O, but got F8
		//IL_0912: Expected O, but got F8
		//IL_0947: Expected O, but got I4
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected O, but got Unknown
		//IL_0b54: Expected O, but got I4
		//IL_0ee8: Invalid comparison between F8 and I4
		//IL_0a2a: Expected O, but got I4
		//IL_0993: Expected F8, but got I4
		//IL_0726: Expected O, but got I
		//IL_0736: Expected O, but got I
		//IL_075c: Expected O, but got I4
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected O, but got Unknown
		//IL_0a98: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1680;
		object obj2 = (nint)0 + (nint)688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityEngine.Object obj3 = (UnityEngine.Object)obj2;
		List<object> list = default(List<object>);
		list..ctor();
		object obj4;
		object obj6;
		Func<object, bool> predicate;
		if (model != null)
		{
			bool flag = model.Rim == null;
			int num = tier;
			if (!flag)
			{
				obj4 = typeof(CardUtils.<>c) + 1160;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v95+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v95+B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v84+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v84+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						goto IL_0147;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v95+B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v84+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v84+8]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						goto IL_0147;
					}
				}
				goto IL_019e;
			}
			goto IL_0456;
		}
		goto IL_0ab4;
		IL_02a3:
		object obj9 = typeof(System.IOAsyncCallback) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 4294967295L;
		_ = 63;
		_ = 0;
		object obj10 = typeof(UsageHint) + 744;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v71+B8]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = default(object);
		obj14..ctor();
		object obj15 = obj14 + 24;
		object obj16;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ClanLogoRim rim = model.Rim;
		bool flag4 = model.Rim == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj17 = obj16;
		nint num3;
		int num2;
		nint num4 = default(nint);
		if (!flag4)
		{
			_ = rim.Id;
			Color color = ColorExtension.FromPackedRgba(rim.Color);
			bool flag5 = list == null;
			enumerator = (List<object>.Enumerator)0;
			obj17 = null;
			if (!flag5)
			{
				object obj18 = (nint)0 + (nint)696;
				object obj19 = obj18;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag6 = list._items == null;
				enumerator = (List<object>.Enumerator)0;
				obj17 = null;
				if (!flag6)
				{
					bool flag7 = list._size < items.Length;
					object obj20 = !flag7;
					int num;
					if (obj20 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj21 = list._items + list._size;
						object obj22 = obj21 + 32;
						obj22 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						num = num2;
						obj3 = (UnityEngine.Object)obj14;
						goto IL_0456;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v77+20]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v78+C0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v79+70]");
					num = 0;
					list.AddWithResize(obj14);
					bool flag8 = model.Icons == null;
					object obj25 = !flag8;
					num3 = num4;
					obj3 = (UnityEngine.Object)obj14;
					if (obj25 != null)
					{
						goto IL_0480;
					}
					goto IL_0ab4;
				}
			}
		}
		goto IL_0d91;
		IL_0d9f:
		object obj26 = (nint)0 + (nint)984;
		Func<object, bool> predicate2;
		object obj27 = Enumerable.FirstOrDefault(layerConfigs, predicate2);
		object obj28 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v25+E4]");
		UnityEngine.Object obj31;
		if ((nint)0 != 0)
		{
			bool flag9 = (UnityEngine.Object)obj27 != null;
			bool flag10 = !flag9;
			object obj30 = !flag10;
			num2 = 0;
			obj31 = null;
			if (obj30 != null)
			{
				goto IL_069a;
			}
			num4 = num3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = (UnityEngine.Object)obj27 != null;
			bool flag12 = !flag11;
			num2 = 0;
			obj31 = null;
			num4 = num3;
			if (!flag12)
			{
				goto IL_069a;
			}
		}
		goto IL_0ab4;
		IL_0d91:
		NullReferenceException ex = new NullReferenceException();
		bool flag13 = (nint)obj17 != 1;
		NullReferenceException ex2 = ex;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj32 = (nint)0 + (nint)4008;
			obj17 = obj32;
			enumerator.Dispose();
			object obj33 = default(object);
			if (obj33 == null)
			{
				goto IL_0ab4;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj33;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E3C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0ab4:
		Initialize((IReadOnlyList<IconLayer>)list, tier);
		return;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v95+E4]");
		bool flag14 = (nint)0 == 0;
		object obj34 = !flag14;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v90+B8]");
			obj6 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)320;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj6, (IntPtr)obj37);
		object obj38 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v89+B8]");
		object obj39 = (nint)0 + (nint)8;
		obj39 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num4 = unchecked((nint)null);
		predicate = func;
		goto IL_019e;
		IL_0598:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v58+E4]");
		bool flag15 = (nint)0 == 0;
		object obj40 = !flag15;
		object obj42;
		object obj43;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj41 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v52+B8]");
			obj43 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)328;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj43, (IntPtr)obj45);
		object obj46 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v51+B8]");
		object obj47 = (nint)0 + (nint)16;
		obj47 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num3 = unchecked((nint)null);
		predicate2 = func2;
		goto IL_0d9f;
		IL_069a:
		bool flag16 = model.Icons == null;
		enumerator = (List<object>.Enumerator)0;
		num4 = num3;
		obj17 = obj31;
		if (!flag16)
		{
			List<object>.Enumerator enumerator3 = ((List<object>)(object)model.Icons).GetEnumerator();
			object obj48 = typeof(UsageHint) + 744;
			object obj49 = (nint)0 + (nint)696;
			obj13 = 0;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			object obj54 = default(object);
			object obj56 = default(object);
			object obj66 = default(object);
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			while (true)
			{
				object obj50 = (nint)0 + (nint)4016;
				if (!enumerator4.MoveNext())
				{
					break;
				}
				object obj51 = typeof(System.IOAsyncCallback) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				_ = 4294967295L;
				_ = 63;
				_ = 0;
				object obj52 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v33+B8]");
				object obj53 = 0;
				obj13 = obj53;
				obj54..ctor();
				object obj55 = obj54 + 24;
				obj55 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj56 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ stack_-A8+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ stack_-A8+14]");
					Color color2 = ColorExtension.FromPackedRgba(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ stack_-A8+18]");
					object obj57 = (nint)1127481344 - (nint)0;
					obj13 = obj57 / 1135869952;
					if (obj27 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v24 (System.Object)+20]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v24 (System.Object)+24]");
						if (num5 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ stack_-A8+24]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v24 (System.Object)+20]");
							object obj58 = num6 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v24 (System.Object)+24]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v24 (System.Object)+20]");
							object obj59 = num7 - 0;
							double num8 = (double)obj58 / (double)obj59;
							double num9 = num8 - 1.0;
							bool flag17 = num9 < 0.0;
							bool flag18 = num9 == 0.0;
							object obj60 = num8 ^ 1.0;
							object obj61 = num8 ^ num9;
							object obj62 = obj60 & obj61;
							bool flag19 = (nint)obj62 < 0;
							bool flag20 = flag17 == flag19;
							object obj63 = !flag18;
							object obj64 = flag20 & obj63;
							object obj65 = ~obj64;
							double num10 = ((obj65 != null) ? num8 : 1.0);
							if (num8 < 0.0)
							{
								double num11 = 0.0;
							}
							else
							{
								double num11 = num10;
							}
						}
						else
						{
							double num11 = 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ stack_-A8+28]");
						_ = 0;
						float rimHalfExtent = GetRimHalfExtent();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ stack_-A8+1C]");
						obj13 = 0 * obj66;
						object obj71;
						if (list != null)
						{
							object obj67 = obj49;
							int version2 = list._version + 1;
							list._version = version2;
							object[] items2 = list._items;
							if (list._items != null)
							{
								bool flag21 = list._size < items2.Length;
								object obj68 = !flag21;
								if (obj68 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v40+20]");
									object obj69 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v42+C0]");
									object obj70 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v43+70]");
									num2 = 0;
									list.AddWithResize(obj54);
									obj71 = 1058642330;
								}
								else
								{
									int size2 = list._size + 1;
									list._size = size2;
									object obj72 = list._items + list._size;
									object obj73 = obj72 + 32;
									obj73 = obj54;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj71 = 1058642330;
								}
								continue;
							}
						}
						NullReferenceException ex4 = new NullReferenceException();
						obj71 = 1058642330;
						obj17 = null;
					}
					else
					{
						NullReferenceException ex5 = new NullReferenceException();
						object obj71 = 1135869952;
						obj17 = null;
					}
				}
				else
				{
					NullReferenceException ex6 = new NullReferenceException();
					obj17 = obj27;
				}
				enumerator = enumerator2;
				enumerator2 = (List<object>.Enumerator)0;
				num4 = num3;
				goto IL_0d91;
			}
			enumerator4.Dispose();
			num4 = num3;
			goto IL_0ab4;
		}
		goto IL_0d91;
		IL_019e:
		object obj74 = (nint)0 + (nint)984;
		obj16 = Enumerable.FirstOrDefault(layerConfigs, predicate);
		object obj75 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj76 = obj75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v73+E4]");
		if ((nint)0 != 0)
		{
			bool flag22 = (UnityEngine.Object)obj16 != null;
			bool flag23 = !flag22;
			object obj77 = !flag23;
			num2 = 0;
			UnityEngine.Object obj78 = null;
			if (obj77 != null)
			{
				goto IL_02a3;
			}
			int num = 0;
			obj3 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag24 = (UnityEngine.Object)obj16 != null;
			bool flag25 = !flag24;
			num2 = 0;
			UnityEngine.Object obj78 = null;
			int num = 0;
			obj3 = null;
			if (!flag25)
			{
				goto IL_02a3;
			}
		}
		goto IL_0456;
		IL_0456:
		bool flag26 = model.Icons == null;
		num3 = num4;
		if (!flag26)
		{
			goto IL_0480;
		}
		goto IL_0ab4;
		IL_0480:
		obj42 = typeof(CardUtils.<>c) + 1160;
		object obj79 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v58+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v58+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v46+10]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v46+10]");
			bool flag27 = (nint)0 == 0;
			object obj80 = !flag27;
			if (obj80 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v46+10]");
				Func<object, bool> func3 = (Func<object, bool>)0;
				goto IL_0598;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj79 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v58+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v46+10]");
			Func<object, bool> func3 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v46+10]");
			bool flag28 = (nint)0 == 0;
			object obj81 = !flag28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v46+10]");
			predicate2 = (Func<object, bool>)0;
			if (obj81 == null)
			{
				goto IL_0598;
			}
		}
		goto IL_0d9f;
	}

	public unsafe void Initialize(IReadOnlyList<IconLayer> layers, int tier)
	{
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Expected O, but got Unknown
		//IL_0a49: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0041: Expected O, but got I
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected O, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Expected O, but got Unknown
		//IL_0ace: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0a72: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_08c9: Expected O, but got I4
		//IL_08d2: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0141: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_0b21: Expected I, but got O
		//IL_0b31: Expected O, but got I
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected O, but got Unknown
		//IL_017c: Expected O, but got I
		//IL_060d: Expected O, but got I4
		//IL_0616: Expected O, but got I4
		//IL_061f: Expected O, but got I4
		//IL_0628: Expected O, but got I4
		//IL_0651: Expected O, but got I4
		//IL_0662: Expected O, but got I4
		//IL_06a3: Expected O, but got I4
		//IL_06ac: Expected O, but got I4
		//IL_0af5: Expected O, but got I
		//IL_0cb6: Expected O, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_06e6: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_025e: Expected O, but got I
		//IL_0d60: Expected O, but got I
		//IL_0721: Expected O, but got I
		//IL_07f9: Expected O, but got I4
		//IL_0d2c: Expected O, but got I
		//IL_0bd8: Expected O, but got I4
		//IL_0299: Expected O, but got I
		//IL_0940: Expected O, but got I4
		//IL_0951: Expected O, but got I4
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_0b76: Expected O, but got I
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_074a: Expected O, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_09d0: Expected O, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_03c9: Expected I, but got O
		//IL_03d9: Expected O, but got I
		//IL_041d: Expected O, but got I4
		//IL_04ee: Expected O, but got I
		//IL_089d: Expected I, but got O
		//IL_0483: Expected I, but got O
		//IL_04a3: Expected I, but got O
		//IL_04b3: Expected O, but got I
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_05ac: Expected O, but got I4
		//IL_0588: Expected O, but got I4
		//IL_05d0: Expected I, but got O
		//IL_05d8: Expected I4, but got O
		//IL_0831: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89D4]");
		nint num = 0;
		Clear();
		object obj = this + 72;
		IReadOnlyList<IconLayer> readOnlyList = default(IReadOnlyList<IconLayer>);
		obj = readOnlyList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		bool flag = obj == null;
		object obj3 = 0;
		if (flag)
		{
			goto IL_0a57;
		}
		object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3336;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15+B0]");
		object obj7 = (nint)0 + (nint)8;
		object obj8 = default(object);
		object obj9 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v29-8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v29-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj9 = obj7 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15+12E]");
			obj6 = -1;
			bool flag2 = (nint)obj6 != 1;
			obj7 = obj9;
			if (flag2)
			{
				continue;
			}
			goto IL_00cd;
		}
		obj6 = obj7;
		object obj10 = obj5 + obj7;
		object obj11 = obj10 + 312;
		obj9 = obj7;
		goto IL_0a96;
		IL_0a96:
		object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v27+8]");
		IconLayer iconLayer = (IconLayer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X0_v27] (should have been resolved before IL gen)");
		num = (nint)(&obj3);
		object obj14 = default(object);
		object obj19 = default(object);
		object obj20 = default(object);
		Delegate obj22 = default(Delegate);
		Behaviour behaviour = default(Behaviour);
		IReadOnlyList<IconLayer> readOnlyList3 = default(IReadOnlyList<IconLayer>);
		Material source = default(Material);
		Action<object> action = default(Action<object>);
		IReadOnlyList<IconLayer> readOnlyList2 = default(IReadOnlyList<IconLayer>);
		IReadOnlyList<IconLayer> readOnlyList4 = default(IReadOnlyList<IconLayer>);
		object obj31 = default(object);
		Delegate obj21 = default(Delegate);
		Delegate obj23 = default(Delegate);
		nint num2 = default(nint);
		int num3 = default(int);
		object obj41 = default(object);
		object obj61 = default(object);
		nint num7;
		object obj47;
		object obj48;
		while (true)
		{
			if (obj14 != null)
			{
				object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+12E]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01cd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v24-8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v24-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj9 = obj17 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+12E]");
					obj6 = -1;
					bool flag3 = (nint)obj6 != 1;
					obj17 = obj9;
					if (flag3)
					{
						continue;
					}
					goto IL_01cd;
				}
				obj6 = obj17;
				object obj18 = obj16 + obj17;
				obj19 = obj18 + 312;
				obj9 = obj17;
				goto IL_0b19;
			}
			NullReferenceException ex = new NullReferenceException();
			readOnlyList = (IReadOnlyList<IconLayer>)iconLayer;
			break;
			IL_05b1:
			ApplyLayer((IconLayer)obj20);
			obj21 = obj22;
			Delegate obj24;
			obj23 = obj24;
			num2 = unchecked((nint)null);
			num3 = (int)obj22;
			iconLayer = (IconLayer)obj20;
			continue;
			IL_02ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_0b9a;
			IL_0b9a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v746 @ X0_v37] (should have been resolved before IL gen)");
			readOnlyList2 = (IReadOnlyList<IconLayer>)logoAnchor;
			object obj25 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v40+E4]");
			bool flag4 = (nint)0 == 0;
			object obj26 = !flag4;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = (nint)0 + (nint)552;
			num3 = (int)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if ((object)behaviour != null)
			{
				behaviour.enabled = false;
				bool flag5 = !useShine;
				num3 = 0;
				readOnlyList = null;
				num = (useShine ? 1 : 0);
				if (!flag5)
				{
					nint num4 = (nint)behaviour;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v43 (Il2CppClass<UnityEngine.Behaviour>)+338]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v768 @ X8_v43 (Il2CppClass<UnityEngine.Behaviour>)+338] (should have been resolved before IL gen)");
					object obj27 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v68+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v68+E4]");
					bool flag6 = (nint)0 == 0;
					object obj28 = !flag6;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag7 = (UnityEngine.Object)readOnlyList3 != null;
					bool flag8 = !flag7;
					readOnlyList2 = readOnlyList3;
					num3 = 0;
					readOnlyList = null;
					if (!flag8)
					{
						nint num5 = (nint)behaviour;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v801 @ X8_v45 (Il2CppClass<UnityEngine.Behaviour>)+338] (should have been resolved before IL gen)");
						Material shineMaterial = GetShineMaterial(source);
						num = (nint)behaviour;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v3 (Il2CppClass<UnityEngine.Behaviour>)+348]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v3 (Il2CppClass<UnityEngine.Behaviour>)+350]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X8_v3 (Il2CppClass<UnityEngine.Behaviour>)+348] (should have been resolved before IL gen)");
						readOnlyList2 = readOnlyList3;
						readOnlyList = (IReadOnlyList<IconLayer>)shineMaterial;
					}
				}
				if (_displayers != null)
				{
					object obj29 = (nint)0 + (nint)3352;
					((Dictionary<object, object>)(object)_displayers).set_Item(obj20, (object)behaviour);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)0 + (nint)1312;
					action..ctor((object)this, (IntPtr)num);
					if (obj20 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89DC]");
						num = 0;
						readOnlyList2 = (IReadOnlyList<IconLayer>)(obj20 + 16);
						Delegate obj30 = (Delegate)readOnlyList2;
						while (true)
						{
							obj24 = Delegate.Combine(obj30, action);
							if ((object)obj24 != null)
							{
								readOnlyList4 = (IReadOnlyList<IconLayer>)obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag9 = obj31 == null;
								object obj32 = !flag9;
								object obj33 = obj31;
								if (obj32 == null)
								{
									break;
								}
							}
							else
							{
								object obj33 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							bool flag10 = (object)obj22 != obj30;
							obj30 = obj22;
							if (!flag10)
							{
								goto IL_05b1;
							}
						}
						InvalidCastException ex2 = new InvalidCastException();
						obj21 = obj30;
						obj23 = obj24;
						num2 = unchecked((nint)null);
						num3 = 0;
						readOnlyList = (IReadOnlyList<IconLayer>)obj13;
					}
					else
					{
						NullReferenceException ex3 = new NullReferenceException();
						num2 = unchecked((nint)null);
						num3 = (int)num;
						readOnlyList = (IReadOnlyList<IconLayer>)this;
					}
				}
				else
				{
					NullReferenceException ex4 = new NullReferenceException();
				}
			}
			else
			{
				NullReferenceException ex5 = new NullReferenceException();
				readOnlyList = readOnlyList2;
			}
			break;
			IL_06ba:
			object obj34 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj36;
			object obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9+12E]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0772;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9+B0]");
			object obj37 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X10_v9-8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X10_v9-8]");
				if (0 == (nint)obj34)
				{
					break;
				}
				obj9 = obj37 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9+12E]");
				obj6 = -1;
				bool flag11 = (nint)obj6 != 1;
				obj37 = obj9;
				if (flag11)
				{
					continue;
				}
				goto IL_0772;
			}
			obj6 = obj37;
			object obj38 = obj35 + obj37;
			object obj39 = obj38 + 312;
			int num6 = num3;
			obj9 = obj37;
			goto IL_0d50;
			IL_01cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_0b19;
			IL_0b19:
			num = (nint)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v33+8]");
			readOnlyList = (IReadOnlyList<IconLayer>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v545 @ X0_v33] (should have been resolved before IL gen)");
			object obj40 = obj41 & 1;
			if (obj40 != null)
			{
				if (obj14 != null)
				{
					object obj42 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 720;
					object obj43 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v28+12E]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v28+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02ea;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v28+B0]");
					object obj44 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v19-8]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v19-8]");
						if (0 == (nint)obj42)
						{
							break;
						}
						obj9 = obj44 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v28+12E]");
						obj6 = -1;
						bool flag12 = (nint)obj6 != 1;
						obj44 = obj9;
						if (flag12)
						{
							continue;
						}
						goto IL_02ea;
					}
					obj6 = obj44;
					object obj45 = obj43 + obj44;
					object obj46 = obj45 + 312;
					obj9 = obj44;
					goto IL_0b9a;
				}
				NullReferenceException ex6 = new NullReferenceException();
				break;
			}
			bool flag13 = obj14 == null;
			num7 = (nint)(&obj3);
			obj3 = obj14;
			obj47 = 0;
			obj48 = 152993792;
			object obj49 = 5;
			object obj50 = 0;
			obj36 = obj14;
			nint num8 = (nint)(&obj3);
			object obj51 = obj8;
			obj3 = obj14;
			obj47 = 0;
			object obj52 = obj12;
			object obj53 = 152993792;
			Delegate obj54 = obj21;
			IReadOnlyList<IconLayer> readOnlyList5 = readOnlyList4;
			Delegate obj55 = obj23;
			IntPtr intPtr = num2;
			IReadOnlyList<IconLayer> readOnlyList6 = readOnlyList2;
			num6 = num3;
			object obj56 = obj9;
			object obj57 = 5;
			object obj58 = 0;
			if (!flag13)
			{
				goto IL_06ba;
			}
			goto IL_0c9c;
			IL_0d50:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v21+8]");
			readOnlyList = (IReadOnlyList<IconLayer>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v688 @ X0_v21] (should have been resolved before IL gen)");
			num8 = num7;
			obj51 = obj8;
			obj52 = obj12;
			obj53 = obj48;
			obj54 = obj21;
			readOnlyList5 = readOnlyList4;
			obj55 = obj23;
			intPtr = num2;
			readOnlyList6 = readOnlyList2;
			obj56 = obj9;
			obj57 = obj49;
			obj58 = obj50;
			goto IL_0c9c;
			IL_0772:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = 0;
			goto IL_0d50;
			IL_0c9c:
			while (true)
			{
				bool flag14 = obj58 == null;
				object obj59 = !flag14;
				num7 = num8;
				obj8 = obj51;
				obj12 = obj52;
				obj48 = obj53;
				obj21 = obj54;
				readOnlyList4 = readOnlyList5;
				obj23 = obj55;
				num2 = intPtr;
				readOnlyList2 = readOnlyList6;
				num3 = num6;
				obj9 = obj56;
				if (obj59 == null)
				{
					if ((nint)obj57 != 5)
					{
						bool flag15 = obj57 == null;
						object obj60 = !flag15;
						if (obj60 != null)
						{
							return;
						}
					}
					ApplySiblingOrder();
					return;
				}
				OutOfMemoryException ex7 = new OutOfMemoryException();
				if ((nint)readOnlyList == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj50 = obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag16 = obj3 == null;
					object obj62 = !flag16;
					obj47 = obj61;
					obj49 = 0;
					obj36 = obj3;
					if (obj62 != null)
					{
						break;
					}
					num8 = num7;
					obj51 = obj8;
					obj47 = obj61;
					obj52 = obj12;
					obj53 = obj48;
					obj54 = obj21;
					readOnlyList5 = readOnlyList4;
					obj55 = obj23;
					intPtr = num2;
					readOnlyList6 = readOnlyList2;
					num6 = num3;
					obj56 = obj9;
					obj57 = 0;
					obj58 = obj61;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			goto IL_06ba;
		}
		num7 = (nint)(&obj3);
		obj3 = obj14;
		obj47 = 0;
		obj48 = 152993792;
		goto IL_0a57;
		IL_0a57:
		throw new NullReferenceException();
		IL_00cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 0;
		goto IL_0a96;
	}

	public unsafe void Clear()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Expected O, but got Unknown
		//IL_0cdf: Expected O, but got I4
		//IL_0ce8: Expected O, but got I4
		//IL_0cf1: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0d5b: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0bfe: Expected I, but got O
		//IL_0c4e: Expected I, but got O
		//IL_0458: Expected O, but got I4
		//IL_0461: Expected O, but got I4
		//IL_046a: Expected O, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0ed1: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_07ec: Expected O, but got I
		//IL_095f: Expected O, but got I
		//IL_096f: Expected O, but got I
		//IL_0985: Expected O, but got I
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_09ad: Expected O, but got I4
		//IL_09bd: Expected O, but got I
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_0821: Expected O, but got I
		//IL_0837: Expected O, but got I
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_0864: Expected O, but got I
		//IL_0f85: Expected O, but got I
		//IL_0a1f: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		//IL_0a45: Expected O, but got I
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected O, but got Unknown
		//IL_09f7: Expected O, but got I4
		//IL_0f07: Expected O, but got I4
		//IL_0f10: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_08a7: Expected O, but got I
		//IL_08b7: Expected O, but got I
		//IL_08cd: Expected O, but got I
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_08f5: Expected O, but got I4
		//IL_0905: Expected O, but got I
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_049b: Expected O, but got I
		//IL_0ae7: Expected O, but got I4
		//IL_0af0: Expected O, but got I4
		//IL_0af9: Expected O, but got I4
		//IL_0b0a: Expected O, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_0932: Expected O, but got I
		//IL_0a80: Expected O, but got I
		//IL_0287: Expected O, but got I
		//IL_04d6: Expected O, but got I
		//IL_0e14: Expected I, but got O
		//IL_0e22: Expected I, but got O
		//IL_02c2: Expected O, but got I
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0b2b: Expected O, but got I4
		//IL_0b34: Expected O, but got I4
		//IL_0b3d: Expected O, but got I4
		//IL_0b46: Expected O, but got I4
		//IL_0b4f: Expected O, but got I4
		//IL_0b5c: Expected I, but got O
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_04ff: Expected O, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I
		//IL_03a4: Expected I, but got O
		//IL_0384: Expected O, but got I4
		//IL_03b9: Expected O, but got I
		//IL_03db: Expected O, but got I4
		//IL_03ec: Expected O, but got I4
		//IL_03fd: Expected O, but got I4
		//IL_0405: Expected I, but got O
		//IL_0416: Expected O, but got I4
		//IL_042e: Expected O, but got I
		//IL_0436: Expected I, but got O
		//IL_0a99: Expected O, but got I4
		//IL_0aa2: Expected O, but got I4
		//IL_0aab: Expected O, but got I4
		//IL_0ab4: Expected O, but got I4
		//IL_0abd: Expected O, but got I4
		//IL_0ace: Expected I, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_ = 0;
		object obj3 = this + 72;
		object obj4 = obj3;
		bool flag = obj3 == null;
		Dictionary<object, object>.Enumerator enumerator = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator2 = (Dictionary<object, object>.Enumerator)0;
		object obj5 = 152993792;
		object obj10 = default(object);
		object obj8;
		if (!flag)
		{
			object obj6 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3336;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v31+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v31+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v31+B0]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X10_v31-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj10 = obj9 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v31+12E]");
				obj8 = -1;
				bool flag2 = (nint)obj8 != 1;
				obj9 = obj10;
				if (flag2)
				{
					continue;
				}
				goto IL_00c5;
			}
			obj8 = obj9;
			object obj11 = obj7 + obj9;
			object obj12 = obj11 + 312;
			obj10 = obj9;
			goto IL_0d23;
		}
		goto IL_0f58;
		IL_0f58:
		object obj14 = default(object);
		Dictionary<object, object>.Enumerator enumerator4;
		Dictionary<object, object>.Enumerator enumerator6;
		object obj15;
		Dictionary<object, object>.Enumerator enumerator5 = default(Dictionary<object, object>.Enumerator);
		object obj16 = default(object);
		NullReferenceException ex2;
		nint num4 = default(nint);
		nint num3;
		object obj13 = default(object);
		nint num = default(nint);
		object obj38;
		Dictionary<object, object>.Enumerator enumerator3;
		while (true)
		{
			NullReferenceException ex = new NullReferenceException();
			bool flag3 = num != 1;
			ex2 = ex;
			if (flag3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			nint num2 = (nint)obj13;
			enumerator.Dispose();
			bool flag4 = obj14 == null;
			enumerator3 = (Dictionary<object, object>.Enumerator)obj14;
			enumerator4 = enumerator5;
			enumerator6 = enumerator2;
			enumerator3 = (Dictionary<object, object>.Enumerator)obj14;
			obj15 = obj16;
			num3 = num4;
			num = (nint)obj13;
			if (flag4)
			{
				bool flag5 = _displayers == null;
				num = num2;
				if (flag5)
				{
					continue;
				}
				((Dictionary<object, object>)(object)_displayers).Clear();
				object obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X19_v6+38]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X19_v6+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v8+10]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v8+10]");
					object obj20 = (nint)0 + (nint)309;
					object obj21 = obj20 & 1;
					bool flag6 = obj21 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v8+10]");
					object obj22 = 0;
					if (!flag6)
					{
						goto IL_0872;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X19_v6+38]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v15+10]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v15+10]");
					object obj24 = (nint)0 + (nint)309;
					object obj25 = obj24 & 1;
					bool flag7 = obj25 == null;
					object obj26 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v15+10]");
					object obj22 = 0;
					if (obj26 != null)
					{
						goto IL_0872;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v19+E4]");
				bool flag8 = (nint)0 == 0;
				object obj27 = !flag8;
				if (obj27 != null)
				{
					goto IL_0897;
				}
				goto IL_0a05;
			}
			goto IL_0c5c;
			IL_0a05:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X19_v6+38]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v10+10]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v10+10]");
			object obj30 = (nint)0 + (nint)309;
			object obj31 = obj30 & 1;
			if (obj31 == null)
			{
				goto IL_0913;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v10+10]");
			object obj32 = 0;
			goto IL_0922;
			IL_0872:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0897;
			}
			goto IL_0a05;
			IL_0897:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X19_v6+38]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v22+10]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v22+10]");
			object obj34 = (nint)0 + (nint)309;
			object obj35 = obj34 & 1;
			bool flag9 = obj35 == null;
			object obj36 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v22+10]");
			obj32 = 0;
			if (obj36 == null)
			{
				goto IL_0913;
			}
			goto IL_0922;
			IL_0922:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v27+B8]");
			object obj37 = 0;
			obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0913:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_0922;
		}
		goto IL_0f66;
		IL_0b17:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator = (Dictionary<object, object>.Enumerator)0;
		enumerator2 = (Dictionary<object, object>.Enumerator)0;
		enumerator3 = (Dictionary<object, object>.Enumerator)0;
		obj16 = 0;
		object obj39 = 152993792;
		object obj40 = default(object);
		obj13 = obj40;
		num = (nint)this;
		goto IL_0ba7;
		IL_0ef6:
		enumerator4 = enumerator5;
		enumerator6 = (Dictionary<object, object>.Enumerator)0;
		enumerator3 = (Dictionary<object, object>.Enumerator)0;
		goto IL_0c5c;
		IL_0c5c:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		enumerator5 = enumerator4;
		enumerator2 = enumerator6;
		obj16 = obj15;
		ex2 = (NullReferenceException)(object)ex4;
		num4 = num3;
		goto IL_0f66;
		IL_0a85:
		InvalidCastException ex5 = new InvalidCastException();
		enumerator = (Dictionary<object, object>.Enumerator)0;
		enumerator2 = (Dictionary<object, object>.Enumerator)0;
		enumerator3 = (Dictionary<object, object>.Enumerator)0;
		obj16 = 0;
		obj39 = 152993792;
		num4 = 0;
		object obj41;
		num = (nint)obj41;
		goto IL_0ba7;
		IL_00c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 0;
		goto IL_0d23;
		IL_0d23:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v36+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v313 @ X0_v36] (should have been resolved before IL gen)");
		object obj42 = default(object);
		bool flag10 = obj42 == null;
		obj5 = 152993792;
		if (flag10)
		{
			goto IL_0444;
		}
		object obj43 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj44 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 720;
		obj41 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2384;
		obj5 = (nint)0 + (nint)1312;
		Delegate obj46 = default(Delegate);
		Delegate obj45 = obj46;
		obj15 = obj16;
		Action<object> action2 = default(Action<object>);
		Action<object> action = action2;
		object obj47 = obj42;
		num3 = num4;
		object obj48 = obj10;
		Action<object> action3 = default(Action<object>);
		IntPtr intPtr = default(IntPtr);
		Delegate obj56 = default(Delegate);
		object obj59 = default(object);
		while (true)
		{
			object obj49 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v38+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v38+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v38+B0]");
			object obj50 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X10_v26-8]");
				if (0 == (nint)obj43)
				{
					break;
				}
				obj48 = obj50 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v38+12E]");
				obj8 = -1;
				bool flag11 = (nint)obj8 != 1;
				obj50 = obj48;
				if (flag11)
				{
					continue;
				}
				goto IL_01f2;
			}
			obj8 = obj50;
			object obj51 = obj49 + obj50;
			object obj52 = obj51 + 312;
			obj48 = obj50;
			goto IL_0d8e;
			IL_0df8:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v866 @ X0_v72] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num4 = (nint)obj5;
			action3..ctor((object)this, (IntPtr)obj5);
			if (obj40 != null)
			{
				obj13 = obj40 + 16;
				Delegate obj53 = (Delegate)obj13;
				while (true)
				{
					Delegate obj54 = Delegate.Remove(obj53, action3);
					if ((object)obj54 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = intPtr == (IntPtr)0;
						object obj55 = !flag12;
						num = intPtr;
						if (obj55 == null)
						{
							break;
						}
					}
					else
					{
						num = unchecked((nint)null);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag13 = (object)obj56 != obj53;
					obj53 = obj56;
					if (flag13)
					{
						continue;
					}
					goto IL_03a9;
				}
				goto IL_0a85;
			}
			goto IL_0b17;
			IL_03a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			bool flag14 = (nint)0 == 0;
			object obj57 = !flag14;
			obj46 = obj56;
			obj16 = 0;
			action2 = action3;
			obj39 = 152993792;
			num4 = (nint)obj56;
			obj45 = obj56;
			obj15 = 0;
			action = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			obj47 = 0;
			num3 = (nint)obj56;
			if (obj57 != null)
			{
				continue;
			}
			goto IL_0444;
			IL_0313:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_0df8;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_0d8e;
			IL_0d8e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v43+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v637 @ X0_v43] (should have been resolved before IL gen)");
			object obj58 = obj59 & 1;
			if (obj58 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			if ((nint)0 == 0)
			{
				goto IL_0ad3;
			}
			object obj60 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v57+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v57+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0313;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v57+B0]");
			object obj61 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X10_v21-8]");
				if (0 == (nint)obj44)
				{
					break;
				}
				obj48 = obj61 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v57+12E]");
				obj8 = -1;
				bool flag15 = (nint)obj8 != 1;
				obj61 = obj48;
				if (flag15)
				{
					continue;
				}
				goto IL_0313;
			}
			obj8 = obj61;
			object obj62 = obj60 + obj61;
			object obj63 = obj62 + 312;
			obj48 = obj61;
			goto IL_0df8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		if ((nint)0 == 0)
		{
			goto IL_0ef6;
		}
		object obj64 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj65 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v53+12E]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v53+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0527;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v53+B0]");
		object obj66 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X10_v15-8]");
			if (0 == (nint)obj64)
			{
				break;
			}
			obj48 = obj66 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v53+12E]");
			obj8 = -1;
			bool flag16 = (nint)obj8 != 1;
			obj66 = obj48;
			if (flag16)
			{
				continue;
			}
			goto IL_0527;
		}
		object obj67 = obj65 + obj66;
		object obj68 = obj67 + 312;
		goto IL_0f39;
		IL_0527:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 0;
		goto IL_0f39;
		IL_0f39:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v65+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v922 @ X0_v65] (should have been resolved before IL gen)");
		goto IL_0ef6;
		IL_0ad3:
		NullReferenceException ex6 = new NullReferenceException();
		enumerator = (Dictionary<object, object>.Enumerator)0;
		enumerator2 = (Dictionary<object, object>.Enumerator)0;
		enumerator3 = (Dictionary<object, object>.Enumerator)0;
		obj16 = obj15;
		obj39 = 152993792;
		num4 = num3;
		goto IL_0ba7;
		IL_0ba7:
		obj38 = obj3;
		goto IL_0f58;
		IL_0f66:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E380");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0444:
		NullReferenceException ex7 = new NullReferenceException();
		enumerator = (Dictionary<object, object>.Enumerator)0;
		enumerator2 = (Dictionary<object, object>.Enumerator)0;
		enumerator3 = (Dictionary<object, object>.Enumerator)0;
		goto IL_0ba7;
	}

	public void ResetToDefault()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0044: Expected I, but got O
		Clear();
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 320;
		object obj2 = (nint)0 + (nint)1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetClanLogoElements(action);
	}

	public unsafe void ApplySiblingOrder()
	{
		//IL_000f: Expected O, but got I4
		//IL_11c9: Expected O, but got I4
		//IL_11d9: Expected O, but got I
		//IL_0eb4: Expected O, but got I
		//IL_0ed6: Expected O, but got I4
		//IL_0ee6: Expected O, but got I
		//IL_0eef: Expected O, but got I4
		//IL_0041: Expected O, but got I
		//IL_0068: Expected O, but got I
		//IL_0071: Expected O, but got I4
		//IL_0f73: Expected O, but got I4
		//IL_0f43: Expected O, but got I4
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected O, but got Unknown
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		//IL_1623: Expected O, but got I
		//IL_1579: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012a: Expected O, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_150d: Expected I, but got O
		//IL_151d: Expected O, but got I
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I4
		//IL_1242: Expected O, but got I
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		//IL_0c75: Expected O, but got Ref
		//IL_0c7d: Expected O, but got Ref
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected O, but got Unknown
		//IL_0cea: Expected O, but got Ref
		//IL_0cf2: Expected O, but got Ref
		//IL_0d2c: Expected O, but got Ref
		//IL_0d34: Expected O, but got Ref
		//IL_120e: Expected O, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_112e: Expected O, but got I4
		//IL_0d54: Expected I, but got O
		//IL_0d64: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_0e23: Expected O, but got I4
		//IL_0236: Expected I, but got O
		//IL_0246: Expected O, but got I
		//IL_0d9f: Expected O, but got I
		//IL_02e5: Expected O, but got I4
		//IL_1597: Expected O, but got I
		//IL_12bb: Expected O, but got I
		//IL_0281: Expected O, but got I
		//IL_1287: Expected O, but got I
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected O, but got Unknown
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected O, but got Unknown
		//IL_0de2: Expected O, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0354: Expected O, but got I
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02aa: Expected O, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03d2: Expected I, but got O
		//IL_03e2: Expected O, but got I
		//IL_0481: Expected O, but got I4
		//IL_1326: Expected O, but got I
		//IL_041d: Expected O, but got I
		//IL_12f2: Expected O, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04f8: Expected O, but got I
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0446: Expected O, but got I
		//IL_0597: Expected O, but got I4
		//IL_13c1: Expected O, but got I
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d9: Expected O, but got Unknown
		//IL_0533: Expected O, but got I
		//IL_138d: Expected O, but got I
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_1082: Expected O, but got Ref
		//IL_108b: Expected O, but got I4
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_0921: Expected O, but got I
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_055c: Expected O, but got I
		//IL_09c0: Expected O, but got I4
		//IL_0601: Expected O, but got I
		//IL_14f6: Expected O, but got I
		//IL_095c: Expected O, but got I
		//IL_06a0: Expected O, but got I4
		//IL_14c2: Expected O, but got I
		//IL_063c: Expected O, but got I
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got Unknown
		//IL_1406: Expected O, but got I
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected O, but got Unknown
		//IL_0985: Expected O, but got I
		//IL_06e5: Expected O, but got I
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_0665: Expected O, but got I
		//IL_078e: Expected O, but got Ref
		//IL_07ce: Expected O, but got I4
		//IL_0811: Expected O, but got I4
		//IL_08a0: Expected O, but got I4
		//IL_08a9: Expected O, but got I4
		//IL_08e0: Expected O, but got I4
		//IL_08f0: Expected O, but got I4
		object handle = 147423232 + 1984;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v4+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+E4]");
		Type typeFromHandle;
		nint num;
		object obj4;
		Type enumType;
		IntPtr intPtr;
		object obj3;
		if ((nint)0 != 0)
		{
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v4+98]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj4 = 0;
			object obj5 = 0;
			enumType = typeFromHandle;
			intPtr = num;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v4+98]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj4 = 0;
			object obj5 = 0;
			enumType = typeFromHandle;
			intPtr = num;
			if (obj6 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Array values = Enum.GetValues(enumType);
		bool flag3 = values == null;
		object obj7 = !flag3;
		obj3 = obj4;
		num = intPtr;
		if (obj7 != null)
		{
			goto IL_00b9;
		}
		goto IL_0f61;
		IL_02d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = 1;
		goto IL_12ab;
		IL_0d4c:
		NullReferenceException ex = default(NullReferenceException);
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0df8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<System.NullReferenceException>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		object obj12;
		object obj14;
		object obj15 = default(object);
		object obj16;
		object obj17;
		object obj19;
		object obj21;
		object obj23;
		object obj25;
		int num3;
		object obj27;
		object obj28 = default(object);
		object obj29;
		ClanLogoPreviewer clanLogoPreviewer;
		ClanLogoPreviewer clanLogoPreviewer2;
		object obj30;
		object obj31;
		object obj13 = default(object);
		object obj18 = default(object);
		object obj20 = default(object);
		object obj22 = default(object);
		object obj24 = default(object);
		int num2 = default(int);
		object obj11 = default(object);
		object obj26;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X10_v22-8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X10_v22-8]");
			bool flag4 = 0 == (nint)obj12;
			obj13 = obj14;
			obj15 = obj16;
			obj8 = obj17;
			obj18 = obj19;
			obj20 = obj21;
			obj22 = obj23;
			obj24 = obj25;
			num2 = num3;
			obj26 = obj27;
			obj28 = obj29;
			clanLogoPreviewer = clanLogoPreviewer2;
			if (flag4)
			{
				break;
			}
			obj30 = obj10 + 16;
			obj9--;
			bool flag5 = (nint)obj9 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X10_v22-8]");
			obj31 = 0;
			obj10 = obj30;
			if (flag5)
			{
				continue;
			}
			goto IL_0df8;
		}
		goto IL_0f82;
		IL_1316:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X0_v55+8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v976 @ X0_v55] (should have been resolved before IL gen)");
		object obj33 = default(object);
		bool flag6 = obj33 == null;
		object obj34 = obj33;
		object obj35 = obj11;
		object obj36 = obj15;
		object obj37 = obj8;
		object obj38 = obj10;
		num2 = num3;
		object obj43;
		object value;
		if (!flag6)
		{
			object obj45 = default(object);
			object obj47 = default(object);
			object obj52 = default(object);
			while (true)
			{
				object obj39 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v42+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v42+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0584;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v42+B0]");
				object obj40 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X10_v37-8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X10_v37-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj10 = obj40 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v42+12E]");
					obj3 = -1;
					bool flag7 = (nint)obj3 != 1;
					obj40 = obj10;
					if (flag7)
					{
						continue;
					}
					goto IL_0584;
				}
				obj3 = obj40;
				object obj41 = obj39 + obj40;
				object obj42 = obj41 + 312;
				obj10 = obj40;
				goto IL_13b1;
				IL_09ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj8 = 0;
				goto IL_14e6;
				IL_107a:
				obj13 = (object)(&obj43);
				object obj44 = 0;
				obj18 = obj19;
				obj20 = obj21;
				obj22 = obj23;
				obj24 = obj25;
				num2 = num3;
				throw new OutOfMemoryException();
				IL_142a:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1216 @ X0_v75] (should have been resolved before IL gen)");
				if (obj45 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X0_v77 (System.Object)+18]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X0_v77 (System.Object)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v55+18]");
						bool flag8 = 0 != (nint)obj47;
						obj32 = obj45;
						if (!flag8)
						{
							if (_displayers == null)
							{
								throw new NullReferenceException();
							}
							obj15 = obj21;
							bool flag9 = ((Dictionary<object, object>)(object)_displayers).TryGetValue(obj45, out value);
							bool flag10 = !flag9;
							obj8 = (object)(&value);
							obj32 = obj45;
							if (!flag10)
							{
								object obj48 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1259 @ X0_v83+E4]");
								bool flag11 = (nint)0 == 0;
								object obj49 = !flag11;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag12 = (UnityEngine.Object)value != null;
								bool flag13 = !flag12;
								obj8 = 0;
								obj32 = null;
								if (!flag13)
								{
									if (value != null)
									{
										Transform transform = ((Component)value).transform;
										num2 = num3 + 1;
										if ((object)transform != null)
										{
											transform.SetSiblingIndex(num3);
											bool flag14 = obj33 == null;
											object obj50 = !flag14;
											obj8 = 0;
											num3 = num2;
											obj34 = obj33;
											if (obj50 != null)
											{
												continue;
											}
											obj35 = obj11;
											obj36 = obj15;
											obj37 = 0;
											obj38 = obj10;
											obj32 = num2;
											break;
										}
										throw new NullReferenceException();
									}
									throw new NullReferenceException();
								}
							}
						}
						bool flag15 = obj33 == null;
						obj34 = obj33;
						if (!flag15)
						{
							continue;
						}
						obj35 = obj11;
						obj36 = obj15;
						obj37 = obj8;
						obj38 = obj10;
						num2 = num3;
						break;
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
				IL_0584:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj8 = 0;
				goto IL_13b1;
				IL_13b1:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v62+8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1096 @ X0_v62] (should have been resolved before IL gen)");
				object obj51 = obj52 & 1;
				if (obj51 != null)
				{
					if (obj33 != null)
					{
						object obj53 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v52+12E]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v52+12E]");
						if ((nint)0 == 0)
						{
							goto IL_068d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v52+B0]");
						object obj54 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X10_v32-8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X10_v32-8]");
							if (0 == (nint)obj23)
							{
								break;
							}
							obj10 = obj54 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v52+12E]");
							obj3 = -1;
							bool flag16 = (nint)obj3 != 1;
							obj54 = obj10;
							if (flag16)
							{
								continue;
							}
							goto IL_068d;
						}
						obj3 = obj54;
						object obj55 = obj53 + obj54;
						object obj56 = obj55 + 312;
						obj10 = obj54;
						goto IL_142a;
					}
					throw new NullReferenceException();
				}
				if (obj33 != null)
				{
					object obj57 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					object obj58 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v48+12E]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v48+12E]");
					if ((nint)0 == 0)
					{
						goto IL_09ad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v48+B0]");
					object obj59 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X10_v26-8]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X10_v26-8]");
						if (0 == (nint)obj57)
						{
							break;
						}
						obj10 = obj59 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v48+12E]");
						obj3 = -1;
						bool flag17 = (nint)obj3 != 1;
						obj59 = obj10;
						if (flag17)
						{
							continue;
						}
						goto IL_09ad;
					}
					obj3 = obj59;
					object obj60 = obj58 + obj59;
					object obj61 = obj60 + 312;
					obj10 = obj59;
					goto IL_14e6;
				}
				goto IL_107a;
				IL_068d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj8 = 0;
				goto IL_142a;
				IL_14e6:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X0_v68+8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1246 @ X0_v68] (should have been resolved before IL gen)");
				goto IL_107a;
			}
		}
		throw new NullReferenceException();
		IL_008f:
		values = Enum.GetValues(typeFromHandle);
		if (values != null)
		{
			goto IL_00b9;
		}
		goto IL_0f61;
		IL_0f61:
		ex = new NullReferenceException();
		obj43 = 0;
		value = null;
		clanLogoPreviewer = this;
		goto IL_0f82;
		IL_00b9:
		IEnumerator enumerator = values.GetEnumerator();
		bool flag18 = enumerator == null;
		obj43 = 0;
		value = null;
		obj32 = null;
		if (!flag18)
		{
			obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			obj23 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 720;
			obj21 = (nint)0 + (nint)3344;
			obj19 = typeof(MemberAchievementClanFeedData) + 2976;
			obj43 = 0;
			value = null;
			num3 = 0;
			IEnumerator enumerator2 = enumerator;
			nint num4 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01c9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj62 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v52-8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v52-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				obj10 = obj62 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj3 = -1;
				bool flag19 = (nint)obj3 != 1;
				obj62 = obj10;
				if (flag19)
				{
					continue;
				}
				goto IL_01c9;
			}
			obj3 = obj62;
			object obj63 = num4 + obj62;
			object obj64 = obj63 + 312;
			obj10 = obj62;
			goto IL_1232;
		}
		throw new NullReferenceException();
		IL_0f82:
		object obj65 = num + obj10;
		object obj66 = obj65 + 312;
		goto IL_1613;
		IL_155f:
		object obj68 = default(object);
		ClanLogoPreviewer clanLogoPreviewer3;
		while (true)
		{
			bool flag20 = (object)clanLogoPreviewer == null;
			object obj67 = !flag20;
			if (obj67 == null)
			{
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			if ((nint)obj32 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				clanLogoPreviewer2 = (ClanLogoPreviewer)obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj32 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				obj26 = ex;
				bool flag21 = ex == null;
				object obj69 = !flag21;
				obj14 = obj13;
				obj31 = obj11;
				obj16 = obj15;
				obj17 = obj8;
				obj30 = obj10;
				obj19 = obj18;
				obj21 = obj20;
				obj23 = obj22;
				obj25 = obj24;
				num3 = num2;
				obj27 = obj26;
				obj29 = obj28;
				clanLogoPreviewer3 = (ClanLogoPreviewer)obj68;
				if (obj69 != null)
				{
					break;
				}
				clanLogoPreviewer3 = (ClanLogoPreviewer)obj68;
				clanLogoPreviewer = (ClanLogoPreviewer)obj68;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_0d4c;
		IL_046e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		goto IL_1316;
		IL_0df8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj13 = obj14;
		obj11 = obj31;
		obj15 = obj16;
		obj8 = 0;
		obj10 = obj30;
		obj18 = obj19;
		obj20 = obj21;
		obj22 = obj23;
		obj24 = obj25;
		num2 = num3;
		obj26 = obj27;
		obj28 = obj29;
		object obj70 = default(object);
		obj66 = obj70;
		clanLogoPreviewer = clanLogoPreviewer2;
		goto IL_1613;
		IL_1613:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v6+8]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X8_v6] (should have been resolved before IL gen)");
		goto IL_155f;
		IL_12ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X0_v48+8]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v881 @ X0_v48] (should have been resolved before IL gen)");
		object obj71 = default(object);
		if (obj71 != null)
		{
			object obj72 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1288;
			obj32 = obj72;
			object obj73 = obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X1_v1 (System.Object)+40]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v32+40]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X1_v1 (System.Object)+40]");
			if (num5 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				IReadOnlyList<IconLayer> layers = _layers;
				if (_layers != null)
				{
					object obj74 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3336;
					nint num6 = (nint)layers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v36 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<IconLayer>>)+12E]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v36 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<IconLayer>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_046e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v36 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<IconLayer>>)+B0]");
					object obj75 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X10_v42-8]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X10_v42-8]");
						if (0 == (nint)obj74)
						{
							break;
						}
						obj10 = obj75 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v36 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<IconLayer>>)+12E]");
						obj3 = -1;
						bool flag22 = (nint)obj3 != 1;
						obj75 = obj10;
						if (flag22)
						{
							continue;
						}
						goto IL_046e;
					}
					obj3 = obj75;
					object obj76 = num6 + obj75;
					object obj77 = obj76 + 312;
					obj10 = obj75;
					goto IL_1316;
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}
		throw new NullReferenceException();
		IL_01c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		goto IL_1232;
		IL_1232:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v42+8]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v773 @ X0_v42] (should have been resolved before IL gen)");
		object obj79 = default(object);
		object obj78 = obj79 & 1;
		IEnumerator enumerator3 = default(IEnumerator);
		if (obj78 != null)
		{
			if (enumerator3 != null)
			{
				nint num7 = (nint)enumerator3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj80 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X10_v47-8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X10_v47-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj10 = obj80 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					obj3 = -1;
					bool flag23 = (nint)obj3 != 1;
					obj80 = obj10;
					if (flag23)
					{
						continue;
					}
					goto IL_02d2;
				}
				obj3 = obj80 + 1;
				object obj81 = num7 + obj3;
				object obj82 = obj81 + 312;
				obj10 = obj80;
				goto IL_12ab;
			}
			throw new NullReferenceException();
		}
		object obj83 = (object)(&enumerator3);
		object obj85 = default(object);
		object obj84 = (object)(&obj85);
		obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		obj32 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		obj84 = ex;
		bool flag24 = ex == null;
		obj14 = obj13;
		obj31 = obj11;
		obj16 = obj15;
		obj17 = obj8;
		obj30 = obj10;
		obj27 = (object)(&obj85);
		obj29 = (object)(&enumerator3);
		clanLogoPreviewer3 = null;
		clanLogoPreviewer2 = null;
		obj18 = obj19;
		obj20 = obj21;
		obj22 = obj23;
		obj24 = obj25;
		num2 = num3;
		obj26 = (object)(&obj85);
		obj28 = (object)(&enumerator3);
		clanLogoPreviewer3 = null;
		clanLogoPreviewer = null;
		if (!flag24)
		{
			goto IL_0d4c;
		}
		goto IL_155f;
	}

	private void PopulateMinimum()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 320;
		object obj2 = (nint)0 + (nint)1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetClanLogoElements(action);
	}

	private void BuildMinimum(List<ClanLogoElementViewModel> elements, Color color)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0109: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0404: Expected O, but got I
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0438: Expected O, but got I
		//IL_0457: Expected O, but got I4
		//IL_048f: Expected O, but got I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I
		//IL_030e: Expected O, but got I4
		//IL_0090: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1680;
		object obj2 = (nint)0 + (nint)688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = obj2;
		List<object> list = default(List<object>);
		list..ctor();
		LogoLayerConfig[] array = layerConfigs;
		if (layerConfigs != null && array.Length >= 1)
		{
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = layerConfigs + 32;
			object obj6 = 0;
			object obj7 = 0;
			object obj17 = default(object);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X20_v5+v216 @ X28_v4*8]");
				UnityEngine.Object obj8 = (UnityEngine.Object)0;
				object obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v7+E4]");
				Color color3;
				object obj11;
				Color color2;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X20_v5+v216 @ X28_v4*8]");
					bool flag = (UnityEngine.Object)0 == null;
					bool flag2 = !flag;
					object obj10 = !flag2;
					color2 = (Color)0;
					obj3 = null;
					if (obj10 != null)
					{
						goto IL_00ca;
					}
					color3 = (Color)0;
					obj11 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X20_v5+v216 @ X28_v4*8]");
					bool flag3 = (UnityEngine.Object)0 == null;
					bool flag4 = !flag3;
					object obj12 = !flag4;
					color2 = (Color)0;
					obj3 = null;
					color3 = (Color)0;
					obj11 = null;
					if (obj12 != null)
					{
						goto IL_00ca;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X24_v4 (UnityEngine.Object)+34]");
				bool flag5 = (nint)0 != 1;
				color2 = color3;
				obj3 = obj11;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X24_v4 (UnityEngine.Object)+18]");
					int num = FirstItemId(elements, ClanLogoLayer.Rim);
					object obj13 = typeof(System.IOAsyncCallback) + 2344;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					_ = 4294967295L;
					_ = 63;
					_ = 0;
					object obj14 = typeof(UsageHint) + 744;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v19+B8]");
					object obj16 = 0;
					obj6 = obj16;
					obj17..ctor();
					object obj18 = obj17 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X20_v5+v216 @ X28_v4*8]");
					obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = defaultTier;
					object obj19 = num + 1;
					bool flag6 = (nint)obj19 < 0;
					bool flag7 = obj19 == null;
					bool flag8 = !flag6;
					object obj20 = !flag7;
					object obj21 = flag8 & obj20;
					object obj22 = ~obj21;
					if (obj22 == null)
					{
						int num2 = num;
					}
					else
					{
						int num2 = 1;
					}
					object obj23 = (nint)0 + (nint)696;
					object obj24 = obj23;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					bool flag9 = list._size < items.Length;
					object obj25 = !flag9;
					if (obj25 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v24+20]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v26+C0]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v27+70]");
						color2 = (Color)0;
						list.AddWithResize(obj17);
						obj3 = obj17;
					}
					else
					{
						int size = list._size + 1;
						list._size = size;
						object obj28 = items + list._size;
						object obj29 = obj28 + 32;
						obj29 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						color2 = color3;
						obj3 = obj17;
					}
				}
				goto IL_00ca;
				IL_00ca:
				obj7++;
			}
			while ((nint)obj7 < array.Length);
		}
		Initialize((IReadOnlyList<IconLayer>)list, defaultTier);
	}

	private static int FirstItemId(List<ClanLogoElementViewModel> elements, ClanLogoLayer layer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00cf: Expected I4, but got O
		//IL_00c1: Expected I4, but got I8
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0077: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			if (elements != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 672;
				object obj4 = (nint)0 + (nint)336;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				object obj5 = Enumerable.FirstOrDefault(elements, func);
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v10 (System.Object)+10]");
					return 0;
				}
			}
			return -1;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private unsafe static Color FirstPresetColor(ClanConfigsResponse configs)
	{
		//IL_00e8: Expected O, but got Ref
		ClanConfigsResponse clanConfigsResponse = default(ClanConfigsResponse);
		Color result;
		if (clanConfigsResponse != null)
		{
			bool flag = clanConfigsResponse.EmblemColorPresets == null;
			result = (Color)clanConfigsResponse.EmblemColorPresets;
			if (!flag)
			{
				List<object>.Enumerator enumerator = ((List<object>)(object)clanConfigsResponse.EmblemColorPresets).GetEnumerator();
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				Color color;
				while (enumerator2.MoveNext() && !ColorUtility.TryParseHtmlString(null, out color))
				{
				}
				enumerator2.Dispose();
				result = (Color)(&enumerator2);
			}
		}
		else
		{
			result = (Color)clanConfigsResponse;
		}
		return result;
	}

	private Material GetShineMaterial(Material source)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0130: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E891D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 88;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v9+E4]");
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
			obj4 = this + 88;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v9+E4]");
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
		bool flag3 = obj7 == null;
		bool flag4 = !flag3;
		obj4 = obj8;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		if (flag4)
		{
			goto IL_00e8;
		}
		goto IL_019a;
		IL_00e8:
		return (Material)obj4;
		IL_019a:
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material = default(Material);
		material..ctor(source);
		obj8 = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj8 != null)
		{
			object obj13 = "_InputUv1BufferOffset" + 2144;
			((Material)obj8).SetFloat((string)obj13, 1f);
			return (Material)obj8;
		}
		return (Material)(object)new NullReferenceException();
		IL_00a0:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		obj10 = 0;
		obj11 = null;
		obj8 = obj4;
		if (obj14 == null)
		{
			goto IL_00e8;
		}
		goto IL_019a;
	}

	private void OnLayerChanged(IconLayer layer)
	{
		ApplyLayer(layer);
	}

	private unsafe void ApplyLayer(IconLayer layer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Ref, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_015c: Expected I4, but got I8
		//IL_0176: Expected O, but got I4
		//IL_03cf: Expected O, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01bf: Expected I, but got O
		//IL_01eb: Expected O, but got I
		//IL_01fb: Expected O, but got I
		//IL_0239: Invalid comparison between F8 and I4
		//IL_0248: Invalid comparison between F8 and I4
		//IL_0265: Expected O, but got F8
		//IL_0277: Expected O, but got F8
		//IL_02ac: Expected O, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_03f9: Expected O, but got I
		//IL_040b: Invalid comparison between F4 and I4
		//IL_02e8: Expected O, but got I4
		//IL_0342: Expected O, but got I
		//IL_0365: Expected O, but got I4
		//IL_0386: Expected O, but got I4
		//IL_039c: Expected O, but got I
		//IL_03b3: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)3344;
		if (!((Dictionary<object, object>)(object)_displayers).TryGetValue((object)layer, out *(object*)(obj2 + 16)))
		{
			return;
		}
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			bool flag = (UnityEngine.Object)0 == null;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj8 != null)
			{
				return;
			}
		}
		int num = (int)(layer.ImageId & 0x80000000L);
		bool flag5 = num == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)344;
			Action<bool> action = default(Action<bool>);
			action..ctor(obj2, (IntPtr)obj11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			UIExtensions.LoadClanLogoImage((Image)0, layer.ImageId, layer.Tier, action);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X8_v14+2A8] (should have been resolved before IL gen)");
			double num2 = (double)layer.Rotation - 1.0;
			bool flag6 = num2 < 0.0;
			bool flag7 = num2 == 0.0;
			object obj14 = (double)layer.Rotation ^ 1.0;
			object obj15 = (double)layer.Rotation ^ num2;
			object obj16 = obj14 & obj15;
			bool flag8 = (nint)obj16 < 0;
			bool flag9 = flag6 == flag8;
			object obj17 = !flag7;
			object obj18 = flag9 & obj17;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			Transform transform = ((Component)0).transform;
			if (layer.Rotation < 0f)
			{
			}
			Vector3 euler = default(Vector3);
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			transform.rotation = (Quaternion)0;
			LogoLayerConfig layerConfig = layer.layerConfig;
			float num3 = FloatExtensions.Map(layer.Scale, 0f, 1f, layerConfig.MinSize, layerConfig.MaxSize);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			Transform transform2 = ((Component)0).transform;
			bool flag10 = !layer.Inverted;
			object obj20 = !flag10;
			if (obj20 == null)
			{
			}
			transform2.localScale = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			Transform transform3 = ((Component)0).transform;
			transform3.localPosition = (Vector3)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			((Behaviour)0).enabled = false;
		}
	}

	public ClanLogoPreviewer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0215: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_0287: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_02ad: Expected O, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_025f: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_0157: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 760;
		object obj2 = (nint)0 + (nint)3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = this + 64;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v3+38]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+10]");
			bool flag = (object)((object)((nint)0 + (nint)309) & 1) == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+10]");
			object obj7 = 0;
			if (!flag)
			{
				goto IL_00c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v3+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+10]");
			object obj9 = (object)((object)((nint)0 + (nint)309) & 1) != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+10]");
			object obj7 = 0;
			if (obj9 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
		if ((object)((nint)0 != 0) != null)
		{
			goto IL_00e9;
		}
		goto IL_026d;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0174;
		IL_00e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v3+38]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v17+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v17+10]");
		object obj12 = (object)((object)((nint)0 + (nint)309) & 1) != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v17+10]");
		object obj13 = 0;
		if (obj12 == null)
		{
			goto IL_0165;
		}
		goto IL_0174;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v15+B8]");
		object obj14 = 0;
		object obj15 = this + 72;
		obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		return;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00e9;
		}
		goto IL_026d;
		IL_026d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v3+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v5+10]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v5+10]");
		if ((object)((object)((nint)0 + (nint)309) & 1) == null)
		{
			goto IL_0165;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v5+10]");
		obj13 = 0;
		goto IL_0174;
	}

	private void <PopulateMinimum>b__19_0(KammelnaResponseModel<List<ClanLogoElementViewModel>> elementsResponse)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0220: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8920]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		Color color = (Color)0;
		if (obj5 == null)
		{
			goto IL_0133;
		}
		return;
		IL_0133:
		object obj6 = (nint)0 + (nint)2608;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)_layers))
		{
			bool flag4 = elementsResponse == null;
			KammelnaResponseModel<List<ClanLogoElementViewModel>> elements = elementsResponse;
			if (!flag4)
			{
				elements = (KammelnaResponseModel<List<ClanLogoElementViewModel>>)(object)elementsResponse.<Model>k__BackingField;
			}
			object obj7 = typeof(RegisteredWaitHandle) + 56;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			Color color2 = FirstPresetColor(current.<Clans>k__BackingField);
			BuildMinimum((List<ClanLogoElementViewModel>)(object)elements, color);
		}
		return;
		IL_0074:
		bool flag6 = this == null;
		bool flag7 = !flag6;
		color = (Color)0;
		if (!flag7)
		{
			return;
		}
		goto IL_0133;
	}
}
