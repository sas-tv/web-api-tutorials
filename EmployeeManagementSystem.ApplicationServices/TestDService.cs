using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestDService : ITestDService
    {
        #region Private Variables
        private ITestDRepository _TestDRepo;
        #endregion

        #region Constructors
        public TestDService(ITestDRepository testDRepo)
        {
            _TestDRepo = testDRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestDRepo.GetName();
        }
        #endregion
    }
}
