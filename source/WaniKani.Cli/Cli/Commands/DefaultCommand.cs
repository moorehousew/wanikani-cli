using System;
using System.Threading;
using System.Threading.Tasks;

using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

namespace WaniKani.Cli.Commands
{
	/// <summary>
	/// Represents the default application command.
	/// </summary>
	[Command]
	public sealed class DefaultCommand :
		ICommand
	{
		/// <summary>
		/// Executes the command using the specified
		/// <see cref="IConsole"/> implementation.
		/// </summary>
		/// <param name="console">
		/// The <see cref="IConsole"/> implementation to use.
		/// </param>
		/// <returns>
		/// A task representing the operation.
		/// </returns>
		public ValueTask ExecuteAsync(
			IConsole console)
		{
			// Write a greeting to the console.
			console.WriteLine(
				"Hello, World!");

			// Return a completed task.
			return ValueTask.CompletedTask;
		}
	}
}
