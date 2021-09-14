using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Options;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.Helper;
using WebAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Main.Test
{
    [TestClass]
    public class UTCUserService
    {
        private IOptions<AppSettings> options;
        private string authToken;
        private IUserAuthService userAuthService;
        [TestInitialize]
        public void Initialize()
        {
            AppSettings appSettings = new AppSettings() { Secret = "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING" };
            options = Options.Create<AppSettings>(appSettings);
        }

        [TestMethod]
        public void TestUserAuthenticate()
        {
            AuthenticateRequest authenticateRequest = new AuthenticateRequest() { Username = "Testuser2", Password = "abc123" };
            Assert.IsNotNull(authenticateRequest, "AuthenticateRequest is null");
            AuthenticateResponse authenticateResponse = null;
            Assert.IsNull(authenticateResponse, "AuthenticateResponse should be null");            

            userAuthService = new UserAuthService(options);
            authenticateResponse = userAuthService.Authenticate(authenticateRequest);

            Assert.IsNotNull(authenticateResponse, "AuthenticateResponse is null");
            Assert.IsTrue(!string.IsNullOrEmpty(authenticateResponse.Token), "AuthenticateRespone Token is empty");
            authToken = authenticateResponse.Token;
        }

        [TestMethod]
        public void TestGetAllUsers()
        {
            userAuthService = new UserAuthService(options);
            Assert.IsNotNull(userAuthService, "TestGetAllUsers - UserAuthService is null");

            IEnumerable<User> allUsers = userAuthService.GetAll();
            Assert.IsNotNull(allUsers, "TestGetAllUsers - Users collection is null");
            Assert.AreEqual(2, allUsers.Count(), "TestGetAllUsers - Users count not matching");
        }

        [TestMethod]
        public void TestGetUserByID()
        {
            userAuthService = new UserAuthService(options);
            Assert.IsNotNull(userAuthService, "TestGetUserByID - UserAuthService is null");

            User expectedUser = userAuthService.GetById(1);
            Assert.IsNotNull(expectedUser, "TestGetUserByID - user object is null");
            Assert.AreEqual("Testuser1", expectedUser.UserName, "TestGetAllUsers - UserName not matching");
            Assert.AreEqual("TestUser", expectedUser.FirstName, "TestGetAllUsers - FirstName not matching");
            Assert.AreEqual("1", expectedUser.LastName, "TestGetAllUsers - LastName not matching");
            
            expectedUser = userAuthService.GetById(2);
            Assert.IsNotNull(expectedUser, "TestGetUserByID - user object is null");
            Assert.AreEqual("Testuser2", expectedUser.UserName, "TestGetAllUsers - UserName not matching");
            Assert.AreEqual("TestUser", expectedUser.FirstName, "TestGetAllUsers - FirstName not matching");
            Assert.AreEqual("2", expectedUser.LastName, "TestGetAllUsers - LastName not matching");            
        }
    }
}
