using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StatSlider : MonoBehaviour
{
	private sealed class <>c__DisplayClass9_0
	{
		public StatSlider <>4__this;

		public float lastPrevValue;

		internal void <OnSizeSliderLetGo>b__0()
		{
			//IL_0033: Expected I, but got O
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			StatSlider statSlider = <>4__this;
			Slider slider = statSlider.slider;
			float num = lastPrevValue;
			nint num2 = (nint)slider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X9_v1 (Il2CppClass<UnityEngine.UI.Slider>)+428]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X9_v1 (Il2CppClass<UnityEngine.UI.Slider>)+430]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private Slider slider;

	public UnityEvent<Action> OnSliderLetGo;

	private float prevValue;

	public Slider Slider => slider;

	public float value
	{
		get
		{
			//IL_0017: Expected I, but got O
			//IL_0027: Expected O, but got I
			//IL_0037: Expected O, but got I
			Slider slider = this.slider;
			nint num = (nint)slider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Slider>)+418]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Slider>)+420]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
		set
		{
			//IL_0017: Expected I, but got O
			//IL_0027: Expected O, but got I
			//IL_0037: Expected O, but got I
			Slider slider = this.slider;
			nint num = (nint)slider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Slider>)+428]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Slider>)+430]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public void OnSizeSliderClicked()
	{
		float num = slider.value;
		float num2 = default(float);
		prevValue = num2;
	}

	public void OnSizeSliderLetGo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004d: Expected I, but got O
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_0201: Invalid comparison between F8 and I4
		//IL_0210: Invalid comparison between F8 and I4
		//IL_0223: Expected O, but got F8
		//IL_0230: Expected O, but got F8
		//IL_0265: Expected O, but got I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_00cd: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Slider slider = this.slider;
		nint num = (nint)slider;
		float num2 = slider.value;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj6 = default(object);
		object obj7 = default(object);
		object obj5 = obj6 - obj7;
		bool flag = (nint)obj5 < 0;
		bool flag2 = obj5 == null;
		object obj8 = obj6 ^ obj7;
		object obj9 = obj6 ^ obj5;
		object obj10 = obj8 & obj9;
		bool flag3 = (nint)obj10 < 0;
		bool flag4 = flag == flag3;
		object obj11 = !flag2;
		object obj12 = flag4 & obj11;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
		}
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v7+B8]");
		object obj15 = 0;
		double num3 = (double)obj7 * 897988541.0;
		double num4 = (double)obj15 * 8.0;
		double num5 = num3 - num4;
		bool flag5 = num5 < 0.0;
		bool flag6 = num5 == 0.0;
		object obj16 = num3 ^ num4;
		object obj17 = num3 ^ num5;
		object obj18 = obj16 & obj17;
		bool flag7 = (nint)obj18 < 0;
		bool flag8 = flag5 == flag7;
		object obj19 = !flag6;
		object obj20 = flag8 & obj19;
		object obj21 = ~obj20;
		if (obj21 != null)
		{
			num3 = num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (!(num4 < num3))
		{
			_ = prevValue;
			object obj22 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)1096;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj23);
			((UnityEvent<object>)(object)OnSliderLetGo).Invoke((object)action);
		}
	}
}
