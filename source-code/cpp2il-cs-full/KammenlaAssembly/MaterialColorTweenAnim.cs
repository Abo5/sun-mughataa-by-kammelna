using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class MaterialColorTweenAnim : MaterialTweenAnim
{
	private Color _color;

	public override Tween tween
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0150: Expected O, but got I4
			//IL_01a8: Expected O, but got I4
			//IL_0200: Expected F4, but got O
			//IL_010d: Expected F4, but got O
			//IL_010d: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F8C]");
			object obj3 = (nint)0 & (nint)1;
			string value;
			string value2;
			if (obj3 != null)
			{
				value = propertyName;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				value2 = propertyName;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				value = propertyName;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				value2 = propertyName;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = string.IsNullOrEmpty(value2);
			Graphic renderer = _renderer;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			Graphic renderer2 = _renderer;
			if (obj6 != null)
			{
				goto IL_00cf;
			}
			goto IL_01c0;
			IL_00cf:
			if ((object)renderer != null)
			{
				Material material = renderer.material;
				return ShortcutExtensions.DOColor(material, (Color)0, (float)_color);
			}
			goto IL_0209;
			IL_0209:
			return (Tween)(object)new NullReferenceException();
			IL_01c0:
			if ((object)renderer2 != null)
			{
				Material material2 = renderer2.material;
				return ShortcutExtensions.DOColor(material2, (Color)propertyName, null, (float)_color);
			}
			goto IL_0209;
			IL_0091:
			bool flag5 = string.IsNullOrEmpty(value);
			renderer = _renderer;
			bool flag6 = !flag5;
			renderer2 = _renderer;
			if (!flag6)
			{
				goto IL_00cf;
			}
			goto IL_01c0;
		}
	}
}
