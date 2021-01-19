using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class6
{
	internal Class6()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class6.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("p%H)gU=\\*zI=EFRg\\&8{`XF5kB)", typeof(Class6).Assembly);
				Class6.resourceManager_0 = resourceManager;
			}
			return Class6.resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class6.cultureInfo_0;
		}
		set
		{
			Class6.cultureInfo_0 = value;
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			object @object = Class6.ResourceManager_0.GetObject("CSM Converter icon", Class6.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;
}
