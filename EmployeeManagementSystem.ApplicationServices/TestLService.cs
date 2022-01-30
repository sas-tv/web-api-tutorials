using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestLService : ITestLService
    {
        #region Private Variables
        private ITestLRepository _TestLRepo;
        #endregion

        #region Constructors
        public TestLService(ITestLRepository testLRepo)
        {
            _TestLRepo = testLRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestLRepo.GetName();
        }
        #endregion
    }
}
