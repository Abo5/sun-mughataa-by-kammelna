using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class ParticleSystemRandomColorSetter : AbstractColorSetter
{
	private ParticleSystem particleSystem;

	private Vector4 HSVa1;

	private Vector4 HSVa2;

	protected override string NameBase => "October" + 3288;

	protected override GameObject Target
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011b: Expected O, but got I4
			//IL_0170: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A92]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				obj5 = particleSystem;
				obj6 = particleSystem;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = particleSystem;
				obj6 = particleSystem;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_017e;
			IL_00b8:
			if ((object)particleSystem != null)
			{
				return particleSystem.gameObject;
			}
			return (GameObject)(object)new NullReferenceException();
			IL_017e:
			return null;
			IL_0091:
			if (obj5 != null)
			{
				goto IL_00b8;
			}
			goto IL_017e;
		}
	}

	public unsafe override void SetColor(Color color)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0030: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_005e: Expected O, but got I
		//IL_005e: Expected O, but got I4
		//IL_0071: Expected O, but got Ref
		//IL_007e: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		ParticleSystem.MainModule main = particleSystem.main;
		Color color2 = ColorExtension.ApplyHsvMultiplier((Color)0, (Vector4)0);
		Color color3 = ColorExtension.ApplyHsvMultiplier((Color)0, (Vector4)0);
		IntPtr intPtr = default(IntPtr);
		ParticleSystem.MinMaxGradient minMaxGradient = new ParticleSystem.MinMaxGradient((Color)0, (Color)(nint)intPtr);
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		ParticleSystem.MinMaxGradient minMaxGradient2 = default(ParticleSystem.MinMaxGradient);
		((ParticleSystem.MainModule*)mainModule)->startColor = (ParticleSystem.MinMaxGradient)(&minMaxGradient2);
		particleSystem.Clear();
		particleSystem.Play();
	}

	public ParticleSystemRandomColorSetter()
	{
		//IL_0012: Expected O, but got I
		//IL_0024: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [71360F0]");
		HSVa1 = (Vector4)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [71360F0]");
		HSVa2 = (Vector4)0;
		((object)this)..ctor();
		object format = "utf-32" + 3720;
		string nameBase = NameBase;
		object target = Target;
		string text = string.Format((string)format, nameBase, target);
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
