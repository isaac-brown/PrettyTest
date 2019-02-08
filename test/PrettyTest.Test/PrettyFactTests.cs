// <copyright file="PrettyFactTests.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PrettyTest.Test
{
    using System;
    using Xunit;

    /// <summary>
    /// Test Cases for the <see cref="PrettyFactAttribute"/>.
    /// </summary>
    public class PrettyFactTests
    {
        [Fact]
        public void Given_a_new_PrettyFactAttribute_When_testMethodName_is_null_Then_an_AgrumentNullException_is_thrown()
        {
            // Given.
            PrettyFactAttribute attribute;

            // When.
            Action testCode = () => attribute = new PrettyFactAttribute(null);

            // Then.
            Assert.Throws<ArgumentNullException>("testMethodName", testCode);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\t")]
        [InlineData("   ")]
        [InlineData("    ")]
        public void Given_a_new_PrettyFactAttribute_When_testMethodName_is_blank_Then_an_AgrumentException_is_thrown(string testMethodName)
        {
            // Given.
            PrettyFactAttribute attribute;

            // When.
            Action testCode = () => attribute = new PrettyFactAttribute(testMethodName);

            // Then.
            Assert.Throws<ArgumentException>("testMethodName", testCode);
        }

        /// <summary>
        /// Checks that display name is unchanged if there are no underscore ("_") characters present in the testMethodName input.
        /// </summary>
        [Fact]
        public void Given_a_new_PrettyFactAttribute_When_testMethodName_contains_no_underscores_Then_DisplayName_will_be_the_same_as_testMethodName()
        {
            // Given.
            PrettyFactAttribute attribute;
            string testMethodName;

            // When.
            testMethodName = "GivenXWhenYThenZ";
            attribute = new PrettyFactAttribute(testMethodName);

            // Then.
            Assert.Equal(expected: testMethodName, actual: attribute.DisplayName);
        }

        /// <summary>
        /// <para>Given a new <see cref="PrettyFactAttribute"/>.</para>
        /// <para>When testMethodName contains underscores.</para>
        /// <para>Then DisplayName will have underscores replaced with spaces.</para>
        /// </summary>
        [Fact]
        public void Given_a_new_PrettyFactAttribute_When_testMethodName_contains_underscores_Then_DisplayName_will_have_underscores_replaced_with_spaces()
        {
            // Given.
            PrettyFactAttribute attribute;
            string testMethodName;

            // When.
            testMethodName = "Given_X_When_Y_Then_Z";
            attribute = new PrettyFactAttribute(testMethodName);

            // Then.
            Assert.Equal(expected: "Given X When Y Then Z", actual: attribute.DisplayName);
        }
    }
}
