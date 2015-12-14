﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rnwood.SmtpServer.Tests
{
    [TestClass]
    public class MemoryMessageTests : AbstractMessageTests
    {
        protected override IEditableMessage GetMessage()
        {
            Mocks mocks = new Mocks();
            return new MemoryMessage(mocks.Session.Object);
        }
    }
}