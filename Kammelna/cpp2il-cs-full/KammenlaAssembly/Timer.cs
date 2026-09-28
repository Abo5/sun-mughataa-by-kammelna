using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	private Action m_onTimeIsUp;

	private Slider slider;

	private TextMeshProUGUI counter;

	private float <MaxTime>k__BackingField;

	private float <RemainingTime>k__BackingField;

	public float MaxTime
	{
		get
		{
			return <MaxTime>k__BackingField;
		}
		private set
		{
			<MaxTime>k__BackingField = value;
		}
	}

	public float RemainingTime
	{
		get
		{
			return <RemainingTime>k__BackingField;
		}
		private set
		{
			<RemainingTime>k__BackingField = value;
		}
	}

	public float PastTime => <MaxTime>k__BackingField - <RemainingTime>k__BackingField;

	public bool IsActive
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_001c: Invalid comparison between F4 and I4
			//IL_0033: Expected O, but got F4
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = <RemainingTime>k__BackingField < 0f;
			bool flag2 = <RemainingTime>k__BackingField == 0f;
			object obj = <RemainingTime>k__BackingField ^ <RemainingTime>k__BackingField;
			object obj2 = <RemainingTime>k__BackingField & obj;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			return (byte)((flag4 & obj3) ? 1 : 0) != 0;
		}
	}

	public event Action onTimeIsUp
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Start()
	{
		if (FloatExtensions.IsNearlyEqualTo(<RemainingTime>k__BackingField, 0f))
		{
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private void Update()
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_001c: Expected O, but got I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I4
		//IL_00dd: Invalid comparison between F4 and I4
		//IL_0114: Invalid comparison between F4 and I4
		//IL_0125: Expected O, but got I4
		//IL_0130: Invalid comparison between F4 and I4
		//IL_0141: Expected O, but got I4
		bool flag = <RemainingTime>k__BackingField < 0f;
		object obj = !flag;
		bool flag2 = <RemainingTime>k__BackingField == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 == null)
		{
			float deltaTime = Time.deltaTime;
			float value = (<RemainingTime>k__BackingField -= deltaTime);
			this.slider.value = value;
			this.slider.maxValue = <MaxTime>k__BackingField;
			object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			if (<MaxTime>k__BackingField == 2.139095E+09f)
			{
			}
			int num = default(int);
			string text = num.ToString();
			counter.text = text;
			bool flag4 = <RemainingTime>k__BackingField < 0f;
			object obj7 = !flag4;
			bool flag5 = <RemainingTime>k__BackingField == 0f;
			object obj8 = !flag5;
			object obj9 = obj7 & obj8;
			if (obj9 == null)
			{
				GameObject gameObject = base.gameObject;
				gameObject.SetActive(value: false);
				Slider slider = this.slider;
				this.slider.value = slider.m_MaxValue;
				<RemainingTime>k__BackingField = 0f;
				Actions.SafeInvoke(this.onTimeIsUp);
			}
		}
	}

	public void StartTimer(float secs)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_001a: Expected O, but got I4
		//IL_0023: Invalid comparison between F4 and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		bool flag = secs < 0f;
		object obj = !flag;
		bool flag2 = secs == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 == null)
		{
			if (FloatExtensions.IsNearlyEqualTo(<RemainingTime>k__BackingField, 0f))
			{
				<MaxTime>k__BackingField = secs;
			}
			<RemainingTime>k__BackingField = secs;
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: true);
		}
		else
		{
			GameObject gameObject2 = base.gameObject;
			gameObject2.SetActive(value: false);
			Slider slider = this.slider;
			this.slider.value = slider.m_MaxValue;
			<RemainingTime>k__BackingField = 0f;
		}
	}

	private void Show()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public void Hide()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		Slider slider = this.slider;
		this.slider.value = slider.m_MaxValue;
		<RemainingTime>k__BackingField = 0f;
	}
}
