using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class ClanNextLevelAchievementPopup : MonoBehaviour
{
	private const string TITLE_KEY = "clan_moved_to_level";

	private const string LEVEL_ORDINAL_KEY = "ORDINAL_LEVELS";

	private PopupUI _popup;

	private ClanTierIcon levelIcon;

	private TextMeshProUGUI title;

	private ParticleSystem particles;

	private Color[] particleColors;

	public void Initialize(int tier)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_00f9: Expected I, but got O
		//IL_01a0: Expected I, but got O
		//IL_013e: Expected I, but got O
		//IL_016c: Expected I, but got O
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		bool flag = (object)_popup == null;
		int num = tier;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			_popup.PopFromCenter();
			bool flag2 = (object)levelIcon == null;
			num = 0;
			if (!flag2)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object input = "Network Authentication Required" + 3280;
				object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
				levelIcon.SetTier(tier);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = LocalizationUtil.LocalizeOrdinal((string)input, tier);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array = default(object[]);
				bool flag4 = array == null;
				nint num2 = unchecked((nint)null);
				num = 1;
				if (!flag4)
				{
					bool flag5 = text == null;
					int num3 = 1;
					if (!flag5)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						num2 = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag6)
						{
							goto IL_0224;
						}
					}
					bool flag7 = array.Length == 0;
					num2 = unchecked((nint)null);
					num = num3;
					if (!flag7)
					{
						object text2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3888;
						object obj5 = array + 32;
						obj5 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TextMeshProExtensions.Localize(title, (string)text2, array);
						SetColorEffect(tier);
						return;
					}
					goto IL_0216;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0216;
		IL_0216:
		ex = new IndexOutOfRangeException();
		goto IL_0224;
		IL_0224:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private unsafe void SetColorEffect(int tier)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0072: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_00b7: Expected O, but got Ref
		//IL_00c4: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		if ((object)particles != null)
		{
			ParticleSystem.MainModule main = particles.main;
			Color[] array = particleColors;
			if (particleColors != null)
			{
				object obj3 = tier - 1;
				bool flag = (nint)obj3 < array.Length;
				object obj4 = !flag;
				if (obj4 == null)
				{
					ParticleSystem.MinMaxGradient minMaxGradient = (Color)0;
					ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
					object obj5 = default(object);
					((ParticleSystem.MainModule*)mainModule)->startColor = (ParticleSystem.MinMaxGradient)(&obj5);
					return;
				}
				goto IL_00d8;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00d8;
		IL_00d8:
		throw new IndexOutOfRangeException();
	}
}
