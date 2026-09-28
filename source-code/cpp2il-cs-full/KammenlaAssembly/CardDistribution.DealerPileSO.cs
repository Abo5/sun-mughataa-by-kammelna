using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using Unity.Properties;
using UnityEngine;

namespace CardDistribution;

public class DealerPileSO : ScriptableObject
{
	private int _totalCardsPerPlayer;

	private int[] <CardsPerBatch>k__BackingField;

	private float <PerspectiveFadeDuration>k__BackingField;

	private float <BatchFadeDuration>k__BackingField;

	private float <FadeInDuration>k__BackingField;

	private float <FadeInDurationMultiplier>k__BackingField;

	private Ease <FadeInEase>k__BackingField;

	private float <PunchDuration>k__BackingField;

	private float <PunchStrength>k__BackingField;

	private int <PunchVibrato>k__BackingField;

	private float <PunchElasticity>k__BackingField;

	private Ease <PunchEase>k__BackingField;

	public int[] CardsPerBatch
	{
		get
		{
			return <CardsPerBatch>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public float PerspectiveFadeDuration
	{
		get
		{
			return <PerspectiveFadeDuration>k__BackingField;
		}
		private set
		{
			<PerspectiveFadeDuration>k__BackingField = value;
		}
	}

	public float BatchFadeDuration
	{
		get
		{
			return <BatchFadeDuration>k__BackingField;
		}
		private set
		{
			<BatchFadeDuration>k__BackingField = value;
		}
	}

	public float FadeInDuration
	{
		get
		{
			return <FadeInDuration>k__BackingField;
		}
		private set
		{
			<FadeInDuration>k__BackingField = value;
		}
	}

	public float FadeInDurationMultiplier
	{
		get
		{
			return <FadeInDurationMultiplier>k__BackingField;
		}
		private set
		{
			<FadeInDurationMultiplier>k__BackingField = value;
		}
	}

	public Ease FadeInEase
	{
		get
		{
			return <FadeInEase>k__BackingField;
		}
		private set
		{
			<FadeInEase>k__BackingField = value;
		}
	}

	public float PunchDuration
	{
		get
		{
			return <PunchDuration>k__BackingField;
		}
		private set
		{
			<PunchDuration>k__BackingField = value;
		}
	}

	public float PunchStrength
	{
		get
		{
			return <PunchStrength>k__BackingField;
		}
		private set
		{
			<PunchStrength>k__BackingField = value;
		}
	}

	public int PunchVibrato
	{
		get
		{
			return <PunchVibrato>k__BackingField;
		}
		private set
		{
			<PunchVibrato>k__BackingField = value;
		}
	}

	public float PunchElasticity
	{
		get
		{
			return <PunchElasticity>k__BackingField;
		}
		private set
		{
			<PunchElasticity>k__BackingField = value;
		}
	}

	public Ease PunchEase
	{
		get
		{
			return <PunchEase>k__BackingField;
		}
		private set
		{
			<PunchEase>k__BackingField = value;
		}
	}

	public int BatchCount
	{
		get
		{
			//IL_003e: Expected I4, but got O
			int[] array = <CardsPerBatch>k__BackingField;
			if (<CardsPerBatch>k__BackingField != null)
			{
				return array.Length;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private void OnValidate()
	{
		//IL_0041: Expected O, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		if (<CardsPerBatch>k__BackingField == null)
		{
			return;
		}
		int num = Enumerable.Sum(<CardsPerBatch>k__BackingField);
		if (num != _totalCardsPerPlayer)
		{
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "WhiteSmoke" + 3064;
			object arg = default(object);
			object arg2 = default(object);
			string text = string.Format((string)format, arg, arg2);
			object obj2 = typeof(DataRelation) + 856;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object message = text;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.LogError(message);
		}
	}

	public DealerPileSO()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0037: Expected F4, but got I
		//IL_0054: Expected F4, but got I
		//IL_0063: Expected I4, but got I8
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		object fldHandle = (nint)0 + (nint)1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		object obj2 = this + 32;
		obj2 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72532B0]");
		<PerspectiveFadeDuration>k__BackingField = 0f;
		<FadeInEase>k__BackingField = Ease.OutQuart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253280]");
		<PunchDuration>k__BackingField = 0f;
		<PunchVibrato>k__BackingField = 1;
		<PunchEase>k__BackingField = Ease.OutBack;
		base..ctor();
	}
}
