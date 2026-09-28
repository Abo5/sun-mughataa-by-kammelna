using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using DG.Tweening;
using UI.Mutations;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

[Serializable]
public class CompletionBehaviour : ProgressBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public CompletionBehaviour <>4__this;

		public bool complete;

		internal void <Defer>b__0()
		{
			<>4__this.Apply(complete);
		}
	}

	private IMutation mutation;

	private Tween deferred;

	public override string EditorLabel
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0085: Expected O, but got I
			object obj = "October" + 240;
			if (mutation != null)
			{
				Type type = mutation.GetType();
				if ((object)type != null)
				{
					string name = type.Name;
					if (name != null)
					{
						object oldValue = "Material with texture name \"" + 3088;
						object newValue = (nint)0 + (nint)2000;
						string text = name.Replace((string)oldValue, (string)newValue);
						return (string)obj + text;
					}
				}
				return (string)(object)new NullReferenceException();
			}
			object obj2 = "Network Authentication Required" + 1600;
			return (string)obj + (string)obj2;
		}
	}

	public override void Setup(GameObject owner)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		IMutation mutation = this.mutation;
		if (this.mutation == null)
		{
			return;
		}
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
		nint num = (nint)mutation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v5-8]");
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
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		goto IL_012a;
		IL_012a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v171 @ X0_v2] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_012a;
	}

	public override void Teardown()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		while (true)
		{
			IMutation mutation = this.mutation;
			if (this.mutation == null)
			{
				break;
			}
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			nint num = (nint)mutation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v4-8]");
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
				object obj4 = obj3 + 1;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
				continue;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v89 @ X0_v3] (should have been resolved before IL gen)");
			break;
		}
	}

	public override void SetImmediate([In] ref ProgressState state)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+C]");
		Apply(complete: false);
	}

	public override void AnimateFromZero([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		IMutation mutation = this.mutation;
		if (this.mutation != null)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
			nint num = (nint)mutation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<UI.Mutations.IMutation>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v6-8]");
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
			object obj4 = obj3 + 3;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0137;
		}
		goto IL_0146;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v167 @ X0_v4] (should have been resolved before IL gen)");
		goto IL_0146;
		IL_0146:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+C]");
		Defer(complete: false, duration);
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0137;
	}

	public override void AnimateFromCurrent([In] ref ProgressState state, float duration, Ease ease)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+C]");
		Defer(complete: false, duration);
	}

	public override void Kill()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		object obj = this + 32;
		if (obj != null)
		{
			TweenExtensions.Kill((Tween)obj);
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Defer(bool complete, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj4 = (nint)0 + (nint)1280;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj4);
		Tween tween = DOVirtual.DelayedCall(duration, tweenCallback);
		object obj6 = this + 32;
		obj6 = tween;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Apply(bool complete)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_011a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		IMutation mutation = this.mutation;
		if (this.mutation == null)
		{
			return;
		}
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3936;
		nint num = (nint)mutation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
		object obj2 = 0;
		object obj4;
		if (complete)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v11-8]");
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
				goto IL_00c6;
			}
			obj4 = obj3 + 2;
			goto IL_021e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_015b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<UI.Mutations.IMutation>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		goto IL_01fa;
		IL_01e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v218 @ X0_v5] (should have been resolved before IL gen)");
		goto IL_01fa;
		IL_015b:
		object obj6 = 3;
		IMutation mutation2 = this.mutation;
		goto IL_01e6;
		IL_021e:
		object obj7 = num + obj4;
		object obj8 = obj7 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v246 @ X0_v2] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_01fa:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_015b;
		}
		obj4 = obj5 + 3;
		goto IL_021e;
		IL_00c6:
		obj6 = 2;
		mutation2 = this.mutation;
		goto IL_01e6;
	}
}
