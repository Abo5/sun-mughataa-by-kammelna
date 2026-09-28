using System;
using Cpp2ILInjected;

[Serializable]
public class PersonalReportTypeConfig
{
	private PerformanceReportType <Metric>k__BackingField;

	private FileInfoModel <Image>k__BackingField;

	private string <Title>k__BackingField;

	private string <DescriptionTemplate>k__BackingField;

	private string <VsLastTemplate>k__BackingField;

	public PerformanceReportType Metric
	{
		get
		{
			return <Metric>k__BackingField;
		}
		set
		{
			<Metric>k__BackingField = value;
		}
	}

	public FileInfoModel Image
	{
		get
		{
			return <Image>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string Title
	{
		get
		{
			return <Title>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string DescriptionTemplate
	{
		get
		{
			return <DescriptionTemplate>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string VsLastTemplate
	{
		get
		{
			return <VsLastTemplate>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
