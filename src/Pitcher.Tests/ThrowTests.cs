﻿using System;
using Xunit;

namespace Pitcher.Tests
{
  public class ThrowTests
  {
    [Fact]
    public void This_WithException_Throws()
    {
      Assert.ThrowsAny<Exception>(() => Throw.This(new Exception()));
    }

    [Fact]
    public void This_WithNullException_ThrowsArgumentNullException()
    {
      Assert.Throws<ArgumentNullException>("exceptionToThrow", () => Throw.This(null));
    }

    [Fact]
    public void When_ConditionTrue_Throws()
    {
      Assert.ThrowsAny<Exception>(() => Throw.When(true, new Exception()));
    }

    [Fact]
    public void When_ConditionFalse_DoesNotThrow()
    {
      Throw.When(false, new Exception());
    }

    [Fact]
    public void When_WithNullException_ThrowsArgumentNullException()
    {
      Assert.Throws<ArgumentNullException>("exceptionToThrow", () => Throw.When(true, null));
    }
  }
}
