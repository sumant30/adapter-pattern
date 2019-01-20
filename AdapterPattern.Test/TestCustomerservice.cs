using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AdapterPattern.Test
{
    [TestClass]
    public class UnitTest1
    {
        Mock<ICacheStorage> _cache;
       
        Mock<ICustomerRepository> _repo;

        [TestInitialize]
        public void Setup()
        {
            _cache = new Mock<ICacheStorage>();
            _repo = new Mock<ICustomerRepository>();
        }

        [TestMethod]
        public void CheckServiceWhenCacheReturnsNull()
        {
            
        }

    }
}
