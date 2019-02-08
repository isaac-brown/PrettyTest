// <copyright file="PrettyFactAttribute.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PrettyTest
{
    using System;
    using System.Runtime.CompilerServices;
    using Xunit;

    /// <summary>
    /// Provides pretty printing output for <see cref="FactAttribute"/>s.
    /// </summary>
    public class PrettyFactAttribute : FactAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrettyFactAttribute"/> class.
        /// </summary>
        /// <param name="testMethodName">The name of the method being run by the test runner.</param>
        public PrettyFactAttribute([CallerMemberName] string testMethodName = "")
        {
            if (testMethodName == null)
            {
                throw new ArgumentNullException(nameof(testMethodName));
            }

            if (testMethodName.Trim() == string.Empty)
            {
                throw new ArgumentException("Cannot be blank", nameof(testMethodName));
            }

            this.DisplayName = testMethodName.Replace("_", " ");
        }
    }
}
