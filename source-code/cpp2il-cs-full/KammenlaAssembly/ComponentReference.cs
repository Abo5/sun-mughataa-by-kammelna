using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

[Serializable]
public sealed class ComponentReference<TComponent> : AssetReference where TComponent : UnityEngine.Component
{
	public ComponentReference(string guid)
		: base(guid)
	{
	}

	public new unsafe AsyncOperationHandle<TComponent> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_009c: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_0167: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_0206: Expected O, but got I4
		//IL_021a: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_0250: Expected O, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0278: Expected O, but got I4
		//IL_02af: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_02cd: Expected I, but got O
		//IL_0302: Expected O, but got Ref
		object obj = 152973312;
		object obj2 = typeof(SqlSingle[]) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E3509]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF000]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ResourceManager resourceManager = Addressables.ResourceManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		ResourceManager resourceManager2 = resourceManager;
		ResourceManager resourceManager3 = resourceManager;
		if (obj7 != null)
		{
			goto IL_00c9;
		}
		goto IL_019f;
		IL_030b:
		return (AsyncOperationHandle<TComponent>)new NullReferenceException();
		IL_01c7:
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 2696;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+B8]");
		object obj10 = 0;
		AsyncOperationHandle<GameObject> asyncOperationHandle = base.InstantiateAsync(position, (Quaternion)0, parent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rotation @ X2 (UnityEngine.Quaternion)+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v9+C0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+8]");
		object obj14 = (nint)0 + (nint)309;
		object obj15 = obj14 & 1;
		bool flag3 = obj15 == null;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rotation @ X2 (UnityEngine.Quaternion)+20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v13+C0]");
		object obj18 = 0;
		Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>> func = default(Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>);
		func..ctor((object)this, (IntPtr)obj18);
		object obj19 = default(object);
		if (resourceManager2 != null)
		{
			return (AsyncOperationHandle<TComponent>)resourceManager2.CreateChainOperation((AsyncOperationHandle<object>)(&obj19), func);
		}
		goto IL_030b;
		IL_00c9:
		bool flag4 = this == null;
		object obj20 = !flag4;
		if (obj20 != null)
		{
			goto IL_01c7;
		}
		goto IL_030b;
		IL_007d:
		ResourceManager resourceManager4 = Addressables.ResourceManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B8]");
		object obj21 = (nint)0 & (nint)1;
		bool flag5 = obj21 == null;
		resourceManager2 = resourceManager4;
		resourceManager3 = resourceManager4;
		if (!flag5)
		{
			goto IL_00c9;
		}
		goto IL_019f;
		IL_019f:
		_ = 1;
		bool flag6 = this == null;
		resourceManager2 = resourceManager3;
		if (!flag6)
		{
			goto IL_01c7;
		}
		goto IL_030b;
	}

	public new unsafe AsyncOperationHandle<TComponent> InstantiateAsync(Transform parent = null, bool instantiateInWorldSpace = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_017d: Expected O, but got I4
		//IL_01ec: Expected O, but got Ref
		object obj = typeof(SqlSingle[]) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E350A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ResourceManager resourceManager = Addressables.ResourceManager;
		if (this != null)
		{
			goto IL_0117;
		}
		goto IL_01f5;
		IL_01f5:
		return (AsyncOperationHandle<TComponent>)new NullReferenceException();
		IL_0117:
		AsyncOperationHandle<GameObject> asyncOperationHandle = base.InstantiateAsync(parent, instantiateInWorldSpace);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6 (Il2CppRgctx<ComponentReference`1>)+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6 (Il2CppRgctx<ComponentReference`1>)+8]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = 0;
		Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>> func = default(Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>);
		func..ctor((object)this, (IntPtr)method);
		object obj9 = default(object);
		if (resourceManager != null)
		{
			return (AsyncOperationHandle<TComponent>)resourceManager.CreateChainOperation((AsyncOperationHandle<object>)(&obj9), func);
		}
		goto IL_01f5;
		IL_0074:
		resourceManager = Addressables.ResourceManager;
		bool flag3 = this == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0117;
		}
		goto IL_01f5;
	}

	public unsafe AsyncOperationHandle<TComponent> LoadAssetAsync()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_0123: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0159: Expected O, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_01f0: Expected O, but got Ref
		object obj = typeof(SqlSingle[]) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E350B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ResourceManager resourceManager = Addressables.ResourceManager;
		if (this != null)
		{
			goto IL_0117;
		}
		goto IL_01f9;
		IL_01f9:
		return (AsyncOperationHandle<TComponent>)new NullReferenceException();
		IL_0117:
		object obj5 = (nint)0 + (nint)3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E2C8");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8 (Il2CppRgctx<ComponentReference`1>)+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8 (Il2CppRgctx<ComponentReference`1>)+8]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = 0;
		Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>> func = default(Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>);
		func..ctor((object)this, (IntPtr)method);
		object obj10 = default(object);
		if (resourceManager != null)
		{
			return (AsyncOperationHandle<TComponent>)resourceManager.CreateChainOperation((AsyncOperationHandle<object>)(&obj10), func);
		}
		goto IL_01f9;
		IL_0074:
		resourceManager = Addressables.ResourceManager;
		bool flag3 = this == null;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_0117;
		}
		goto IL_01f9;
	}

	private unsafe AsyncOperationHandle<TComponent> GameObjectReady(AsyncOperationHandle<GameObject> arg)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		object result = ((AsyncOperationHandle<object>*)arg)->Result;
		if (result != null)
		{
			object obj = typeof(SqlSingle[]) + 3048;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ResourceManager resourceManager = Addressables.ResourceManager;
			if (resourceManager != null)
			{
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v8+90]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9+B8]");
				object errorMsg = 0;
				object result2 = default(object);
				return (AsyncOperationHandle<TComponent>)resourceManager.CreateCompletedOperation(result2, (string)errorMsg);
			}
		}
		return (AsyncOperationHandle<TComponent>)new NullReferenceException();
	}

	public override bool ValidateAsset(UnityEngine.Object obj)
	{
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_016b: Expected I4, but got O
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag = (object)obj == null;
		UnityEngine.Object obj3 = obj;
		if (!flag)
		{
			object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			obj3 = ((obj != obj4) ? null : obj);
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v2+E4]");
		bool flag2;
		if ((nint)0 != 0)
		{
			flag2 = obj3 != null;
			bool flag3 = !flag2;
			object obj6 = 0;
			if (!flag3)
			{
				goto IL_007f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag2 = obj3 != null;
			bool flag4 = !flag2;
			object obj7 = !flag4;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_007f;
			}
		}
		return flag2;
		IL_007f:
		if ((object)obj3 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7+E4]");
			UnityEngine.Object obj9 = default(UnityEngine.Object);
			if ((nint)0 != 0)
			{
				return obj9 != null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return obj9 != null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override bool ValidateAsset(string path)
	{
		return false;
	}

	public unsafe void ReleaseInstance(AsyncOperationHandle<TComponent> op)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = 0;
		object result = ((AsyncOperationHandle<object>*)op)->Result;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(SqlSingle[]) + 3048;
		bool flag2 = (UnityEngine.Object)result != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			GameObject gameObject = ((UnityEngine.Component)result).gameObject;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = Addressables.ReleaseInstance(gameObject);
			obj5 = null;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F36D54");
	}
}
