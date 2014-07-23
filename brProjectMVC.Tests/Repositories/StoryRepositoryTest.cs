using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using brProject.Models;
using brProject.Infraestructure;

namespace brProjectMVC.Tests.Repositories
{
    [TestClass]
    public class StoryRepositoryTest
    {

        [TestMethod]
        public void TestStoreGet()
        {
            try
            {
                StoreRepository<Store> r = new StoreRepository<Store>();

                var result = r.Get();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [TestMethod]
        public void TestProductGet()
        {
            try
            {
                StoreRepository<Product> r = new StoreRepository<Product>();

                var result = r.Get();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [TestMethod]
        public void TestCategoryGet()
        {
            try
            {
                StoreRepository<Category> r = new StoreRepository<Category>();

                var result = r.Get();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
