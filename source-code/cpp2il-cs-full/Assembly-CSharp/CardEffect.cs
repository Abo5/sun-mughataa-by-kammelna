using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class CardEffect : MonoBehaviour
{
	public AudioSource source;

	public AudioClip clip;

	public float duratin;

	private static readonly int Dissolve;

	public Material material;

	public void PlayEffect()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004c: Expected O, but got I4
		//IL_0062: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_00ea: Expected I4, but got O
		//IL_0114: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_01fa: Expected I4, but got O
		//IL_01af: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 320;
		source.PlayOneShot(clip);
		int num = ShortcutExtensions.DOKill(this.material);
		object obj2 = 152961024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E00AF]");
		object obj3 = (nint)0 & (nint)1;
		Material material;
		Material material2;
		if (obj3 != null)
		{
			material = this.material;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			material2 = this.material;
			if (!flag)
			{
				goto IL_00c0;
			}
		}
		else
		{
			_ = 1;
			material = this.material;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			material2 = this.material;
			if (obj5 != null)
			{
				goto IL_00c0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = (object)material2 == null;
		object obj6 = !flag3;
		material = material2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c0;
		IL_00c0:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+B8]");
		object obj8 = 0;
		material.SetFloat((int)obj8, 0f);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+B8]");
		object obj11 = 0;
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(this.material, 1f, (int)obj11, duratin);
	}

	public void Reset()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00b2: Expected I4, but got O
		//IL_0129: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E00AF]");
		object obj2 = (nint)0 & (nint)1;
		Material material;
		Material material2;
		if (obj2 != null)
		{
			material = this.material;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			material2 = this.material;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			material = this.material;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			material2 = this.material;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = (object)material2 == null;
		object obj5 = !flag3;
		material = material2;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0088;
		IL_0088:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+B8]");
		object obj7 = 0;
		material.SetFloat((int)obj7, 0f);
	}

	static CardEffect()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0055: Expected O, but got I4
		object obj = "[{0}]:{1}" + 2888;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 320;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = num;
	}
}
