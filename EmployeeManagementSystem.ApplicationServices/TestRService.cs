using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestRService : ITestRService
    {
        #region Private Variables
        private ITestRRepository _TestRRepo;
        #endregion

        #region Constructors
        public TestRService(ITestRRepository testRRepo)
        {
            _TestRRepo = testRRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestRRepo.GetName();
        }
        #endregion
    }
}
