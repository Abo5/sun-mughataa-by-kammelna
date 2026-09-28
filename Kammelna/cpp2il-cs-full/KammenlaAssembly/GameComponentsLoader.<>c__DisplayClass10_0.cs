using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameComponentsLoader : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public Transform parent;

		internal void <LoadComponentsHelper>b__0(GameObject go)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003f: Expected O, but got I
			//IL_0069: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = (nint)0 + (nint)920;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		}
	}

	private sealed class <LoadComponentsHelper>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public GameComponentsLoader <>4__this;

		public Room room;

		public Action<bool> callback;

		private List<AsyncOperationHandle<IList<GameObject>>>.Enumerator <>7__wrap1;

		private AsyncOperationHandle<IList<GameObject>> <operation>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadComponentsHelper>d__10(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_007f: Expected O, but got I
			//IL_00ad: Expected I4, but got I8
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = (nint)0 + (nint)2368;
				<>1__state = -1;
				object obj7 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47B2218");
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_0010: Expected O, but got Ref
			//IL_0cdf: Expected O, but got I4
			//IL_0cf7: Expected O, but got Ref
			//IL_0d13: Expected O, but got I4
			//IL_0d23: Expected O, but got I4
			//IL_0639: Expected I4, but got I8
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Expected O, but got Unknown
			//IL_0662: Expected O, but got I
			//IL_067c: Expected O, but got I4
			//IL_068a: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_0e59: Expected O, but got I
			//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e67: Expected O, but got Unknown
			//IL_0e81: Expected O, but got I
			//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8f: Expected O, but got Unknown
			//IL_0ea7: Expected O, but got I4
			//IL_06ca: Expected O, but got I
			//IL_06e0: Expected O, but got I
			//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0701: Expected O, but got Unknown
			//IL_072b: Expected O, but got I4
			//IL_0a44: Expected O, but got I4
			//IL_0761: Expected O, but got I
			//IL_076d: Expected O, but got I
			//IL_078b: Expected O, but got I
			//IL_006a: Expected I4, but got I8
			//IL_0ec1: Expected O, but got I
			//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed9: Expected O, but got Unknown
			//IL_0ef3: Expected O, but got I
			//IL_0f11: Expected O, but got I
			//IL_0f2f: Expected O, but got I
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Expected O, but got Unknown
			//IL_0976: Expected O, but got I
			//IL_0986: Expected O, but got I
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_099b: Expected O, but got Unknown
			//IL_09c0: Expected O, but got I
			//IL_09c8: Expected O, but got I4
			//IL_09e2: Expected O, but got I
			//IL_09f1: Expected O, but got I4
			//IL_0a02: Expected O, but got I4
			//IL_0e0e: Expected O, but got I
			//IL_0e16: Expected I4, but got O
			//IL_0e2c: Expected O, but got I
			//IL_0e3f: Expected O, but got I4
			//IL_0f66: Expected O, but got I4
			//IL_0f74: Expected O, but got I4
			//IL_00c5: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_010d: Expected O, but got I
			//IL_0115: Expected I4, but got O
			//IL_0c78: Expected O, but got I4
			//IL_0fb4: Expected O, but got I
			//IL_0fbc: Expected I4, but got O
			//IL_0fdf: Expected O, but got I4
			//IL_083d: Expected O, but got I4
			//IL_0846: Unknown result type (might be due to invalid IL or missing references)
			//IL_084b: Expected O, but got Unknown
			//IL_07bc: Expected O, but got I
			//IL_07df: Expected O, but got I4
			//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4b: Expected O, but got Unknown
			//IL_019c: Expected O, but got I
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Expected O, but got Unknown
			//IL_01d1: Expected O, but got I
			//IL_0887: Expected O, but got I4
			//IL_0890: Expected O, but got I4
			//IL_0b7d: Expected O, but got I4
			//IL_0800: Expected O, but got Ref
			//IL_0816: Expected O, but got I4
			//IL_08c7: Expected O, but got I
			//IL_08f6: Expected O, but got I
			//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd8: Expected O, but got Unknown
			//IL_0be0: Expected O, but got I4
			//IL_0bfd: Expected O, but got Ref
			//IL_0915: Expected O, but got I
			//IL_0bb0: Expected O, but got Ref
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Expected O, but got Unknown
			//IL_02ce: Expected O, but got I4
			//IL_02e0: Expected I, but got O
			//IL_0db7: Expected O, but got I
			//IL_032b: Expected O, but got I
			//IL_0d69: Expected O, but got I4
			//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7e: Expected O, but got Unknown
			//IL_041e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Expected O, but got Unknown
			//IL_0439: Expected O, but got I
			//IL_044a: Expected I, but got O
			//IL_03df: Expected I4, but got O
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Expected O, but got Unknown
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fa: Expected O, but got Unknown
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Expected O, but got Unknown
			//IL_048d: Expected O, but got I4
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected O, but got Unknown
			//IL_0376: Expected O, but got I4
			//IL_0384: Expected O, but got I4
			//IL_04b6: Expected O, but got I
			//IL_0a7a: Expected O, but got I4
			//IL_0a82: Expected O, but got Ref
			//IL_0a9f: Expected I4, but got O
			//IL_04e9: Expected O, but got I
			//IL_0507: Expected O, but got I
			//IL_056e: Expected O, but got I4
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Expected O, but got Unknown
			//IL_01e9: Expected O, but got Ref
			//IL_0203: Expected O, but got I
			//IL_0213: Expected O, but got I
			//IL_0223: Expected O, but got I
			//IL_0231: Expected O, but got Ref
			//IL_0243: Expected I4, but got O
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Expected O, but got Unknown
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Expected O, but got Unknown
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected O, but got Unknown
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Expected O, but got Unknown
			//IL_0615: Expected O, but got I4
			//IL_061d: Expected I4, but got O
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Dictionary<System.Int32Enum, object>.Enumerator enumerator = default(Dictionary<System.Int32Enum, object>.Enumerator);
			List<object> list = (List<object>)(&enumerator);
			list = (List<object>)0;
			list._items = null;
			object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
			bool flag = <>1__state < 1;
			object obj4 = !flag;
			object obj5 = <>1__state - 1;
			object[] array3 = default(object[]);
			Action<object> action = default(Action<object>);
			<LoadComponentsHelper>d__10 <LoadComponentsHelper>d__ = default(<LoadComponentsHelper>d__10);
			Dictionary<System.Int32Enum, object>.Enumerator enumerator3 = default(Dictionary<System.Int32Enum, object>.Enumerator);
			<LoadComponentsHelper>d__10 <LoadComponentsHelper>d__2;
			object obj47;
			object obj48;
			bool flag10;
			object[] array2 = default(object[]);
			object obj7;
			bool flag3;
			NullReferenceException ex;
			object obj21;
			object[] array4;
			object[] array5;
			object[] array;
			if (<>1__state != 1)
			{
				bool flag2 = <>1__state == 0;
				object obj6 = !flag2;
				obj7 = 0;
				array = null;
				IntPtr intPtr = default(IntPtr);
				flag3 = (byte)(nint)intPtr != 0;
				if (obj6 == null)
				{
					<>1__state = -1;
					if ((object)<>4__this != null)
					{
						GameComponentsStore componentsStore = <>4__this.ComponentsStore;
						if ((object)componentsStore != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v52+28]");
							ILookup<GameComponentsStore.Placement, AssetReferenceGameObject> componentsFor = componentsStore.GetComponentsFor((Room)0);
							object obj9 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3568;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj10 = (nint)0 + (nint)2392;
							flag3 = (byte)(int)obj10 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32A7788");
							Dictionary<GameComponentsStore.Placement, Transform> locations = <>4__this.Locations;
							if (locations != null)
							{
								Dictionary<System.Int32Enum, object>.Enumerator enumerator2 = ((Dictionary<System.Int32Enum, object>)(object)locations).GetEnumerator();
								list = (List<object>)(object)array2;
								list._items = array3;
								bool flag5 = default(bool);
								if (componentsFor != null)
								{
									object obj11 = (nint)0 + (nint)3936;
									object obj12 = typeof(DebugUI.BitField) + 3944;
									object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2016;
									object obj14 = (nint)0 + (nint)2120;
									array = array2;
									object obj15 = default(object);
									bool flag7 = default(bool);
									IEnumerable<object> source2 = default(IEnumerable<object>);
									while (enumerator.MoveNext())
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj15..ctor();
										bool flag4 = obj15 == null;
										flag3 = false;
										if (flag4)
										{
											goto IL_0b9f;
										}
										object obj16 = obj15 + 16;
										obj16 = flag5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										nint num = (nint)componentsFor;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v69 (Il2CppClass<System.Linq.ILookup`2<GameComponentsStore+Placement, UnityEngine.AddressableAssets.AssetReferenceGameObject>>)+12E]");
										int num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v69 (Il2CppClass<System.Linq.ILookup`2<GameComponentsStore+Placement, UnityEngine.AddressableAssets.AssetReferenceGameObject>>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_03c8;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v69 (Il2CppClass<System.Linq.ILookup`2<GameComponentsStore+Placement, UnityEngine.AddressableAssets.AssetReferenceGameObject>>)+B0]");
										object obj17 = (nint)0 + (nint)8;
										bool flag6 = flag7;
										object obj18;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X10_v16 (System.Object)-8]");
											bool flag8 = 0 < (nint)obj13;
											obj4 = !flag8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X10_v16 (System.Object)-8]");
											obj5 = 0 - obj13;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X10_v16 (System.Object)-8]");
											if (0 == (nint)obj13)
											{
												break;
											}
											obj18 = obj17 + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v69 (Il2CppClass<System.Linq.ILookup`2<GameComponentsStore+Placement, UnityEngine.AddressableAssets.AssetReferenceGameObject>>)+12E]");
											num2 = (int)(-1);
											bool flag9 = num2 < 1;
											obj4 = !flag9;
											obj5 = num2 - 1;
											flag10 = obj5 == null;
											flag7 = num2 != 1;
											flag6 = flag7;
											obj17 = obj18;
											if (flag7)
											{
												continue;
											}
											goto IL_03c8;
										}
										num2 = (int)obj17;
										object obj19 = num + obj17;
										object obj20 = obj19 + 312;
										flag7 = flag6;
										obj18 = obj17;
										goto IL_0da7;
										IL_0da7:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v95+8]");
										obj21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v962 @ X0_v95] (should have been resolved before IL gen)");
										List<object> source = Enumerable.ToList(source2);
										if (!Enumerable.Any(source))
										{
											continue;
										}
										object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj23 = (nint)0 + (nint)1448;
										action..ctor(obj15, (IntPtr)obj23);
										object obj24 = typeof(SqlSingle[]) + 3048;
										object obj25 = obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v102+E4]");
										bool flag11 = (nint)0 == 0;
										object obj26 = !flag11;
										if (obj26 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj27 = (nint)0 + (nint)3248;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F364EC");
										if (<LoadComponentsHelper>d__ != null)
										{
											object obj28 = (nint)0 + (nint)2400;
											object obj29 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v72 (GameComponentsLoader+<LoadComponentsHelper>d__10)+1C]");
											object obj30 = (nint)0 + (nint)1;
											num2 = <LoadComponentsHelper>d__.<>1__state;
											if (<LoadComponentsHelper>d__.<>1__state != 0)
											{
												obj18 = <LoadComponentsHelper>d__.<>2__current;
												object obj31 = <LoadComponentsHelper>d__.<>2__current;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X9_v20 (System.Int32)+18]");
												bool flag12 = (nint)obj31 < 0;
												obj4 = !flag12;
												object obj32 = <LoadComponentsHelper>d__.<>2__current;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X9_v20 (System.Int32)+18]");
												obj5 = obj32 - 0;
												flag10 = obj5 == null;
												if (obj4 != null)
												{
													object obj33 = (object)(&enumerator);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v86+20]");
													object obj34 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X8_v90+C0]");
													object obj35 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v91+70]");
													obj21 = 0;
													object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32A82C0");
													num2 = (int)array3;
													array = array2;
												}
												else
												{
													object obj37 = <LoadComponentsHelper>d__.<>2__current + 1;
													<LoadComponentsHelper>d__.<>2__current = obj37;
													object obj38 = <LoadComponentsHelper>d__.<>2__current * 24;
													object obj39 = num2 + obj38;
													object obj40 = obj39 + 32;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													obj21 = 1;
													num2 = (int)array3;
													array = array2;
												}
												continue;
											}
										}
										goto IL_0a68;
										IL_03c8:
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
										goto IL_0da7;
									}
								}
								else
								{
									object obj41 = (nint)0 + (nint)3936;
									bool flag13 = enumerator.MoveNext();
									bool flag14 = !flag13;
									object obj42 = !flag14;
									array = array2;
									if (obj42 != null)
									{
										object obj43 = typeof(DebugUI.BitField) + 3944;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj44 = default(object);
										obj44..ctor();
										bool flag15 = obj44 == null;
										object obj45 = !flag15;
										array = array2;
										flag3 = false;
										if (obj45 == null)
										{
											goto IL_0b9f;
										}
										object obj46 = obj44 + 16;
										obj46 = flag5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										ex = new NullReferenceException();
										enumerator3 = (Dictionary<System.Int32Enum, object>.Enumerator)(&enumerator);
										array4 = null;
										array5 = array3;
										array = array2;
										flag3 = flag5;
										<LoadComponentsHelper>d__2 = <LoadComponentsHelper>d__;
										goto IL_0c2e;
									}
								}
								enumerator3 = (Dictionary<System.Int32Enum, object>.Enumerator)(&enumerator);
								array4 = null;
								array5 = array3;
								obj47 = 7;
								<LoadComponentsHelper>d__2 = <LoadComponentsHelper>d__;
								goto IL_0fa8;
							}
							ex = new NullReferenceException();
							array = null;
							<LoadComponentsHelper>d__2 = <LoadComponentsHelper>d__;
						}
						else
						{
							ex = new NullReferenceException();
							array = null;
							flag3 = (byte)(nint)intPtr != 0;
							<LoadComponentsHelper>d__2 = this;
						}
					}
					else
					{
						ex = new NullReferenceException();
						array = null;
						flag3 = (byte)(nint)intPtr != 0;
						<LoadComponentsHelper>d__2 = this;
					}
					goto IL_0c2e;
				}
			}
			else
			{
				<>1__state = -3;
				AsyncOperationHandle<object> asyncOperationHandle = (AsyncOperationHandle<object>)(this + 96);
				AsyncOperationStatus status = ((AsyncOperationHandle<object>*)asyncOperationHandle)->Status;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				obj48 = 0;
				bool flag16 = status < AsyncOperationStatus.Failed;
				obj4 = !flag16;
				obj5 = status - 2;
				flag10 = obj5 == null;
				if (status != AsyncOperationStatus.Failed)
				{
					_ = 0;
					_ = 0;
					_ = 0;
					goto IL_0e4d;
				}
				object obj49 = (nint)0 + (nint)360;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				AsyncOperationHandle<object> asyncOperationHandle2 = (AsyncOperationHandle<object>)((nint)0 + (nint)96);
				Exception operationException = ((AsyncOperationHandle<object>*)asyncOperationHandle2)->OperationException;
				object obj50 = typeof(DataRelation) + 856;
				object obj51 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v32+E4]");
				bool flag17 = (nint)0 == 0;
				object obj52 = !flag17;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogException(operationException);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				object obj53 = 0;
				object obj54 = (nint)0 + (nint)2056;
				obj21 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v32+30]");
				Actions.SafeInvoke((Action<bool>)0, arg: false);
				_ = 4294967295L;
				object obj55 = (nint)0 + (nint)2368;
				flag3 = (byte)(int)obj55 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				object obj56 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47B2218");
				obj7 = 0;
				array = null;
			}
			goto IL_0a2a;
			IL_0c2e:
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj57 = default(object);
				array4 = (object[])obj57;
				obj47 = 0;
				goto IL_0fa8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238AA8");
			bool flag18 = (flag3 ? 1 : 0) < (true ? 1 : 0);
			obj4 = !flag18;
			obj5 = (flag3 ? 1 : 0) - 1;
			flag10 = obj5 == null;
			bool result;
			object obj58;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				object obj59 = default(object);
				obj58 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag19 = obj59 == null;
				result = false;
				if (!flag19)
				{
					obj7 = obj59;
					goto IL_0a10;
				}
				goto IL_0a63;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238AE8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result2 = default(bool);
			return result2;
			IL_0a2a:
			bool flag20 = obj7 == null;
			object obj60 = !flag20;
			obj58 = obj7;
			result = false;
			if (obj60 != null)
			{
				goto IL_0a10;
			}
			goto IL_0a63;
			IL_0a10:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239044");
			throw new OutOfMemoryException();
			IL_0fa8:
			object obj61 = (nint)0 + (nint)3928;
			flag3 = (byte)(int)obj61 != 0;
			((Dictionary<System.Int32Enum, object>.Enumerator*)enumerator3)->Dispose();
			bool flag21 = array4 == null;
			object obj62 = !flag21;
			if (obj62 == null)
			{
				bool flag22 = (nint)obj47 < 7;
				obj4 = !flag22;
				obj5 = obj47 - 7;
				if ((nint)obj47 != 7)
				{
					bool flag23 = obj47 == null;
					object obj63 = !flag23;
					obj7 = 0;
					if (obj63 != null)
					{
						goto IL_0a2a;
					}
				}
				if (<LoadComponentsHelper>d__2 != null)
				{
					object obj64 = (nint)0 + (nint)2408;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32A945C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
					object obj65 = (nint)0 + (nint)56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
					obj48 = 0;
					_ = 4294967293L;
					object[] array6 = default(object[]);
					array5 = array6;
					array2 = array4;
					goto IL_0e4d;
				}
				ex = new NullReferenceException();
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
				ex = (NullReferenceException)(object)ex2;
			}
			goto IL_0c2e;
			IL_0e4d:
			object obj66 = (nint)0 + (nint)2376;
			object obj67 = obj48 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47B221C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
			obj58 = 0;
			object obj69 = default(object);
			object obj68 = obj69 & 1;
			bool flag24 = obj68 == null;
			obj7 = 0;
			if (!flag24)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X19_v9+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X19_v9+58]");
				_ = 0;
				object obj70 = obj58 + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				object obj71 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v7+60]");
				array = (object[])0;
				object obj72 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				object obj73 = (nint)0 + (nint)24;
				bool flag25 = default(bool);
				obj73 = flag25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				object obj74 = 0;
				_ = 1;
				obj7 = 0;
				flag3 = flag25;
				obj58 = 0;
				result = true;
				goto IL_0a63;
			}
			object obj75 = (nint)0 + (nint)2368;
			_ = 4294967295L;
			object obj76 = obj58 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47B2218");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
			object obj77 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj78 = (nint)0 + (nint)2056;
			obj21 = obj78;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v19+30]");
			Actions.SafeInvoke((Action<bool>)0, arg: true);
			array = null;
			flag3 = true;
			goto IL_0a2a;
			IL_0b9f:
			ex = new NullReferenceException();
			enumerator3 = (Dictionary<System.Int32Enum, object>.Enumerator)(&enumerator);
			array4 = null;
			array5 = array3;
			<LoadComponentsHelper>d__2 = <LoadComponentsHelper>d__;
			goto IL_0c2e;
			IL_0a68:
			ex = new NullReferenceException();
			obj21 = 1;
			enumerator3 = (Dictionary<System.Int32Enum, object>.Enumerator)(&enumerator);
			array4 = null;
			array5 = array3;
			array = array2;
			flag3 = (byte)(int)action != 0;
			<LoadComponentsHelper>d__2 = <LoadComponentsHelper>d__;
			goto IL_0c2e;
			IL_0a63:
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void <>m__Finally1()
		{
			//IL_000c: Expected O, but got I
			//IL_0020: Expected I4, but got I8
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			object obj = (nint)0 + (nint)2368;
			<>1__state = -1;
			object obj2 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47B2218");
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
			object obj2 = (nint)0 + (nint)1456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private GameComponentsStore balootComponents;

	private GameComponentsStore tarneebComponents;

	private GameComponentsStore JackarooComponents;

	private Transform topBarsParent;

	private Transform bottomBarsParent;

	private GameComponentsStore ComponentsStore
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0103: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_00bc: Expected O, but got I4
			//IL_00d3: Expected O, but got I
			//IL_0143: Expected O, but got I4
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected O, but got Unknown
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_02af: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AE1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v38+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v38+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame = Preferences.CurrentGame;
			bool flag2 = currentGame < (Games)3;
			object obj6 = !flag2;
			object obj7 = ~obj6;
			if (obj7 != null)
			{
				goto IL_00ae;
			}
			goto IL_015a;
			IL_00ae:
			object obj8 = (int)currentGame << 3;
			object obj9 = (object)this + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
			return (GameComponentsStore)0;
			IL_015a:
			object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D040");
			Games currentGame2 = Preferences.CurrentGame;
			object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Games currentGame3 = Preferences.CurrentGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj12 = "{0} color encoding is currently unsupported for outputting to HDR." + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj13 = "Complete" + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj14 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			string format = default(string);
			object arg = default(object);
			object arg2 = default(object);
			object arg3 = default(object);
			string message = string.Format(format, arg, arg2, arg3);
			object obj15 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, message);
			object obj16 = (nint)0 + (nint)152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (GameComponentsStore)(object)new OutOfMemoryException();
			IL_007d:
			currentGame = Preferences.CurrentGame;
			bool flag3 = currentGame < (Games)3;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				goto IL_00ae;
			}
			goto IL_015a;
		}
	}

	private Dictionary<GameComponentsStore.Placement, Transform> Locations
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0026: Expected O, but got I
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0091: Expected O, but got I4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
			dictionary..ctor();
			if (dictionary != null)
			{
				object obj2 = (nint)0 + (nint)848;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				dictionary.Add((System.Int32Enum)0, topBarsParent);
				dictionary.Add((System.Int32Enum)1, bottomBarsParent);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GameObject mainCanvas = KUtil.GetMainCanvas();
				if ((object)mainCanvas != null)
				{
					object caller = "LAK" + 2256;
					Transform value = mainCanvas.transform;
					dictionary.Add((System.Int32Enum)2, value);
					GameObject secondaryCanvas = KUtil.GetSecondaryCanvas((string)caller);
					if ((object)secondaryCanvas != null)
					{
						Transform value2 = secondaryCanvas.transform;
						dictionary.Add((System.Int32Enum)3, value2);
						return (Dictionary<GameComponentsStore.Placement, Transform>)(object)dictionary;
					}
				}
			}
			return (Dictionary<GameComponentsStore.Placement, Transform>)(object)new NullReferenceException();
		}
	}

	public void LoadComponents(Room room, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 48;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private IEnumerator LoadComponentsHelper(Room room, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 48;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}
}
