using System;

using Microsoft;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(
	Scope = ExecutionScope.ClassLevel)]

// See https://github.com/microsoft/testfx/issues/1094.
[assembly: TestDataSourceDiscovery(
	TestDataSourceDiscoveryOption.DuringExecution)]
