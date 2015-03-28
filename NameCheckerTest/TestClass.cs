using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameCheckerTest
{
    [TestClass]
    public class NameCheckerTestClass
    {
        [TestMethod]
        public void CheckFingerTest()
        {
            var target = new NameChecker.MainClass();
            var obj = new PrivateObject( target );

            Assert.AreEqual( obj.Invoke( "CheckFinger", "左親指1" ), "左親指１" );
            Assert.AreEqual( obj.Invoke( "CheckFinger", "右中指2" ), "右中指２" );
            Assert.AreEqual( obj.Invoke( "CheckFinger", "左小指4" ), null );
        }

        [TestMethod]
        public void CheckIKTest()
        {
            var target = new NameChecker.MainClass();
            var obj = new PrivateObject( target );

            Assert.AreEqual( obj.Invoke( "CheckIK", "左足IK" ), "左足ＩＫ" );
            Assert.AreEqual( obj.Invoke( "CheckIK", "右つま先IK" ), "右つま先ＩＫ" );
        }
    }
}
