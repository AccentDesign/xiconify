﻿using System.Linq;

namespace JoanZapata.XamarinIconify.Fonts
{
	public class MaterialModule : IIconFontDescriptor
	{
		public string FontFileName {
			get {
				return "android-iconify-material.ttf";
			}
		}
		private static readonly ILookup<string, Icon> _characters = EnumToLookup.ToLookup<MaterialIcons> ();

		public ILookup<string, Icon> Characters {
			get{ return _characters; }
		}
	}

}