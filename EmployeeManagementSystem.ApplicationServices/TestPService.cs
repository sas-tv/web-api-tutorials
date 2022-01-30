using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestPService : ITestPService
    {
        #region Private Variables
        private ITestPRepository _TestPRepo;
        #endregion

        #region Constructors
        public TestPService(ITestPRepository testPRepo)
        {
            _TestPRepo = testPRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestPRepo.GetName();
        }
        #endregion
    }
}
