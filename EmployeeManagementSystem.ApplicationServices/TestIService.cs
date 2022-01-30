using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestIService : ITestIService
    {
        #region Private Variables
        private ITestIRepository _TestIRepo;
        #endregion

        #region Constructors
        public TestIService(ITestIRepository testIRepo)
        {
            _TestIRepo = testIRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestIRepo.GetName();
        }
        #endregion
    }
}
