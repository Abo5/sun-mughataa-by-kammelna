using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class TournamentSeparatePrizeUi : TournamentPrizeUi
{
	[Serializable]
	protected class PrizeLabel
	{
		private TextMeshProUGUI label;

		private GameObject container;

		public void Initialize(int? prize, NumberFormatter formatter)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			object obj = (object?)prize >> 32;
			if ((nint)obj >= 1)
			{
				object obj2 = (??)prize & 1;
				if (obj2 != null)
				{
					container.SetActive(value: true);
					int? num = default(int?);
					int value = num.Value;
					formatter.AssignValue(label, value);
					return;
				}
			}
			container.SetActive(value: false);
		}
	}

	private NumberFormatter formatter;

	protected PrizeLabel horizontalPrize1;

	protected PrizeLabel horizontalPrize2;

	protected PrizeLabel horizontalPrize3;

	protected GameObject horizontalPrizes;

	public override void Initialize(TournamentData tournament)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_0206: Expected O, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected I4, but got Unknown
		//IL_0285: Expected O, but got I4
		//IL_029b: Expected I, but got O
		//IL_02ab: Expected O, but got I
		//IL_02d4: Expected O, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_03af: Expected O, but got I8
		//IL_0354: Expected I, but got O
		//IL_0364: Expected O, but got I
		//IL_038d: Expected O, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_0482: Expected O, but got I4
		//IL_0492: Expected O, but got I4
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_041f: Expected I, but got O
		//IL_042f: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D67]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			obj5 = horizontalPrizes;
			obj6 = horizontalPrizes;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = horizontalPrizes;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = horizontalPrizes;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		PrizeLabel prizeLabel = null;
		if (!flag4)
		{
			goto IL_0158;
		}
		goto IL_0227;
		IL_0227:
		object obj8 = typeof(SqlSingle[]) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		PrizeLabel[] array = default(PrizeLabel[]);
		bool flag5 = array == null;
		prizeLabel = (PrizeLabel)3;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag5)
		{
			bool flag6 = horizontalPrize1 == null;
			PrizeLabel prizeLabel2 = (PrizeLabel)3;
			if (!flag6)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v16 (Il2CppClass<PrizeLabel[]>)+40]");
				prizeLabel2 = (PrizeLabel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag7 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v16 (Il2CppClass<PrizeLabel[]>)+40]");
				prizeLabel = (PrizeLabel)0;
				if (flag7)
				{
					goto IL_051f;
				}
			}
			if (array.Length != 0)
			{
				object obj9 = array + 32;
				obj9 = horizontalPrize1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag8 = horizontalPrize2 == null;
				prizeLabel2 = horizontalPrize1;
				if (!flag8)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v15 (Il2CppClass<PrizeLabel[]>)+40]");
					prizeLabel2 = (PrizeLabel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag9 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v15 (Il2CppClass<PrizeLabel[]>)+40]");
					prizeLabel = (PrizeLabel)0;
					if (flag9)
					{
						goto IL_051f;
					}
				}
				object obj10 = array.Length & 0xFFFFFFFEL;
				if (obj10 != null)
				{
					object obj11 = array + 40;
					obj11 = horizontalPrize2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag10 = horizontalPrize3 == null;
					prizeLabel2 = horizontalPrize2;
					if (!flag10)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v14 (Il2CppClass<PrizeLabel[]>)+40]");
						prizeLabel2 = (PrizeLabel)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag11 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v14 (Il2CppClass<PrizeLabel[]>)+40]");
						prizeLabel = (PrizeLabel)0;
						if (flag11)
						{
							goto IL_051f;
						}
					}
					bool flag12 = array.Length < 2;
					object obj12 = !flag12;
					object obj13 = array.Length - 2;
					bool flag13 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag13;
					if (obj15 == null)
					{
						object obj16 = array + 48;
						obj16 = horizontalPrize3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						InitializePrizes(array, tournament);
						return;
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			prizeLabel = prizeLabel2;
		}
		goto IL_0511;
		IL_0511:
		ex = new NullReferenceException();
		goto IL_051f;
		IL_051f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0091:
		bool flag14 = obj5;
		bool flag15 = !flag14;
		object obj17 = !flag15;
		prizeLabel = null;
		if (obj17 != null)
		{
			goto IL_0158;
		}
		goto IL_0227;
		IL_0158:
		if (tournament != null)
		{
			int totalPrize = tournament.TotalPrize;
			bool flag16 = (object)horizontalPrizes == null;
			prizeLabel = null;
			if (!flag16)
			{
				bool flag17 = totalPrize < 0;
				bool flag18 = totalPrize == 0;
				int num4 = totalPrize ^ totalPrize;
				int num5 = totalPrize & num4;
				bool flag19 = num5 < 0;
				bool flag20 = flag17 == flag19;
				object obj18 = !flag18;
				bool active = (byte)((flag20 & obj18) ? 1 : 0) != 0;
				horizontalPrizes.SetActive(active);
				goto IL_0227;
			}
		}
		goto IL_0511;
	}

	protected void InitializePrizes(PrizeLabel[] prizeLabels, TournamentData tournament)
	{
		//IL_00e3: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		if (prizeLabels != null && tournament != null)
		{
			int? prize = tournament.<FirstPrize>k__BackingField;
			if (prizeLabels[0] != null)
			{
				prizeLabels[0].Initialize(prize, formatter);
				if (prizeLabels[1] != null)
				{
					prizeLabels[1].Initialize(tournament.<SecondPrize>k__BackingField, formatter);
					bool flag = prizeLabels.Length < 2;
					object obj = !flag;
					object obj2 = prizeLabels.Length - 2;
					bool flag2 = obj2 == null;
					object obj3 = ~obj;
					object obj4 = obj3 | flag2;
					if (obj4 != null)
					{
						goto IL_017e;
					}
					if (prizeLabels[2] != null)
					{
						prizeLabels[2].Initialize(tournament.<ThirdPrize>k__BackingField, formatter);
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_017e;
		IL_017e:
		throw new IndexOutOfRangeException();
	}
}
