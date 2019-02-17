// <copyright file="PrettyFactSpec.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PrettyTest.Test
{
    using System;
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Test Cases for the <see cref="PrettyFactAttribute"/>.
    /// </summary>
    public class PrettyFactSpec
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1600 // Elements must be documented

        [Fact]
        public void Given_a_new_PrettyFactAttribute_When_testMethodName_is_null_Then_an_AgrumentNullException_is_thrown()
        {
            // Given.
            PrettyFactAttribute attribute;

            // When.
            Action testCode = () => attribute = new PrettyFactAttribute(null);

            // Then.
            testCode.Should().Throw<ArgumentNullException>();
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
            testCode.Should().Throw<ArgumentException>().WithMessage("Cannot be blank*testMethodName");
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
            attribute.DisplayName.Should().BeEquivalentTo(testMethodName);
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
            attribute.DisplayName.Should().BeEquivalentTo("Given X When Y Then Z");
        }
    }
}
