using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentCupPrizeUi : TournamentCumulativePrizeUi
{
	private sealed class <>c__DisplayClass5_0
	{
		public TournamentCupPrizeUi <>4__this;

		public bool prizeNotZero;

		internal void <Initialize>b__0(bool success)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_00a1: Expected O, but got I4
			TournamentCupPrizeUi tournamentCupPrizeUi = <>4__this;
			GameObject gameObject = tournamentCupPrizeUi.trophyImage.gameObject;
			gameObject.SetActive(success);
			TournamentCupPrizeUi tournamentCupPrizeUi2 = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				bool flag = tournamentCupPrizeUi2.prizeAcesImage;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_00ee;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)tournamentCupPrizeUi2.prizeAcesImage)
				{
					goto IL_00ee;
				}
			}
			goto IL_0128;
			IL_0128:
			TournamentCupPrizeUi tournamentCupPrizeUi3 = <>4__this;
			tournamentCupPrizeUi3.privateImage.SetActive(value: false);
			TournamentCupPrizeUi tournamentCupPrizeUi4 = <>4__this;
			GameObject gameObject2 = tournamentCupPrizeUi4.publicImage.gameObject;
			gameObject2.SetActive(value: false);
			return;
			IL_00ee:
			TournamentCupPrizeUi tournamentCupPrizeUi5 = <>4__this;
			GameObject gameObject3 = tournamentCupPrizeUi5.prizeAcesImage.gameObject;
			gameObject3.SetActive(prizeNotZero);
			goto IL_0128;
		}
	}

	private GameObject prizeLayout;

	private Image trophyImage;

	private Image publicImage;

	private GameObject privateImage;

	private Image prizeAcesImage;

	public override void Initialize(TournamentData tournament)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_02e8: Expected O, but got I4
		//IL_02f1: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_027b: Expected O, but got I
		//IL_028c: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base.Initialize(tournament);
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		int totalPrize = tournament.TotalPrize;
		bool flag = totalPrize < 0;
		bool flag2 = totalPrize == 0;
		int num = totalPrize ^ totalPrize;
		int num2 = totalPrize & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = prizeLayout;
			bool flag6 = !flag5;
			object obj8 = !flag6;
			if (obj8 != null)
			{
				goto IL_0174;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)prizeLayout)
			{
				goto IL_0174;
			}
		}
		goto IL_0190;
		IL_0190:
		ResetPrizes(tournament.<Type>k__BackingField);
		ChampionshipTournamentAddon tournamentAddonsChampionship = tournament.TournamentAddonsChampionship;
		if (tournamentAddonsChampionship == null)
		{
			return;
		}
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = trophyImage != null;
			bool flag8 = !flag7;
			object obj10 = 0;
			if (flag8)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = trophyImage != null;
			bool flag10 = !flag9;
			object obj11 = !flag10;
			object obj10 = 0;
			if (obj11 == null)
			{
				return;
			}
		}
		ChampionshipTournamentAddon tournamentAddonsChampionship2 = tournament.TournamentAddonsChampionship;
		ChampionshipTournamentAddon tournamentAddonsChampionship3 = tournament.TournamentAddonsChampionship;
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3816;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj13);
		UIExtensions.LoadAchievementImage(trophyImage, tournamentAddonsChampionship2.<trophyName>k__BackingField, tournamentAddonsChampionship3.<levelId>k__BackingField, action);
		return;
		IL_0174:
		GameObject obj14 = prizeLayout;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		obj14.SetActive(value: false);
		goto IL_0190;
	}

	private void ResetPrizes(TournamentType tournamentType)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		//IL_00e2: Expected I, but got O
		//IL_00e7: Expected I, but got O
		//IL_023d: Expected I, but got O
		//IL_0117: Expected O, but got I4
		//IL_026e: Expected I, but got O
		//IL_031c: Expected I, but got O
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_02aa: Expected I, but got O
		//IL_02b8: Expected I, but got O
		//IL_0356: Expected I, but got O
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_041d: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_01d0: Expected I, but got O
		bool flag = (object)trophyImage == null;
		bool flag2 = (byte)tournamentType != 0;
		bool flag6;
		nint num2;
		nint num;
		if (!flag)
		{
			GameObject gameObject = trophyImage.gameObject;
			bool flag3 = (object)gameObject == null;
			flag2 = false;
			if (!flag3)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				gameObject.SetActive(value: false);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					bool flag4 = prizeAcesImage;
					bool flag5 = !flag4;
					object obj3 = !flag5;
					flag6 = false;
					flag2 = false;
					if (obj3 == null)
					{
						goto IL_00ce;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag7 = prizeAcesImage;
					bool flag8 = !flag7;
					flag6 = false;
					flag2 = false;
					if (flag8)
					{
						goto IL_00ce;
					}
				}
				bool flag9 = (object)prizeAcesImage == null;
				num = unchecked((nint)null);
				if (!flag9)
				{
					GameObject gameObject2 = prizeAcesImage.gameObject;
					bool flag10 = (object)gameObject2 == null;
					num = unchecked((nint)null);
					flag2 = false;
					if (!flag10)
					{
						gameObject2.SetActive(value: false);
						bool flag11 = tournamentType != TournamentType.Private;
						num = unchecked((nint)null);
						flag6 = false;
						num2 = unchecked((nint)null);
						flag2 = false;
						if (flag11)
						{
							goto IL_00fd;
						}
						goto IL_02cf;
					}
				}
			}
		}
		goto IL_037c;
		IL_037c:
		throw new NullReferenceException();
		IL_00fd:
		bool flag12 = tournamentType == TournamentType.Public;
		object obj4 = !flag12;
		flag2 = flag6;
		GameObject gameObject4;
		if (obj4 == null)
		{
			bool flag13 = (object)publicImage == null;
			flag2 = flag6;
			if (!flag13)
			{
				GameObject gameObject3 = publicImage.gameObject;
				bool flag14 = (object)gameObject3 == null;
				flag2 = false;
				if (!flag14)
				{
					gameObject3.SetActive(value: true);
					gameObject4 = privateImage;
					bool flag15 = (object)privateImage == null;
					object obj5 = !flag15;
					if (obj5 != null)
					{
						goto IL_036d;
					}
					num = unchecked((nint)null);
					flag2 = true;
				}
			}
			goto IL_037c;
		}
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = "startPosition" + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj9 = (nint)0 + (nint)800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_036d:
		gameObject4.SetActive(value: false);
		return;
		IL_02cf:
		bool flag16 = (object)privateImage == null;
		num = num2;
		if (!flag16)
		{
			privateImage.SetActive(value: true);
			bool flag17 = (object)publicImage == null;
			num = unchecked((nint)null);
			flag2 = true;
			if (!flag17)
			{
				gameObject4 = publicImage.gameObject;
				bool flag18 = (object)gameObject4 == null;
				num = unchecked((nint)null);
				flag2 = false;
				if (!flag18)
				{
					goto IL_036d;
				}
			}
		}
		goto IL_037c;
		IL_00ce:
		bool flag19 = tournamentType == TournamentType.Private;
		num = unchecked((nint)null);
		num2 = unchecked((nint)null);
		flag2 = flag6;
		if (!flag19)
		{
			goto IL_00fd;
		}
		goto IL_02cf;
	}

	public TournamentCupPrizeUi()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D58]");
		if ((object)((nint)0 & (nint)1) != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((object)((nint)0 != 0) != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		((MonoBehaviour)this)..ctor();
		return;
		IL_007d:
		((MonoBehaviour)this)..ctor();
	}
}
