﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Pages.Extensions;

namespace SemestriProject.Tests.Pages.Extensions
{
    [TestClass]
    public class SearchControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(SearchControlsForHtmlExtension);

        [TestMethod]
        public void SearchControlsForTest()
        {
            Assert.Inconclusive();
        }
    }
}