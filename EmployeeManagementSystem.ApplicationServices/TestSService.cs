using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestSService : ITestSService
    {
        #region Private Variables
        private ITestSRepository _TestSRepo;
        #endregion

        #region Constructors
        public TestSService(ITestSRepository testSRepo)
        {
            _TestSRepo = testSRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestSRepo.GetName();
        }
        #endregion
    }
}
