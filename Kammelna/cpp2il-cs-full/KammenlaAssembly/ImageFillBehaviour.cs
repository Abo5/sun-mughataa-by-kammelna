using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ImageFillBehaviour : FillBehaviour
{
	private Image fill;

	private bool configureImage;

	private Image.FillMethod fillMethod;

	private int fillOrigin;

	private bool configured;

	private bool ShowNotFilledWarning
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0121: Expected I4, but got O
			//IL_00f4: Expected O, but got I4
			bool flag;
			if (configureImage)
			{
				flag = false;
			}
			else
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					flag = fill;
					if (flag)
					{
						goto IL_00b8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					flag = fill;
					if (flag)
					{
						goto IL_00b8;
					}
				}
			}
			return flag;
			IL_00b8:
			Image image = fill;
			if ((object)fill != null)
			{
				object obj3 = image.m_Type - 3;
				bool flag2 = obj3 == null;
				return !flag2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override string EditorLabel
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_0188: Expected O, but got I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_01d8: Expected O, but got I4
			//IL_022c: Expected O, but got I4
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B84]");
			object obj = (nint)0 & (nint)1;
			Image image;
			object obj2;
			object obj4;
			Image image2;
			if (obj != null)
			{
				image = fill;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				obj4 = obj2;
				image2 = fill;
				if (!flag)
				{
					goto IL_0096;
				}
			}
			else
			{
				_ = 1;
				image = fill;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				obj4 = obj2;
				image2 = fill;
				if (obj6 != null)
				{
					goto IL_0096;
				}
			}
			_ = 1;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			UnityEngine.Object obj9 = image2;
			UnityEngine.Object obj10 = image2;
			if (obj8 != null)
			{
				goto IL_00d3;
			}
			goto IL_01f6;
			IL_026c:
			object obj11 = "HH:mm:ss.ffZ" + 3600;
			string text;
			return (string)obj11 + text;
			IL_00fd:
			if ((object)obj9 != null)
			{
				string name = obj9.name;
				text = name;
				goto IL_026c;
			}
			return (string)(object)new NullReferenceException();
			IL_0242:
			object obj12 = "Network Authentication Required" + 1600;
			text = (string)obj12;
			goto IL_026c;
			IL_0096:
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			obj9 = image;
			obj10 = image;
			if (!flag4)
			{
				goto IL_00d3;
			}
			goto IL_01f6;
			IL_01f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj10;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			obj9 = obj10;
			if (obj13 != null)
			{
				goto IL_00fd;
			}
			goto IL_0242;
			IL_00d3:
			if ((bool)obj9)
			{
				goto IL_00fd;
			}
			goto IL_0242;
		}
	}

	public override void SetImmediate([In] ref ProgressState state)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0225: Expected O, but got I4
		//IL_00cb: Expected F4, but got O
		//IL_0279: Expected O, but got I4
		//IL_010f: Invalid comparison between F8 and I4
		//IL_011e: Invalid comparison between F8 and I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01c5: Expected F4, but got O
		//IL_0292: Invalid comparison between F4 and I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_01d3: Expected F4, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B14]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = fill;
			obj6 = fill;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		Configure();
		float num = (float)state;
		if (base.remap)
		{
			double num2 = (double)state - 1.0;
			bool flag5 = num2 < 0.0;
			bool flag6 = num2 == 0.0;
			object obj9 = state ^ 1.0;
			object obj10 = state ^ num2;
			object obj11 = obj9 & obj10;
			bool flag7 = (nint)obj11 < 0;
			bool flag8 = flag5 == flag7;
			object obj12 = !flag6;
			object obj13 = flag8 & obj12;
			object obj14 = ~obj13;
			float num3 = ((obj14 != null) ? ((float)state) : 1f);
			float num4 = ((!(num < 0f)) ? num3 : 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ImageFillBehaviour)+18]");
			object obj15 = 0 - base.remapRange;
			float num5 = num4 * (float)obj15;
			num = (float)base.remapRange + num5;
		}
		fill.fillAmount = num;
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
		}
	}

	public override void AnimateFromZero([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0234: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_00e0: Expected F4, but got O
		//IL_02b1: Expected O, but got I
		//IL_0124: Invalid comparison between F8 and I4
		//IL_0133: Invalid comparison between F8 and I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01da: Expected F4, but got O
		//IL_02c5: Invalid comparison between F4 and I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_01e8: Expected F4, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B15]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = fill;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = fill;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		Configure();
		fill.fillAmount = 0f;
		float num = (float)state;
		if (base.remap)
		{
			double num2 = (double)state - 1.0;
			bool flag5 = num2 < 0.0;
			bool flag6 = num2 == 0.0;
			object obj9 = state ^ 1.0;
			object obj10 = state ^ num2;
			object obj11 = obj9 & obj10;
			bool flag7 = (nint)obj11 < 0;
			bool flag8 = flag5 == flag7;
			object obj12 = !flag6;
			object obj13 = flag8 & obj12;
			object obj14 = ~obj13;
			float num3 = ((obj14 != null) ? ((float)state) : 1f);
			float num4 = ((!(num < 0f)) ? num3 : 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ImageFillBehaviour)+18]");
			object obj15 = 0 - base.remapRange;
			float num5 = num4 * (float)obj15;
			num = (float)base.remapRange + num5;
		}
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(fill, num, duration);
		object obj16 = (nint)0 + (nint)2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
		}
	}

	public override void AnimateFromCurrent([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_022b: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00d7: Expected F4, but got O
		//IL_0275: Expected O, but got I4
		//IL_011b: Invalid comparison between F8 and I4
		//IL_012a: Invalid comparison between F8 and I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01d1: Expected F4, but got O
		//IL_02b0: Invalid comparison between F4 and I4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_01df: Expected F4, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B16]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = fill;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = fill;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		object obj9 = (nint)0 + (nint)2864;
		Configure();
		float num = (float)state;
		if (base.remap)
		{
			double num2 = (double)state - 1.0;
			bool flag5 = num2 < 0.0;
			bool flag6 = num2 == 0.0;
			object obj10 = state ^ 1.0;
			object obj11 = state ^ num2;
			object obj12 = obj10 & obj11;
			bool flag7 = (nint)obj12 < 0;
			bool flag8 = flag5 == flag7;
			object obj13 = !flag6;
			object obj14 = flag8 & obj13;
			object obj15 = ~obj14;
			float num3 = ((obj15 != null) ? ((float)state) : 1f);
			float num4 = ((!(num < 0f)) ? num3 : 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ImageFillBehaviour)+18]");
			object obj16 = 0 - base.remapRange;
			float num5 = num4 * (float)obj16;
			num = (float)base.remapRange + num5;
		}
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(fill, num, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
		}
	}

	public override void Kill()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B17]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = fill;
			obj6 = fill;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		int num = ShortcutExtensions.DOKill(fill);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void Configure()
	{
		//IL_001c: Expected O, but got I4
		bool flag = !configured;
		object obj = !flag;
		if (obj == null && configureImage)
		{
			configured = configureImage;
			fill.type = Image.Type.Filled;
			fill.fillMethod = fillMethod;
			fill.fillOrigin = fillOrigin;
		}
	}

	public ImageFillBehaviour()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DDA10]");
		base.remapRange = (Vector2)0;
		((object)this)..ctor();
	}
}
