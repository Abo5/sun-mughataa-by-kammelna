using Cpp2ILInjected;
using UnityEngine;

public class ShineComponentData : MonoBehaviour, IComponentData
{
	private float <ScaleDelay>k__BackingField;

	private float <ScaleDuration>k__BackingField;

	private float <RotationDuration>k__BackingField;

	public float ScaleDelay
	{
		get
		{
			return <ScaleDelay>k__BackingField;
		}
		private set
		{
			<ScaleDelay>k__BackingField = value;
		}
	}

	public float ScaleDuration
	{
		get
		{
			return <ScaleDuration>k__BackingField;
		}
		private set
		{
			<ScaleDuration>k__BackingField = value;
		}
	}

	public float RotationDuration
	{
		get
		{
			return <RotationDuration>k__BackingField;
		}
		private set
		{
			<RotationDuration>k__BackingField = value;
		}
	}

	public ShineComponentData()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EB0]");
		<ScaleDelay>k__BackingField = 0f;
		<RotationDuration>k__BackingField = 25f;
		base..ctor();
	}
}
