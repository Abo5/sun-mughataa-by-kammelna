using System;
using System.Data;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

public class TournamentScheduleButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private InputFieldTMProUGUI inputField;

	private DatePickerManager pickerManager;

	public void OnPointerClick(PointerEventData eventData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		if (base.enabled)
		{
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime dateTime = default(DateTime);
			DateTime defaultTime = dateTime.AddMinutes(61.0);
			pickerManager.PickFromHours(inputField, defaultTime, IPicker.PickerMode.FutureOnly);
		}
	}
}
