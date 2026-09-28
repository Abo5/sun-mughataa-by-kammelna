using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressReference<TComponent> : IKeyEvaluator where TComponent : Component
{
	private readonly string _address;

	public object RuntimeKey => _address;

	public AddressReference(string address)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = address;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void ValidateAddress()
	{
	}

	private void OnDelayCall()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E3FC0]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isPlaying = Application.isPlaying;
		return;
		IL_0074:
		bool isPlaying2 = Application.isPlaying;
	}

	public bool RuntimeKeyIsValid()
	{
		return true;
	}

	public static implicit operator AddressReference<TComponent>(string s)
	{
		//IL_000c: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_0154: Expected I, but got O
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		//IL_0192: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		if (obj2 != null)
		{
			nint num = 0;
			nint num2 = num;
			object obj3 = num + 309;
			object obj4 = obj3 & 1;
			bool flag = obj4 == null;
			nint num3 = num;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X0_v6+C0]");
			object obj5 = 0;
			nint num2 = (nint)obj5;
			object obj6 = obj5 + 309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			nint num3 = (nint)obj5;
			if (obj8 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj12 = default(object);
		object obj11 = obj12;
		nint num4 = 0;
		if (flag3)
		{
			goto IL_00e8;
		}
		object obj13 = obj12;
		goto IL_00ff;
		IL_00e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj13 = obj11;
		goto IL_00ff;
		IL_0086:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)309;
		object obj15 = obj14 & 1;
		bool flag4 = obj15 == null;
		object obj16 = !flag4;
		object obj17 = default(object);
		obj11 = obj17;
		num4 = 0;
		obj13 = obj17;
		if (obj16 == null)
		{
			goto IL_00e8;
		}
		goto IL_00ff;
		IL_00ff:
		obj13..ctor();
		object obj18 = obj13 + 16;
		obj18 = s;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (AddressReference<TComponent>)obj13;
	}
}
