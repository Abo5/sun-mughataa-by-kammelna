using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem.XR;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.TextCore;

public static class AssetInitializer
{
	private sealed class <>c__DisplayClass4_0<T> where T : UnityEngine.Object
	{
		public IKeyEvaluator reference;

		internal object <InitializeHelper>b__0(string _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007c: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3048;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F35B5C");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object result = default(object);
			return result;
		}
	}

	private sealed class <InitializeHelper>d__4<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
	{
		private int <>1__state;

		private object <>2__current;

		public IKeyEvaluator reference;

		public Action<T> callback;

		private string <runtimeKey>5__2;

		private AsyncOperationHandle<T> <operation>5__3;

		private T <initializedPrefab>5__4;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <InitializeHelper>d__4(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_04ba: Expected I4, but got I8
			//IL_099b: Expected I4, but got O
			//IL_02db: Expected I4, but got I8
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Expected O, but got Unknown
			//IL_0319: Expected O, but got I4
			//IL_0a4a: Expected O, but got I
			//IL_0040: Expected O, but got I4
			//IL_034a: Expected O, but got I
			//IL_0361: Expected O, but got I
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Expected O, but got Unknown
			//IL_005d: Expected I4, but got I8
			//IL_0073: Expected O, but got I
			//IL_0089: Expected O, but got I
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00b1: Expected O, but got I4
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Expected O, but got Unknown
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected O, but got Unknown
			//IL_0405: Expected O, but got I4
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_0a7f: Expected O, but got I
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_017d: Expected O, but got I
			//IL_0436: Expected O, but got I
			//IL_0451: Expected O, but got I
			//IL_0460: Unknown result type (might be due to invalid IL or missing references)
			//IL_0465: Expected O, but got Unknown
			//IL_022d: Expected O, but got I4
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Expected O, but got Unknown
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Expected O, but got Unknown
			//IL_056b: Expected O, but got I4
			//IL_01b8: Expected O, but got I
			//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a02: Expected O, but got Unknown
			//IL_0a2c: Expected O, but got I4
			//IL_0252: Expected O, but got I4
			//IL_0aac: Expected O, but got I
			//IL_0508: Unknown result type (might be due to invalid IL or missing references)
			//IL_050d: Expected O, but got Unknown
			//IL_0531: Expected O, but got I4
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_02ab: Expected O, but got I4
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_059b: Expected O, but got I
			//IL_05c3: Expected O, but got Ref
			//IL_0828: Expected O, but got I4
			//IL_0b32: Expected O, but got I
			//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b46: Expected O, but got Unknown
			//IL_0b7b: Expected O, but got I
			//IL_0b94: Expected O, but got I
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e5: Expected O, but got Unknown
			//IL_0863: Expected O, but got I
			//IL_0879: Expected O, but got I
			//IL_0882: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Expected O, but got Unknown
			//IL_08a1: Expected O, but got I4
			//IL_075d: Expected O, but got I4
			//IL_0766: Expected O, but got I4
			//IL_076f: Expected O, but got I4
			//IL_0633: Expected O, but got I4
			//IL_063c: Expected O, but got I4
			//IL_07a7: Expected O, but got I4
			//IL_08ce: Expected I, but got O
			//IL_0b05: Expected O, but got I
			//IL_0689: Expected O, but got I
			//IL_069f: Expected O, but got I
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Expected O, but got Unknown
			//IL_06c7: Expected O, but got I4
			//IL_091f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0924: Expected O, but got Unknown
			//IL_07e0: Expected O, but got I
			//IL_0949: Unknown result type (might be due to invalid IL or missing references)
			//IL_094e: Expected O, but got Unknown
			//IL_097a: Expected O, but got I4
			//IL_0710: Expected O, but got I4
			object obj6 = default(object);
			object obj17;
			object obj18;
			object obj20;
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_09ba;
					}
					<>1__state = -1;
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v28 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+8]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v28 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+8]");
					object obj3 = (nint)0 + (nint)309;
					object obj4 = obj3 & 1;
					bool flag2 = obj4 == null;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31E91F4");
					if (obj6 != null)
					{
						object obj7 = obj6 + 16;
						obj7 = reference;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj8 = obj7;
						if (obj7 != null)
						{
							object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3368;
							object obj10 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v35+12E]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v35+12E]");
							if ((nint)0 == 0)
							{
								goto IL_01f9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v35+B0]");
							object obj12 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X10_v11-8]");
								if (0 == (nint)obj9)
								{
									break;
								}
								obj12 += 16;
								obj11--;
								if ((nint)obj11 != 1)
								{
									continue;
								}
								goto IL_01f9;
							}
							object obj13 = obj10 + obj12;
							object obj14 = obj13 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v495 @ X0_v100] (should have been resolved before IL gen)");
							object obj15 = default(object);
							bool flag3 = obj15 == null;
							object obj16 = !flag3;
							obj17 = obj15;
							object obj19 = default(object);
							obj18 = obj19;
							obj20 = obj15;
							if (obj16 != null)
							{
								goto IL_0243;
							}
							goto IL_0557;
						}
					}
				}
				else
				{
					<>1__state = -1;
					object obj21 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 976;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v12+E4]");
					bool flag4 = (nint)0 == 0;
					object obj23 = !flag4;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj22 = obj21;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v12+B8]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v12+8]");
					if ((nint)0 != 0)
					{
						object obj25 = (nint)0 + (nint)24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v12+8]");
						bool flag5 = ((Dictionary<object, object>)0).Remove(<runtimeKey>5__2);
						AsyncOperationHandle<object> asyncOperationHandle = (AsyncOperationHandle<object>)(this + 56);
						AsyncOperationStatus status = ((AsyncOperationHandle<object>*)asyncOperationHandle)->Status;
						if (status == AsyncOperationStatus.Failed)
						{
							goto IL_09ba;
						}
						AsyncOperationHandle<object> asyncOperationHandle2 = (AsyncOperationHandle<object>)(this + 56);
						object result = ((AsyncOperationHandle<object>*)asyncOperationHandle2)->Result;
						object obj26 = this + 80;
						obj26 = result;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj27 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v23+E4]");
						bool flag6 = (nint)0 == 0;
						object obj28 = !flag6;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj27 = obj21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v23+B8]");
						object obj29 = 0;
						if (obj29 != null)
						{
							object obj30 = (nint)0 + (nint)88;
							string key = <runtimeKey>5__2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AssetInitializer+<InitializeHelper>d__4`1<T>)+50]");
							((Dictionary<object, object>)obj29).set_Item((object)key, (object)0);
							object obj31 = typeof(UsageHint) + 1632;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							WaitForEndOfFrame waitForEndOfFrame = default(WaitForEndOfFrame);
							waitForEndOfFrame..ctor();
							object obj32 = this + 24;
							obj32 = waitForEndOfFrame;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 2;
							return true;
						}
					}
				}
			}
			else
			{
				<>1__state = -1;
				Action<T> action = callback;
				if (callback != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ X8_v8 (System.Action`1<T>)+18] (should have been resolved before IL gen)");
					goto IL_09ba;
				}
			}
			goto IL_097f;
			IL_064a:
			Action<T> action2 = callback;
			if (callback == null)
			{
				goto IL_097f;
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v68 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+20]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v68 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+20]");
			object obj34 = (nint)0 + (nint)309;
			object obj35 = obj34 & 1;
			bool flag7 = obj35 == null;
			object obj36 = !flag7;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				object obj37 = default(object);
				obj33 = obj37;
			}
			object value;
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				object obj38 = default(object);
				bool flag8 = obj38 == null;
				object obj39 = !flag8;
				object obj40 = obj38;
				if (obj39 == null)
				{
					goto IL_098d;
				}
			}
			else
			{
				object obj40 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v220 @ X21_v14 (System.Action`1<T>)+18] (should have been resolved before IL gen)");
			goto IL_09ba;
			IL_098d:
			InvalidCastException ex = new InvalidCastException();
			return (byte)(int)ex != 0;
			IL_09e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj41 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 976;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v43+E4]");
			bool flag9 = (nint)0 == 0;
			object obj43 = !flag9;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj42 = obj41;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v43+B8]");
			object obj44 = 0;
			object obj46;
			if (obj44 != null)
			{
				object obj45 = obj46;
				object obj47 = (nint)0 + (nint)80;
				bool flag10 = ((Dictionary<object, object>)obj44).TryGetValue(obj46, out value);
				bool flag11 = !flag10;
				object obj48 = (object)(&value);
				if (!flag11)
				{
					object obj49 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj50 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v67+E4]");
					if ((nint)0 != 0)
					{
						bool flag12 = (UnityEngine.Object)value;
						bool flag13 = !flag12;
						object obj51 = 0;
						object obj52 = 0;
						if (!flag13)
						{
							goto IL_064a;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag14 = (UnityEngine.Object)value;
						bool flag15 = !flag14;
						object obj53 = !flag15;
						object obj51 = 0;
						object obj52 = 0;
						if (obj53 != null)
						{
							goto IL_064a;
						}
					}
					object obj54 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v70+E4]");
					bool flag16 = (nint)0 == 0;
					object obj55 = !flag16;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj54 = obj41;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v70+B8]");
					object obj56 = 0;
					if (obj56 == null)
					{
						goto IL_097f;
					}
					obj45 = obj46;
					object obj57 = (nint)0 + (nint)72;
					obj48 = obj57;
					bool flag17 = ((Dictionary<object, object>)obj56).Remove(obj46);
				}
				object obj58 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v48+E4]");
				bool flag18 = (nint)0 == 0;
				object obj59 = !flag18;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj58 = obj41;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v48+B8]");
				object obj60 = 0;
				object obj61 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3600;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v47 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+30]");
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj6, (IntPtr)0);
				object obj62 = (nint)0 + (nint)3320;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v43+8]");
				object orPut = DictionaryExtensions.GetOrPut((IDictionary<object, object>)0, obj46, func);
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v51 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+38]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v51 (Il2CppRgctx<AssetInitializer+<InitializeHelper>d__4`1>)+38]");
				object obj64 = (nint)0 + (nint)309;
				object obj65 = obj64 & 1;
				bool flag19 = obj65 == null;
				object obj66 = !flag19;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj67 = default(object);
					obj63 = obj67;
				}
				if (orPut != null)
				{
					nint num6 = (nint)orPut;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v54 (Il2CppClass<System.Object>)+40]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v23+40]");
					if (num7 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v54+10]");
						_ = 0;
						object obj68 = this + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj69 = this + 24;
						object obj70 = default(object);
						obj69 = obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						return true;
					}
					goto IL_098d;
				}
			}
			goto IL_097f;
			IL_09ba:
			return false;
			IL_0557:
			obj46 = this + 48;
			obj46 = 0;
			goto IL_09e4;
			IL_01f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ X0_v97] (should have been resolved before IL gen)");
			object obj71 = default(object);
			bool flag20 = obj71 == null;
			obj17 = obj71;
			obj18 = 0;
			obj20 = obj71;
			if (!flag20)
			{
				goto IL_0243;
			}
			goto IL_0557;
			IL_0243:
			object obj72 = 153100288 + 1024;
			object obj73 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v12+90]");
			if (obj73 == null)
			{
				obj46 = this + 48;
				obj46 = obj17;
				object obj74 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X9_v12+90]");
				bool flag21 = obj74 == null;
				obj18 = 0;
				obj20 = obj17;
				if (flag21)
				{
					goto IL_09e4;
				}
			}
			throw new InvalidCastException();
			IL_097f:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_098d;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private static readonly Dictionary<string, UnityEngine.Object> InitializedAssets;

	private static readonly Dictionary<string, object> OngoingOperations;

	public static void InitializeAsset<T>(AssetReferenceT<T> reference, Action<T> callback) where T : UnityEngine.Object
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		InitializeAsset((IKeyEvaluator)reference, callback);
	}

	public static void InitializeAsset<T>(IKeyEvaluator reference, Action<T> callback = null) where T : UnityEngine.Object
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = CoroutineDummy.Instance;
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 976;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerator routine = InitializeHelper(reference, callback);
		Coroutine coroutine = instance.StartCoroutine(routine);
	}

	private static IEnumerator InitializeHelper<T>(IKeyEvaluator reference, Action<T> callback) where T : UnityEngine.Object
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00bf: Expected I4, but got O
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e2: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<InitializeHelper>d__4<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<InitializeHelper>d__4<T> <InitializeHelper>d__ = (<InitializeHelper>d__4<T>)(enumerator + 32);
			<InitializeHelper>d__ = (<InitializeHelper>d__4<T>)(object)reference;
			<InitializeHelper>d__..ctor((int)reference);
			<InitializeHelper>d__4<T> <InitializeHelper>d__2 = (<InitializeHelper>d__4<T>)(enumerator + 40);
			<InitializeHelper>d__2 = (<InitializeHelper>d__4<T>)(object)callback;
			<InitializeHelper>d__2..ctor((int)callback);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	static AssetInitializer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2664;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 976;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = obj2;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		dictionary2..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
