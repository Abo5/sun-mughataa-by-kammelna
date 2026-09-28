using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[Serializable]
public class IconLayer
{
	private Action<IconLayer> m_OnChanged;

	public LogoLayerConfig layerConfig;

	public int ImageId = -1;

	public float Rotation = 63f;

	public float Scale;

	public bool Inverted;

	public Color Color = (Color)0;

	public Vector2 Position;

	public ClanLogoImageSelector Selector;

	public int Tier;

	public bool IsNotNull
	{
		get
		{
			int num = ~ImageId;
			return (byte)(num >> 31) != 0;
		}
	}

	public event Action<IconLayer> OnChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2384;
			object obj2 = this + 16;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2384;
			object obj2 = this + 16;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public void Reset()
	{
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_022f: Expected I4, but got I8
		//IL_023a: Expected F4, but got I4
		//IL_0250: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0281: Expected O, but got I
		//IL_007f: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		//IL_0034: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		//IL_00c0: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		ImageId = -1;
		Rotation = 63f;
		Inverted = false;
		Color = (Color)0;
		object obj2 = typeof(UsageHint) + 744;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+B8]");
		object position = 0;
		Position = (Vector2)position;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = Selector != null;
			bool flag2 = !flag;
			object obj5 = !flag2;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj5 != null)
			{
				goto IL_0092;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = Selector != null;
			bool flag4 = !flag3;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (!flag4)
			{
				goto IL_0092;
			}
		}
		goto IL_01fe;
		IL_0124:
		UnityEngine.Object colorSelector;
		bool flag5 = colorSelector != null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			goto IL_01eb;
		}
		goto IL_01fe;
		IL_01eb:
		ClanLogoImageSelector selector;
		selector.colorSelector.ResetToDefault();
		goto IL_01fe;
		IL_0092:
		selector = Selector;
		object obj9 = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89C9]");
		object obj10 = (nint)0 & (nint)1;
		UnityEngine.Object colorSelector2;
		if (obj10 != null)
		{
			colorSelector = selector.colorSelector;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
			bool flag7 = (nint)0 == 0;
			colorSelector2 = selector.colorSelector;
			if (!flag7)
			{
				goto IL_0124;
			}
		}
		else
		{
			_ = 1;
			colorSelector = selector.colorSelector;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
			bool flag8 = (nint)0 == 0;
			object obj12 = !flag8;
			colorSelector2 = selector.colorSelector;
			if (obj12 != null)
			{
				goto IL_0124;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (colorSelector2 != null)
		{
			goto IL_01eb;
		}
		goto IL_01fe;
		IL_01fe:
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public void SetImage(int imageId)
	{
		ImageId = imageId;
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public void SetColor(Color color)
	{
		Color color2 = default(Color);
		Color = color2;
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public void SetRotation(float rotation)
	{
		Rotation = rotation;
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public void SetScale(float scale)
	{
		Scale = scale;
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public void SetInverted(bool inverted)
	{
		Inverted = inverted;
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public void SetPosition(Vector2 position)
	{
		Vector2 position2 = default(Vector2);
		Position = position2;
		Actions.SafeInvoke((Action<object>)this.OnChanged, this);
	}

	public IconLayer(LogoLayerConfig layerConfig, int Tier)
	{
		//IL_000f: Expected I4, but got I8
		//IL_001a: Expected F4, but got I4
		//IL_0025: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+B8]");
		Position = (Vector2)0;
		base..ctor();
		object obj2 = this + 24;
		obj2 = layerConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
