using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class MaterialFloatPropertyController : MonoBehaviour
{
	private Graphic graphic;

	public string propertyName;

	public float value;

	private bool instantiateMaterial;

	private Material material
	{
		get
		{
			//IL_0031: Expected I, but got O
			Graphic graphic = this.graphic;
			if ((object)this.graphic != null)
			{
				nint num = (nint)graphic;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+338] (should have been resolved before IL gen)");
			}
			return (Material)(object)new NullReferenceException();
		}
		set
		{
			//IL_0017: Expected I, but got O
			//IL_0027: Expected O, but got I
			//IL_0037: Expected O, but got I
			Graphic graphic = this.graphic;
			nint num = (nint)graphic;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+348]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+350]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private void Awake()
	{
		//IL_001c: Expected I, but got O
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0067: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_008c: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_00ac: Expected O, but got I
		if (instantiateMaterial)
		{
			Graphic graphic = this.graphic;
			nint num = (nint)graphic;
			Material material = graphic.material;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
			Graphic graphic2 = this.graphic;
			nint num2 = (nint)graphic2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v11 (Il2CppClass<UnityEngine.UI.Graphic>)+348]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v11 (Il2CppClass<UnityEngine.UI.Graphic>)+350]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void Update()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_00df: Expected O, but got I4
		Graphic graphic = this.graphic;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)graphic;
		UnityEngine.Object obj2 = graphic.material;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!(obj2 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = obj2 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		Material material = this.graphic.material;
		material.SetFloat(propertyName, value);
	}
}
