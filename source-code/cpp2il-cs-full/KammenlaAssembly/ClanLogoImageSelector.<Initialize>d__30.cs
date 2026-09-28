using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ClanLogoImageSelector : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanLogoImageSelectorItem, bool> <>9__29_0;

		public static Func<(ClanLogoImageSelectorItem, Task<bool>), ClanLogoImageSelectorItem> <>9__30_1;

		public static Func<(ClanLogoImageSelectorItem, Task<bool>), Task<bool>> <>9__32_0;

		public static Func<(ClanLogoImageSelectorItem, Task<bool>), bool> <>9__32_1;

		public static Func<(ClanLogoImageSelectorItem, Task<bool>), ClanLogoImageSelectorItem> <>9__32_2;

		public static Func<ClanLogoImageSelectorItem, int> <>9__32_3;

		public static Func<ClanLogoImageSelectorItem, bool> <>9__33_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_HasSelectableItems>b__29_0(ClanLogoImageSelectorItem i)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e4: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0174: Expected I4, but got O
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E890C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = i != null;
			if (!flag2)
			{
				goto IL_00af;
			}
			goto IL_0128;
			IL_00af:
			return flag2;
			IL_0128:
			if ((object)i != null)
			{
				int num = ~i.<Id>k__BackingField;
				return (byte)(num >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_007d:
			flag2 = i != null;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				goto IL_00af;
			}
			goto IL_0128;
		}

		internal ClanLogoImageSelectorItem <Initialize>b__30_1((ClanLogoImageSelectorItem, Task<bool>) p)
		{
			return (ClanLogoImageSelectorItem)p;
		}

		internal Task<bool> <PruneItemsThatFailToLoad>b__32_0((ClanLogoImageSelectorItem, Task<bool>) p)
		{
			//IL_0005: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (Task<bool>)(nint)intPtr;
		}

		internal bool <PruneItemsThatFailToLoad>b__32_1((ClanLogoImageSelectorItem, Task<bool>) p)
		{
			//IL_0034: Expected I4, but got O
			//IL_000f: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			if (intPtr != (IntPtr)0)
			{
				bool result = ((Task<bool>)(nint)intPtr).Result;
				return (byte)((result ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal ClanLogoImageSelectorItem <PruneItemsThatFailToLoad>b__32_2((ClanLogoImageSelectorItem, Task<bool>) p)
		{
			return (ClanLogoImageSelectorItem)p;
		}

		internal int <PruneItemsThatFailToLoad>b__32_3(ClanLogoImageSelectorItem i)
		{
			//IL_0035: Expected I4, but got O
			if ((object)i != null)
			{
				return i.<Id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <PickDefault>b__33_0(ClanLogoImageSelectorItem i)
		{
			//IL_0067: Expected I4, but got O
			if ((object)i != null)
			{
				GameObject gameObject = i.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public int id;

		internal bool <RestoreSelectionToId>b__0(ClanLogoImageSelectorItem i)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if ((object)i != null)
			{
				object obj = i.<Id>k__BackingField - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass53_0
	{
		public ClanLogoLayer layer;

		public TaskCompletionSource<List<ClanLogoElementViewModel>> tcs;

		public Func<ClanLogoElementViewModel, bool> <>9__1;

		internal void <GetLogoElements>b__0(KammelnaResponseModel<List<ClanLogoElementViewModel>> e)
		{
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected O, but got Unknown
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_0011: Expected O, but got I
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected O, but got Unknown
			//IL_0257: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0086: Expected O, but got I4
			//IL_0131: Expected O, but got I
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00be: Expected O, but got I
			//IL_00cc: Expected I, but got O
			if (e != null)
			{
				object obj = (nint)0 + (nint)624;
				if (((KammelnaResponseModel<object>)(object)e).Succeeded && e.<Model>k__BackingField != null)
				{
					object obj2 = this + 32;
					Func<object, bool> predicate = (Func<object, bool>)obj2;
					bool flag = obj2 == null;
					object obj3 = !flag;
					if (obj3 == null)
					{
						object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 672;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj5 = (nint)0 + (nint)288;
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor((object)this, (IntPtr)obj5);
						<>9__1 = func;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						predicate = func;
					}
					IEnumerable<object> source = Enumerable.Where(e.<Model>k__BackingField, predicate);
					List<object> result = Enumerable.ToList(source);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X23_v6-8]");
					bool flag2 = ((TaskCompletionSource<object>)0).TrySetResult(result);
					return;
				}
			}
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1288;
			object format = "WhiteSmoke" + 3344;
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg;
			if (e != null)
			{
				string errorMessage = ((KammelnaResponseModel<object>)(object)e).ErrorMessage;
				arg = errorMessage;
			}
			else
			{
				arg = null;
			}
			object obj8 = typeof(List<AdaptivePerformanceScaler>) + 544;
			object arg2 = default(object);
			string text = string.Format((string)format, arg2, arg);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj11 = text;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = text;
			}
			KLogger.LogWarning(obj11);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			bool flag4 = ((TaskCompletionSource<object>)(object)tcs).TrySetResult((object)list);
		}

		internal bool <GetLogoElements>b__1(ClanLogoElementViewModel logoEl)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (logoEl != null)
			{
				object obj = (int)logoEl.Type - (int)layer;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <Initialize>d__30 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public ClanLogoImageSelector <>4__this;

		public LogoLayerConfig layerConfig;

		public int tier;

		public Task<List<Color>> colorsTask;

		private List<(ClanLogoImageSelectorItem, Task<bool>)> <pending>5__2;

		private TaskAwaiter<List<ClanLogoElementViewModel>> <>u__1;

		private ColorSelector <>7__wrap2;

		private TaskAwaiter<List<Color>> <>u__2;

		private unsafe void MoveNext()
		{
			//IL_1451: Unknown result type (might be due to invalid IL or missing references)
			//IL_1456: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			//IL_0094: Expected I4, but got I8
			//IL_0728: Expected O, but got I
			//IL_127c: Expected O, but got I
			//IL_0032: Expected O, but got I4
			//IL_0041: Expected I4, but got I8
			//IL_0ac2: Expected O, but got I
			//IL_0aed: Expected O, but got I4
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_1557: Expected O, but got Ref
			//IL_0793: Expected O, but got I
			//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a7: Expected O, but got Unknown
			//IL_07b3: Expected O, but got I
			//IL_07bf: Expected O, but got I
			//IL_07cb: Expected O, but got I
			//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0d: Expected O, but got Unknown
			//IL_0b2d: Expected O, but got I4
			//IL_0b56: Expected O, but got I4
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_0158: Expected O, but got I
			//IL_0066: Expected O, but got I4
			//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a50: Expected O, but got Unknown
			//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a62: Expected O, but got Unknown
			//IL_0a8a: Expected O, but got I4
			//IL_0b70: Expected O, but got I
			//IL_0888: Expected O, but got I4
			//IL_12a1: Expected O, but got I4
			//IL_1169: Expected I4, but got I8
			//IL_1174: Expected O, but got Ref
			//IL_117f: Expected O, but got Ref
			//IL_1188: Expected O, but got I4
			//IL_11bc: Expected O, but got I4
			//IL_0ab1: Expected O, but got I4
			//IL_019d: Expected O, but got I
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01e5: Expected O, but got I4
			//IL_022d: Expected O, but got I4
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected O, but got Unknown
			//IL_0372: Expected O, but got Ref
			//IL_1356: Expected O, but got I4
			//IL_0956: Expected O, but got I
			//IL_096b: Expected O, but got I
			//IL_03cc: Expected O, but got I4
			//IL_1377: Expected O, but got I4
			//IL_09c1: Expected O, but got I4
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_02d3: Expected O, but got I
			//IL_02e6: Expected I, but got O
			//IL_07e8: Expected O, but got I
			//IL_07f8: Expected O, but got I
			//IL_0808: Expected O, but got I
			//IL_09e5: Expected O, but got I
			//IL_0a07: Expected O, but got I
			//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a15: Expected O, but got Unknown
			//IL_0436: Expected O, but got I4
			//IL_1398: Expected O, but got I4
			//IL_0d63: Expected O, but got Ref
			//IL_0d9f: Expected O, but got I4
			//IL_045f: Expected O, but got I
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Expected O, but got Unknown
			//IL_0328: Expected O, but got I4
			//IL_0dc8: Expected O, but got Ref
			//IL_04dc: Expected O, but got I
			//IL_0523: Expected O, but got I
			//IL_0541: Expected O, but got I
			//IL_0556: Expected O, but got I
			//IL_05ac: Expected O, but got I4
			//IL_0634: Expected O, but got I
			//IL_0644: Expected O, but got I
			//IL_0654: Expected O, but got I
			//IL_05d0: Expected O, but got I
			//IL_05f2: Expected O, but got I
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			ClanLogoImageSelector clanLogoImageSelector = <>4__this;
			object obj12;
			object obj15 = default(object);
			NullReferenceException ex;
			object obj10 = default(object);
			object obj6;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>u__2 = (TaskAwaiter<List<Color>>)0;
					<>1__state = -1;
					TaskAwaiter<object> taskAwaiter = (TaskAwaiter<object>)<>u__2;
					object result = taskAwaiter.GetResult();
					object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80));
					if (obj2 != null)
					{
						((ColorSelector)obj2).Init((IReadOnlyList<Color>)result);
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						<>1__state = -2;
						AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
						object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 64));
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj4 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v18+E4]");
						bool flag = (nint)0 == 0;
						object obj5 = !flag;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetResult();
						return;
					}
					ex = new NullReferenceException();
					obj6 = result;
				}
				else if ((object)<>4__this != null)
				{
					obj6 = layerConfig;
					object obj7 = <>4__this + 200;
					obj7 = layerConfig;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					clanLogoImageSelector._tier = tier;
					ColorSelector colorSelector = clanLogoImageSelector.colorSelector;
					if ((object)clanLogoImageSelector.colorSelector != null)
					{
						object obj8 = typeof(TypeConverter<ushort, char>) + 520;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj9 = (nint)0 + (nint)1272;
						obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4028B68");
						if (colorSelector.OnItemSelected != null)
						{
							object obj11 = (nint)0 + (nint)1344;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @402E7BC");
							obj12 = typeof(MemberAchievementClanFeedData) + 2976;
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v119+E4]");
							bool flag2 = (nint)0 == 0;
							object obj14 = !flag2;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag3 = clanLogoImageSelector.confirmButton != null;
							bool flag4 = !flag3;
							obj15 = 0;
							obj10 = null;
							UnityAction unityAction = null;
							if (flag4)
							{
								goto IL_033a;
							}
							if ((object)clanLogoImageSelector.confirmButton != null)
							{
								clanLogoImageSelector.confirmButton.interactable = false;
								Button confirmButton = clanLogoImageSelector.confirmButton;
								if ((object)clanLogoImageSelector.confirmButton != null)
								{
									object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj17 = (nint)0 + (nint)1288;
									UnityAction unityAction2 = default(UnityAction);
									unityAction2..ctor(<>4__this, (IntPtr)obj17);
									if (confirmButton.m_OnClick != null)
									{
										confirmButton.m_OnClick.AddListener(unityAction2);
										obj15 = 0;
										obj10 = null;
										unityAction = unityAction2;
										goto IL_033a;
									}
									ex = new NullReferenceException();
									obj15 = 0;
									obj10 = obj17;
									obj6 = <>4__this;
								}
								else
								{
									ex = new NullReferenceException();
									obj15 = 0;
									obj10 = null;
									obj6 = null;
								}
							}
							else
							{
								ex = new NullReferenceException();
								obj15 = 0;
								obj10 = null;
								obj6 = null;
							}
						}
						else
						{
							ex = new NullReferenceException();
							obj15 = 0;
							obj6 = <>4__this;
						}
					}
					else
					{
						ex = new NullReferenceException();
					}
				}
				else
				{
					ex = new NullReferenceException();
					IntPtr intPtr = default(IntPtr);
					obj6 = (nint)intPtr;
				}
				goto IL_141d;
			}
			<>u__1 = (TaskAwaiter<List<ClanLogoElementViewModel>>)0;
			<>1__state = -1;
			TaskAwaiter<object> taskAwaiter2 = (TaskAwaiter<object>)<>u__1;
			goto IL_071c;
			IL_071c:
			object obj18 = (nint)0 + (nint)3248;
			obj6 = obj18;
			object result2 = taskAwaiter2.GetResult();
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			ClanLogoImageSelectorItem clanLogoImageSelectorItem = default(ClanLogoImageSelectorItem);
			Task<bool> task;
			object obj32 = default(object);
			object obj39;
			object obj40;
			List<object>.Enumerator enumerator5;
			object obj42;
			object obj36;
			object obj41;
			List<object>.Enumerator enumerator2;
			if (result2 != null)
			{
				List<object>.Enumerator enumerator = ((List<object>)result2).GetEnumerator();
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				object obj38 = default(object);
				if ((object)<>4__this != null)
				{
					object obj19 = (nint)0 + (nint)3992;
					object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj21 = (nint)0 + (nint)504;
					object obj22 = (nint)0 + (nint)3744;
					object obj23 = (nint)0 + (nint)3400;
					enumerator2 = enumerator3;
					ClanLogoElementViewModel model = default(ClanLogoElementViewModel);
					while (true)
					{
						obj6 = obj19;
						if (!enumerator4.MoveNext())
						{
							break;
						}
						object obj24 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v96+E4]");
						bool flag5 = (nint)0 == 0;
						object obj25 = !flag5;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						obj10 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
						if ((object)clanLogoImageSelectorItem != null)
						{
							List<(object, object)> list = (List<(object, object)>)(object)<pending>5__2;
							task = clanLogoImageSelectorItem.Init(model, tier, <>4__this);
							obj15 = obj22;
							(object, object) tuple = (clanLogoImageSelectorItem, task);
							if (<pending>5__2 != null)
							{
								object obj26 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
								object obj27 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
								bool flag6 = (nint)0 == 0;
								enumerator2 = (List<object>.Enumerator)tuple;
								if (!flag6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X9_v15+18]");
									bool flag7 = num < 0;
									object obj29 = !flag7;
									if (obj29 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v72+20]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v74+C0]");
										object obj31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v75+70]");
										obj15 = 0;
										((List<(object, object)>)(object)<pending>5__2).AddWithResize(tuple);
										enumerator2 = (List<object>.Enumerator)tuple;
										obj10 = obj32;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
										object obj33 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
										nint num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v19 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
										object obj34 = num2 + 0;
										object obj35 = obj34 + 32;
										obj35 = tuple;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										enumerator2 = (List<object>.Enumerator)tuple;
										obj10 = task;
									}
									continue;
								}
							}
							goto IL_11e8;
						}
						goto IL_1206;
					}
					obj36 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
					object obj37 = obj38 & 0x80000000L;
					bool flag8 = obj37 == null;
					obj39 = obj15;
					obj40 = obj10;
					obj41 = 10;
					if (!flag8)
					{
						obj = obj36;
						enumerator5 = enumerator2;
						obj42 = 10;
						goto IL_0b64;
					}
				}
				else
				{
					object obj43 = (nint)0 + (nint)3992;
					obj6 = obj43;
					bool flag9 = enumerator4.MoveNext();
					bool flag10 = !flag9;
					object obj44 = !flag10;
					if (obj44 != null)
					{
						ex = new NullReferenceException();
						enumerator2 = enumerator3;
						goto IL_141d;
					}
					object obj45 = obj38 & 0x80000000L;
					bool flag11 = obj45 == null;
					enumerator5 = enumerator3;
					obj42 = 10;
					obj36 = obj;
					enumerator2 = enumerator3;
					obj39 = obj15;
					obj40 = obj10;
					obj41 = 10;
					if (!flag11)
					{
						goto IL_0b64;
					}
				}
				goto IL_122f;
			}
			ex = new NullReferenceException();
			goto IL_141d;
			IL_141d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_1206:
			ex = new NullReferenceException();
			obj6 = clanLogoImageSelector.layout;
			goto IL_141d;
			IL_0b64:
			object obj46 = (nint)0 + (nint)3984;
			obj6 = obj46;
			enumerator4.Dispose();
			obj36 = obj;
			enumerator2 = enumerator5;
			obj39 = obj15;
			obj40 = obj10;
			obj41 = obj42;
			goto IL_122f;
			IL_06a7:
			LogoLayerConfig logoLayerConfig;
			Task<List<ClanLogoElementViewModel>> logoElements = GetLogoElements(logoLayerConfig.Layer);
			if (logoElements != null)
			{
				TaskAwaiter<object> awaiter = ((Task<object>)(object)logoElements).GetAwaiter();
				TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
				bool isCompleted = awaiter2.IsCompleted;
				bool flag12 = !isCompleted;
				taskAwaiter2 = awaiter2;
				if (!flag12)
				{
					goto IL_071c;
				}
				<>1__state = 0;
				object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
				obj47 = awaiter2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj48 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v139+E4]");
				bool flag13 = (nint)0 == 0;
				object obj49 = !flag13;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
				return;
			}
			ex = new NullReferenceException();
			goto IL_141d;
			IL_122f:
			OutOfMemoryException ex2 = new OutOfMemoryException();
			obj15 = obj39;
			obj10 = obj40;
			ex = (NullReferenceException)(object)ex2;
			goto IL_141d;
			IL_033a:
			object obj50 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<(object, object)> list2 = default(List<(object, object)>);
			list2..ctor();
			object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 64));
			obj51 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			logoLayerConfig = layerConfig;
			if ((object)layerConfig != null)
			{
				bool flag14 = !logoLayerConfig.InitBaseLayer;
				object obj52 = !flag14;
				obj6 = list2;
				if (obj52 == null)
				{
					bool flag15 = !clanLogoImageSelector.InstantiateEmptyItem;
					obj6 = list2;
					if (!flag15)
					{
						object obj53 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v143+E4]");
						bool flag16 = (nint)0 == 0;
						object obj54 = !flag16;
						if (obj54 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj55 = (nint)0 + (nint)504;
						obj10 = obj55;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
						object obj56 = <>4__this + 216;
						object obj57 = default(object);
						obj56 = obj57;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (obj56 != null)
						{
							List<(object, object)> list3 = (List<(object, object)>)obj51;
							Task<bool> task2 = ((ClanLogoImageSelectorItem)obj56).InitAsEmpty(<>4__this);
							object obj58 = (nint)0 + (nint)3744;
							obj15 = obj58;
							(object, object) tuple2 = (obj56, task2);
							if (obj51 != null)
							{
								object obj59 = (nint)0 + (nint)3400;
								object obj60 = obj59;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
								object obj61 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
								object obj62 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
								bool flag17 = (nint)0 == 0;
								enumerator2 = (List<object>.Enumerator)tuple2;
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X9_v22+18]");
									bool flag18 = num3 < 0;
									object obj63 = !flag18;
									if (obj63 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
										object obj64 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X21_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
										object obj65 = num4 + 0;
										object obj66 = obj65 + 32;
										obj66 = tuple2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										obj10 = task2;
										obj6 = null;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X8_v110+20]");
										object obj67 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v113+C0]");
										object obj68 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X8_v114+70]");
										obj15 = 0;
										((List<(object, object)>)obj51).AddWithResize(tuple2);
										obj10 = obj32;
										obj6 = tuple2;
									}
									logoLayerConfig = layerConfig;
									bool flag19 = (object)layerConfig == null;
									enumerator2 = (List<object>.Enumerator)tuple2;
									if (!flag19)
									{
										goto IL_06a7;
									}
									ex = new NullReferenceException();
									enumerator2 = (List<object>.Enumerator)tuple2;
									goto IL_141d;
								}
							}
							ex = new NullReferenceException();
							obj10 = task2;
							obj6 = obj56;
						}
						else
						{
							ex = new NullReferenceException();
							obj6 = obj57;
						}
						goto IL_141d;
					}
				}
				goto IL_06a7;
			}
			ex = new NullReferenceException();
			obj6 = list2;
			goto IL_141d;
			IL_11e8:
			ex = new NullReferenceException();
			obj10 = task;
			obj6 = clanLogoImageSelectorItem;
			goto IL_141d;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006b: Expected O, but got I4
			//IL_0033: Expected O, but got Ref
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <PruneItemsThatFailToLoad>d__32 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public List<(ClanLogoImageSelectorItem, Task<bool>)> pending;

		public ClanLogoImageSelector <>4__this;

		private TaskAwaiter<bool[]> <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8d: Expected O, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_00a1: Expected I4, but got I8
			//IL_027b: Expected O, but got I
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Expected O, but got Unknown
			//IL_02c6: Expected O, but got I4
			//IL_030d: Expected O, but got I4
			//IL_00d2: Expected O, but got I
			//IL_00e2: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_0998: Expected I4, but got I8
			//IL_09a3: Expected O, but got Ref
			//IL_0175: Expected O, but got I
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_01ce: Expected O, but got I4
			//IL_0042: Expected O, but got I
			//IL_0052: Expected O, but got I
			//IL_0074: Expected O, but got I4
			//IL_01f7: Expected O, but got I
			//IL_0134: Expected O, but got I4
			//IL_040b: Expected O, but got I
			//IL_041b: Expected O, but got I
			//IL_043d: Expected O, but got I4
			//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aca: Expected O, but got Unknown
			//IL_0ae0: Expected O, but got I
			//IL_0af1: Expected I, but got O
			//IL_0b0f: Expected O, but got I
			//IL_0b2a: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_0358: Expected O, but got I
			//IL_0368: Expected O, but got I
			//IL_038a: Expected O, but got I4
			//IL_0164: Expected O, but got I
			//IL_0565: Expected O, but got I
			//IL_0575: Expected O, but got I
			//IL_0597: Expected O, but got I4
			//IL_046d: Expected O, but got I4
			//IL_0608: Expected O, but got I
			//IL_062d: Expected O, but got I
			//IL_04fe: Expected O, but got I
			//IL_050e: Expected O, but got I
			//IL_0530: Expected O, but got I4
			//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4b: Expected O, but got Unknown
			//IL_0b61: Expected O, but got I
			//IL_0b72: Expected I, but got O
			//IL_0b90: Expected O, but got I
			//IL_0bab: Expected O, but got I4
			//IL_03b3: Expected O, but got Ref
			//IL_03d1: Expected O, but got Ref
			//IL_05c7: Expected O, but got I4
			//IL_049d: Expected O, but got I
			//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcc: Expected O, but got Unknown
			//IL_0be2: Expected O, but got I
			//IL_0bf3: Expected I, but got O
			//IL_0c11: Expected O, but got I
			//IL_0c2c: Expected O, but got I4
			//IL_05f7: Expected O, but got I
			//IL_06db: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e0: Expected O, but got Unknown
			//IL_0714: Expected O, but got I4
			//IL_0c49: Expected O, but got I
			//IL_0c59: Expected O, but got I
			//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c68: Expected O, but got Unknown
			//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c77: Expected O, but got Unknown
			//IL_0c99: Expected O, but got I4
			//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Expected O, but got Unknown
			//IL_080c: Expected O, but got I4
			//IL_075b: Expected O, but got I4
			//IL_0842: Expected O, but got I
			//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbb: Expected O, but got Unknown
			//IL_0cd1: Expected O, but got I
			//IL_0ce2: Expected I, but got O
			//IL_0d00: Expected O, but got I
			//IL_09fc: Expected O, but got I4
			//IL_078b: Expected O, but got I
			//IL_0877: Expected O, but got I
			//IL_0883: Expected O, but got I
			//IL_08a0: Expected O, but got I
			//IL_08b4: Expected O, but got I
			//IL_0a20: Expected O, but got I4
			//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ed: Expected O, but got Unknown
			//IL_08ff: Expected I, but got O
			//IL_0a37: Expected O, but got I4
			//IL_0a4f: Expected O, but got I
			//IL_0958: Expected O, but got I
			object obj = typeof(CardUtils.<>c) + 1120;
			UnityEngine.Object obj2 = <>4__this;
			object obj4;
			Func<(object, object), object> selector;
			if (<>1__state != 0)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v101+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v101+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v97+18]");
					selector = (Func<(object, object), object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v97+18]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						goto IL_0112;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v101+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v97+18]");
					selector = (Func<(object, object), object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v97+18]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						goto IL_0112;
					}
				}
				goto IL_0169;
			}
			<>u__1 = (TaskAwaiter<bool[]>)0;
			<>1__state = -1;
			TaskAwaiter<object> taskAwaiter = (TaskAwaiter<object>)<>u__1;
			goto IL_026f;
			IL_05fc:
			object obj7 = (nint)0 + (nint)2856;
			object obj8 = obj7;
			IEnumerable<(object, object)> source2;
			Func<(object, object), object> selector2;
			IEnumerable<object> source = Enumerable.Select(source2, selector2);
			object obj9 = (nint)0 + (nint)1984;
			object obj10 = obj9;
			List<object> list = Enumerable.ToList(source);
			object obj30;
			NullReferenceException ex;
			if (list != null)
			{
				if (list._size == 0)
				{
					goto IL_0989;
				}
				if ((object)<>4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v2 (UnityEngine.Object)+C8]");
					if ((nint)0 != 0)
					{
						object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1288;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj12 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v32+E4]");
						bool flag3 = (nint)0 == 0;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v32+B8]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v48+30]");
						Func<object, int> selector3 = (Func<object, int>)0;
						object separator = "&action=sign-up" + 3424;
						object format = "WhiteSmoke" + 3368;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v48+30]");
						bool flag4 = (nint)0 == 0;
						object obj15 = !flag4;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v32+E4]");
							bool flag5 = (nint)0 == 0;
							object obj16 = !flag5;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj17 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v54+B8]");
								obj14 = 0;
							}
							object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 688;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj19 = (nint)0 + (nint)256;
							Func<object, int> func = default(Func<object, int>);
							func..ctor(obj14, (IntPtr)obj19);
							object obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v53+B8]");
							object obj21 = (nint)0 + (nint)48;
							obj21 = func;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							selector3 = func;
						}
						IEnumerable<int> values = Enumerable.Select(list, selector3);
						string text = string.Join((string)separator, values);
						object arg = default(object);
						string obj22 = string.Format((string)format, arg, text);
						object obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
						object obj24 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v40+E4]");
						bool flag6 = (nint)0 == 0;
						object obj25 = !flag6;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						KLogger.LogWarning(obj22);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v2 (UnityEngine.Object)+C0]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v2 (UnityEngine.Object)+C0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v39+20]");
							obj10 = 0;
							object obj27 = (nint)0 + (nint)3376;
							obj8 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v39+20]");
							bool flag7 = list.Contains(0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v2 (UnityEngine.Object)+C0]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v2 (UnityEngine.Object)+C0]");
							if ((nint)0 != 0)
							{
								object obj29 = typeof(List<Tween>) + 3160;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								nint num = (nint)list;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v45 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+210]");
								Predicate<object> predicate = default(Predicate<object>);
								predicate..ctor((object)list, (IntPtr)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v42+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v42+18]");
									int num2 = ((List<object>)0).RemoveAll(predicate);
									if (flag7)
									{
										<>4__this.PickDefault();
									}
									goto IL_0989;
								}
								ex = new NullReferenceException();
								obj30 = 0;
								obj10 = list;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v45 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+210]");
								obj8 = 0;
							}
							else
							{
								ex = new NullReferenceException();
								obj30 = 0;
							}
						}
						else
						{
							ex = new NullReferenceException();
							obj30 = 0;
							obj10 = null;
							obj8 = text;
						}
					}
					else
					{
						ex = new NullReferenceException();
					}
				}
				else
				{
					ex = new NullReferenceException();
				}
			}
			else
			{
				ex = new NullReferenceException();
			}
			goto IL_0a54;
			IL_0a54:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_044b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v73+E4]");
			bool flag8 = (nint)0 == 0;
			object obj31 = !flag8;
			object obj33;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v74+B8]");
				obj33 = 0;
			}
			object obj34 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = (nint)0 + (nint)240;
			Func<(object, object), bool> func2 = default(Func<(object, object), bool>);
			func2..ctor(obj33, (IntPtr)obj35);
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v73+B8]");
			object obj37 = (nint)0 + (nint)32;
			obj37 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj30 = 0;
			Func<(object, object), bool> predicate2 = func2;
			goto IL_04a2;
			IL_0989:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetResult();
			return;
			IL_0112:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v101+E4]");
			bool flag9 = (nint)0 == 0;
			object obj38 = !flag9;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj39 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v103+B8]");
				obj4 = 0;
			}
			object obj40 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj41 = (nint)0 + (nint)232;
			Func<(object, object), object> func3 = default(Func<(object, object), object>);
			func3..ctor(obj4, (IntPtr)obj41);
			object obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v102+B8]");
			object obj43 = (nint)0 + (nint)24;
			obj43 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj30 = 0;
			selector = func3;
			goto IL_0169;
			IL_05a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v63+E4]");
			bool flag10 = (nint)0 == 0;
			object obj44 = !flag10;
			object obj46;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj45 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v63+B8]");
				obj46 = 0;
			}
			object obj47 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj48 = (nint)0 + (nint)248;
			Func<(object, object), object> func4 = default(Func<(object, object), object>);
			func4..ctor(obj46, (IntPtr)obj48);
			object obj49 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v62+B8]");
			object obj50 = (nint)0 + (nint)40;
			obj50 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj30 = 0;
			selector2 = func4;
			goto IL_05fc;
			IL_026f:
			object obj51 = (nint)0 + (nint)3456;
			object result = taskAwaiter.GetResult();
			object obj52 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v11+E4]");
			bool flag11 = (nint)0 == 0;
			object obj54 = !flag11;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag12 = <>4__this == null;
			bool flag13 = !flag12;
			object obj55 = !flag13;
			if (obj55 == null)
			{
				object obj56 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v73+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v73+B8]");
					obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v68+20]");
					predicate2 = (Func<(object, object), bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v68+20]");
					bool flag14 = (nint)0 == 0;
					object obj57 = !flag14;
					if (obj57 == null)
					{
						goto IL_044b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj56 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v73+B8]");
					obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v68+20]");
					predicate2 = (Func<(object, object), bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v68+20]");
					bool flag15 = (nint)0 == 0;
					object obj58 = !flag15;
					if (obj58 == null)
					{
						goto IL_044b;
					}
				}
				goto IL_04a2;
			}
			goto IL_0989;
			IL_0169:
			object obj59 = (nint)0 + (nint)2848;
			obj8 = obj59;
			IEnumerable<object> tasks = Enumerable.Select((IEnumerable<(object, object)>)pending, selector);
			object obj60 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
			object obj61 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v88+E4]");
			bool flag16 = (nint)0 == 0;
			object obj62 = !flag16;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj63 = (nint)0 + (nint)720;
			obj10 = obj63;
			Task<bool[]> task = Task.WhenAll((IEnumerable<Task<bool>>)tasks);
			if (task != null)
			{
				TaskAwaiter<object> awaiter = ((Task<object>)(object)task).GetAwaiter();
				TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
				bool isCompleted = awaiter2.IsCompleted;
				bool flag17 = !isCompleted;
				taskAwaiter = awaiter2;
				if (!flag17)
				{
					goto IL_026f;
				}
				<>1__state = 0;
				object obj64 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
				obj64 = awaiter2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
				return;
			}
			ex = new NullReferenceException();
			goto IL_0a54;
			IL_04a2:
			object obj65 = (nint)0 + (nint)3200;
			source2 = Enumerable.Where((IEnumerable<(object, object)>)pending, predicate2);
			object obj66 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v63+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v63+B8]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v57+28]");
				selector2 = (Func<(object, object), object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v57+28]");
				bool flag18 = (nint)0 == 0;
				object obj67 = !flag18;
				if (obj67 == null)
				{
					goto IL_05a5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj66 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v63+B8]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v57+28]");
				selector2 = (Func<(object, object), object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v57+28]");
				bool flag19 = (nint)0 == 0;
				object obj68 = !flag19;
				if (obj68 == null)
				{
					goto IL_05a5;
				}
			}
			goto IL_05fc;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private ClanLogoImageSelectorItem itemPrefab;

	private Transform layout;

	private ColorSelector colorSelector;

	private Image previewImage;

	private Image placeholderImage;

	private GameObject selectedIndicator;

	private ScrollSnapToNearest scrollSnap;

	private bool InstantiateEmptyItem;

	private GameObject sortingObject;

	private TextMeshProUGUI indexLabel;

	private Button confirmButton;

	public UnityEvent<ClanLogoLayer, int> OnItemSelected;

	public UnityEvent<ClanLogoLayer, int> OnItemConfirmed;

	public UnityEvent<int> OnOrderChangeRequested;

	public UnityEvent<Vector2, Camera> OnDropRequested;

	public UnityEvent<Vector2, Camera> OnDragMoved;

	public UnityEvent OnDragBegan;

	public UnityEvent OnPressed;

	public PopupUI selectorPopup;

	private ClanLogoBuilder _builder;

	private ItemPicker<ClanLogoImageSelectorItem> itemPicker;

	private LogoLayerConfig _layerConfig;

	private int _tier;

	private ClanLogoImageSelectorItem emptyItem;

	private ClanLogoImageSelectorItem _lastConfirmedItem;

	private bool _isSelected;

	public UnityEvent<Color, Action> ColorSelected
	{
		get
		{
			ColorSelector colorSelector = this.colorSelector;
			if ((object)this.colorSelector != null)
			{
				return colorSelector.OnItemSelected;
			}
			return (UnityEvent<Color, Action>)(object)new NullReferenceException();
		}
	}

	public bool HasSelectableItems
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_00e5: Expected O, but got I
			//IL_00f5: Expected O, but got I
			//IL_0117: Expected O, but got I4
			//IL_0078: Expected O, but got I
			//IL_0088: Expected O, but got I
			//IL_00aa: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_01eb: Expected O, but got I
			//IL_01fc: Expected I, but got O
			//IL_021a: Expected O, but got I
			//IL_0177: Expected O, but got I
			ItemPicker<ClanLogoImageSelectorItem> itemPicker = this.itemPicker;
			object obj;
			object obj3;
			Func<object, bool> predicate;
			if (this.itemPicker != null && itemPicker.<Items>k__BackingField != null)
			{
				obj = typeof(CardUtils.<>c) + 1120;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+8]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						goto IL_0125;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+8]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						goto IL_0125;
					}
				}
				goto IL_017c;
			}
			return false;
			IL_017c:
			return Enumerable.Any(itemPicker.<Items>k__BackingField, predicate);
			IL_0125:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v15+B8]");
				obj3 = 0;
			}
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)264;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj3, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v14+B8]");
			object obj11 = (nint)0 + (nint)8;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
			goto IL_017c;
		}
	}

	public unsafe Task Initialize(LogoLayerConfig layerConfig, int tier, Task<List<Color>> colorsTask)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0106: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_005c: Expected O, but got Ref
		//IL_0074: Expected O, but got Ref
		//IL_0091: Expected O, but got Ref
		//IL_00a9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		<Initialize>d__30 stateMachine = default(<Initialize>d__30);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
	}

	public void RefreshColorPalette(IReadOnlyList<Color> colors)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88FE]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = colorSelector;
			obj6 = colorSelector;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = colorSelector;
			obj6 = colorSelector;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b9;
		IL_00b9:
		colorSelector.RefreshPalette(colors);
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b9;
		}
	}

	private unsafe void PruneItemsThatFailToLoad(List<(ClanLogoImageSelectorItem, Task<bool>)> pending)
	{
		//IL_0056: Expected O, but got I
		//IL_006e: Expected O, but got Ref
		//IL_0014: Expected O, but got Ref
		//IL_002c: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<PruneItemsThatFailToLoad>d__32 stateMachine = default(<PruneItemsThatFailToLoad>d__32);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public void PickDefault()
	{
		//IL_0011: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_021b: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_028c: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_01b4: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0339: Expected O, but got I
		//IL_034a: Expected I, but got O
		//IL_0368: Expected O, but got I
		//IL_027b: Expected O, but got I
		ItemPicker<ClanLogoImageSelectorItem> itemPicker = this.itemPicker;
		object obj = (nint)0 + (nint)2528;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)itemPicker.<Items>k__BackingField))
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "WhiteSmoke" + 3360;
			object arg = default(object);
			string text = string.Format((string)format, arg);
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			object obj6 = text;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = text;
			}
			KLogger.LogWarning(obj6);
			return;
		}
		ItemPicker<ClanLogoImageSelectorItem> itemPicker2 = this.itemPicker;
		ClanLogoImageSelectorItem item;
		if (itemPicker2.<AllowDeselect>k__BackingField)
		{
			item = emptyItem;
			goto IL_02f6;
		}
		object obj7 = typeof(CardUtils.<>c) + 1120;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+E4]");
		object obj9;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v13+38]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v13+38]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				goto IL_0229;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v13+38]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v13+38]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				goto IL_0229;
			}
		}
		goto IL_0280;
		IL_0229:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+B8]");
			obj9 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)224;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj9, (IntPtr)obj15);
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v18+B8]");
		object obj17 = (nint)0 + (nint)56;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		goto IL_0280;
		IL_0280:
		object obj18 = (nint)0 + (nint)128;
		object obj19 = Enumerable.First(itemPicker2.<Items>k__BackingField, predicate);
		item = (ClanLogoImageSelectorItem)obj19;
		goto IL_02f6;
		IL_02f6:
		PickItem(item);
		ItemPicker<ClanLogoImageSelectorItem> itemPicker3 = this.itemPicker;
		object obj20 = this + 224;
		obj20 = itemPicker3._selectedItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateConfirmButton();
	}

	public void PickItemByRect(RectTransform rectTransform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8900]");
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
		bool flag2 = rectTransform == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 == null)
		{
			goto IL_0139;
		}
		return;
		IL_0139:
		object obj7 = (nint)0 + (nint)3688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+E4]");
		UnityEngine.Object obj9 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			if (!(obj9 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = obj9 != null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				return;
			}
		}
		PickItem((ClanLogoImageSelectorItem)obj9);
		return;
		IL_0074:
		bool flag6 = rectTransform == null;
		bool flag7 = !flag6;
		obj6 = 0;
		if (!flag7)
		{
			return;
		}
		goto IL_0139;
	}

	public void PickItem(ClanLogoImageSelectorItem item)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_017b: Expected I4, but got I8
		//IL_0195: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_0300: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_059a: Expected O, but got I4
		//IL_05da: Expected O, but got I4
		//IL_0448: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04bc: Expected O, but got I
		//IL_04f9: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_0542: Expected I4, but got I8
		if (this.itemPicker == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CE]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v51+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0079;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v51+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0079;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (obj5 == null)
		{
			goto IL_0164;
		}
		goto IL_0202;
		IL_051b:
		UnityEvent<System.Int32Enum, int> onItemSelected;
		bool flag4 = onItemSelected == null;
		object obj10 = !flag4;
		int arg = -1;
		UnityEvent<System.Int32Enum, int> unityEvent = onItemSelected;
		LogoLayerConfig layerConfig;
		LogoLayerConfig logoLayerConfig = layerConfig;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_067b;
		IL_05f0:
		ItemPicker<ClanLogoImageSelectorItem> itemPicker;
		ClanLogoImageSelectorItem clanLogoImageSelectorItem;
		if (!(itemPicker._selectedItem == clanLogoImageSelectorItem))
		{
			goto IL_04b0;
		}
		goto IL_061f;
		IL_0669:
		arg = clanLogoImageSelectorItem.<Id>k__BackingField;
		goto IL_067b;
		IL_0400:
		bool flag5;
		sortingObject.SetActive(flag5);
		UpdatePreview(clanLogoImageSelectorItem);
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		object obj13 = 0;
		ClanLogoImageSelectorItem clanLogoImageSelectorItem2 = clanLogoImageSelectorItem;
		if (obj12 == null)
		{
			goto IL_0467;
		}
		goto IL_05f0;
		IL_0079:
		bool flag7 = item == null;
		bool flag8 = !flag7;
		obj6 = 0;
		obj7 = null;
		if (flag8)
		{
			goto IL_0164;
		}
		obj8 = 0;
		obj9 = null;
		goto IL_0202;
		IL_0164:
		int num = (int)(item.<Id>k__BackingField & 0x80000000L);
		bool flag9 = num == 0;
		object obj14 = !flag9;
		obj8 = obj6;
		obj9 = obj7;
		if (obj14 != null)
		{
			goto IL_0202;
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v45+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		flag5 = true;
		bool flag11;
		if (obj16 == null)
		{
			flag11 = true;
			goto IL_0290;
		}
		goto IL_02a7;
		IL_04b0:
		object obj17 = (nint)0 + (nint)3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
		layerConfig = _layerConfig;
		onItemSelected = (UnityEvent<System.Int32Enum, int>)(object)OnItemSelected;
		bool flag12 = (object)clanLogoImageSelectorItem == null;
		object obj18 = !flag12;
		unityEvent = (UnityEvent<System.Int32Enum, int>)(object)OnItemSelected;
		logoLayerConfig = _layerConfig;
		if (obj18 == null)
		{
			goto IL_051b;
		}
		goto IL_0669;
		IL_061f:
		layerConfig = _layerConfig;
		bool flag13 = (object)clanLogoImageSelectorItem == null;
		onItemSelected = (UnityEvent<System.Int32Enum, int>)(object)OnItemSelected;
		unityEvent = (UnityEvent<System.Int32Enum, int>)(object)OnItemSelected;
		logoLayerConfig = _layerConfig;
		if (flag13)
		{
			goto IL_051b;
		}
		goto IL_0669;
		IL_067b:
		unityEvent.Invoke((System.Int32Enum)logoLayerConfig.Layer, arg);
		UpdateConfirmButton();
		return;
		IL_0202:
		ItemPicker<ClanLogoImageSelectorItem> itemPicker2 = this.itemPicker;
		if (itemPicker2.<AllowDeselect>k__BackingField)
		{
			obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v45+E4]");
			bool flag14 = (nint)0 == 0;
			object obj19 = !flag14;
			obj6 = obj8;
			obj7 = obj9;
			flag11 = false;
			flag5 = false;
			if (obj19 == null)
			{
				goto IL_0290;
			}
			goto IL_02a7;
		}
		return;
		IL_0467:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = itemPicker._selectedItem == clanLogoImageSelectorItem;
		bool flag16 = !flag15;
		object obj20 = !flag16;
		if (obj20 == null)
		{
			goto IL_04b0;
		}
		goto IL_061f;
		IL_0290:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		flag5 = flag11;
		goto IL_02a7;
		IL_02a7:
		bool flag17 = item == null;
		bool flag18 = !flag17;
		clanLogoImageSelectorItem = item;
		if (!flag18)
		{
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v40+E4]");
			bool flag19 = (nint)0 == 0;
			object obj22 = !flag19;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag20 = emptyItem != null;
			bool flag21 = !flag20;
			clanLogoImageSelectorItem = item;
			if (!flag21)
			{
				clanLogoImageSelectorItem = emptyItem;
			}
		}
		itemPicker = this.itemPicker;
		ColorSelector colorSelector = this.colorSelector;
		colorSelector.canvasGroup.interactable = flag5;
		bool flag22 = !flag5;
		object obj23 = !flag22;
		object obj24 = ~obj23;
		float alpha = ((obj24 != null) ? 0.5f : 1f);
		colorSelector.canvasGroup.alpha = alpha;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)sortingObject)
			{
				goto IL_0400;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag23 = sortingObject;
			bool flag24 = !flag23;
			object obj26 = !flag24;
			if (obj26 != null)
			{
				goto IL_0400;
			}
		}
		UpdatePreview(clanLogoImageSelectorItem);
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v31+E4]");
		bool flag25 = (nint)0 == 0;
		obj13 = 0;
		clanLogoImageSelectorItem2 = clanLogoImageSelectorItem;
		if (flag25)
		{
			goto IL_0467;
		}
		goto IL_05f0;
	}

	public void ConfirmSelection()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_01ab: Expected I4, but got I8
		ItemPicker<ClanLogoImageSelectorItem> itemPicker = this.itemPicker;
		if (this.itemPicker != null)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = this + 224;
			UnityEngine.Object selectedItem = itemPicker._selectedItem;
			CloseSelector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				bool flag = (UnityEngine.Object)obj2 == itemPicker._selectedItem;
				bool flag2 = !flag;
				object obj4 = 0;
				if (!flag2)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = (UnityEngine.Object)obj2 == itemPicker._selectedItem;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				object obj4 = 0;
				if (obj5 != null)
				{
					return;
				}
			}
			_lastConfirmedItem = itemPicker._selectedItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			UpdateConfirmButton();
			LogoLayerConfig layerConfig = _layerConfig;
			int arg;
			if ((object)itemPicker._selectedItem != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X20_v3 (UnityEngine.Object)+48]");
				arg = 0;
			}
			else
			{
				bool flag5 = OnItemConfirmed == null;
				object obj6 = !flag5;
				arg = -1;
				if (obj6 == null)
				{
					throw new NullReferenceException();
				}
			}
			((UnityEvent<System.Int32Enum, int>)(object)OnItemConfirmed).Invoke((System.Int32Enum)layerConfig.Layer, arg);
		}
		else
		{
			CloseSelector();
		}
	}

	public void CancelSelection()
	{
		PickItem(_lastConfirmedItem);
		CloseSelector();
	}

	public void SetSelectedIndicator(bool isSelected)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8902]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			_isSelected = isSelected;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectedIndicator;
			obj6 = selectedIndicator;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			_isSelected = isSelected;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = selectedIndicator;
			obj6 = selectedIndicator;
			if (obj7 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c2;
		IL_00c2:
		selectedIndicator.SetActive(isSelected);
		return;
		IL_009b:
		if (obj5 != null)
		{
			goto IL_00c2;
		}
	}

	public unsafe void SetIndexLabel(int index)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0182: Expected I4, but got I8
		//IL_019c: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_023a: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0264: Expected O, but got Ref
		//IL_0289: Expected O, but got Ref
		//IL_0309: Expected O, but got I4
		//IL_029f: Expected I, but got O
		//IL_02af: Expected O, but got I
		//IL_02d1: Expected O, but got I4
		//IL_02e1: Expected O, but got I
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8903]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v23+E4]");
			bool flag = (nint)0 == 0;
			obj5 = indexLabel;
			obj6 = indexLabel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = indexLabel;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = indexLabel;
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
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_03e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_03d4:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03e2;
		IL_0170:
		int num = (int)(index & 0x80000000L);
		bool flag5 = num == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			if ((object)indexLabel != null)
			{
				GameObject gameObject = indexLabel.gameObject;
				bool flag6 = (object)gameObject == null;
				obj10 = null;
				if (!flag6)
				{
					gameObject.SetActive(value: true);
					object obj12 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj13 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array = default(object[]);
					bool flag7 = array == null;
					obj9 = 0;
					int num2 = default(int);
					obj10 = (UnityEngine.Object)(&num2);
					if (!flag7)
					{
						object obj14 = default(object);
						bool flag8 = obj14 == null;
						UnityEngine.Object obj15 = (UnityEngine.Object)(&num2);
						if (!flag8)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
							obj15 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag9 = ex == null;
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
							obj10 = (UnityEngine.Object)0;
							if (flag9)
							{
								goto IL_03e2;
							}
						}
						bool flag10 = array.Length == 0;
						obj9 = 0;
						obj10 = obj15;
						if (!flag10)
						{
							object obj16 = array + 32;
							obj16 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object text = "HH:mm:ss.ffZ" + 3256;
							TextMeshProExtensions.Localize(indexLabel, (string)text, array);
							return;
						}
						goto IL_03d4;
					}
				}
			}
		}
		else if ((object)indexLabel != null)
		{
			GameObject gameObject2 = indexLabel.gameObject;
			bool flag11 = (object)gameObject2 == null;
			obj10 = null;
			if (!flag11)
			{
				gameObject2.SetActive(value: false);
				return;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03d4;
		IL_0091:
		bool flag12 = obj5 == null;
		bool flag13 = !flag12;
		obj9 = 0;
		obj10 = null;
		if (!flag13)
		{
			return;
		}
		goto IL_0170;
	}

	public void ResetColorPicker()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89C9]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = colorSelector;
			obj6 = colorSelector;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = colorSelector;
			obj6 = colorSelector;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b9;
		IL_00b9:
		colorSelector.ResetToDefault();
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b9;
		}
	}

	public void RemoveItem()
	{
		PickItem(null);
		ConfirmSelection();
	}

	public void RestoreSelectionToId(int id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0074: Expected I, but got O
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		ItemPicker<ClanLogoImageSelectorItem> itemPicker = this.itemPicker;
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 680;
		object obj4 = (nint)0 + (nint)272;
		object obj5 = (nint)0 + (nint)704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object item = Enumerable.FirstOrDefault(itemPicker.<Items>k__BackingField, func);
		PickItem((ClanLogoImageSelectorItem)item);
		ItemPicker<ClanLogoImageSelectorItem> itemPicker2 = this.itemPicker;
		object obj6 = this + 224;
		obj6 = itemPicker2._selectedItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateConfirmButton();
	}

	public void SetColorSelectorTo(Color color)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8905]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = colorSelector;
			obj6 = colorSelector;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = colorSelector;
			obj6 = colorSelector;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		Color selectedItemByColor = (Color)0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c2;
		IL_00c2:
		colorSelector.SetSelectedItemByColor(selectedItemByColor);
		return;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		selectedItemByColor = (Color)0;
		if (!flag6)
		{
			goto IL_00c2;
		}
	}

	public void ChangeOrder(int delta)
	{
		if (OnOrderChangeRequested != null)
		{
			int arg = default(int);
			OnOrderChangeRequested.Invoke(arg);
		}
	}

	public void RequestDropAt(Vector2 screenPosition, Camera pressEventCamera)
	{
		//IL_0011: Expected O, but got I
		if (OnDropRequested != null)
		{
			object arg = (nint)0 + (nint)1368;
			Vector2 arg2 = default(Vector2);
			((UnityEvent<Vector2, object>)(object)OnDropRequested).Invoke(arg2, arg);
		}
	}

	public void RequestDragMove(Vector2 screenPosition, Camera pressEventCamera)
	{
		//IL_0011: Expected O, but got I
		if (OnDragMoved != null)
		{
			object arg = (nint)0 + (nint)1368;
			Vector2 arg2 = default(Vector2);
			((UnityEvent<Vector2, object>)(object)OnDragMoved).Invoke(arg2, arg);
		}
	}

	public void NotifyDragBegan()
	{
		if (OnDragBegan != null)
		{
			OnDragBegan.Invoke();
		}
	}

	public void NotifyPressed()
	{
		if (OnPressed != null)
		{
			OnPressed.Invoke();
		}
	}

	public void MoveForwardInGroup()
	{
		if (OnOrderChangeRequested != null)
		{
			OnOrderChangeRequested.Invoke(1);
		}
	}

	public void MoveBackwardInGroup()
	{
		//IL_001a: Expected I4, but got I8
		if (OnOrderChangeRequested != null)
		{
			OnOrderChangeRequested.Invoke(-1);
		}
	}

	public void SetBuilder(ClanLogoBuilder builder)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 184;
		obj = builder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void OpenSelector()
	{
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0529: Expected O, but got I4
		//IL_0531: Expected O, but got I
		//IL_0025: Expected O, but got I
		//IL_0294: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_02e3: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_030c: Expected O, but got I
		//IL_0178: Expected O, but got I8
		//IL_0192: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_03e8: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_04e3: Expected O, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_0560: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag = !_isSelected;
		object obj2 = !flag;
		IntPtr intPtr = default(IntPtr);
		UnityEngine.Object obj3 = (UnityEngine.Object)(nint)intPtr;
		object obj8;
		UnityEngine.Object obj9;
		object obj10;
		if (obj2 == null)
		{
			UnityEngine.Object lastConfirmedItem = _lastConfirmedItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CE]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v54+E4]");
				if ((nint)0 != 0)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v54+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 != null)
				{
					goto IL_006f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _lastConfirmedItem == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			obj8 = 0;
			obj9 = null;
			obj10 = 0;
			obj3 = null;
			if (obj7 == null)
			{
				goto IL_015e;
			}
		}
		goto IL_01db;
		IL_015e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v13 (UnityEngine.Object)+48]");
		object obj11 = 0 & 0x80000000L;
		bool flag5 = obj11 == null;
		object obj12 = !flag5;
		obj10 = obj8;
		obj3 = obj9;
		if (obj12 == null)
		{
			if (OnPressed != null)
			{
				OnPressed.Invoke();
			}
			return;
		}
		goto IL_01db;
		IL_01db:
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9+E4]");
		object obj15;
		object obj14;
		if ((nint)0 != 0)
		{
			bool flag6 = _builder != null;
			bool flag7 = !flag6;
			obj14 = 0;
			obj15 = 0;
			UnityEngine.Object obj16 = null;
			if (!flag7)
			{
				goto IL_024c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = _builder != null;
			bool flag9 = !flag8;
			object obj17 = !flag9;
			obj14 = 0;
			obj15 = 0;
			UnityEngine.Object obj16 = null;
			if (obj17 != null)
			{
				goto IL_024c;
			}
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v41+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = (nint)0 + (nint)256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9300");
		obj14 = obj15;
		UnityEngine.Object obj22 = default(UnityEngine.Object);
		UnityEngine.Object obj21 = obj22;
		goto IL_032b;
		IL_032b:
		selectorPopup.SlideFromBottom();
		InstallCloseGuard();
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = selectorPopup != null;
			bool flag12 = !flag11;
			object obj24 = !flag12;
			object obj25 = 0;
			UnityEngine.Object obj26 = null;
			if (obj24 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = selectorPopup != null;
			bool flag14 = !flag13;
			object obj25 = 0;
			UnityEngine.Object obj26 = null;
			if (flag14)
			{
				return;
			}
		}
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			if (!(obj21 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = obj21 != null;
			bool flag16 = !flag15;
			object obj28 = !flag16;
			if (obj28 == null)
			{
				return;
			}
		}
		Transform transform = selectorPopup.transform;
		object obj29 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
		if (transform == obj29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X20_v8 (UnityEngine.Object)+68]");
			transform.parent = (Transform)0;
			((RectTransform)transform).sizeDelta = (Vector2)0;
			((RectTransform)transform).anchoredPosition = (Vector2)0;
			return;
		}
		throw new InvalidCastException();
		IL_024c:
		obj21 = _builder;
		goto IL_032b;
		IL_006f:
		bool flag17 = _lastConfirmedItem == null;
		bool flag18 = !flag17;
		obj8 = 0;
		obj9 = null;
		if (flag18)
		{
			goto IL_015e;
		}
		obj10 = 0;
		obj3 = null;
		goto IL_01db;
	}

	private static Task<List<ClanLogoElementViewModel>> GetLogoElements(ClanLogoLayer layer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ab: Expected I, but got O
		//IL_00eb: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Queue<string>) + 1776;
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 320;
			object obj5 = (nint)0 + (nint)280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TaskCompletionSource<object> taskCompletionSource = default(TaskCompletionSource<object>);
			taskCompletionSource..ctor();
			object obj6 = obj2 + 24;
			obj6 = taskCompletionSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			KammelnaRequests.GetClanLogoElements(action);
			object obj7 = obj6;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+10]");
				return (Task<List<ClanLogoElementViewModel>>)0;
			}
		}
		return (Task<List<ClanLogoElementViewModel>>)(object)new NullReferenceException();
	}

	private void ApplyColorToVisuals(Color color)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00f7: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_0247: Expected O, but got I
		//IL_0496: Expected O, but got I
		//IL_0296: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_0444: Expected O, but got I4
		//IL_0535: Expected O, but got I8
		//IL_054f: Expected O, but got I4
		//IL_0558: Expected O, but got I4
		//IL_0341: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_0388: Expected O, but got I4
		//IL_03a6: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CD]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object obj3;
		UnityEngine.Object obj5;
		if (obj2 != null)
		{
			obj3 = previewImage;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v25+E4]");
			bool flag = (nint)0 == 0;
			obj5 = previewImage;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = previewImage;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = previewImage;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj7 = 0;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_00d1;
		}
		goto IL_01a9;
		IL_0206:
		ItemPicker<ClanLogoImageSelectorItem> itemPicker;
		if (itemPicker.<Items>k__BackingField == null)
		{
			return;
		}
		List<object>.Enumerator enumerator = ((List<object>)(object)itemPicker.<Items>k__BackingField).GetEnumerator();
		object obj10 = (nint)0 + (nint)4040;
		object obj12 = default(object);
		object obj11 = obj12;
		object obj14 = default(object);
		object obj13 = obj14;
		object obj16 = default(object);
		object obj15 = obj16;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator2 = enumerator3;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		UnityEngine.Object obj19 = default(UnityEngine.Object);
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		while (true)
		{
			if (enumerator4.MoveNext())
			{
				object obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v23+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = obj19 != null;
				bool flag7 = !flag6;
				obj7 = 0;
				if (flag7)
				{
					continue;
				}
				bool flag8 = (object)obj19 == null;
				obj8 = 0;
				obj9 = null;
				if (flag8)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ stack_-88 (UnityEngine.Object)+48]");
				object obj20 = 0 & 0x80000000L;
				bool flag9 = obj20 == null;
				object obj21 = !flag9;
				obj7 = 0;
				if (obj21 != null)
				{
					continue;
				}
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v30+E4]");
				bool flag10 = (nint)0 == 0;
				object obj23 = !flag10;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ stack_-88 (UnityEngine.Object)+20]");
				bool flag11 = (UnityEngine.Object)0 != null;
				bool flag12 = !flag11;
				obj7 = 0;
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ stack_-88 (UnityEngine.Object)+20]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ stack_-88 (UnityEngine.Object)+20]");
					bool flag13 = (nint)0 == 0;
					obj8 = 0;
					obj9 = null;
					if (flag13)
					{
						break;
					}
					object obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v337 @ X8_v21+2A8] (should have been resolved before IL gen)");
					obj11 = obj12;
					obj13 = obj14;
					obj15 = obj16;
					enumerator2 = enumerator5;
					obj7 = 0;
				}
				continue;
			}
			enumerator4.Dispose();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		List<object>.Enumerator enumerator6 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		goto IL_04e3;
		IL_00d1:
		itemPicker = this.itemPicker;
		bool flag14 = this.itemPicker == null;
		object obj26 = !flag14;
		if (obj26 == null)
		{
			return;
		}
		goto IL_0206;
		IL_04e3:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag15 = (nint)obj9 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj27 = (nint)0 + (nint)4032;
			obj9 = (UnityEngine.Object)obj27;
			enumerator6.Dispose();
			object obj28 = default(object);
			if (obj28 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj28;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E264");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0088:
		bool flag16 = obj3 != null;
		bool flag17 = !flag16;
		object obj29 = !flag17;
		obj7 = 0;
		obj8 = 0;
		obj9 = null;
		if (obj29 == null)
		{
			goto IL_00d1;
		}
		goto IL_01a9;
		IL_01a9:
		if ((object)previewImage != null)
		{
			previewImage.color = (Color)0;
			itemPicker = this.itemPicker;
			bool flag18 = this.itemPicker == null;
			obj7 = obj8;
			if (!flag18)
			{
				goto IL_0206;
			}
			return;
		}
		goto IL_04e3;
	}

	private static bool IsEmpty(ClanLogoImageSelectorItem item)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_0174: Expected I4, but got O
		//IL_0123: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_00a8;
		}
		goto IL_0131;
		IL_00a8:
		return true;
		IL_0131:
		if ((object)item != null)
		{
			return (byte)(item.<Id>k__BackingField >> 31) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_007d:
		if (item == null)
		{
			goto IL_00a8;
		}
		goto IL_0131;
	}

	private void UpdateConfirmButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8908]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = confirmButton;
			obj6 = confirmButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = confirmButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = confirmButton;
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
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		ItemPicker<ClanLogoImageSelectorItem> itemPicker = this.itemPicker;
		bool interactable;
		if (this.itemPicker != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = itemPicker._selectedItem != _lastConfirmedItem;
			interactable = flag6;
		}
		else
		{
			bool flag7 = (object)confirmButton == null;
			object obj13 = !flag7;
			interactable = false;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
		}
		confirmButton.interactable = interactable;
		return;
		IL_0091:
		bool flag8 = obj5 == null;
		bool flag9 = !flag8;
		obj9 = 0;
		obj10 = null;
		if (!flag9)
		{
			return;
		}
		goto IL_0170;
	}

	private void UpdatePreview(ClanLogoImageSelectorItem item)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0253: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_02bf: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_051d: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CF]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CE]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89CE]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_0269;
		IL_0470:
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!(placeholderImage != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = placeholderImage != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				return;
			}
		}
		GameObject gameObject = placeholderImage.gameObject;
		bool flag6;
		gameObject.SetActive(flag6);
		return;
		IL_03b1:
		GameObject gameObject2 = previewImage.gameObject;
		bool flag8;
		bool flag7 = (byte)((flag8 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(flag7);
		bool flag9 = !flag8;
		object obj12 = !flag9;
		int num = 0;
		int num2 = (flag7 ? 1 : 0);
		obj5 = obj3;
		flag6 = flag8;
		if (obj12 == null)
		{
			num2 = item.<Id>k__BackingField;
			num = _tier;
			UIExtensions.LoadClanLogoImage(previewImage, item.<Id>k__BackingField, _tier);
			obj5 = obj3;
			flag6 = flag8;
		}
		goto IL_0470;
		IL_016a:
		UnityEngine.Object obj13;
		bool flag10 = obj13 != null;
		bool flag11 = !flag10;
		object obj14 = !flag11;
		if (obj14 != null)
		{
			goto IL_03b1;
		}
		num = 0;
		num2 = 0;
		obj5 = obj3;
		flag6 = flag8;
		goto IL_0470;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v24+E4]");
		bool flag12 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag12)
		{
			goto IL_00c0;
		}
		goto IL_0269;
		IL_0269:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = item == null;
		bool flag14 = !flag13;
		object obj15 = !flag14;
		object obj16 = 0;
		UnityEngine.Object obj17 = null;
		obj3 = obj5;
		object obj18 = 0;
		UnityEngine.Object obj19 = null;
		if (obj15 != null)
		{
			goto IL_010f;
		}
		goto IL_02d2;
		IL_00c0:
		bool flag15 = item == null;
		bool flag16 = !flag15;
		obj16 = 0;
		obj17 = null;
		obj18 = 0;
		obj19 = null;
		obj5 = obj3;
		if (!flag16)
		{
			goto IL_010f;
		}
		goto IL_02d2;
		IL_02d2:
		int num3 = item.<Id>k__BackingField >> 31;
		obj13 = previewImage;
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v18+E4]");
		bool flag17 = (nint)0 == 0;
		object obj21 = !flag17;
		obj3 = obj5;
		flag8 = (byte)num3 != 0;
		UnityEngine.Object obj22 = previewImage;
		obj16 = obj18;
		obj17 = obj19;
		flag6 = (byte)num3 != 0;
		if (obj21 != null)
		{
			goto IL_016a;
		}
		goto IL_0359;
		IL_010f:
		obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v18+E4]");
		bool flag18 = (nint)0 == 0;
		obj13 = previewImage;
		flag8 = true;
		obj22 = previewImage;
		obj5 = obj3;
		flag6 = true;
		if (!flag18)
		{
			goto IL_016a;
		}
		goto IL_0359;
		IL_0359:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = obj22 != null;
		bool flag20 = !flag19;
		obj3 = obj5;
		flag8 = flag6;
		num = 0;
		num2 = 0;
		if (!flag20)
		{
			goto IL_03b1;
		}
		goto IL_0470;
	}

	private void InstallCloseGuard()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_021a: Expected O, but got I
		//IL_0228: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8909]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectorPopup;
			obj6 = selectorPopup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = selectorPopup;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = selectorPopup;
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
		PopupUI popupUI = selectorPopup;
		GameObject gameObject = popupUI.content.gameObject;
		object obj10 = typeof(RegisteredWaitHandle) + 3136;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.RemovePopup(gameObject);
		object obj13 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1280;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj14);
		ScreenManager.PushPopup(gameObject, action);
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

	private void CloseSelector()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E890A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectorPopup;
			obj6 = selectorPopup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = selectorPopup;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = selectorPopup;
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
		PopupUI popupUI = selectorPopup;
		GameObject go = popupUI.content.gameObject;
		object obj10 = typeof(RegisteredWaitHandle) + 3136;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.RemovePopup(go);
		selectorPopup.SlideToBottom();
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

	private void <Initialize>b__30_0(Color color, Action _)
	{
		ApplyColorToVisuals(color);
	}
}
