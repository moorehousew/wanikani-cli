using System;
using System.Threading;
using System.Threading.Tasks;

using CliFx;

namespace WaniKani
{
	/// <summary>
	/// Contains the entry-point for the application.
	/// </summary>
	public static class Program
	{
		/// <summary>
		/// Runs the application and returns an exit code.
		/// </summary>
		/// <returns>An exit code.</returns>
		internal static async Task<int> Main() =>
			await new CliApplicationBuilder()
				.AddCommandsFromThisAssembly()
				.Build()
				.RunAsync();
	}
}
