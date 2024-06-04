using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace DevPro.Tests
{
    [TestClass()]
    public class DevProLoggerTests
    {
        DevProLogger logger;

        [TestInitialize]
        public void ClassInitialize() 
        {
            this.logger = new DevProLogger();
        }


        [TestMethod()]
        public void LogMessageDoesNotTrhowsExecpetion()
        {
            logger.LogMessage("application.log", "first logged message", "info");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogMessageWithEmptyApplicationTrhowsExecption()
        {
            logger.LogMessage("", "first logged message", "info");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogMessageWithEmptyMessageTrhowsExecption()
        {
            logger.LogMessage("application.log", "", "info");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogMessageWithEmptyLevelTrhowsExecption()
        {
            logger.LogMessage("application.log", "first logged message", "");
        }
    }
}