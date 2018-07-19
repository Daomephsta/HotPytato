using System;
namespace HotPytato.Util
{
	public static class ServiceProviderGenerifyingExtension
    {
		public static T GetService<T>(this IServiceProvider me, Type serviceType)
		{
			return (T)me.GetService(serviceType);
		}
    }
}
