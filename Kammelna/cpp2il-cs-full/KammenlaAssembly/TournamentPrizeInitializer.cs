using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TournamentPrizeInitializer : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public TournamentPrizeInitializer <>4__this;

		public Action onSuccess;

		internal void <InitializeTrophyImage>b__0(bool success)
		{
			TournamentPrizeInitializer tournamentPrizeInitializer = <>4__this;
			GameObject gameObject = tournamentPrizeInitializer.trophyImage.gameObject;
			gameObject.SetActive(success);
			Action action = onSuccess;
			if (onSuccess != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v45 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private Image trophyImage;

	private GameObject acesPrizeObject;

	private GameObject pointsPrizeObject;

	private TextMeshProUGUI acesPrizeText;

	private TextMeshProUGUI tournamentPointsPrizeText;

	private MonthlyTournamentTrophySprites trophySprites;

	private GameObject acesPrizeTrophy;

	private GameObject acesPrizeBehind;

	public bool Initialize(TournamentData tData, int lvl, Action onSuccess = null)
	{
		bool flag = InitializeTrophyImage(tData, (PrizeLevel)lvl, onSuccess);
		bool flag2 = InitializePrizeText(tData, (PrizeLevel)lvl);
		return flag || flag2;
	}

	public bool Initialize(TournamentData tData, PrizeLevel level, Action onSuccess = null)
	{
		bool flag = InitializeTrophyImage(tData, level, onSuccess);
		bool flag2 = InitializePrizeText(tData, level);
		return flag || flag2;
	}

	private bool InitializeTrophyImage(TournamentData tData, PrizeLevel level, Action onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_035c: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_02c5: Expected O, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02fe: Expected O, but got I
		//IL_030f: Expected I, but got O
		//IL_033b: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = onSuccess;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				if (trophyImage == null)
				{
					goto IL_00c9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = trophyImage == null;
				bool flag2 = !flag;
				object obj7 = !flag2;
				if (obj7 != null)
				{
					goto IL_00c9;
				}
			}
			if ((object)trophyImage != null)
			{
				GameObject gameObject = trophyImage.gameObject;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(value: false);
					if (tData != null)
					{
						if (tData.<Type>k__BackingField == TournamentType.OfficialMonthly)
						{
							System.Int32Enum? int32Enum = default(System.Int32Enum?);
							System.Int32Enum value = int32Enum.Value;
							if ((object)trophySprites != null)
							{
								Sprite monthlySprite = trophySprites.GetMonthlySprite((TournamentSubType)value, level);
								if ((object)trophyImage != null)
								{
									trophyImage.sprite = monthlySprite;
									if ((object)trophyImage != null)
									{
										GameObject gameObject2 = trophyImage.gameObject;
										if ((object)gameObject2 != null)
										{
											gameObject2.SetActive(value: true);
											object obj8 = obj5;
											if (obj5 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v313 @ X8_v24+18] (should have been resolved before IL gen)");
											}
											goto IL_0340;
										}
									}
								}
							}
						}
						else
						{
							object obj9 = (nint)0 + (nint)432;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
							bool flag3 = default(bool);
							if (!flag3)
							{
								return flag3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
							object obj10 = default(object);
							if (obj10 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
								object obj11 = default(object);
								if (obj11 != null)
								{
									object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj13 = (nint)0 + (nint)232;
									Action<bool> action = default(Action<bool>);
									action..ctor(obj2, (IntPtr)obj13);
									Image img = trophyImage;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v23+10]");
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v26+18]");
									UIExtensions.LoadAchievementImage(img, (string)num, 0, action);
									goto IL_0340;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0340:
		return true;
		IL_00c9:
		return false;
	}

	private bool InitializePrizeText(TournamentData tData, PrizeLevel level)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_032b: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_03b9: Expected I4, but got O
		//IL_0376: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_03fd: Expected O, but got I4
		//IL_09d8: Expected I4, but got O
		//IL_01d3: Expected I4, but got O
		//IL_011f: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_047c: Expected O, but got I4
		//IL_04d0: Expected O, but got I4
		//IL_04d9: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_051d: Expected I4, but got O
		//IL_0283: Expected O, but got I4
		//IL_028c: Expected O, but got I4
		//IL_02de: Expected O, but got I4
		//IL_0557: Expected O, but got I4
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_059d: Expected O, but got I4
		//IL_07fa: Expected O, but got I4
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected O, but got Unknown
		//IL_07af: Expected O, but got I4
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E52]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v61+E4]");
			bool flag = (nint)0 == 0;
			obj5 = pointsPrizeObject;
			obj6 = pointsPrizeObject;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = pointsPrizeObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v61+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = pointsPrizeObject;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			goto IL_00c6;
		}
		goto IL_0392;
		IL_09d8:
		return true;
		IL_09de:
		bool flag5;
		return flag5;
		IL_05a2:
		TextMeshProUGUI textMeshProUGUI;
		string text;
		TextMeshProUGUI textMeshProUGUI2;
		int? prize2;
		if (tData != null)
		{
			int? prize = tData.GetPrize(level);
			object obj11 = (??)prize & 1;
			if (obj11 == null)
			{
				flag5 = false;
				goto IL_09de;
			}
			if (tData.<PrizeType>k__BackingField != TournamentPrizeType.TournamentPoints)
			{
				if (tData.<PrizeType>k__BackingField != TournamentPrizeType.Aces)
				{
					return false;
				}
				if ((object)trophyImage != null)
				{
					GameObject gameObject = trophyImage.gameObject;
					if ((object)gameObject != null)
					{
						bool activeSelf = gameObject.activeSelf;
						if ((object)acesPrizeBehind != null)
						{
							acesPrizeBehind.SetActive(activeSelf);
							if ((object)trophyImage != null)
							{
								GameObject gameObject2 = trophyImage.gameObject;
								if ((object)gameObject2 != null)
								{
									bool activeSelf2 = gameObject2.activeSelf;
									if ((object)acesPrizeTrophy != null)
									{
										bool active = (byte)((activeSelf2 ? 1u : 0u) ^ 1u) != 0;
										acesPrizeTrophy.SetActive(active);
										object obj12 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v33+E4]");
										if ((nint)0 != 0)
										{
											bool flag6 = acesPrizeText != null;
											bool flag7 = !flag6;
											object obj13 = !flag7;
											if (obj13 != null)
											{
												goto IL_093c;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											if (acesPrizeText != null)
											{
												goto IL_093c;
											}
										}
										goto IL_09d8;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				object obj14 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v16+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag5 = tournamentPointsPrizeText != null;
				if (!flag5)
				{
					goto IL_09de;
				}
				if ((object)pointsPrizeObject != null)
				{
					pointsPrizeObject.SetActive(value: true);
					textMeshProUGUI = tournamentPointsPrizeText;
					prize2 = tData.GetPrize(level);
					object obj16 = (??)prize2 & 1;
					bool flag9 = obj16 == null;
					text = null;
					textMeshProUGUI2 = tournamentPointsPrizeText;
					if (!flag9)
					{
						goto IL_08c9;
					}
					goto IL_09e3;
				}
			}
		}
		goto IL_09ca;
		IL_0091:
		bool flag10 = obj5 != null;
		bool flag11 = !flag10;
		obj9 = 0;
		obj10 = null;
		if (!flag11)
		{
			goto IL_00c6;
		}
		goto IL_0392;
		IL_0392:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v88+E4]");
		bool flag12 = (nint)0 == 0;
		bool flag13 = (byte)(int)obj10 != 0;
		UnityEngine.Object obj18 = acesPrizeObject;
		UnityEngine.Object obj19 = acesPrizeObject;
		if (flag12)
		{
			goto IL_0153;
		}
		goto IL_03db;
		IL_00c6:
		if ((object)pointsPrizeObject != null)
		{
			pointsPrizeObject.SetActive(value: false);
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v88+E4]");
			bool flag14 = (nint)0 == 0;
			object obj20 = !flag14;
			obj9 = 0;
			flag13 = false;
			obj18 = acesPrizeObject;
			obj19 = acesPrizeObject;
			if (obj20 == null)
			{
				goto IL_0153;
			}
			goto IL_03db;
		}
		goto IL_09ca;
		IL_09ca:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_03db:
		bool flag15 = obj19 != null;
		bool flag16 = !flag15;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (flag16)
		{
			goto IL_01a2;
		}
		goto IL_0410;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj18 != null;
		bool flag18 = !flag17;
		object obj23 = !flag18;
		obj21 = 0;
		obj22 = null;
		if (obj23 == null)
		{
			goto IL_01a2;
		}
		goto IL_0410;
		IL_0410:
		UnityEngine.Object obj26;
		UnityEngine.Object obj27;
		object obj24;
		bool flag20;
		if ((object)acesPrizeObject != null)
		{
			acesPrizeObject.SetActive(value: false);
			obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v49+E4]");
			bool flag19 = (nint)0 == 0;
			object obj25 = !flag19;
			obj26 = acesPrizeBehind;
			obj21 = 0;
			flag20 = false;
			obj27 = acesPrizeBehind;
			if (obj25 != null)
			{
				goto IL_01eb;
			}
			goto IL_049d;
		}
		goto IL_09ca;
		IL_093c:
		if ((object)acesPrizeObject == null)
		{
			goto IL_09ca;
		}
		acesPrizeObject.SetActive(value: true);
		textMeshProUGUI2 = acesPrizeText;
		prize2 = tData.GetPrize(level);
		object obj28 = (??)prize2 & 1;
		bool flag21 = obj28 == null;
		text = null;
		if (!flag21)
		{
			textMeshProUGUI = acesPrizeText;
			goto IL_08c9;
		}
		goto IL_09e3;
		IL_01a2:
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v49+E4]");
		bool flag22 = (nint)0 == 0;
		obj26 = acesPrizeBehind;
		flag20 = (byte)(int)obj22 != 0;
		obj27 = acesPrizeBehind;
		if (!flag22)
		{
			goto IL_01eb;
		}
		goto IL_049d;
		IL_049d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag23 = obj27 != null;
		bool flag24 = !flag23;
		object obj29 = !flag24;
		object obj30 = 0;
		UnityEngine.Object obj31 = null;
		if (obj29 != null)
		{
			goto IL_0220;
		}
		goto IL_04ec;
		IL_01eb:
		bool flag25 = obj26 != null;
		bool flag26 = !flag25;
		obj30 = 0;
		obj31 = null;
		if (!flag26)
		{
			goto IL_0220;
		}
		goto IL_04ec;
		IL_04ec:
		UnityEngine.Object obj32 = acesPrizeTrophy;
		object obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v26+E4]");
		bool flag27 = (nint)0 == 0;
		bool flag28 = (byte)(int)obj31 != 0;
		UnityEngine.Object obj34 = acesPrizeTrophy;
		if (flag27)
		{
			goto IL_02ad;
		}
		goto IL_0535;
		IL_0220:
		if ((object)acesPrizeBehind != null)
		{
			acesPrizeBehind.SetActive(value: false);
			obj32 = acesPrizeTrophy;
			obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v26+E4]");
			bool flag29 = (nint)0 == 0;
			object obj35 = !flag29;
			obj30 = 0;
			flag28 = false;
			obj34 = acesPrizeTrophy;
			if (obj35 == null)
			{
				goto IL_02ad;
			}
			goto IL_0535;
		}
		goto IL_09ca;
		IL_09e3:
		if ((object)textMeshProUGUI2 == null)
		{
			goto IL_09ca;
		}
		textMeshProUGUI2.text = text;
		goto IL_09d8;
		IL_0535:
		bool flag30 = obj34 != null;
		bool flag31 = !flag30;
		object obj36 = 0;
		if (!flag31)
		{
			goto IL_0565;
		}
		goto IL_05a2;
		IL_02ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag32 = obj32 != null;
		bool flag33 = !flag32;
		obj36 = 0;
		if (!flag33)
		{
			goto IL_0565;
		}
		goto IL_05a2;
		IL_0565:
		if ((object)acesPrizeTrophy != null)
		{
			acesPrizeTrophy.SetActive(value: false);
			obj36 = 0;
			goto IL_05a2;
		}
		goto IL_09ca;
		IL_08c9:
		int num = default(int);
		string text2 = num.ToString();
		text = text2;
		textMeshProUGUI2 = textMeshProUGUI;
		goto IL_09e3;
	}
}
