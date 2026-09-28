using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem.XR;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.TextCore;

public class PrefabInitializer : MonoBehaviour
{
	private enum LayerOptions
	{
		MainCanvas,
		SecondaryCanvas,
		CustomParent
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<IInitializable> <>9__8_0;

		public static Action<IInitializable> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <InitializePrefab>b__8_0(IInitializable initializable)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3144;
			nint num = (nint)initializable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IInitializable>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IInitializable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IInitializable>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			goto IL_0116;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_0116:
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}

		internal void <Initialize>b__11_0(IInitializable initializable)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3144;
			nint num = (nint)initializable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IInitializable>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IInitializable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IInitializable>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			goto IL_0116;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_0116:
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}
	}

	private sealed class <>c__DisplayClass12_0<T>
	{
		public IKeyEvaluator assetReference;

		public Transform parent;

		internal AsyncOperationHandle<GameObject> <InitializeHelper>b__0(string _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3048;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Addressables.InstantiateAsync(assetReference, parent);
		}
	}

	private sealed class <InitializeHelper>d__12<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public IKeyEvaluator assetReference;

		public Transform parent;

		public Action<T> callback;

		private <>c__DisplayClass12_0<T> <>8__1;

		private string <runtimeKey>5__2;

		private GameObject <instance>5__3;

		private AsyncOperationHandle<GameObject> <operation>5__4;

		private GameObject <initializedPrefab>5__5;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <InitializeHelper>d__12(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_04fd: Expected I4, but got I8
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0511: Expected O, but got Unknown
			//IL_053b: Expected O, but got I4
			//IL_0c5d: Expected O, but got I
			//IL_01ec: Expected I4, but got I8
			//IL_0202: Expected O, but got I
			//IL_0218: Expected O, but got I
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected O, but got Unknown
			//IL_0240: Expected O, but got I4
			//IL_0b9a: Expected I4, but got O
			//IL_056c: Expected O, but got I
			//IL_0583: Expected O, but got I
			//IL_0593: Expected O, but got I
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Expected O, but got Unknown
			//IL_0130: Expected I4, but got I8
			//IL_0140: Expected O, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_0188: Expected O, but got I4
			//IL_01a2: Expected O, but got I
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected O, but got Unknown
			//IL_005e: Expected I4, but got I8
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_00b0: Expected O, but got I4
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected O, but got Unknown
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected O, but got Unknown
			//IL_0605: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Expected O, but got Unknown
			//IL_0634: Expected O, but got I4
			//IL_067e: Expected O, but got I4
			//IL_0693: Unknown result type (might be due to invalid IL or missing references)
			//IL_0698: Expected O, but got Unknown
			//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b0: Expected O, but got Unknown
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Expected O, but got Unknown
			//IL_038f: Expected I, but got O
			//IL_039f: Expected O, but got I
			//IL_044f: Expected O, but got I4
			//IL_0854: Unknown result type (might be due to invalid IL or missing references)
			//IL_0859: Expected O, but got Unknown
			//IL_0862: Expected O, but got I4
			//IL_03da: Expected O, but got I
			//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c15: Expected O, but got Unknown
			//IL_0c3f: Expected O, but got I4
			//IL_0474: Expected O, but got I4
			//IL_0cca: Expected O, but got I
			//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Expected O, but got Unknown
			//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0804: Expected O, but got Unknown
			//IL_0828: Expected O, but got I4
			//IL_0741: Expected O, but got I4
			//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Expected O, but got Unknown
			//IL_04cd: Expected O, but got I4
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Expected O, but got Unknown
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Expected O, but got Unknown
			//IL_0c92: Expected O, but got I
			//IL_0892: Expected O, but got I
			//IL_0898: Unknown result type (might be due to invalid IL or missing references)
			//IL_089d: Expected Ref, but got Unknown
			//IL_0afa: Expected O, but got I4
			//IL_0772: Expected O, but got I
			//IL_078d: Expected O, but got I
			//IL_079c: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a1: Expected O, but got Unknown
			//IL_0d24: Expected O, but got I
			//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d38: Expected O, but got Unknown
			//IL_0d6f: Expected O, but got I
			//IL_08da: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Expected O, but got Unknown
			//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c4: Expected O, but got Unknown
			//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b34: Expected O, but got Unknown
			//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b52: Expected O, but got Unknown
			//IL_07e4: Expected O, but got I4
			//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6c: Expected O, but got Unknown
			//IL_0b87: Expected O, but got I4
			//IL_0a38: Expected O, but got I4
			//IL_0a41: Expected O, but got I4
			//IL_092f: Expected O, but got I4
			//IL_0a79: Expected O, but got I4
			//IL_0cf7: Expected O, but got I
			//IL_0ab2: Expected O, but got I
			//IL_09aa: Expected O, but got I
			//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09be: Expected O, but got Unknown
			//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e1: Expected O, but got Unknown
			object obj5;
			object obj16;
			bool result;
			Action<T> action2;
			GameObject gameObject2;
			object obj17;
			object obj19;
			object obj39;
			object obj40;
			Action<T> action;
			GameObject gameObject;
			if (<>1__state <= 1)
			{
				if (<>1__state == 0)
				{
					<>1__state = -1;
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v39 (Il2CppRgctx<PrefabInitializer+<InitializeHelper>d__12`1>)+8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v39 (Il2CppRgctx<PrefabInitializer+<InitializeHelper>d__12`1>)+8]");
					object obj2 = (nint)0 + (nint)309;
					object obj3 = obj2 & 1;
					bool flag = obj3 == null;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D67D4");
					obj5 = this + 56;
					object obj6 = default(object);
					obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj5 != null)
					{
						object obj7 = obj5 + 16;
						obj7 = assetReference;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (<>8__1 != null)
						{
							object obj8 = <>8__1 + 24;
							obj8 = parent;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							<>c__DisplayClass12_0<T> <>c__DisplayClass12_ = <>8__1;
							if (<>8__1 != null)
							{
								IKeyEvaluator keyEvaluator = <>c__DisplayClass12_.assetReference;
								if (<>c__DisplayClass12_.assetReference != null)
								{
									object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3368;
									nint num3 = (nint)keyEvaluator;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v47 (Il2CppClass<UnityEngine.AddressableAssets.IKeyEvaluator>)+12E]");
									object obj10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v47 (Il2CppClass<UnityEngine.AddressableAssets.IKeyEvaluator>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_041b;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v47 (Il2CppClass<UnityEngine.AddressableAssets.IKeyEvaluator>)+B0]");
									object obj11 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X10_v12-8]");
										if (0 == (nint)obj9)
										{
											break;
										}
										obj11 += 16;
										obj10--;
										if ((nint)obj10 != 1)
										{
											continue;
										}
										goto IL_041b;
									}
									object obj12 = num3 + obj11;
									object obj13 = obj12 + 312;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v578 @ X0_v109] (should have been resolved before IL gen)");
									object obj14 = default(object);
									bool flag2 = obj14 == null;
									object obj15 = !flag2;
									obj16 = obj14;
									object obj18 = default(object);
									obj17 = obj18;
									obj19 = obj14;
									if (obj15 != null)
									{
										goto IL_0465;
									}
									goto IL_084e;
								}
							}
						}
					}
					goto IL_0b8c;
				}
				bool flag3 = <>1__state != 1;
				result = false;
				if (flag3)
				{
					goto IL_0bb9;
				}
				<>1__state = -1;
				gameObject = <instance>5__3;
				action = callback;
				object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v32+E4]");
				bool flag4 = (nint)0 == 0;
				object obj22 = !flag4;
				if (obj22 == null)
				{
					action2 = callback;
					gameObject2 = <instance>5__3;
					goto IL_01b0;
				}
			}
			else
			{
				if (<>1__state == 2)
				{
					<>1__state = -1;
					object obj23 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v11+E4]");
					bool flag5 = (nint)0 == 0;
					object obj25 = !flag5;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj23;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v11+B8]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v13+8]");
					if ((nint)0 != 0)
					{
						object obj27 = (nint)0 + (nint)856;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v13+8]");
						bool flag6 = ((Dictionary<object, AsyncOperationHandle<object>>)0).Remove(<runtimeKey>5__2);
						object obj28 = (nint)0 + (nint)672;
						AsyncOperationHandle<object> asyncOperationHandle = (AsyncOperationHandle<object>)(this + 80);
						AsyncOperationStatus status = ((AsyncOperationHandle<object>*)asyncOperationHandle)->Status;
						if (status == AsyncOperationStatus.Failed)
						{
							goto IL_01cf;
						}
						<>c__DisplayClass12_0<T> <>c__DisplayClass12_2 = <>8__1;
						if (<>8__1 != null)
						{
							object obj29 = typeof(MemberAchievementClanFeedData) + 2976;
							object obj30 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v16+E4]");
							bool flag7 = (nint)0 == 0;
							object obj31 = !flag7;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = <>c__DisplayClass12_2.parent == null;
							bool flag9 = !flag8;
							object obj32 = !flag9;
							if (obj32 != null)
							{
								goto IL_01cf;
							}
							AsyncOperationHandle<object> asyncOperationHandle2 = (AsyncOperationHandle<object>)(this + 80);
							object result2 = ((AsyncOperationHandle<object>*)asyncOperationHandle2)->Result;
							object obj33 = this + 104;
							obj33 = result2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							if (obj33 != null)
							{
								Transform transform = ((GameObject)obj33).transform;
								if ((object)transform != null)
								{
									transform.SetAsLastSibling();
									object obj34 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X0_v27+E4]");
									bool flag10 = (nint)0 == 0;
									object obj35 = !flag10;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj34 = obj23;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X0_v27+B8]");
									object obj36 = 0;
									if (obj36 != null)
									{
										object obj37 = (nint)0 + (nint)2720;
										string key = <runtimeKey>5__2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PrefabInitializer+<InitializeHelper>d__12`1<T>)+68]");
										((Dictionary<object, object>)obj36).set_Item((object)key, (object)0);
										object obj38 = typeof(UsageHint) + 1632;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										WaitForEndOfFrame waitForEndOfFrame = default(WaitForEndOfFrame);
										waitForEndOfFrame..ctor();
										obj39 = this + 24;
										obj39 = waitForEndOfFrame;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										obj40 = 3;
										goto IL_0caf;
									}
								}
							}
						}
					}
					goto IL_0b8c;
				}
				bool flag11 = <>1__state != 3;
				result = false;
				if (flag11)
				{
					goto IL_0bb9;
				}
				<>1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PrefabInitializer+<InitializeHelper>d__12`1<T>)+68]");
				gameObject2 = (GameObject)0;
				action2 = callback;
				object obj41 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
				object obj21 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v32+E4]");
				bool flag12 = (nint)0 == 0;
				object obj42 = !flag12;
				action = callback;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PrefabInitializer+<InitializeHelper>d__12`1<T>)+68]");
				gameObject = (GameObject)0;
				if (obj42 == null)
				{
					goto IL_01b0;
				}
			}
			goto IL_0bbe;
			IL_0bbe:
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F8107C");
			goto IL_01cf;
			IL_0465:
			object obj43 = 153100288 + 1024;
			object obj44 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X9_v14+90]");
			object obj45;
			if (obj44 == null)
			{
				obj45 = this + 64;
				obj45 = obj16;
				object obj46 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X9_v14+90]");
				bool flag13 = obj46 == null;
				obj17 = 0;
				obj19 = obj16;
				if (flag13)
				{
					goto IL_0bf7;
				}
			}
			throw new InvalidCastException();
			IL_0caf:
			return true;
			IL_01cf:
			result = false;
			goto IL_0bb9;
			IL_093d:
			if ((object)<instance>5__3 != null)
			{
				Transform transform2 = <instance>5__3.transform;
				object obj47 = obj5;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v75+18]");
					UIExtensions.AttachToCanvas(transform2, (Transform)0);
					object obj48 = typeof(UsageHint) + 1632;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitForEndOfFrame waitForEndOfFrame2 = default(WaitForEndOfFrame);
					waitForEndOfFrame2..ctor();
					object obj49 = this + 24;
					obj49 = waitForEndOfFrame2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
			}
			goto IL_0b8c;
			IL_041b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v547 @ X0_v106] (should have been resolved before IL gen)");
			object obj50 = default(object);
			bool flag14 = obj50 == null;
			obj16 = obj50;
			obj17 = 0;
			obj19 = obj50;
			if (!flag14)
			{
				goto IL_0465;
			}
			goto IL_084e;
			IL_0b8c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_084e:
			obj45 = this + 64;
			obj45 = 0;
			goto IL_0bf7;
			IL_0bf7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj51 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v60+E4]");
			bool flag15 = (nint)0 == 0;
			object obj53 = !flag15;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj52 = obj51;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v60+B8]");
			object obj54 = 0;
			if (obj54 == null)
			{
				goto IL_0b8c;
			}
			object obj55 = obj45;
			object obj56 = (nint)0 + (nint)2696;
			if (((Dictionary<object, object>)obj54).TryGetValue(obj45, out *(object*)(this + 72)))
			{
				object obj57 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj58 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v78+E4]");
				if ((nint)0 != 0)
				{
					bool flag16 = <instance>5__3;
					bool flag17 = !flag16;
					object obj59 = 0;
					if (!flag17)
					{
						goto IL_093d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag18 = <instance>5__3;
					bool flag19 = !flag18;
					object obj60 = !flag19;
					object obj59 = 0;
					if (obj60 != null)
					{
						goto IL_093d;
					}
				}
				object obj61 = obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v81+E4]");
				bool flag20 = (nint)0 == 0;
				object obj62 = !flag20;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj61 = obj51;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v81+B8]");
				object obj63 = 0;
				if (obj63 == null)
				{
					goto IL_0b8c;
				}
				obj55 = obj45;
				object obj64 = (nint)0 + (nint)2688;
				ref object reference = ref *(object*)obj64;
				bool flag21 = ((Dictionary<object, object>)obj63).Remove(obj45);
			}
			object obj65 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v65+E4]");
			bool flag22 = (nint)0 == 0;
			object obj66 = !flag22;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj65 = obj51;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v65+B8]");
			object obj67 = 0;
			object obj68 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num5 = 0;
			<>c__DisplayClass12_0<T> <>c__DisplayClass12_3 = <>8__1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v59 (Il2CppRgctx<PrefabInitializer+<InitializeHelper>d__12`1>)+28]");
			Func<object, AsyncOperationHandle<object>> func = default(Func<object, AsyncOperationHandle<object>>);
			func..ctor((object)<>c__DisplayClass12_3, (IntPtr)0);
			object obj69 = (nint)0 + (nint)3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D6B7D8");
			object obj70 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj71 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			obj39 = this + 24;
			object obj72 = default(object);
			obj39 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj40 = 2;
			goto IL_0caf;
			IL_01b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			gameObject = gameObject2;
			goto IL_0bbe;
			IL_0bb9:
			return result;
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

	private static readonly Dictionary<string, GameObject> InitializedPrefabs;

	private static readonly Dictionary<string, AsyncOperationHandle<GameObject>> OngoingOperations;

	public AssetReferenceGameObject address;

	private LayerOptions canvas;

	private RectTransform customParent;

	private bool CustomParentValid()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (canvas == LayerOptions.CustomParent)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				return customParent != null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return customParent != null;
		}
		return true;
	}

	public static void InitializePrefab<T>(ComponentReference<T> reference, CanvasLayer layer, Action<T> callback) where T : Component
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		Transform parent = CanvasLayerExtensions.GetCanvas(layer);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		InitializePrefab(reference, parent, callback);
	}

	public static void InitializePrefab<T>(AddressReference<T> reference, CanvasLayer layer, Action<T> callback) where T : Component
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		Transform parent = CanvasLayerExtensions.GetCanvas(layer);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		InitializePrefab(reference, parent, callback);
	}

	public static void InitializePrefab(IKeyEvaluator reference, CanvasLayer layer = CanvasLayer.MainCanvas)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01b1: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_021d: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_0117: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0369: Expected O, but got I
		//IL_0371: Expected I, but got O
		//IL_0382: Expected I, but got O
		//IL_03a0: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02ea: Expected O, but got I4
		//IL_02af: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D60]");
		object obj3 = (nint)0 & (nint)1;
		CanvasLayer layer2 = default(CanvasLayer);
		Transform transform3;
		object obj4;
		Transform transform2;
		if (obj3 != null)
		{
			Transform transform = CanvasLayerExtensions.GetCanvas(layer2);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			transform2 = transform;
			object obj5 = obj4;
			transform3 = transform;
			if (!flag)
			{
				goto IL_00a2;
			}
		}
		else
		{
			_ = 1;
			Transform transform4 = CanvasLayerExtensions.GetCanvas(layer2);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			transform2 = transform4;
			object obj5 = obj4;
			transform3 = transform4;
			if (obj6 != null)
			{
				goto IL_00a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		transform2 = transform3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_010b;
		}
		goto IL_025d;
		IL_010b:
		object obj11 = (nint)0 + (nint)2080;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		object obj13 = obj11;
		Action<object> action2 = action;
		transform3 = transform2;
		if (!flag4)
		{
			goto IL_0164;
		}
		goto IL_0318;
		IL_0318:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		transform2 = transform3;
		goto IL_0164;
		IL_0164:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80E14");
		return;
		IL_00a2:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		transform3 = transform2;
		if (!flag5)
		{
			goto IL_010b;
		}
		goto IL_025d;
		IL_025d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1760;
		num = (nint)obj17;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2080;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		transform2 = transform3;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0164;
		}
		goto IL_0318;
	}

	public static void InitializePrefab<T>(IKeyEvaluator reference, CanvasLayer layer, Action<T> callback)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		Transform parent = CanvasLayerExtensions.GetCanvas(layer);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		InitializePrefab(reference, parent, callback);
	}

	public static void InitializePrefab<T>(IKeyEvaluator reference, Transform parent, Action<T> callback = null)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = CoroutineDummy.Instance;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerator routine = InitializeHelper(reference, parent, callback);
		Coroutine coroutine = instance.StartCoroutine(routine);
	}

	public void Initialize()
	{
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0294: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_0043: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I
		//IL_0304: Expected I, but got O
		//IL_0322: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3144;
		Transform transform2;
		AssetReferenceGameObject assetReferenceGameObject2;
		object obj2;
		Transform transform;
		AssetReferenceGameObject assetReferenceGameObject;
		if (canvas == LayerOptions.CustomParent)
		{
			transform = customParent;
			assetReferenceGameObject = address;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				object obj4 = obj2;
				transform2 = customParent;
				assetReferenceGameObject2 = address;
				goto IL_00e5;
			}
		}
		else
		{
			Transform transform3 = CanvasLayerExtensions.GetCanvas((CanvasLayer)canvas);
			assetReferenceGameObject2 = address;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			transform2 = transform3;
			obj2 = obj4;
			transform = transform3;
			assetReferenceGameObject = address;
			if (obj5 == null)
			{
				goto IL_00e5;
			}
		}
		goto IL_0270;
		IL_0270:
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v6+10]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v6+10]");
		Action<object> action2;
		object obj10;
		object obj8;
		if ((nint)0 != 0)
		{
			obj8 = (nint)0 + (nint)2080;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v6+10]");
			action2 = (Action<object>)0;
			obj10 = obj8;
			if (!flag3)
			{
				goto IL_015d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v13+B8]");
				obj7 = 0;
			}
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1752;
			Action<object> action3 = default(Action<object>);
			action3..ctor(obj7, (IntPtr)obj14);
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v11+B8]");
			object obj16 = (nint)0 + (nint)16;
			obj16 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = (nint)0 + (nint)2080;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v4+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			action = action3;
			action2 = action3;
			obj10 = obj8;
			if (obj17 != null)
			{
				goto IL_015d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action2;
		obj8 = obj10;
		goto IL_015d;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj2 = obj;
		transform = transform2;
		assetReferenceGameObject = assetReferenceGameObject2;
		goto IL_0270;
		IL_015d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80E14");
	}

	private static IEnumerator InitializeHelper<T>(IKeyEvaluator assetReference, Transform parent, Action<T> callback)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
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
		((<InitializeHelper>d__12<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			object obj4 = enumerator + 32;
			obj4 = assetReference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = enumerator + 40;
			obj5 = parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = enumerator + 48;
			obj6 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static void SetupInstance<T>(GameObject instance, Action<T> callback)
	{
		GameObject gameObject = default(GameObject);
		IEnumerable<object> components = (IEnumerable<object>)(object)gameObject.GetComponents<T>();
		ArraysExtensions.ForEach(components, (Action<object>)(object)callback);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_016a: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D62]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		AssetReferenceGameObject assetReferenceGameObject = address;
		goto IL_011c;
		IL_011c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+B8]");
		object obj6 = 0;
		object runtimeKey = assetReferenceGameObject.RuntimeKey;
		if (runtimeKey != null)
		{
			object obj7 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v9+90]");
			if (runtimeKey != null)
			{
				throw new InvalidCastException();
			}
		}
		bool flag3 = ((Dictionary<object, object>)obj6).Remove(runtimeKey);
		return;
		IL_007c:
		assetReferenceGameObject = address;
		bool flag4 = address == null;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011c;
	}

	static PrefabInitializer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2384;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = obj2;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, AsyncOperationHandle<object>> dictionary2 = default(Dictionary<object, AsyncOperationHandle<object>>);
		dictionary2..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
