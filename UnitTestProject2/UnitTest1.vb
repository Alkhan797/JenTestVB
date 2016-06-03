Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Assert.IsFalse(False)
    End Sub

    <TestMethod()>
    Public Sub ShouldFail()
        Assert.IsTrue(False)
    End Sub

End Class