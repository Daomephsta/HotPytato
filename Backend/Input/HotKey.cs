using System;
using System.Linq;
using HotPytato.Util;

namespace HotPytato.Input
{
    public struct HotKey
    {
		public bool IsPressed
		{
			get
			{
				IKeyboard keyboard = HotPytatoBackend.PlatformServices.GetService<IKeyboard>(typeof(IKeyboard));
				return keys.All(keyboard.IsKeyDown);
			}
		}

		private ConsoleKey[] keys;
    }
}
