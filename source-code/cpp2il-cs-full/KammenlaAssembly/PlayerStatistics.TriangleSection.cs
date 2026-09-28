using System;
using Cpp2ILInjected;
using TMPro;
using Unity.Properties;
using UnityEngine;

[Serializable]
public class PlayerStatistics : MonoBehaviour
{
	[Serializable]
	private class TriangleSection
	{
		private GameObject activeState;

		private GameObject emptyState;

		private TrianglarProgress progress;

		private TextMeshProUGUI descriptionText;

		public unsafe void Initialize(int rank, int percentile, string description)
		{
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00f1: Expected O, but got I4
			//IL_0155: Expected I, but got O
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			bool flag = (object)emptyState == null;
			int num = percentile;
			bool flag2 = (byte)rank != 0;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			if (!flag)
			{
				bool flag3 = rank == 0;
				emptyState.SetActive(flag3);
				bool flag4 = (object)activeState == null;
				num = 0;
				flag2 = flag3;
				if (!flag4)
				{
					bool flag5 = rank == 0;
					bool flag6 = !flag5;
					activeState.SetActive(flag6);
					bool flag7 = (object)progress == null;
					num = 0;
					flag2 = flag6;
					if (!flag7)
					{
						object obj = typeof(TypeConverter<ushort, char>) + 3400;
						progress.Initialize(percentile, rank);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj2 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array = default(object[]);
						bool flag8 = array == null;
						num = rank;
						int num2 = default(int);
						flag2 = (byte)(&num2) != 0;
						if (!flag8)
						{
							object obj3 = default(object);
							bool flag9 = obj3 == null;
							bool flag10 = (byte)(&num2) != 0;
							if (!flag9)
							{
								nint num3 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
								flag10 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag11 = ex == null;
								num = rank;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
								flag2 = false;
								if (flag11)
								{
									goto IL_0228;
								}
							}
							bool flag12 = array.Length == 0;
							num = rank;
							flag2 = flag10;
							if (!flag12)
							{
								object obj4 = array + 32;
								obj4 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								TextMeshProExtensions.Localize(descriptionText, description, array);
								return;
							}
							goto IL_021a;
						}
					}
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_021a;
			IL_0228:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			throw new OutOfMemoryException();
			IL_021a:
			ex = new IndexOutOfRangeException();
			goto IL_0228;
		}

		public void Hide()
		{
			emptyState.SetActive(value: true);
			activeState.SetActive(value: false);
		}
	}

	private const string LastWeekDescription = "Ranking in last week leader board is among best {0}%";

	private const string LastMonthDescription = "Ranking in last month leader board is among best {0}%";

	private const string OverallDescription = "Ranking in overall leader board is among best {0}%";

	private TriangleSection triangleLastWeek;

	private TriangleSection triangleLastMonth;

	private TriangleSection triangleOverall;

	private CircularProgress circleWeek;

	private CircularProgress circleMonth;

	public void Populate(PlayerProfileModel profileModel)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0137: Expected F4, but got I4
		PlayerRankingModel <ranking>k__BackingField = profileModel.<ranking>k__BackingField;
		TriangleSection triangleSection = triangleLastWeek;
		if (profileModel.<ranking>k__BackingField != null)
		{
			object description = "Picking audio files is not supported on iOS" + 3952;
			triangleSection.Initialize(<ranking>k__BackingField.<lastWeekRank>k__BackingField, <ranking>k__BackingField.<lastWeekPercentile>k__BackingField, (string)description);
			PlayerRankingModel <ranking>k__BackingField2 = profileModel.<ranking>k__BackingField;
			object description2 = "Picking audio files is not supported on iOS" + 3944;
			triangleLastMonth.Initialize(<ranking>k__BackingField2.<lastMonthRank>k__BackingField, <ranking>k__BackingField2.<lastMonthPercentile>k__BackingField, (string)description2);
			PlayerRankingModel <ranking>k__BackingField3 = profileModel.<ranking>k__BackingField;
			object description3 = "Picking audio files is not supported on iOS" + 3960;
			triangleOverall.Initialize(<ranking>k__BackingField3.<overallRank>k__BackingField, <ranking>k__BackingField3.<overallPercentile>k__BackingField, (string)description3);
			PlayerRankingModel <ranking>k__BackingField4 = profileModel.<ranking>k__BackingField;
			CircularProgress circularProgress = circleWeek;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			circularProgress.MaxProgress = <ranking>k__BackingField4.<currentWeekPoints>k__BackingField;
			circularProgress.StartAnimating();
			CircularProgress circularProgress2 = circleMonth;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			float maxProgress = default(float);
			circularProgress2.MaxProgress = maxProgress;
			circularProgress2.StartAnimating();
		}
		else
		{
			triangleSection.emptyState.SetActive(value: true);
			triangleSection.activeState.SetActive(value: false);
			TriangleSection triangleSection2 = triangleLastMonth;
			triangleSection2.emptyState.SetActive(value: true);
			triangleSection2.activeState.SetActive(value: false);
			TriangleSection triangleSection3 = triangleOverall;
			triangleSection3.emptyState.SetActive(value: true);
			triangleSection3.activeState.SetActive(value: false);
			CircularProgress circularProgress3 = circleWeek;
			circularProgress3.MaxProgress = 0f;
			circularProgress3.StartAnimating();
			CircularProgress circularProgress4 = circleMonth;
			circularProgress4.MaxProgress = 0f;
			circularProgress4.StartAnimating();
		}
	}
}
