using System.Buffers.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Rendering;
using UnityStandardAssets.ImageEffects;

public class Blur2RT : BlurOptimized
{
	private RenderTexture _renderTexture;

	private RTHandle _renderTextureHandle;

	public bool renderTextureOnly = true;

	private bool <HasBlurredOnce>k__BackingField;

	private bool _blurOnceOnly;

	public RenderTexture renderTexture
	{
		get
		{
			return _renderTexture;
		}
		set
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_0123: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
			//IL_017b: Expected O, but got I4
			//IL_0184: Expected O, but got I4
			//IL_028e: Expected O, but got I4
			//IL_029c: Expected O, but got I4
			//IL_022e: Expected O, but got I4
			//IL_0237: Expected O, but got I4
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Expected O, but got Unknown
			//IL_02ed: Expected O, but got I4
			//IL_0325: Expected O, but got I4
			//IL_0253: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73B4]");
			object obj3 = (nint)0 & (nint)1;
			Object obj5;
			Object obj7;
			object obj8;
			object obj4;
			if (obj3 != null)
			{
				obj4 = this + 56;
				obj5 = (Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 56;
				obj5 = (Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == value;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj11 = 0;
			Object obj12 = value;
			obj4 = obj8;
			if (obj10 != null)
			{
				return;
			}
			goto IL_01a2;
			IL_0332:
			RTHandle rTHandle;
			object obj13 = rTHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_02af:
			object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3024;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RTHandle rTHandle2 = RTHandles.Alloc(value);
			object obj17 = 0;
			rTHandle = rTHandle2;
			goto IL_0332;
			IL_01a2:
			obj13 = this + 64;
			if (obj13 != null)
			{
				((RTHandle)obj13).Release();
				obj12 = null;
			}
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				bool flag6 = value != null;
				bool flag7 = !flag6;
				object obj19 = !flag7;
				object obj20 = 0;
				RTHandle rTHandle3 = null;
				if (obj19 != null)
				{
					goto IL_02af;
				}
				obj17 = 0;
				rTHandle = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag8 = value != null;
				bool flag9 = !flag8;
				object obj20 = 0;
				RTHandle rTHandle3 = null;
				obj17 = 0;
				rTHandle = null;
				if (!flag9)
				{
					goto IL_02af;
				}
			}
			goto IL_0332;
			IL_00a0:
			bool flag10 = obj5 == value;
			bool flag11 = !flag10;
			obj11 = 0;
			obj12 = value;
			if (!flag11)
			{
				return;
			}
			goto IL_01a2;
		}
	}

	public RTHandle RenderTextureHandle => _renderTextureHandle;

	public bool HasBlurredOnce
	{
		get
		{
			return <HasBlurredOnce>k__BackingField;
		}
		set
		{
			<HasBlurredOnce>k__BackingField = value;
		}
	}

	public bool blurOnceOnly
	{
		get
		{
			return _blurOnceOnly;
		}
		set
		{
			_blurOnceOnly = value;
			<HasBlurredOnce>k__BackingField = false;
			base.enabled = true;
		}
	}

	public override void OnDisable()
	{
		base.OnDisable();
		if ((object)_renderTexture != null)
		{
			_renderTexture.DiscardContents();
		}
	}

	private void OnDestroy()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		((RTHandle)(object)(this + 64))?.Release();
		_renderTextureHandle = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)_renderTexture != null)
		{
			_renderTexture.DiscardContents();
		}
	}
}
