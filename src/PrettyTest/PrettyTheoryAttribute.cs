// <copyright file="PrettyTheoryAttribute.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PrettyTest
{
    using System.Runtime.CompilerServices;
    using Xunit;

    /// <summary>
    /// Provides pretty printing output for <see cref="TheoryAttribute"/>s.
    /// </summary>
    [Xunit.Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.TheoryDiscoverer", "xunit.execution.{Platform}")]
    public class PrettyTheoryAttribute : PrettyFactAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrettyTheoryAttribute"/> class.
        /// </summary>
        /// <param name="testMethodName">The name of the method being run by the test runner.</param>
        public PrettyTheoryAttribute([CallerMemberName] string testMethodName = "")
           : base(testMethodName)
        {
        }
    }
}
