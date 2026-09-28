using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.TextCore;

public static class TutorialGameAssetFetcher
{
	private sealed class <>c__DisplayClass2_0
	{
		public TutorialType tutorialType;

		internal bool <GeTutorialGame>b__0(TutorialGame game)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if ((object)game != null)
			{
				object obj = game._tutorialType - tutorialType;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <GeTutorialGame>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public TutorialType tutorialType;

		private <>c__DisplayClass2_0 <>8__1;

		private IEnumerator <initializeTutorials>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GeTutorialGame>d__2(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_03b5: Expected I4, but got I8
			//IL_018a: Expected I4, but got I8
			//IL_0040: Expected O, but got I4
			//IL_0431: Expected I4, but got O
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_01cf: Expected I, but got O
			//IL_01df: Expected O, but got I
			//IL_0066: Expected I4, but got I8
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_021a: Expected O, but got I
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected O, but got Unknown
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected O, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected O, but got Unknown
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected O, but got Unknown
			//IL_0407: Expected O, but got I4
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0111: Expected O, but got I4
			//IL_02f5: Expected O, but got I
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected O, but got Unknown
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Expected O, but got Unknown
			//IL_0331: Expected O, but got I
			//IL_0344: Expected I, but got O
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Expected O, but got Unknown
			//IL_0355: Expected O, but got I
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Expected O, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			bool result;
			int num;
			object obj18 = default(object);
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					result = false;
					if (obj != null)
					{
						goto IL_0450;
					}
					<>1__state = -1;
					object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 248;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj3 = default(object);
					obj3..ctor();
					object obj4 = this + 40;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj4 != null)
					{
						_ = tutorialType;
						object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2288;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v32+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj8 = typeof(TrackedDeviceRaycaster.<>c) + 264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj9 = default(object);
						obj9..ctor();
						_ = 0;
						object obj10 = this + 48;
						obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj11 = this + 24;
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						result = true;
						num = 1;
						goto IL_0490;
					}
				}
				else
				{
					<>1__state = -1;
					IEnumerator enumerator = <initializeTutorials>5__2;
					if (<initializeTutorials>5__2 != null)
					{
						object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
						nint num2 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v12 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v12 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_025b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v12 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
						object obj14 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v9-8]");
							if (0 == (nint)obj12)
							{
								break;
							}
							obj14 += 16;
							obj13--;
							if ((nint)obj13 != 1)
							{
								continue;
							}
							goto IL_025b;
						}
						object obj15 = obj14 + 1;
						object obj16 = num2 + obj15;
						object obj17 = obj16 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X0_v25] (should have been resolved before IL gen)");
						bool flag3 = obj18 == null;
						object obj19 = !flag3;
						if (obj19 != null)
						{
							goto IL_028c;
						}
					}
				}
				goto IL_0415;
			}
			result = false;
			num = -1;
			goto IL_0490;
			IL_0450:
			return result;
			IL_0490:
			<>1__state = num;
			goto IL_0450;
			IL_028c:
			object obj20 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1264;
			object obj21 = obj20;
			object obj22 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v16+40]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X1_v7+40]");
			if (num3 != 0)
			{
				goto IL_0423;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			object obj23 = (nint)0 + (nint)408;
			AsyncOperationHandle<object> asyncOperationHandle = default(AsyncOperationHandle<object>);
			object result2 = asyncOperationHandle.Result;
			object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 4016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)864;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>8__1, (IntPtr)obj25);
			object obj26 = (nint)0 + (nint)248;
			object obj27 = Enumerable.First((IEnumerable<object>)result2, func);
			object obj28 = this + 24;
			obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			result = true;
			num = 2;
			goto IL_0490;
			IL_0423:
			InvalidCastException ex = new InvalidCastException();
			return (byte)(int)ex != 0;
			IL_025b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v22] (should have been resolved before IL gen)");
			if (obj18 != null)
			{
				goto IL_028c;
			}
			goto IL_0415;
			IL_0415:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0423;
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
			object obj2 = (nint)0 + (nint)872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <InitializeTutorials>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <InitializeTutorials>d__3(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0204: Expected I4, but got I8
			//IL_0121: Expected I4, but got I8
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_015f: Expected O, but got I4
			//IL_023f: Expected O, but got I
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected O, but got Unknown
			//IL_027d: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_019f: Expected O, but got I
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected O, but got Unknown
			//IL_005d: Expected I4, but got I8
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_009b: Expected O, but got I4
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj == null)
					{
						<>1__state = -1;
						object obj2 = typeof(SqlSingle[]) + 3048;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v18+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AsyncOperationHandle<IResourceLocator> asyncOperationHandle = Addressables.InitializeAsync(autoReleaseHandle: true);
						object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1296;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj6 = this + 24;
						object obj7 = default(object);
						obj6 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						return true;
					}
					return false;
				}
				<>1__state = -1;
				object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2288;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v4+B8]");
				object obj11 = 0;
				object obj12 = typeof(SqlSingle[]) + 3048;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v5+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = (nint)0 + (nint)3256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F36B18");
				object obj16 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1264;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj17 = this + 24;
				object obj18 = default(object);
				obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 2;
				return true;
			}
			<>1__state = -1;
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
			object obj2 = (nint)0 + (nint)880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const string Label = "Tutorial";

	private static readonly List<string> Keys;

	public static IEnumerator GeTutorialGame(TutorialType tutorialType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private static IEnumerator InitializeTutorials()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		return (IEnumerator)obj2;
	}

	static TutorialGameAssetFetcher()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = "ThisIsFakeReceiptData" + 2680;
		object obj3 = (nint)0 + (nint)3072;
		object obj4 = obj3;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2288;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9+C0]");
			object obj10 = 0;
			list.AddWithResize(obj2);
		}
		object obj11 = obj5;
		object obj12 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
