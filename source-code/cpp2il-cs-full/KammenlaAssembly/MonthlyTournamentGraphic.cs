using System;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.UI;

public class MonthlyTournamentGraphic : TournamentGraphic
{
	[Serializable]
	private class TierGraphic
	{
		private enum Type
		{
			FirstCup,
			SecondCup,
			HalfCup,
			Title
		}

		private Image image;

		private Type type;

		public void Assign(TournamentSprites sprites, TournamentSubType tier)
		{
			//IL_01c2: Expected O, but got I
			//IL_01ca: Expected I4, but got O
			//IL_01ee: Expected O, but got I4
			//IL_015d: Expected O, but got I
			//IL_0165: Expected I4, but got O
			//IL_0189: Expected O, but got I4
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected O, but got Unknown
			//IL_029f: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_0100: Expected I4, but got O
			//IL_0124: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_005a: Expected I4, but got O
			//IL_007e: Expected O, but got I4
			TournamentSubType tournamentSubType2 = default(TournamentSubType);
			TournamentSprites tournamentSprites = default(TournamentSprites);
			Sprite sprite;
			TournamentSprites tournamentSprites2;
			if (type <= Type.SecondCup)
			{
				if (type != Type.FirstCup)
				{
					if (type != Type.SecondCup)
					{
						goto IL_025d;
					}
					object obj = (nint)0 + (nint)488;
					TournamentSubType tournamentSubType = (TournamentSubType)obj;
					System.Int32Enum? subType = (System.Int32Enum)tournamentSubType2;
					bool flag = (object)tournamentSprites == null;
					tournamentSprites2 = (TournamentSprites)tournamentSubType2;
					if (!flag)
					{
						sprite = tournamentSprites.GetMonthlyTournamentSecondCup((TournamentSubType?)subType);
						tournamentSubType = TournamentSubType.Platinum;
						goto IL_021b;
					}
				}
				else
				{
					object obj2 = (nint)0 + (nint)488;
					TournamentSubType tournamentSubType = (TournamentSubType)obj2;
					System.Int32Enum? subType = (System.Int32Enum)tournamentSubType2;
					bool flag2 = (object)tournamentSprites == null;
					tournamentSprites2 = (TournamentSprites)tournamentSubType2;
					if (!flag2)
					{
						sprite = tournamentSprites.GetMonthlyTournamentFirstCup((TournamentSubType?)subType);
						tournamentSubType = TournamentSubType.Platinum;
						goto IL_021b;
					}
				}
			}
			else if (type != Type.HalfCup)
			{
				if (type != Type.Title)
				{
					goto IL_025d;
				}
				object obj3 = (nint)0 + (nint)488;
				TournamentSubType tournamentSubType = (TournamentSubType)obj3;
				System.Int32Enum? subType = (System.Int32Enum)tournamentSubType2;
				bool flag3 = (object)tournamentSprites == null;
				tournamentSprites2 = (TournamentSprites)tournamentSubType2;
				if (!flag3)
				{
					sprite = tournamentSprites.GetMonthlyTournamentTypeTitle((TournamentSubType?)subType);
					tournamentSubType = TournamentSubType.Platinum;
					goto IL_021b;
				}
			}
			else
			{
				object obj4 = (nint)0 + (nint)488;
				TournamentSubType tournamentSubType = (TournamentSubType)obj4;
				System.Int32Enum? subType = (System.Int32Enum)tournamentSubType2;
				bool flag4 = (object)tournamentSprites == null;
				tournamentSprites2 = (TournamentSprites)tournamentSubType2;
				if (!flag4)
				{
					sprite = tournamentSprites.GetMonthlyTournamentHalfCup((TournamentSubType?)subType);
					tournamentSubType = TournamentSubType.Platinum;
					goto IL_021b;
				}
			}
			goto IL_0252;
			IL_021b:
			bool flag5 = (object)image == null;
			tournamentSprites2 = (TournamentSprites)(object)sprite;
			if (!flag5)
			{
				image.sprite = sprite;
				return;
			}
			goto IL_0252;
			IL_025d:
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			ex..ctor();
			object obj6 = (nint)0 + (nint)2080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
			IL_0252:
			throw new NullReferenceException();
		}
	}

	private TournamentSprites tournamentSprites;

	private TierGraphic[] cups;

	public override void Initialize(TournamentData tournament)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		object obj = (??)tournament.<SubType>k__BackingField & 1;
		if (obj == null)
		{
			return;
		}
		TierGraphic[] array = cups;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			System.Int32Enum? int32Enum = default(System.Int32Enum?);
			do
			{
				System.Int32Enum value = int32Enum.Value;
				obj3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X25_v4+v72 @ X24_v5*8]");
				((TierGraphic)0).Assign(tournamentSprites, (TournamentSubType)value);
			}
			while ((nint)obj3 < array.Length);
		}
	}
}
