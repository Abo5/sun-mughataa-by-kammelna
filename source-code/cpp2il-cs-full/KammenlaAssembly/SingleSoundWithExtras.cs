public class SingleSoundWithExtras : SingleSound
{
	private float <Volume>k__BackingField = 0f;

	private float <Pitch>k__BackingField;

	private bool <Loop>k__BackingField;

	public float Volume
	{
		get
		{
			return <Volume>k__BackingField;
		}
		private set
		{
			<Volume>k__BackingField = value;
		}
	}

	public float Pitch
	{
		get
		{
			return <Pitch>k__BackingField;
		}
		private set
		{
			<Pitch>k__BackingField = value;
		}
	}

	public bool Loop
	{
		get
		{
			return <Loop>k__BackingField;
		}
		private set
		{
			<Loop>k__BackingField = value;
		}
	}
}
