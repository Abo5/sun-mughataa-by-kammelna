using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class GraphicHSVColorSetter : AbstractColorSetter
{
	private Graphic graphic;

	private Vector4 HSVa;

	private bool forceOpaque;

	protected override string NameBase => "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3448;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A8E]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				obj5 = graphic;
				obj6 = graphic;
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
				obj5 = graphic;
				obj6 = graphic;
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
			if ((object)graphic != null)
			{
				return graphic.gameObject;
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

	public override void SetColor(Color color)
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_0030: Expected O, but got I
		//IL_003e: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_009e: Expected I, but got O
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GraphicHSVColorSetter)+24]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GraphicHSVColorSetter)+28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GraphicHSVColorSetter)+2C]");
		object obj3 = 0;
		Color color2 = ColorExtension.ApplyHsvMultiplier((Color)0, color);
		Graphic graphic = this.graphic;
		bool flag = !forceOpaque;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			double num = 1.0;
		}
		nint num2 = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v2 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v2 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public GraphicHSVColorSetter()
	{
		//IL_0012: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [71360F0]");
		HSVa = (Vector4)0;
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
