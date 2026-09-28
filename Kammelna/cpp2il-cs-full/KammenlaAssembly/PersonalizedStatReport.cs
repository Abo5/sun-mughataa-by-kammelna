using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class PersonalizedStatReport
{
	private DateTime <Date>k__BackingField;

	private StatisticsReportType <ReportType>k__BackingField;

	public List<PersonalizedStat> Stats;

	public DateTime Date
	{
		get
		{
			return <Date>k__BackingField;
		}
		set
		{
			<Date>k__BackingField = value;
		}
	}

	public StatisticsReportType ReportType
	{
		get
		{
			return <ReportType>k__BackingField;
		}
		set
		{
			<ReportType>k__BackingField = value;
		}
	}

	public PersonalizedStatReport()
	{
	}

	public PersonalizedStatReport(DateTime date, StatisticsReportType reportType, List<PersonalizedStat> stats)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 32;
		obj = stats;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
