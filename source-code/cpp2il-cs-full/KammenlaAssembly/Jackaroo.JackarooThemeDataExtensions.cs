using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

namespace Jackaroo;

public static class JackarooThemeDataExtensions
{
	public unsafe static JackarooThemeData With(JackarooThemeData source, JackarooThemeData other)
	{
		//IL_0008: Expected O, but got Ref
		//IL_001a: Expected O, but got I
		//IL_003b: Expected O, but got Ref
		//IL_0043: Expected native int or pointer, but got O
		//IL_0068: Expected O, but got Ref
		//IL_0070: Expected native int or pointer, but got O
		//IL_009a: Expected O, but got Ref
		//IL_00a2: Expected native int or pointer, but got O
		//IL_00c7: Expected O, but got Ref
		//IL_00cf: Expected native int or pointer, but got O
		//IL_00ed: Expected O, but got Ref
		//IL_00fa: Expected native int or pointer, but got O
		//IL_011f: Expected O, but got Ref
		//IL_0127: Expected native int or pointer, but got O
		//IL_0151: Expected O, but got Ref
		//IL_0159: Expected native int or pointer, but got O
		//IL_01eb: Expected O, but got Ref
		//IL_01eb: Expected O, but got Ref
		//IL_01eb: Expected O, but got Ref
		//IL_01eb: Expected O, but got I
		//IL_01eb: Expected O, but got Ref
		//IL_01eb: Expected O, but got Ref
		//IL_01eb: Expected O, but got Ref
		//IL_01eb: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		if (other != null)
		{
			object value = (nint)0 + (nint)2112;
			_ = 0;
			_ = 0;
			_ = 0;
			Color? color = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
			*(Color?*)(nint)color = (Color)value;
			_ = 0;
			_ = 0;
			_ = 0;
			Color? color2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
			*(Color?*)(nint)color2 = (Color)value;
			_ = 0;
			_ = 0;
			_ = 0;
			Color? color3 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 168));
			*(Color?*)(nint)color3 = (Color)value;
			_ = 0;
			_ = 0;
			_ = 0;
			Color? color4 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 192));
			*(Color?*)(nint)color4 = (Color)value;
			_ = 0;
			bool? flag = (bool?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 194));
			*(bool?*)(nint)flag = other.<ColorizeNodes>k__BackingField;
			_ = 0;
			_ = 0;
			_ = 0;
			Color? color5 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 216));
			*(Color?*)(nint)color5 = (Color)value;
			_ = 0;
			_ = 0;
			_ = 0;
			Color? color6 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 240));
			*(Color?*)(nint)color6 = (Color)value;
			Color? color7 = (Color)value;
			bool? highlightLastNode = other.<HighlightLastNode>k__BackingField;
			Sprite <BoardSprite>k__BackingField = other.<BoardSprite>k__BackingField;
			Sprite <BottomMarble>k__BackingField = other.<BottomMarble>k__BackingField;
			Sprite <LeftMarble>k__BackingField = other.<LeftMarble>k__BackingField;
			Sprite <TopMarble>k__BackingField = other.<TopMarble>k__BackingField;
			Sprite <RightMarble>k__BackingField = other.<RightMarble>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C2]");
			object obj3 = default(object);
			object obj4 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
			object obj7 = default(object);
			object obj8 = default(object);
			object obj9 = default(object);
			return With(source, (Color?)(object)(&obj3), (Color?)(object)(&obj4), (Color?)(object)(&obj5), (Color?)(object)(&obj6), <BoardSprite>k__BackingField, <BottomMarble>k__BackingField, <LeftMarble>k__BackingField, <TopMarble>k__BackingField, <RightMarble>k__BackingField, (bool?)(object)0, (Color?)(object)(&obj7), (Color?)(object)(&obj8), (Color?)(object)(&obj9), highlightLastNode);
		}
		return (JackarooThemeData)(object)new NullReferenceException();
	}

	public unsafe static JackarooThemeData With(JackarooThemeData source, Color? bottom = null, Color? left = null, Color? top = null, Color? right = null, Sprite boardSprite = null, Sprite bottomMarble = null, Sprite leftMarble = null, Sprite topMarble = null, Sprite rightMarble = null, bool? colorizeNodes = null, Color? nodeDefaultColor = null, Color? nodeSelectedColor = null, Color? highlightDefaultColor = null, bool? highlightLastNode = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_1646: Unknown result type (might be due to invalid IL or missing references)
		//IL_164b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected O, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_0923: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_09ee: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected O, but got Unknown
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected O, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected O, but got Unknown
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Expected O, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_0ad9: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected O, but got Unknown
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b80: Expected O, but got Unknown
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected O, but got Unknown
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0bd6: Expected O, but got I4
		//IL_0ca8: Expected O, but got I4
		//IL_0d87: Expected O, but got I4
		//IL_04bd: Expected O, but got I
		//IL_0e64: Expected O, but got I
		//IL_0e86: Expected O, but got I4
		//IL_0592: Expected O, but got I
		//IL_0f6b: Expected O, but got I
		//IL_0f8d: Expected O, but got I4
		//IL_0667: Expected O, but got I
		//IL_067d: Expected O, but got I
		//IL_107a: Expected O, but got I
		//IL_1090: Expected O, but got I
		//IL_10aa: Expected O, but got I4
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected I4, but got Unknown
		//IL_076e: Expected O, but got I
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_119f: Expected O, but got I
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_11c7: Expected O, but got I4
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected O, but got Unknown
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c3: Expected O, but got Unknown
		//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d1: Expected O, but got Unknown
		//IL_12da: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected O, but got Unknown
		//IL_1678: Expected O, but got I
		//IL_1681: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686: Expected O, but got Unknown
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a2: Expected O, but got Unknown
		//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b0: Expected O, but got Unknown
		//IL_13b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13be: Expected O, but got Unknown
		//IL_13c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cc: Expected O, but got Unknown
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fc: Expected O, but got Unknown
		//IL_1405: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Expected O, but got Unknown
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_1418: Expected O, but got Unknown
		//IL_1421: Unknown result type (might be due to invalid IL or missing references)
		//IL_1426: Expected O, but got Unknown
		//IL_16b3: Expected O, but got I
		//IL_16bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c1: Expected O, but got Unknown
		//IL_1434: Unknown result type (might be due to invalid IL or missing references)
		//IL_1439: Expected O, but got Unknown
		//IL_1442: Unknown result type (might be due to invalid IL or missing references)
		//IL_1447: Expected O, but got Unknown
		//IL_1450: Unknown result type (might be due to invalid IL or missing references)
		//IL_1455: Expected O, but got Unknown
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected O, but got Unknown
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Expected O, but got Unknown
		//IL_149c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a1: Expected O, but got Unknown
		//IL_14aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14af: Expected O, but got Unknown
		//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bd: Expected O, but got Unknown
		//IL_16f4: Expected O, but got I
		//IL_14d8: Expected O, but got I
		//IL_14e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e6: Expected I4, but got Unknown
		//IL_1720: Unknown result type (might be due to invalid IL or missing references)
		//IL_1725: Expected O, but got Unknown
		//IL_1791: Unknown result type (might be due to invalid IL or missing references)
		//IL_1796: Expected O, but got Unknown
		//IL_1563: Unknown result type (might be due to invalid IL or missing references)
		//IL_1568: Expected O, but got Unknown
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_1588: Expected O, but got Unknown
		//IL_15a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ad: Expected O, but got Unknown
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = (??)bottom & 1;
		object obj13;
		object obj14;
		object obj15;
		object obj16;
		object obj11;
		object obj10;
		object obj9;
		object obj8;
		if (obj3 != null)
		{
			object obj4 = (??)bottom + 16;
			object obj5 = (??)bottom + 12;
			object obj6 = (??)bottom + 8;
			object obj7 = (??)bottom + 4;
			obj8 = obj4;
			obj9 = obj5;
			obj10 = obj6;
			obj11 = obj7;
			object obj12 = (??)left & 1;
			bool flag = obj12 == null;
			obj13 = obj7;
			obj14 = obj6;
			obj15 = obj5;
			obj16 = obj4;
			if (!flag)
			{
				goto IL_00b0;
			}
		}
		else
		{
			if (source == null)
			{
				goto IL_162f;
			}
			object obj17 = source + 16;
			object obj18 = source + 20;
			object obj19 = source + 24;
			object obj20 = source + 28;
			obj8 = obj20;
			obj9 = obj19;
			obj10 = obj18;
			obj11 = obj17;
			object obj21 = (??)left & 1;
			bool flag2 = obj21 == null;
			object obj22 = !flag2;
			obj13 = obj17;
			obj14 = obj18;
			obj15 = obj19;
			obj16 = obj20;
			if (obj22 != null)
			{
				goto IL_00b0;
			}
		}
		object obj27;
		object obj28;
		object obj29;
		object obj30;
		object obj33;
		object obj34;
		object obj35;
		object obj36;
		if (source != null)
		{
			object obj23 = source + 32;
			object obj24 = source + 36;
			object obj25 = source + 40;
			object obj26 = source + 44;
			obj27 = obj26;
			obj28 = obj25;
			obj29 = obj24;
			obj30 = obj23;
			object obj31 = (??)top & 1;
			bool flag3 = obj31 == null;
			object obj32 = !flag3;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			obj33 = obj23;
			obj34 = obj24;
			obj35 = obj25;
			obj36 = obj26;
			if (obj32 != null)
			{
				goto IL_0173;
			}
			goto IL_0a3c;
		}
		goto IL_162f;
		IL_0582:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+18]");
		Sprite sprite = (Sprite)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+18]");
		bool flag4 = (nint)0 == 0;
		object obj38;
		object obj37 = obj38;
		object obj40;
		object obj39 = obj40;
		object obj42;
		object obj41 = obj42;
		object obj44;
		object obj43 = obj44;
		object obj46;
		object obj45 = obj46;
		object obj48;
		object obj47 = obj48;
		object obj50;
		object obj49 = obj50;
		object obj52;
		object obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		Sprite sprite3;
		Sprite sprite2 = sprite3;
		Sprite sprite5;
		Sprite sprite4 = sprite5;
		Sprite sprite7;
		Sprite sprite6 = sprite7;
		Sprite sprite9;
		Sprite sprite8 = sprite9;
		if (!flag4)
		{
			goto IL_0657;
		}
		goto IL_1040;
		IL_1040:
		object obj53;
		Sprite sprite10;
		if (source != null)
		{
			sprite = source.<RightMarble>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+20]");
			obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+20]");
			object obj54 = (nint)0 & (nint)1;
			bool flag5 = obj54 == null;
			object obj55 = !flag5;
			obj38 = obj37;
			obj40 = obj39;
			obj42 = obj41;
			obj44 = obj43;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			sprite3 = sprite2;
			sprite5 = sprite4;
			sprite7 = sprite6;
			sprite9 = sprite8;
			sprite10 = source.<RightMarble>k__BackingField;
			if (obj55 != null)
			{
				goto IL_0742;
			}
			goto IL_1165;
		}
		goto IL_162f;
		IL_162f:
		return (JackarooThemeData)(object)new NullReferenceException();
		IL_0f31:
		if (source != null)
		{
			sprite3 = source.<TopMarble>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+18]");
			sprite = (Sprite)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+18]");
			bool flag6 = (nint)0 == 0;
			object obj56 = !flag6;
			obj38 = obj37;
			obj40 = obj39;
			obj42 = obj41;
			obj44 = obj43;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			sprite5 = sprite4;
			sprite7 = sprite6;
			sprite9 = sprite8;
			sprite2 = source.<TopMarble>k__BackingField;
			if (obj56 != null)
			{
				goto IL_0657;
			}
			goto IL_1040;
		}
		goto IL_162f;
		IL_0849:
		object obj58;
		object obj57 = obj58 + 16;
		object obj59 = obj58 + 12;
		object obj60 = obj58 + 8;
		object obj61 = obj58 + 4;
		goto IL_1668;
		IL_00b0:
		object obj62 = (??)left + 16;
		object obj63 = (??)left + 12;
		object obj64 = (??)left + 8;
		object obj65 = (??)left + 4;
		obj27 = obj62;
		obj28 = obj63;
		obj29 = obj64;
		obj30 = obj65;
		object obj66 = (??)top & 1;
		bool flag7 = obj66 == null;
		obj33 = obj65;
		obj34 = obj64;
		obj35 = obj63;
		obj36 = obj62;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		if (!flag7)
		{
			goto IL_0173;
		}
		goto IL_0a3c;
		IL_0a3c:
		if (source != null)
		{
			object obj67 = source + 48;
			object obj68 = source + 52;
			object obj69 = source + 56;
			object obj70 = source + 60;
			obj52 = obj70;
			obj50 = obj69;
			obj48 = obj68;
			obj46 = obj67;
			object obj71 = (??)right & 1;
			bool flag8 = obj71 == null;
			object obj72 = !flag8;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			obj45 = obj67;
			obj47 = obj68;
			obj49 = obj69;
			obj51 = obj70;
			if (obj72 != null)
			{
				goto IL_0256;
			}
			goto IL_0b47;
		}
		goto IL_162f;
		IL_0657:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+20]");
		obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+20]");
		object obj73 = (nint)0 & (nint)1;
		bool flag9 = obj73 == null;
		obj37 = obj38;
		obj39 = obj40;
		obj41 = obj42;
		obj43 = obj44;
		obj45 = obj46;
		obj47 = obj48;
		obj49 = obj50;
		obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		sprite10 = sprite;
		sprite2 = sprite3;
		sprite4 = sprite5;
		sprite6 = sprite7;
		sprite8 = sprite9;
		if (!flag9)
		{
			goto IL_0742;
		}
		goto IL_1165;
		IL_0173:
		object obj74 = (??)top + 16;
		object obj75 = (??)top + 12;
		object obj76 = (??)top + 8;
		object obj77 = (??)top + 4;
		obj52 = obj74;
		obj50 = obj75;
		obj48 = obj76;
		obj46 = obj77;
		object obj78 = (??)right & 1;
		bool flag10 = obj78 == null;
		obj45 = obj77;
		obj47 = obj76;
		obj49 = obj75;
		obj51 = obj74;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		if (!flag10)
		{
			goto IL_0256;
		}
		goto IL_0b47;
		IL_0b47:
		if (source != null)
		{
			object obj79 = source + 64;
			object obj80 = source + 68;
			object obj81 = source + 72;
			object obj82 = source + 76;
			obj44 = obj82;
			obj42 = obj81;
			obj40 = obj80;
			obj38 = obj79;
			bool flag11 = (object)boardSprite == null;
			object obj83 = !flag11;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			obj37 = obj79;
			obj39 = obj80;
			obj41 = obj81;
			obj43 = obj82;
			if (obj83 != null)
			{
				goto IL_034b;
			}
			goto IL_0c64;
		}
		goto IL_162f;
		IL_1165:
		bool flag13;
		bool <ColorizeNodes>k__BackingField;
		if (source != null)
		{
			<ColorizeNodes>k__BackingField = source.<ColorizeNodes>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+28]");
			obj58 = 0;
			object obj84 = obj58 & 1;
			bool flag12 = obj84 == null;
			object obj85 = !flag12;
			obj38 = obj37;
			obj40 = obj39;
			obj42 = obj41;
			obj44 = obj43;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			sprite = sprite10;
			sprite3 = sprite2;
			sprite5 = sprite4;
			sprite7 = sprite6;
			sprite9 = sprite8;
			flag13 = source.<ColorizeNodes>k__BackingField;
			if (obj85 != null)
			{
				goto IL_0849;
			}
			goto IL_128a;
		}
		goto IL_162f;
		IL_0256:
		object obj86 = (??)right + 16;
		object obj87 = (??)right + 12;
		object obj88 = (??)right + 8;
		object obj89 = (??)right + 4;
		obj44 = obj86;
		obj42 = obj87;
		obj40 = obj88;
		obj38 = obj89;
		bool flag14 = (object)boardSprite == null;
		obj37 = obj89;
		obj39 = obj88;
		obj41 = obj87;
		obj43 = obj86;
		obj45 = obj46;
		obj47 = obj48;
		obj49 = obj50;
		obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		if (!flag14)
		{
			goto IL_034b;
		}
		goto IL_0c64;
		IL_0c64:
		if (source != null)
		{
			sprite5 = source.<BoardSprite>k__BackingField;
			bool flag15 = (object)bottomMarble == null;
			object obj90 = !flag15;
			obj38 = obj37;
			obj40 = obj39;
			obj42 = obj41;
			obj44 = obj43;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			sprite4 = source.<BoardSprite>k__BackingField;
			if (obj90 != null)
			{
				goto IL_03f8;
			}
			goto IL_0d43;
		}
		goto IL_162f;
		IL_1668:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+30]");
		object obj91 = 0;
		object obj92 = obj91 & 1;
		if (obj92 != null)
		{
			object obj93 = obj91 + 16;
			object obj94 = obj91 + 12;
			object obj95 = obj91 + 8;
			object obj96 = obj91 + 4;
		}
		else
		{
			if (source == null)
			{
				goto IL_162f;
			}
			object obj96 = source + 140;
			object obj95 = source + 144;
			object obj94 = source + 148;
			object obj93 = source + 152;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+38]");
		object obj97 = 0;
		object obj98 = obj97 & 1;
		if (obj98 != null)
		{
			object obj99 = obj97 + 16;
			object obj100 = obj97 + 12;
			object obj101 = obj97 + 8;
			object obj102 = obj97 + 4;
		}
		else
		{
			if (source == null)
			{
				goto IL_162f;
			}
			object obj102 = source + 156;
			object obj101 = source + 160;
			object obj100 = source + 164;
			object obj99 = source + 168;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+40]");
		object obj103 = (nint)0 & (nint)1;
		if (obj103 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+40]");
			object obj104 = (nint)0 >> 8;
			bool flag16 = (byte)(obj104 & 1) != 0;
			object obj105 = obj27;
			object obj106 = obj28;
			object obj107 = obj29;
			object obj108 = obj30;
		}
		else
		{
			if (source == null)
			{
				goto IL_162f;
			}
			bool flag16 = source.<HighlightLastNode>k__BackingField;
			object obj105 = obj27;
			object obj106 = obj28;
			object obj107 = obj29;
			object obj108 = obj30;
		}
		object obj109 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj110 = default(object);
		obj110..ctor();
		object obj111 = obj110 + 80;
		obj111 = sprite5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj112 = obj110 + 88;
		obj112 = sprite7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj113 = obj110 + 96;
		obj113 = sprite9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj114 = obj110 + 104;
		obj114 = sprite3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj115 = obj110 + 112;
		obj115 = sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (JackarooThemeData)obj110;
		IL_034b:
		bool flag17 = (object)bottomMarble == null;
		sprite5 = boardSprite;
		obj37 = obj38;
		obj39 = obj40;
		obj41 = obj42;
		obj43 = obj44;
		obj45 = obj46;
		obj47 = obj48;
		obj49 = obj50;
		obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		sprite4 = boardSprite;
		if (!flag17)
		{
			goto IL_03f8;
		}
		goto IL_0d43;
		IL_0d43:
		if (source != null)
		{
			sprite7 = source.<BottomMarble>k__BackingField;
			bool flag18 = (object)leftMarble == null;
			object obj116 = !flag18;
			obj38 = obj37;
			obj40 = obj39;
			obj42 = obj41;
			obj44 = obj43;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			sprite5 = sprite4;
			sprite6 = source.<BottomMarble>k__BackingField;
			if (obj116 != null)
			{
				goto IL_04ad;
			}
			goto IL_0e2a;
		}
		goto IL_162f;
		IL_0742:
		object obj117 = obj53 >> 8;
		<ColorizeNodes>k__BackingField = (byte)(obj117 & 1) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+28]");
		obj58 = 0;
		object obj118 = obj58 & 1;
		bool flag19 = obj118 == null;
		obj37 = obj38;
		obj39 = obj40;
		obj41 = obj42;
		obj43 = obj44;
		obj45 = obj46;
		obj47 = obj48;
		obj49 = obj50;
		obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		flag13 = <ColorizeNodes>k__BackingField;
		sprite10 = sprite;
		sprite2 = sprite3;
		sprite4 = sprite5;
		sprite6 = sprite7;
		sprite8 = sprite9;
		if (!flag19)
		{
			goto IL_0849;
		}
		goto IL_128a;
		IL_03f8:
		bool flag20 = (object)leftMarble == null;
		sprite7 = bottomMarble;
		obj37 = obj38;
		obj39 = obj40;
		obj41 = obj42;
		obj43 = obj44;
		obj45 = obj46;
		obj47 = obj48;
		obj49 = obj50;
		obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		sprite4 = sprite5;
		sprite6 = bottomMarble;
		if (!flag20)
		{
			goto IL_04ad;
		}
		goto IL_0e2a;
		IL_0e2a:
		if (source != null)
		{
			sprite9 = source.<LeftMarble>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+10]");
			sprite3 = (Sprite)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+10]");
			bool flag21 = (nint)0 == 0;
			object obj119 = !flag21;
			obj38 = obj37;
			obj40 = obj39;
			obj42 = obj41;
			obj44 = obj43;
			obj46 = obj45;
			obj48 = obj47;
			obj50 = obj49;
			obj52 = obj51;
			obj30 = obj33;
			obj29 = obj34;
			obj28 = obj35;
			obj27 = obj36;
			obj11 = obj13;
			obj10 = obj14;
			obj9 = obj15;
			obj8 = obj16;
			sprite5 = sprite4;
			sprite7 = sprite6;
			sprite8 = source.<LeftMarble>k__BackingField;
			if (obj119 != null)
			{
				goto IL_0582;
			}
			goto IL_0f31;
		}
		goto IL_162f;
		IL_128a:
		if (source == null)
		{
			goto IL_162f;
		}
		obj61 = source + 124;
		obj60 = source + 128;
		obj59 = source + 132;
		obj57 = source + 136;
		obj38 = obj37;
		obj40 = obj39;
		obj42 = obj41;
		obj44 = obj43;
		obj46 = obj45;
		obj48 = obj47;
		obj50 = obj49;
		obj52 = obj51;
		obj30 = obj33;
		obj29 = obj34;
		obj28 = obj35;
		obj27 = obj36;
		obj11 = obj13;
		obj10 = obj14;
		obj9 = obj15;
		obj8 = obj16;
		<ColorizeNodes>k__BackingField = flag13;
		sprite = sprite10;
		sprite3 = sprite2;
		sprite5 = sprite4;
		sprite7 = sprite6;
		sprite9 = sprite8;
		goto IL_1668;
		IL_04ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+10]");
		sprite3 = (Sprite)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1+10]");
		bool flag22 = (nint)0 == 0;
		sprite9 = leftMarble;
		obj37 = obj38;
		obj39 = obj40;
		obj41 = obj42;
		obj43 = obj44;
		obj45 = obj46;
		obj47 = obj48;
		obj49 = obj50;
		obj51 = obj52;
		obj33 = obj30;
		obj34 = obj29;
		obj35 = obj28;
		obj36 = obj27;
		obj13 = obj11;
		obj14 = obj10;
		obj15 = obj9;
		obj16 = obj8;
		sprite4 = sprite5;
		sprite6 = sprite7;
		sprite8 = leftMarble;
		if (!flag22)
		{
			goto IL_0582;
		}
		goto IL_0f31;
	}
}
