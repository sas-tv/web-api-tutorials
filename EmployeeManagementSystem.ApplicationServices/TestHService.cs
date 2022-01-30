using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestHService : ITestHService
    {
        #region Private Variables
        private ITestHRepository _TestHRepo;
        #endregion

        #region Constructors
        public TestHService(ITestHRepository testHRepo)
        {
            _TestHRepo = testHRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestHRepo.GetName();
        }
        #endregion
    }
}
