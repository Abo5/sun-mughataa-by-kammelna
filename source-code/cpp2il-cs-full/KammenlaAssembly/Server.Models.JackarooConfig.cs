using Cpp2ILInjected;

namespace Server.Models;

public class JackarooConfig
{
	private float <MinMarbleMoveDuration>k__BackingField;

	private float <MaxMarbleMoveDuration>k__BackingField;

	private bool <CustomRulesEnabled>k__BackingField;

	public float MinMarbleMoveDuration
	{
		get
		{
			return <MinMarbleMoveDuration>k__BackingField;
		}
		set
		{
			<MinMarbleMoveDuration>k__BackingField = value;
		}
	}

	public float MaxMarbleMoveDuration
	{
		get
		{
			return <MaxMarbleMoveDuration>k__BackingField;
		}
		set
		{
			<MaxMarbleMoveDuration>k__BackingField = value;
		}
	}

	public bool CustomRulesEnabled
	{
		get
		{
			return <CustomRulesEnabled>k__BackingField;
		}
		set
		{
			<CustomRulesEnabled>k__BackingField = value;
		}
	}

	public JackarooConfig()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253200]");
		<MinMarbleMoveDuration>k__BackingField = 0f;
		base..ctor();
	}
}
