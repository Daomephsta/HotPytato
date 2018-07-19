using System;
using System.ComponentModel.Design;
using HotPytato.Input;

namespace HotPytato
{
    public class HotPytatoBackend
    {
		public static IServiceProvider PlatformServices { get => platformServices; }
		private static readonly IServiceContainer platformServices = new ServiceContainer(); 
        
		public static void Init(IKeyboard keyboardService)
        {
			platformServices.AddService(typeof(IKeyboard), keyboardService);
        }
    }
}
