using System.Formats.Asn1;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickSound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private SoundOptions.Channel playChannel;

	private SingleSound clip;

	public void OnPointerClick(PointerEventData eventData)
	{
		//IL_0034: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
		{
			return;
		}
		object obj = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ stack_-38_v3+D8]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SoundOptions soundOptions = default(SoundOptions);
		soundOptions..ctor(playChannel, SoundOptions.Mode.Instant);
		SoundChannel.PlaySoundWithMode(clip, soundOptions);
	}
}
