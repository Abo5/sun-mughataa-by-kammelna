using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.UI;

public class UIShineIndicator : MonoBehaviour
{
	private Image image;

	private bool onStartOnly;

	private bool createInstanceMaterial = true;

	private Texture lastTexture;

	private void Start()
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_001c: Expected I, but got O
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (createInstanceMaterial)
		{
			Image image = this.image;
			nint num = (nint)image;
			Material material = image.material;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Material material2 = default(Material);
			material2..ctor(material);
			image.material = material2;
		}
		object materialProperty = "_InputUv1BufferOffset" + 3072;
		SpriteExensions.SetAtlasRectInfo(this.image, (string)materialProperty);
		bool flag = !onStartOnly;
		object obj2 = 0;
		if (!flag)
		{
			base.enabled = false;
			obj2 = 0;
		}
		Texture mainTexture = this.image.mainTexture;
		object obj3 = this + 48;
		obj3 = mainTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Update()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v3-10]");
		object obj2 = 0;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ X8_v4+368] (should have been resolved before IL gen)");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		Object obj6 = default(Object);
		if ((nint)0 != 0)
		{
			bool flag = (Object)obj != obj6;
			bool flag2 = !flag;
			object obj7 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (Object)obj != obj6;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj7 = 0;
			if (obj8 == null)
			{
				return;
			}
		}
		Texture mainTexture = image.mainTexture;
		lastTexture = mainTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object materialProperty = "_InputUv1BufferOffset" + 3072;
		SpriteExensions.SetAtlasRectInfo(image, (string)materialProperty);
	}
}
